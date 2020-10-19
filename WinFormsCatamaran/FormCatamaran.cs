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
        private ITransport boat;

        public FormCatamaran()
        {
            InitializeComponent();
        }

        private void Draw()
        {
            Bitmap bmp = new Bitmap(pictureBoxCatamaran.Width, pictureBoxCatamaran.Height);
            Graphics gr = Graphics.FromImage(bmp);
            boat?.DrawTransport(gr);
            pictureBoxCatamaran.Image = bmp;
        }

        public void SetBoat(ITransport boat)
        {
            this.boat = boat;
            Random rnd = new Random();
            boat.SetPosition(rnd.Next(10, 100), rnd.Next(10, 100), pictureBoxCatamaran.Width,
pictureBoxCatamaran.Height);
            Draw();
        }

        private void ButtonCreateBoat_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            boat = new Boat(rnd.Next(100, 300), rnd.Next(1000, 2000), Color.Gray);
            boat.SetPosition(rnd.Next(10, 100), rnd.Next(10, 100), pictureBoxCatamaran.Width,
pictureBoxCatamaran.Height);
            Draw();

        }

        private void ButtonCreateCatamaran_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            boat = new Catamaran(rnd.Next(100, 300), rnd.Next(1000, 2000), Color.Gray,
           Color.Red, true, true);
            boat.SetPosition(rnd.Next(10, 100), rnd.Next(10, 100), pictureBoxCatamaran.Width,
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
                    boat?.MoveTransport(Direction.Up);
                    break;
                case "buttonDown":
                    boat?.MoveTransport(Direction.Down);
                    break;
                case "buttonLeft":
                    boat?.MoveTransport(Direction.Left);
                    break;
                case "buttonRight":
                    boat?.MoveTransport(Direction.Right);
                    break;
            }
            Draw();
        }
    }
}
