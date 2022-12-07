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

        Form1 _gameForm = null;

        public LoginForm(Form1 gameForm)
        {
            _gameForm = gameForm;

            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            _gameForm.Close();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            //while (!_gameForm._client.Connected && _gameForm._client == null)
            //{
            //    _gameForm._client = new TcpClient(tbxIpAddress.Text, Int32.Parse(tbxPort.Text));
            //}
        }
    }
}
