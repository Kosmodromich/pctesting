﻿using System;
using System.Windows.Forms;
using pctesting.TestHardware;

namespace pctesting
{
    public partial class UserForm : Form
    {
        FileManager fileWatcher;
        TrafficManager trafficWatcher;
        ProcessControl process;
        ActivityControl activityControl;

        string comp;
        string user;
        public UserForm(string userName, string compName)
        {
            InitializeComponent();
            fileWatcher = new FileManager(userName, compName);
            trafficWatcher = new TrafficManager(userName, compName);
            process = new ProcessControl(userName, compName);
            activityControl = new ActivityControl(userName, compName);
            this.comp = compName;
            this.user = userName;
            fileWatcher.watch();
            trafficWatcher.Start();
            activityControl.Subscribe();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Show();
            pctestingIcon.Visible = false;
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            backgroundWorkerForSaveInfo.RunWorkerAsync();
            timer1.Enabled = false;
            activityControl.Unsubscribe();
            trafficWatcher.Stop();
            //process.SaveToDatabase();
            Application.Exit();
        }

        private void pctetingIcon_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            this.Show();
            pctestingIcon.Visible = false;
        }

        private void UserForm_Move(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Minimized)
            {
                this.Hide();
                pctestingIcon.Visible = true;
            }
        }

        private void testButton_Click(object sender, EventArgs e)
        {
            TestHardware.Stop st = new TestHardware.Stop(user, comp);
            st.ShowDialog(); 
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            process.UpdateProcess();
        }


        private void UserForm_Load(object sender, EventArgs e)
        {

        }

        private void UserForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                e.Cancel = true;
                this.Hide();
                pctestingIcon.Visible = true;
            }
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            backgroundWorkerForSaveInfo.RunWorkerAsync();
            timer1.Enabled = false;
            activityControl.Unsubscribe();
            trafficWatcher.Stop();            
            //process.SaveToDatabase();
            new LoginForm().Show();
            this.Close();
        }

        private void backgroundWorkerForSaveInfo_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
        {
            process.SaveToDatabase();
        }
    }
}
