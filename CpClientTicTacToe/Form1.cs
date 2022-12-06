using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace CpClientTicTacToe
{
    public partial class Form1 : Form
    {
        private List<Button> _field;
        private bool _turn=true;
        private int user=2;     //1 - X   2 - 0

        public Form1()
        {
            CreateField();
            this.Size=new Size(500,500);
            this.FormBorderStyle= FormBorderStyle.FixedDialog;

        }

        void CreateField()
        {
            _field = new List<Button>();
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Button tmp = new Button()
                    {
                        Width = 100,
                        Height = 100,
                        Location=new Point(i*105+5,j*105+5),
                        Font=new Font("Arial",32,FontStyle.Bold)
                    };
                    tmp.Click += OnClick;
                    _field.Add(tmp);
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

                if (user == 1)
                {
                  
                    btn.Image = Image.FromFile("..//..//..//Images//Cross.png");
                }
                else if (user == 2)
                {
                    btn.Image = Image.FromFile("..//..//..//Images//Circle.png");
                }

                _turn=false;
            }
        }
    }
}
