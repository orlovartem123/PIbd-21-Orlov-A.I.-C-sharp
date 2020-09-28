using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsCatamaran
{
    public partial class FormCatamaran : Form
    {
        private Catamaran catamaran;
        public FormCatamaran()
        {
            InitializeComponent();
        }
        private void Draw()
        {
            Bitmap bmp = new Bitmap(pictureBoxCatamaran.Width, pictureBoxCatamaran.Height);
            Graphics gr = Graphics.FromImage(bmp);
            catamaran.DrawTransport(gr);
            pictureBoxCatamaran.Image = bmp;
        }

        private void ButtonCreate_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            catamaran = new Catamaran(rnd.Next(100, 300), rnd.Next(1000, 2000), Color.DarkRed,
           Color.LightGray, true, true);
            catamaran.SetPosition(rnd.Next(10, 100), rnd.Next(10, 100), pictureBoxCatamaran.Width,
           pictureBoxCatamaran.Height);
            Draw();
        }

        private void buttonMove_Click(object sender, EventArgs e)
        {
            //получаем имя кнопки
            string name = (sender as Button).Name;
            switch (name)
            {
                case "buttonUp":
                    catamaran.MoveTransport(Direction.Up);
                    break;
                case "buttonDown":
                    catamaran.MoveTransport(Direction.Down);
                    break;
                case "buttonLeft":
                    catamaran.MoveTransport(Direction.Left);
                    break;
                case "buttonRight":
                    catamaran.MoveTransport(Direction.Right);
                    break;
            }
            Draw();
        }
    }
}
