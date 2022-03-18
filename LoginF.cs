using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JiraTool._3._1
{
    public partial class LoginF : Form
    {
        const string KEY_GUID = "304c3357-3376-7645-2164-336e63332139";
        FileInfo _loginFile;
        public Jira.Models.MyselfInfo LoginInfo { get; private set; }
        public Jira.JiraClient JiraClient { get; private set; }
        public LoginF()
        {
            InitializeComponent();
            _loginFile = new FileInfo(Directory.GetCurrentDirectory() + "/login.txt");
            if(_loginFile?.Exists ?? false)
            {
                var lines = File.ReadAllLines(_loginFile.FullName);
                if(lines?.Length > 0)
                {
                    txt_url.Text = lines[0];
                }
                if (lines?.Length > 1)
                {
                    txt_username.Text = lines[1];
                }
                if (lines?.Length > 2)
                {
                    txt_token.Text = VSSystem.Security.Cryptography.DecryptFromHexString<string>(lines[2], KEY_GUID);
                }
            }
        }

        private async void but_ok_Click(object sender, EventArgs e)
        {

            try
            {
                string url = txt_url.Text;
                string username = txt_username.Text;
                string token = txt_token.Text;

                JiraClient = new Jira.JiraClient(url, username, token);
                LoginInfo = default;

                try
                {
                    LoginInfo = await JiraClient.GetLoginInfoAsync();
                }
                catch { }
                if(LoginInfo != null)
                {
                    List<string> lines = new List<string>()
                    {
                        url,
                        username,
                        VSSystem.Security.Cryptography.EncryptToHexString( token,KEY_GUID)
                    };
                    File.WriteAllLines(_loginFile.FullName, lines);
                    DialogResult = DialogResult.OK;
                }
                else
                {
                    if(MessageBox.Show("Login failed, do you want to try again?", "Login", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.No)
                    {
                        DialogResult = DialogResult.Cancel;
                    }

                }
            }
            catch //(Exception ex) 
            {
            }
            
        }

        private void but_cancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

            try
            {
                //https://id.atlassian.com/manage-profile/security/api-tokens
                Process.Start("https://id.atlassian.com/manage-profile/security/api-tokens");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
