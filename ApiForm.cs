using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CinemaVault
{
    public partial class ApiForm : Form
    {
        static FetchData fetch = new FetchData();
        public ApiForm()
        {
            InitializeComponent();
            Region = System.Drawing.Region.FromHrgn(RoundWinform.CreateRoundRectRgn(0, 0, Width, Height, 20, 20)); //rounds the corners of the form
        }

        private void btnFinish_Click(object sender, EventArgs e)
        {
            fetch.Key = apiTextBox.TextName;
            Environment.SetEnvironmentVariable("CinemaVault_Key", fetch.Key.Trim(), EnvironmentVariableTarget.User);
            Close();
            MessageBox.Show("Key properly configured and enabled!"+"\r\n"+"Please restart application for changes to take effect.", "Confirmation");
        }

        private void showCurrentKey_MouseEnter(object sender, EventArgs e)
        {
            showCurrentKey.ForeColor = Color.DodgerBlue;
        }

        private void showCurrentKey_MouseLeave(object sender, EventArgs e)
        {
            showCurrentKey.ForeColor = Color.White;
        }

        private void showCurrentKey_Click(object sender, EventArgs e)
        {
            ;
            if (Environment.GetEnvironmentVariable("CinemaVault_Key") == null)
            {
                showCurrentKey.Text = "No current key found";
            }
            else
            {
                showCurrentKey.Text = "Key: "+ Environment.GetEnvironmentVariable("CinemaVault_Key").ToString();
            }
        }

        private void resetKey_MouseEnter(object sender, EventArgs e)
        {
            resetKey.ForeColor = Color.Red;
        }

        private void resetKey_MouseLeave(object sender, EventArgs e)
        {
            resetKey.ForeColor = Color.White;
        }

        private void resetKey_Click(object sender, EventArgs e)
        {
            Environment.SetEnvironmentVariable("CinemaVault_Key", null, EnvironmentVariableTarget.User);
            MessageBox.Show("Key has been reset! Current key option may not be updated until the program restarts.", "Reset Confirmation");
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void btnClose_MouseEnter(object sender, EventArgs e)
        {
            btnClose.Image = Properties.Resources.HoverClose;
        }

        private void btnClose_MouseLeave(object sender, EventArgs e)
        {
            btnClose.Image = Properties.Resources.NormalClose;
        }

        private void btnMinimize_MouseEnter(object sender, EventArgs e)
        {
            btnMinimize.Image = Properties.Resources.MiniHover;
        }

        private void btnMinimize_MouseLeave(object sender, EventArgs e)
        {
            btnMinimize.Image = Properties.Resources.MiniNormal;
        }

        private void goToLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("http://www.omdbapi.com/apikey.aspx");
        }
    }
}
