using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.NetworkInformation;
using System.ComponentModel;
using System.Threading;
using System.IO;
using System.Data;

enum JobStatus
{
        Running,
        Paused,
        Stopped,
        Canceled,
        Restarting,
        Complete
};

namespace Pingfiniti
{
    class PingPackage
    {
        private BackgroundWorker PingWorker = new BackgroundWorker();
        public JobStatus Status = JobStatus.Running;

        public int Sent;
        public int Success;
        public int Failed;

        public DateTime StartDate;
        public readonly DateTime EndDate;

        public bool Restart = false;

        public readonly string Address;
        public readonly int Delay = 2000;
        public readonly int Bytes = 32;
        public readonly int Timeout = 3;
        public readonly int TTL = 255;
        public readonly string LogPath;
        public int MaxResponse = 10000;

        public PingReply PingReply;
        public DataTable ResponseGrid;
        public List<string> PingResponses = new List<string> { };

        private void InitializePackage()
        {
            ResponseGrid = new DataTable("Responses");
            ResponseGrid.Columns.Add("DateTime");
            ResponseGrid.Columns.Add("Address");
            ResponseGrid.Columns.Add("Buffer");
            ResponseGrid.Columns.Add("RoundTrip");
            ResponseGrid.Columns.Add("TTL");
            ResponseGrid.Columns.Add("Status");

            PingWorker.DoWork += PingWorker_DoWork;
            PingWorker.RunWorkerCompleted += PingWorker_WorkComplete;
            PingWorker.WorkerSupportsCancellation = true;
            PingWorker.RunWorkerAsync();
        }

        public PingPackage(string inStrAddress, string inStrLogPath, double inDblRunFor = 24)
        {
            InitializePackage();

            StartDate = DateTime.Now;
            EndDate = StartDate.AddHours(inDblRunFor);
            Address = inStrAddress;
            LogPath = inStrLogPath;
        }

        public PingPackage(string inStrAddress, string inStrLogPath, double inDblRunFor, 
            int inIntDelay, int inIntBytes, int inIntTimeout, int inIntTTL)
        {
            InitializePackage();

            StartDate = DateTime.Now;
            Address = inStrAddress;
            LogPath = inStrLogPath;
            EndDate = StartDate.AddHours(inDblRunFor);
            Delay = inIntDelay;
            Bytes = inIntBytes;
            Timeout = inIntTimeout;
            TTL = inIntTTL;
        }

        private async void ConnectionTest(string inStrAddress)
        {
            var TestConneciton = new Ping();
            var TestOptions = new PingOptions();

            TestOptions.Ttl = TTL;

            PingReply = await TestConneciton.SendPingAsync(inStrAddress, Timeout, BitConverter.GetBytes(Bytes), TestOptions);

            Sent += 1;

            if (PingReply.Status == IPStatus.Success)
            {
                Success += 1;
                PingResponses.Add(string.Format("Reply from {0}: bytes={1} time={2}ms TTL={3}",
                    PingReply.Address, PingReply.Buffer.LongLength, PingReply.RoundtripTime, PingReply.Options.Ttl));
            }
            else
            {
                Failed += 1;
                if (PingReply.Status == IPStatus.TimedOut)
                    PingResponses.Add(string.Format("Request timed out."));
                else if (PingReply.Status == IPStatus.TtlExpired)
                    PingResponses.Add(string.Format("TTL expired."));
                else if (PingReply.Status == IPStatus.BadDestination)
                    PingResponses.Add(string.Format("Bad destination."));
                else
                    PingResponses.Add(string.Format("Unknown error to destination."));
            }

        }

        private void UpdateResponseGrid(PingReply inPingReply, DateTime inDateTime)
        {
            try
            {
                var Row = ResponseGrid.NewRow();
                Row["DateTime"] = inDateTime;
                Row["Address"] = inPingReply.Address;
                Row["Buffer"] = inPingReply.Buffer.LongLength;
                Row["RoundTrip"] = inPingReply.RoundtripTime;
                Row["TTL"] = inPingReply.Options.Ttl;
                Row["Status"] = inPingReply.Status;
                ResponseGrid.Rows.Add(Row);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private void Export_Log(string inStrLine, DateTime inDateTime)
        {
            using (StreamWriter writer = new StreamWriter(LogPath, true))
            {
                writer.WriteLine("{0} > {1}", inDateTime, inStrLine);
            }
        }

        private void PingWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            do
            {
                Thread.Sleep(Delay);

                if (Restart | Status == JobStatus.Stopped | Status == JobStatus.Canceled | Status == JobStatus.Complete)
                    break;

                if (Status != JobStatus.Paused)
                {
                    ConnectionTest(Address);

                    if (PingResponses.Count > 0)
                    {
                        var datetimenow = DateTime.Now;
                        Export_Log(PingResponses[PingResponses.Count - 1], datetimenow);
                        UpdateResponseGrid(PingReply, datetimenow);
                    }

                    if (DateTime.Now >= EndDate)
                        Status = JobStatus.Stopped;

                    //if (DateTime.Now >= EndDate | PingResponses.Count == MaxResponse)
                    //    Status = JobStatus.Stopped;
                }

            } while (!PingWorker.CancellationPending);

        }

        private void PingWorker_WorkComplete(object sender, RunWorkerCompletedEventArgs e)
        {
            if (Restart)
                RestartPingWorker();

            if (PingResponses.Count > 0)
            {
                PingResponses.Add(string.Format("Connection test {0} ended.", PingReply.Address, DateTime.Now));
                Export_Log(PingResponses[PingResponses.Count - 1], DateTime.Now);
            }
        }

        public void Stop()
        {

        }

        public void Cancel()
        {
            Status = JobStatus.Canceled;
            PingWorker.CancelAsync();
        }

        private void RestartPingWorker()
        {
            Status = JobStatus.Restarting;
            Restart = false;

            Sent = 0;
            Success = 0;
            Failed = 0;
            StartDate = DateTime.Now;

            PingResponses.Clear();
            ResponseGrid.Rows.Clear();

            if (PingWorker.IsBusy)
                PingWorker.CancelAsync();

            PingWorker.RunWorkerAsync();
            Status = JobStatus.Running;
        }

        public void Pause()
        {
            Status = JobStatus.Paused;
        }

    }

}
