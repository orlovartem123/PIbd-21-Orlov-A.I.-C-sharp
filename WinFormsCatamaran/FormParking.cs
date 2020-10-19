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
    public partial class FormParking : Form
    {

        private readonly Parking<Boat> parking;

        public FormParking()
        {
            InitializeComponent();
            parking = new Parking<Boat>(pictureBoxParking.Width,
           pictureBoxParking.Height);
            Draw();
        }

        private void Draw()
        {
            Bitmap bmp = new Bitmap(pictureBoxParking.Width, pictureBoxParking.Height);
            Graphics gr = Graphics.FromImage(bmp);
            parking.Draw(gr);
            pictureBoxParking.Image = bmp;
        }

        private void buttonSetBoat_Click(object sender, EventArgs e)
        {
            ColorDialog dialog = new ColorDialog();
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                var boat = new Boat(100, 1000, dialog.Color);
                if (parking + boat)
                {
                    Draw();
                }
                else
                {
                    MessageBox.Show("Парковка переполнена");
                }
            }
        }

        private void buttonSetCatamaran_Click(object sender, EventArgs e)
        {
            ColorDialog dialog = new ColorDialog();
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                ColorDialog dialogDop = new ColorDialog();
                if (dialogDop.ShowDialog() == DialogResult.OK)
                {
                    var boat = new Catamaran(100, 1000, dialog.Color, dialogDop.Color,
                   true, true);
                    if (parking + boat)
                    {
                        Draw();
                    }
                    else
                    {
                        MessageBox.Show("Парковка переполнена");
                    }
                }
            }
        }

        private void buttonTakeBoat_Click(object sender, EventArgs e)
        {
            if (maskedTextBox.Text != "")
            {
                int index = Convert.ToInt32(maskedTextBox.Text);
                var boat = parking - index;
                if (boat != null)
                {
                    FormCatamaran form = new FormCatamaran();
                    form.SetBoat(boat);
                    form.ShowDialog();
                }
                Draw();
            }
        }
    }
}

