using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace CpClientTicTacToe
{
    public partial class Form1 : Form
    {
        private List<Button> _buttonField;
        private int[] _field;

        private bool _turn=true;
        private int user=2;     //1 - X   2 - 0

        string path=string.Empty;

        LoginForm loginForm = null;

        public TcpClient client = null;

        public Form1()
        {
            loginForm = new LoginForm(this);
            loginForm.ShowDialog();

            InitializeComponent();

            _field =new int[9];
            CreateField();
            path=Directory.GetCurrentDirectory()+ "/Images";
            if (!Directory.Exists(path))
            {
                Directory.CreateDirectory(path);
            }
            this.Size=new Size(500,500);
            this.FormBorderStyle= FormBorderStyle.FixedDialog;
        }

        void CreateField()
        {
            _buttonField = new List<Button>();
            for (int j = 0; j < 3; j++)
            {
                for (int i = 0; i < 3; i++)
                {
                    Button tmp = new Button()
                    {
                        Width = 100,
                        Height = 100,
                        Location=new Point(i*105+5,j*105+5),
                        Image = Image.FromFile("Images/Empt.png")
                    };
                    tmp.Click += OnClick;
                    _buttonField.Add(tmp);
                    Controls.Add(tmp);
                }
            }
        }



        void OnClick(object s, EventArgs e)
        {
            if (_turn == true)
            {
                Button btn=s as Button;
                if (btn==null || btn.Text!=string.Empty)
                    return;
                int index=_buttonField.IndexOf(btn);
                if (_field[index] == 0)
                {
                    if (user == 1)
                    {
                        _field[index]=user;
                        btn.Image = Image.FromFile("Images/Cross.png");
                        btn.Enabled=false;
                    }
                    else if (user == 2)
                    {
                        _field[index]=user;
                        btn.Image = Image.FromFile("Images/Circle.png");
                        btn.Enabled=false;
                    }

                    //_turn=false;
                    CheckWin();
                }

                
            }
        }


        void CheckWin()
        {
            for (int i = 0; i < 9; i+=3)
            {
                if(_field[i]==_field[i+1] && _field[i] == _field[i + 2] && _field[i]!=0)
                {
                    //Win
                    OnWin();
                }
            }

            for (int i = 0; i < 3; i++)
            {
                if(_field[i]==_field[i+3] && _field[i] == _field[i + 6] && _field[i]!=0)
                {
                    //Win
                    OnWin();
                }
            }

            if(_field[0]==_field[4] && _field[0] == _field[8] && _field[0]!=0)
            {
                //Win
                OnWin();
            }
                
            if(_field[2]==_field[4] && _field[2] == _field[6] && _field[2]!=0)
            {
                //Win
                OnWin();
            }
        }

        void OnWin()
        {
             MessageBox.Show("Win");
        }


        void FillField(int[] field)
        {
            _field = field;
            for (int i = 0; i < _field.Length; i++)
            {
                if (_field[i] != 0)
                {
                    _buttonField[i].Image=(_field[i]==1)?Image.FromFile("Images/Cross.png"):
                        Image.FromFile("Images/Circle.png");
                    _buttonField[i].Enabled=false;
                }
            }
        }
    }
}
