using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.NetworkInformation;
using System.Threading;

namespace Pingfiniti
{
    public partial class Pingfiniti : Form
    {

        public int currentRowIndex;

        private BackgroundWorker ConnectionWorker = new BackgroundWorker();

        public Pingfiniti()
        {
            InitializeComponent();

            ConnectionWorker.DoWork += ConnectionWorker_DoWork;
            ConnectionWorker.ProgressChanged += ConnectionWorker_ProgressChanged;
            ConnectionWorker.WorkerReportsProgress = true;
            ConnectionWorker.RunWorkerAsync();

            textBoxLogPath.Text = Properties.Settings.Default.LogPath;

        }

        private void textBoxAddress_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (textBoxLogPath.Text.Length > 0)
                    if (isNewTest(textBoxAddress.Text))
                    {
                        if (ValidAddress(textBoxAddress.Text))
                            NewConnectionTest(textBoxAddress.Text);
                        textBoxAddress.Clear();
                    }
            }
        }

        private bool ValidAddress(string inStrAddress)
        {
            try
            {
                Ping validateAddress = new Ping();
                var test = validateAddress.Send(inStrAddress);

                if (test.Status != IPStatus.Success)
                    return false;
            }
            catch (PingException ex)
            {
                Console.WriteLine("Error occured with the address: {0}", inStrAddress);
                Console.WriteLine(ex.Message);
                return false;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error occured while validating the address: {0}", inStrAddress);
                Console.WriteLine(ex.Message);
                return false;
            }

            return true;
        }

        private bool isNewTest(string inAddress)
        {
            foreach (DataGridViewRow row in dgvConnectionTests.Rows)
            {
                string cellvalue = row.Cells["HostAddress"].Value.ToString();
                string status = row.Cells["Status"].Value.ToString();

                if (cellvalue == inAddress && status == "Running")
                    return false;
            }
            return true;
        }

        private void NewConnectionTest(string inAddress)
        {
            if (textBoxLogPath.Text.Length > 0)
                if (System.IO.Directory.Exists(textBoxLogPath.Text))
                {
                    var Path = string.Format("{0}\\Pingfiniti_{1}_{2}.txt", textBoxLogPath.Text, inAddress, DateTime.Now.ToString("yyyyMMddThhmmss"));
                    Properties.Settings.Default.LogPath = textBoxLogPath.Text;
                    Properties.Settings.Default.Save();
                    int newConnectionRowIndex = dgvConnectionTests.Rows.Add();
                    dgvConnectionTests.Rows[newConnectionRowIndex].Tag = new PingPackage(inAddress, Path, (double)numericUpDownDuration.Value,
                        (int)numericUpDownPingDelay.Value, (int)numericUpDownBytes.Value, (int)numericUpDownTimeout.Value, (int)numericUpDownTTL.Value);

                    var package = dgvConnectionTests.Rows[newConnectionRowIndex].Tag as PingPackage;

                    dgvConnectionTests.Rows[newConnectionRowIndex].Cells["Initialized"].Value = package.StartDate;
                    dgvConnectionTests.Rows[newConnectionRowIndex].Cells["HostAddress"].Value = package.Address;
                    dgvConnectionTests.Rows[newConnectionRowIndex].Cells["Status"].Value = package.Status;
                    dgvConnectionTests.Rows[newConnectionRowIndex].Cells["Sent"].Value = package.Sent;
                    dgvConnectionTests.Rows[newConnectionRowIndex].Cells["Success"].Value = string.Format("{0} ({1}%)", package.Success, Math.Max(0, (int)(((double)package.Success / package.Sent) * 100)));
                    dgvConnectionTests.Rows[newConnectionRowIndex].Cells["Failures"].Value = string.Format("{0} ({1}%)", package.Failed, Math.Max(0, (int)(((double)package.Failed / package.Sent) * 100)));
                }
        }

        private void ConnectionWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            do
            {
                Thread.Sleep(100);
                ConnectionWorker.ReportProgress(0);
                Application.DoEvents();
            } while (true);
        }

        private void ConnectionWorker_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            foreach (DataGridViewRow row in dgvConnectionTests.Rows)
            {
                var package = row.Tag as PingPackage;
                row.Cells["Status"].Value = (row.Tag as PingPackage).Status;
                if (package.Status == JobStatus.Running)
                {
                    try
                    {
                        row.Cells["Sent"].Value = package.Sent;
                        if (package.Sent > 0 & package.Success > 0 & package.Status != JobStatus.Restarting)
                            row.Cells["Success"].Value = string.Format("{0} ({1}%)", package.Success, (int)(((double)package.Success / package.Sent) * 100));
                        if (package.Sent > 0 & package.Failed > 0 & package.Status != JobStatus.Restarting)
                            row.Cells["Failures"].Value = string.Format("{0} ({1}%)", package.Failed, (int)(((double)package.Failed / package.Sent) * 100));
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("Error occured while updating row of job: {0} > {1}", package.StartDate, package.Address);
                        Console.WriteLine(ex.Message);
                    }
                }
            }
        }

        private void exportXMLToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var package = dgvConnectionTests.Rows[currentRowIndex].Tag as PingPackage;
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.Filter = "XML File|*.xml";
            saveFileDialog1.Title = "Save as XML File";
            saveFileDialog1.FileName = String.Format("{0}_{1}_{2}", "PingForever", package.Address, DateTime.Now.ToString(package.StartDate.ToString("yyyyMMddThhmmss")));

            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                if (saveFileDialog1.FileName.Length != 0)
                {
                    package.ResponseGrid.TableName = "ConnectionTest";
                    package.ResponseGrid.WriteXml(saveFileDialog1.FileName);
                }
            }
        }
             
        private void buttonCancelAll_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dgvConnectionTests.Rows)
            {
                (row.Tag as PingPackage).Cancel();
                row.Cells["Status"].Value = "Canceled";
            }               
        }

        private void cancelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var pingpackage = dgvConnectionTests.Rows[currentRowIndex].Tag as PingPackage;
            pingpackage.Cancel();
            dgvConnectionTests.Rows[currentRowIndex].Cells["Status"].Value = pingpackage.Status;
        }

        private void updateDgvRowIndex(object sender, EventArgs e)
        {
            currentRowIndex = dgvConnectionTests.CurrentCell.RowIndex;
        }

        private void pauseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            var pingpackage = dgvConnectionTests.Rows[currentRowIndex].Tag as PingPackage;
            if (pingpackage.Status == JobStatus.Running)
                pingpackage.Pause();
            else if (pingpackage.Status == JobStatus.Paused)
                pingpackage.Status = JobStatus.Running;

            dgvConnectionTests.Rows[currentRowIndex].Cells["Status"].Value = pingpackage.Status;
        }

        private void restartToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var package = dgvConnectionTests.Rows[currentRowIndex].Tag as PingPackage;

            if (package.Status != JobStatus.Restarting)
            {
                package.Restart = true;
                dgvConnectionTests.Rows[currentRowIndex].Cells["Initialized"].Value = package.StartDate;
                dgvConnectionTests.Rows[currentRowIndex].Cells["HostAddress"].Value = package.Address;
                dgvConnectionTests.Rows[currentRowIndex].Cells["Status"].Value = package.Status;
                dgvConnectionTests.Rows[currentRowIndex].Cells["Sent"].Value = "0";
                dgvConnectionTests.Rows[currentRowIndex].Cells["Success"].Value = "0 (0%)";
                dgvConnectionTests.Rows[currentRowIndex].Cells["Failures"].Value = "0 (0%)";
            }
        }

        private void textBoxLogPath_DoubleClick(object sender, EventArgs e)
        {
            var folderBrowser = new FolderBrowserDialog();
            if (folderBrowser.ShowDialog() == DialogResult.OK)
                textBoxLogPath.Text = folderBrowser.SelectedPath;

        }
    }
}
