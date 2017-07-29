namespace SpotifyAccountChecker
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.configToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.importComboToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AccountGrid = new System.Windows.Forms.DataGridView();
            this.Username = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Password = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnStart = new System.Windows.Forms.Button();
            this.btnExport = new System.Windows.Forms.Button();
            this.ImportAccountsDialog = new System.Windows.Forms.OpenFileDialog();
            this.lblNameWorking = new System.Windows.Forms.Label();
            this.lblWorking = new System.Windows.Forms.Label();
            this.lblTwitter = new System.Windows.Forms.LinkLabel();
            this.WorkingUpdater = new System.Windows.Forms.Timer(this.components);
            this.MaxThreads = new System.Windows.Forms.NumericUpDown();
            this.lblNameThread = new System.Windows.Forms.Label();
            this.CheckerThreadMonitor = new System.Windows.Forms.Timer(this.components);
            this.ExportWorkingDialog = new System.Windows.Forms.SaveFileDialog();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AccountGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MaxThreads)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.configToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(585, 33);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // configToolStripMenuItem
            // 
            this.configToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.importComboToolStripMenuItem});
            this.configToolStripMenuItem.Name = "configToolStripMenuItem";
            this.configToolStripMenuItem.Size = new System.Drawing.Size(77, 29);
            this.configToolStripMenuItem.Text = "Config";
            // 
            // importComboToolStripMenuItem
            // 
            this.importComboToolStripMenuItem.Name = "importComboToolStripMenuItem";
            this.importComboToolStripMenuItem.Size = new System.Drawing.Size(241, 30);
            this.importComboToolStripMenuItem.Text = "Import Accounts...";
            this.importComboToolStripMenuItem.Click += new System.EventHandler(this.importComboToolStripMenuItem_Click);
            // 
            // AccountGrid
            // 
            this.AccountGrid.AllowUserToAddRows = false;
            this.AccountGrid.AllowUserToDeleteRows = false;
            this.AccountGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.AccountGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Username,
            this.Password});
            this.AccountGrid.Location = new System.Drawing.Point(12, 36);
            this.AccountGrid.Name = "AccountGrid";
            this.AccountGrid.ReadOnly = true;
            this.AccountGrid.RowTemplate.Height = 28;
            this.AccountGrid.Size = new System.Drawing.Size(561, 263);
            this.AccountGrid.TabIndex = 1;
            // 
            // Username
            // 
            this.Username.HeaderText = "Username";
            this.Username.Name = "Username";
            this.Username.ReadOnly = true;
            // 
            // Password
            // 
            this.Password.HeaderText = "Password";
            this.Password.Name = "Password";
            this.Password.ReadOnly = true;
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(12, 349);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(561, 44);
            this.btnStart.TabIndex = 2;
            this.btnStart.Text = "Start Checking";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnExport
            // 
            this.btnExport.Location = new System.Drawing.Point(12, 400);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(561, 44);
            this.btnExport.TabIndex = 3;
            this.btnExport.Text = "Export Accounts...";
            this.btnExport.UseVisualStyleBackColor = true;
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // ImportAccountsDialog
            // 
            this.ImportAccountsDialog.Filter = "Text Files | *.txt";
            this.ImportAccountsDialog.FileOk += new System.ComponentModel.CancelEventHandler(this.ImportAccountsDialog_FileOk);
            // 
            // lblNameWorking
            // 
            this.lblNameWorking.AutoSize = true;
            this.lblNameWorking.Location = new System.Drawing.Point(27, 310);
            this.lblNameWorking.Name = "lblNameWorking";
            this.lblNameWorking.Size = new System.Drawing.Size(71, 20);
            this.lblNameWorking.TabIndex = 4;
            this.lblNameWorking.Text = "Working:";
            // 
            // lblWorking
            // 
            this.lblWorking.AutoSize = true;
            this.lblWorking.Location = new System.Drawing.Point(95, 312);
            this.lblWorking.Name = "lblWorking";
            this.lblWorking.Size = new System.Drawing.Size(18, 20);
            this.lblWorking.TabIndex = 5;
            this.lblWorking.Text = "0";
            // 
            // lblTwitter
            // 
            this.lblTwitter.AutoSize = true;
            this.lblTwitter.Location = new System.Drawing.Point(403, 311);
            this.lblTwitter.Name = "lblTwitter";
            this.lblTwitter.Size = new System.Drawing.Size(170, 20);
            this.lblTwitter.TabIndex = 6;
            this.lblTwitter.TabStop = true;
            this.lblTwitter.Text = "Raghav Jhavar © 2017";
            this.lblTwitter.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblTwitter_LinkClicked);
            // 
            // WorkingUpdater
            // 
            this.WorkingUpdater.Interval = 1000;
            this.WorkingUpdater.Tick += new System.EventHandler(this.WorkingUpdater_Tick);
            // 
            // MaxThreads
            // 
            this.MaxThreads.Location = new System.Drawing.Point(252, 309);
            this.MaxThreads.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.MaxThreads.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.MaxThreads.Name = "MaxThreads";
            this.MaxThreads.Size = new System.Drawing.Size(120, 26);
            this.MaxThreads.TabIndex = 7;
            this.MaxThreads.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
            // 
            // lblNameThread
            // 
            this.lblNameThread.AutoSize = true;
            this.lblNameThread.Location = new System.Drawing.Point(175, 311);
            this.lblNameThread.Name = "lblNameThread";
            this.lblNameThread.Size = new System.Drawing.Size(71, 20);
            this.lblNameThread.TabIndex = 8;
            this.lblNameThread.Text = "Threads:";
            // 
            // CheckerThreadMonitor
            // 
            this.CheckerThreadMonitor.Interval = 1000;
            this.CheckerThreadMonitor.Tick += new System.EventHandler(this.CheckerThreadMonitor_Tick);
            // 
            // ExportWorkingDialog
            // 
            this.ExportWorkingDialog.Filter = "Text Files | *.txt";
            this.ExportWorkingDialog.FileOk += new System.ComponentModel.CancelEventHandler(this.ExportWorkingDialog_FileOk);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(585, 452);
            this.Controls.Add(this.lblNameThread);
            this.Controls.Add(this.MaxThreads);
            this.Controls.Add(this.lblTwitter);
            this.Controls.Add(this.lblWorking);
            this.Controls.Add(this.lblNameWorking);
            this.Controls.Add(this.btnExport);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.AccountGrid);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MinimumSize = new System.Drawing.Size(607, 465);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AccountGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MaxThreads)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem configToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem importComboToolStripMenuItem;
        private System.Windows.Forms.DataGridView AccountGrid;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnExport;
        private System.Windows.Forms.DataGridViewTextBoxColumn Username;
        private System.Windows.Forms.DataGridViewTextBoxColumn Password;
        private System.Windows.Forms.OpenFileDialog ImportAccountsDialog;
        private System.Windows.Forms.Label lblNameWorking;
        private System.Windows.Forms.Label lblWorking;
        private System.Windows.Forms.LinkLabel lblTwitter;
        private System.Windows.Forms.Timer WorkingUpdater;
        private System.Windows.Forms.NumericUpDown MaxThreads;
        private System.Windows.Forms.Label lblNameThread;
        private System.Windows.Forms.Timer CheckerThreadMonitor;
        private System.Windows.Forms.SaveFileDialog ExportWorkingDialog;
    }
}

