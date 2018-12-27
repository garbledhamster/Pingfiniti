namespace Pingfiniti
{
    partial class Pingfiniti
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBoxGlobalSettings = new System.Windows.Forms.GroupBox();
            this.textBoxLogPath = new System.Windows.Forms.TextBox();
            this.labelLogPath = new System.Windows.Forms.Label();
            this.buttonStopAll = new System.Windows.Forms.Button();
            this.groupBoxNewConnectionTest = new System.Windows.Forms.GroupBox();
            this.labelTTL = new System.Windows.Forms.Label();
            this.numericUpDownTTL = new System.Windows.Forms.NumericUpDown();
            this.labelBytes = new System.Windows.Forms.Label();
            this.numericUpDownBytes = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.numericUpDownTimeout = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownPingDelay = new System.Windows.Forms.NumericUpDown();
            this.textBoxAddress = new System.Windows.Forms.TextBox();
            this.labelPingDelay = new System.Windows.Forms.Label();
            this.labelDuration = new System.Windows.Forms.Label();
            this.labelAddress = new System.Windows.Forms.Label();
            this.numericUpDownDuration = new System.Windows.Forms.NumericUpDown();
            this.dgvConnectionTests = new System.Windows.Forms.DataGridView();
            this.Initialized = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HostAddress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sent = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Success = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Failures = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Empty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.restartToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pauseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.removeTestToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.exportXMLToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBoxGlobalSettings.SuspendLayout();
            this.groupBoxNewConnectionTest.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownTTL)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownBytes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownTimeout)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPingDelay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDuration)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConnectionTests)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 244F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.dgvConnectionTests, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(755, 354);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.groupBoxGlobalSettings);
            this.panel1.Controls.Add(this.groupBoxNewConnectionTest);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(238, 348);
            this.panel1.TabIndex = 0;
            // 
            // groupBoxGlobalSettings
            // 
            this.groupBoxGlobalSettings.Controls.Add(this.textBoxLogPath);
            this.groupBoxGlobalSettings.Controls.Add(this.labelLogPath);
            this.groupBoxGlobalSettings.Controls.Add(this.buttonStopAll);
            this.groupBoxGlobalSettings.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxGlobalSettings.Location = new System.Drawing.Point(0, 182);
            this.groupBoxGlobalSettings.Name = "groupBoxGlobalSettings";
            this.groupBoxGlobalSettings.Size = new System.Drawing.Size(238, 166);
            this.groupBoxGlobalSettings.TabIndex = 6;
            this.groupBoxGlobalSettings.TabStop = false;
            this.groupBoxGlobalSettings.Text = "Global Settings";
            // 
            // textBoxLogPath
            // 
            this.textBoxLogPath.Location = new System.Drawing.Point(88, 19);
            this.textBoxLogPath.Name = "textBoxLogPath";
            this.textBoxLogPath.Size = new System.Drawing.Size(144, 20);
            this.textBoxLogPath.TabIndex = 13;
            this.textBoxLogPath.DoubleClick += new System.EventHandler(this.textBoxLogPath_DoubleClick);
            // 
            // labelLogPath
            // 
            this.labelLogPath.AutoSize = true;
            this.labelLogPath.Location = new System.Drawing.Point(22, 22);
            this.labelLogPath.Name = "labelLogPath";
            this.labelLogPath.Size = new System.Drawing.Size(60, 13);
            this.labelLogPath.TabIndex = 14;
            this.labelLogPath.Text = "Log/s Path";
            // 
            // buttonStopAll
            // 
            this.buttonStopAll.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonStopAll.Location = new System.Drawing.Point(151, 137);
            this.buttonStopAll.Name = "buttonStopAll";
            this.buttonStopAll.Size = new System.Drawing.Size(84, 20);
            this.buttonStopAll.TabIndex = 3;
            this.buttonStopAll.Text = "Stop All";
            this.buttonStopAll.UseVisualStyleBackColor = true;
            this.buttonStopAll.Click += new System.EventHandler(this.buttonCancelAll_Click);
            // 
            // groupBoxNewConnectionTest
            // 
            this.groupBoxNewConnectionTest.Controls.Add(this.labelTTL);
            this.groupBoxNewConnectionTest.Controls.Add(this.numericUpDownTTL);
            this.groupBoxNewConnectionTest.Controls.Add(this.labelBytes);
            this.groupBoxNewConnectionTest.Controls.Add(this.numericUpDownBytes);
            this.groupBoxNewConnectionTest.Controls.Add(this.label1);
            this.groupBoxNewConnectionTest.Controls.Add(this.numericUpDownTimeout);
            this.groupBoxNewConnectionTest.Controls.Add(this.numericUpDownPingDelay);
            this.groupBoxNewConnectionTest.Controls.Add(this.textBoxAddress);
            this.groupBoxNewConnectionTest.Controls.Add(this.labelPingDelay);
            this.groupBoxNewConnectionTest.Controls.Add(this.labelDuration);
            this.groupBoxNewConnectionTest.Controls.Add(this.labelAddress);
            this.groupBoxNewConnectionTest.Controls.Add(this.numericUpDownDuration);
            this.groupBoxNewConnectionTest.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBoxNewConnectionTest.Location = new System.Drawing.Point(0, 0);
            this.groupBoxNewConnectionTest.Name = "groupBoxNewConnectionTest";
            this.groupBoxNewConnectionTest.Size = new System.Drawing.Size(238, 182);
            this.groupBoxNewConnectionTest.TabIndex = 5;
            this.groupBoxNewConnectionTest.TabStop = false;
            this.groupBoxNewConnectionTest.Text = "Connection Test";
            // 
            // labelTTL
            // 
            this.labelTTL.AutoSize = true;
            this.labelTTL.Location = new System.Drawing.Point(40, 151);
            this.labelTTL.Name = "labelTTL";
            this.labelTTL.Size = new System.Drawing.Size(53, 13);
            this.labelTTL.TabIndex = 12;
            this.labelTTL.Text = "TTL (sec)";
            // 
            // numericUpDownTTL
            // 
            this.numericUpDownTTL.Location = new System.Drawing.Point(99, 149);
            this.numericUpDownTTL.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.numericUpDownTTL.Name = "numericUpDownTTL";
            this.numericUpDownTTL.Size = new System.Drawing.Size(133, 20);
            this.numericUpDownTTL.TabIndex = 11;
            this.numericUpDownTTL.Value = new decimal(new int[] {
            255,
            0,
            0,
            0});
            // 
            // labelBytes
            // 
            this.labelBytes.AutoSize = true;
            this.labelBytes.Location = new System.Drawing.Point(60, 125);
            this.labelBytes.Name = "labelBytes";
            this.labelBytes.Size = new System.Drawing.Size(33, 13);
            this.labelBytes.TabIndex = 10;
            this.labelBytes.Text = "Bytes";
            // 
            // numericUpDownBytes
            // 
            this.numericUpDownBytes.Location = new System.Drawing.Point(99, 123);
            this.numericUpDownBytes.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.numericUpDownBytes.Name = "numericUpDownBytes";
            this.numericUpDownBytes.Size = new System.Drawing.Size(133, 20);
            this.numericUpDownBytes.TabIndex = 9;
            this.numericUpDownBytes.Value = new decimal(new int[] {
            32,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 99);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Timeout (sec)";
            // 
            // numericUpDownTimeout
            // 
            this.numericUpDownTimeout.Location = new System.Drawing.Point(99, 97);
            this.numericUpDownTimeout.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.numericUpDownTimeout.Name = "numericUpDownTimeout";
            this.numericUpDownTimeout.Size = new System.Drawing.Size(133, 20);
            this.numericUpDownTimeout.TabIndex = 7;
            this.numericUpDownTimeout.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            // 
            // numericUpDownPingDelay
            // 
            this.numericUpDownPingDelay.Increment = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericUpDownPingDelay.Location = new System.Drawing.Point(99, 71);
            this.numericUpDownPingDelay.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.numericUpDownPingDelay.Name = "numericUpDownPingDelay";
            this.numericUpDownPingDelay.Size = new System.Drawing.Size(133, 20);
            this.numericUpDownPingDelay.TabIndex = 5;
            this.numericUpDownPingDelay.Value = new decimal(new int[] {
            2000,
            0,
            0,
            0});
            // 
            // textBoxAddress
            // 
            this.textBoxAddress.Location = new System.Drawing.Point(99, 18);
            this.textBoxAddress.Name = "textBoxAddress";
            this.textBoxAddress.Size = new System.Drawing.Size(133, 20);
            this.textBoxAddress.TabIndex = 0;
            this.textBoxAddress.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxAddress_KeyDown);
            // 
            // labelPingDelay
            // 
            this.labelPingDelay.AutoSize = true;
            this.labelPingDelay.Location = new System.Drawing.Point(13, 73);
            this.labelPingDelay.Name = "labelPingDelay";
            this.labelPingDelay.Size = new System.Drawing.Size(80, 13);
            this.labelPingDelay.TabIndex = 6;
            this.labelPingDelay.Text = "Ping Delay (ms)";
            // 
            // labelDuration
            // 
            this.labelDuration.AutoSize = true;
            this.labelDuration.Location = new System.Drawing.Point(11, 47);
            this.labelDuration.Name = "labelDuration";
            this.labelDuration.Size = new System.Drawing.Size(82, 13);
            this.labelDuration.TabIndex = 4;
            this.labelDuration.Text = "Duration (hours)";
            // 
            // labelAddress
            // 
            this.labelAddress.AutoSize = true;
            this.labelAddress.Location = new System.Drawing.Point(35, 21);
            this.labelAddress.Name = "labelAddress";
            this.labelAddress.Size = new System.Drawing.Size(58, 13);
            this.labelAddress.TabIndex = 1;
            this.labelAddress.Text = "IP Address";
            // 
            // numericUpDownDuration
            // 
            this.numericUpDownDuration.Location = new System.Drawing.Point(99, 45);
            this.numericUpDownDuration.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.numericUpDownDuration.Name = "numericUpDownDuration";
            this.numericUpDownDuration.Size = new System.Drawing.Size(133, 20);
            this.numericUpDownDuration.TabIndex = 2;
            this.numericUpDownDuration.Value = new decimal(new int[] {
            24,
            0,
            0,
            0});
            // 
            // dgvConnectionTests
            // 
            this.dgvConnectionTests.AllowUserToAddRows = false;
            this.dgvConnectionTests.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvConnectionTests.BackgroundColor = System.Drawing.Color.White;
            this.dgvConnectionTests.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvConnectionTests.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Initialized,
            this.HostAddress,
            this.Status,
            this.Sent,
            this.Success,
            this.Failures,
            this.Empty});
            this.dgvConnectionTests.ContextMenuStrip = this.contextMenuStrip1;
            this.dgvConnectionTests.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvConnectionTests.Location = new System.Drawing.Point(247, 3);
            this.dgvConnectionTests.MultiSelect = false;
            this.dgvConnectionTests.Name = "dgvConnectionTests";
            this.dgvConnectionTests.RowHeadersVisible = false;
            this.dgvConnectionTests.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvConnectionTests.Size = new System.Drawing.Size(505, 348);
            this.dgvConnectionTests.TabIndex = 1;
            this.dgvConnectionTests.SelectionChanged += new System.EventHandler(this.updateDgvRowIndex);
            // 
            // Initialized
            // 
            this.Initialized.HeaderText = "Initialized";
            this.Initialized.Name = "Initialized";
            this.Initialized.Width = 75;
            // 
            // HostAddress
            // 
            this.HostAddress.HeaderText = "HostAddress";
            this.HostAddress.Name = "HostAddress";
            this.HostAddress.Width = 92;
            // 
            // Status
            // 
            this.Status.HeaderText = "Status";
            this.Status.Name = "Status";
            this.Status.Width = 62;
            // 
            // Sent
            // 
            this.Sent.HeaderText = "Sent";
            this.Sent.Name = "Sent";
            this.Sent.Width = 54;
            // 
            // Success
            // 
            this.Success.HeaderText = "Success";
            this.Success.Name = "Success";
            this.Success.Width = 73;
            // 
            // Failures
            // 
            this.Failures.HeaderText = "Failures";
            this.Failures.Name = "Failures";
            this.Failures.Width = 68;
            // 
            // Empty
            // 
            this.Empty.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Empty.HeaderText = " ";
            this.Empty.Name = "Empty";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.restartToolStripMenuItem,
            this.pauseToolStripMenuItem,
            this.removeTestToolStripMenuItem,
            this.toolStripSeparator1,
            this.exportXMLToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(153, 98);
            // 
            // restartToolStripMenuItem
            // 
            this.restartToolStripMenuItem.Name = "restartToolStripMenuItem";
            this.restartToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.restartToolStripMenuItem.Text = "Restart";
            this.restartToolStripMenuItem.Click += new System.EventHandler(this.restartToolStripMenuItem_Click);
            // 
            // pauseToolStripMenuItem
            // 
            this.pauseToolStripMenuItem.Name = "pauseToolStripMenuItem";
            this.pauseToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.pauseToolStripMenuItem.Text = "Pause/Resume";
            this.pauseToolStripMenuItem.Click += new System.EventHandler(this.pauseToolStripMenuItem_Click);
            // 
            // removeTestToolStripMenuItem
            // 
            this.removeTestToolStripMenuItem.Name = "removeTestToolStripMenuItem";
            this.removeTestToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.removeTestToolStripMenuItem.Text = "Cancel";
            this.removeTestToolStripMenuItem.Click += new System.EventHandler(this.cancelToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(149, 6);
            // 
            // exportXMLToolStripMenuItem
            // 
            this.exportXMLToolStripMenuItem.Name = "exportXMLToolStripMenuItem";
            this.exportXMLToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.exportXMLToolStripMenuItem.Text = "Export To XML";
            this.exportXMLToolStripMenuItem.Click += new System.EventHandler(this.exportXMLToolStripMenuItem_Click);
            // 
            // Pingfiniti
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(755, 354);
            this.Controls.Add(this.tableLayoutPanel1);
            this.DoubleBuffered = true;
            this.MinimumSize = new System.Drawing.Size(771, 393);
            this.Name = "Pingfiniti";
            this.Text = "Pingfiniti";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.groupBoxGlobalSettings.ResumeLayout(false);
            this.groupBoxGlobalSettings.PerformLayout();
            this.groupBoxNewConnectionTest.ResumeLayout(false);
            this.groupBoxNewConnectionTest.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownTTL)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownBytes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownTimeout)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPingDelay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDuration)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConnectionTests)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label labelAddress;
        private System.Windows.Forms.TextBox textBoxAddress;
        private System.Windows.Forms.DataGridView dgvConnectionTests;
        private System.Windows.Forms.DataGridViewTextBoxColumn Initialized;
        private System.Windows.Forms.DataGridViewTextBoxColumn HostAddress;
        private System.Windows.Forms.DataGridViewTextBoxColumn Status;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sent;
        private System.Windows.Forms.DataGridViewTextBoxColumn Success;
        private System.Windows.Forms.DataGridViewTextBoxColumn Failures;
        private System.Windows.Forms.DataGridViewTextBoxColumn Empty;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem exportXMLToolStripMenuItem;
        public System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button buttonStopAll;
        private System.Windows.Forms.NumericUpDown numericUpDownDuration;
        private System.Windows.Forms.Label labelDuration;
        private System.Windows.Forms.ToolStripMenuItem removeTestToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBoxGlobalSettings;
        private System.Windows.Forms.NumericUpDown numericUpDownPingDelay;
        private System.Windows.Forms.Label labelPingDelay;
        private System.Windows.Forms.GroupBox groupBoxNewConnectionTest;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numericUpDownTimeout;
        private System.Windows.Forms.ToolStripMenuItem pauseToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.Label labelBytes;
        private System.Windows.Forms.NumericUpDown numericUpDownBytes;
        private System.Windows.Forms.Label labelTTL;
        private System.Windows.Forms.NumericUpDown numericUpDownTTL;
        private System.Windows.Forms.ToolStripMenuItem restartToolStripMenuItem;
        private System.Windows.Forms.TextBox textBoxLogPath;
        private System.Windows.Forms.Label labelLogPath;
    }
}

