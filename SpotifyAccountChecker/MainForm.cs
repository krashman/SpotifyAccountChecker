using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Threading;
using System.IO;

namespace SpotifyAccountChecker
{
    public partial class MainForm : Form
    {

        private const string Version = "[BETA] V1.0.0";
        Thread CheckerThread;

        public MainForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Text = $"Spotify Account Checker by Raghav {Version}";
            this.AccountGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        #region ShowImportAccountDialog
        private void importComboToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ImportAccountsDialog.ShowDialog();
        }
        #endregion

        #region ProcessImportedAccounts
        private void ImportAccountsDialog_FileOk(object sender, CancelEventArgs e)
        {
            if(AccountManager.LoadAccounts(ImportAccountsDialog.FileName))
            {
                MessageBox.Show(
                    "Loaded Accounts.",
                    "Info",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                    );
            }
            else
            {
                ShowErrorMessage("No accounts were loaded. Please check your list!");
            }
        }
        #endregion

        #region ShowErrorMessageFunction
        private void ShowErrorMessage(string Content, string Title = "Error")
        {
            MessageBox.Show(
                Content,
                Title,
                MessageBoxButtons.OK,
                MessageBoxIcon.Error
                );
        }
        #endregion

        #region ShowTwitter
        private void lblTwitter_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://twitter.com/raghav_jhavar");
        }
        #endregion

        #region UpdateWorkingLabel
        private void WorkingUpdater_Tick(object sender, EventArgs e)
        {
            lblWorking.Text = AccountGrid.Rows.Count.ToString();
        }
        #endregion

        #region StartChecker
        private void btnStart_Click(object sender, EventArgs e)
        {
            btnStart.Enabled = false;

            CheckerThread = new Thread(() =>
            {
                new Checker(Decimal.ToInt32(MaxThreads.Value), this).Start();
            });
            CheckerThread.Start();

            CheckerThreadMonitor.Start();
            WorkingUpdater.Start();
        }
        #endregion

        #region UpdateAccountGrid
        public void UpdateAccountGrid(Account _Account)
        {
            if(AccountGrid.InvokeRequired)
            {
                AccountGrid.Invoke((MethodInvoker)(() => this.AccountGrid.Rows.Add(_Account.Username, _Account.Password)));
            }
            else
            {
                this.AccountGrid.Rows.Add(_Account.Username, _Account.Password);
            }
        }
        #endregion

        #region ShowExportDialog
        private void btnExport_Click(object sender, EventArgs e)
        {
            if(AccountGrid.Rows.Count > 0)
            {
                ExportWorkingDialog.ShowDialog();
            }
            else
            {
                ShowErrorMessage("Cannot export nothing!");
            }
        }
        #endregion

        #region CheckerThreadTimerTick
        private void CheckerThreadMonitor_Tick(object sender, EventArgs e)
        {
            if(!CheckerThread.IsAlive)
            {
                CheckerThreadMonitor.Stop();
                WorkingUpdater.Stop();

                MessageBox.Show(
                    "Finished checking!",
                    "Info",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                    );
            }
        }
        #endregion

        #region ExitOnThreadRunning
        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(CheckerThread != null && CheckerThread.IsAlive)
            {
                ShowErrorMessage("Cannot exit while the checker is running! If you really need to, end from Task Manager.");
                e.Cancel = true;
            }
        }
        #endregion

        #region SaveExportedAccounts
        private void ExportWorkingDialog_FileOk(object sender, CancelEventArgs e)
        {
            string Path = ExportWorkingDialog.FileName;

            using (StreamWriter WriteAccountsStream = new StreamWriter(Path, true))
            {
                if (File.Exists(Path)) WriteAccountsStream.Write("");

                foreach (DataGridViewRow SingleAccount in AccountGrid.Rows)
                {
                    WriteAccountsStream.WriteLine($"{SingleAccount.Cells["Username"].Value.ToString()}:{SingleAccount.Cells["Password"].Value.ToString()}");
                }
            }

            MessageBox.Show(
                "Finished exporting.",
                "Info",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
                );
        }
        #endregion
    }
}
