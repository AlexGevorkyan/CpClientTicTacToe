using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Net.Sockets;
using System.Text;
using System.Windows.Forms;

namespace CpClientTicTacToe
{
    public partial class LoginForm : Form
    {
        public string PlayerName { get; set; }
        public string IpAddress { get; set; }
        public int Port { get; set; }

        public Image imgCross;
        public Image imgCircle;
        public Image imgEmpty;

        Form1 _gameForm = null;

        public LoginForm(Form1 gameForm)
        {
            InitializeComponent();
            this.FormClosing += LoginForm_FormClosing;
            this.DialogResult=DialogResult.OK;

            _gameForm = gameForm;
            imgCross=pbCross.Image;
            imgCircle=pbCircle.Image;
            imgEmpty=pbEmpty.Image;

            
        }

        private void LoginForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(this.DialogResult== DialogResult.Cancel)
            {
                Application.Exit();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            //Application.Exit();
            this.DialogResult= DialogResult.Cancel;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            //while (!_gameForm._client.Connected && _gameForm._client == null)
            //{
            //    _gameForm._client = new TcpClient(tbxIpAddress.Text, Int32.Parse(tbxPort.Text));
            //}

            IpAddress=tbxIpAddress.Text.Trim();
            Port=Convert.ToInt32(tbxPort.Text.Trim());
            _gameForm.Connect();

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btSelectCross_Click(object sender, EventArgs e)
        {
            using(OpenFileDialog ofd=new OpenFileDialog())
            {
                if(ofd.ShowDialog()== DialogResult.OK)
                {
                    imgCross=Image.FromFile(ofd.FileName);
                    pbCross.Image=Image.FromFile(ofd.FileName);
                }
            }
        }

        private void btSelectCircle_Click(object sender, EventArgs e)
        {
            using(OpenFileDialog ofd=new OpenFileDialog())
            {
                if(ofd.ShowDialog()== DialogResult.OK)
                {
                    imgCircle=Image.FromFile(ofd.FileName);
                    pbCircle.Image=Image.FromFile(ofd.FileName);
                }
            }
        }

        private void btSelectEmpty_Click(object sender, EventArgs e)
        {
            using(OpenFileDialog ofd=new OpenFileDialog())
            {
                if(ofd.ShowDialog()== DialogResult.OK)
                {
                    imgEmpty=Image.FromFile(ofd.FileName);
                    pbEmpty.Image=Image.FromFile(ofd.FileName);
                }
            }
        }
    }
}
