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
    public partial class FormBoatConfig : Form
    {
        Vehicle boat = null;

        private event Action<Vehicle> eventAddBoat;

        public FormBoatConfig()
        {
            InitializeComponent();
            panelRed.MouseDown += panelColor_MouseDown;
            panelGray.MouseDown += panelColor_MouseDown;
            panelBlue.MouseDown += panelColor_MouseDown;
            panelWhite.MouseDown += panelColor_MouseDown;
            panelBlack.MouseDown += panelColor_MouseDown;
            panelFuchsia.MouseDown += panelColor_MouseDown;
            panelLime.MouseDown += panelColor_MouseDown;
            panelYellow.MouseDown += panelColor_MouseDown;
            buttonCancel.Click += (Object sender, EventArgs e) => { Close(); };
        }

        private void DrawBoat()
        {
            if (boat != null)
            {
                Bitmap bmp = new Bitmap(pictureBoxBoat.Width, pictureBoxBoat.Height);
                Graphics gr = Graphics.FromImage(bmp);
                boat.SetPosition(5, 5, pictureBoxBoat.Width, pictureBoxBoat.Height);
                boat.DrawTransport(gr);
                pictureBoxBoat.Image = bmp;
            }
        }

        public void AddEvent(Action<Vehicle> ev)
        {
            if (eventAddBoat == null)
            {
                eventAddBoat = new Action<Vehicle>(ev);
            }
            else
            {
                eventAddBoat += ev;
            }
        }

        private void labelBoat_MouseDown(object sender, MouseEventArgs e)
        {
            labelBoat.DoDragDrop(labelBoat.Text, DragDropEffects.Move |
DragDropEffects.Copy);
        }

        private void labelCatamaran_MouseDown(object sender, MouseEventArgs e)
        {
            labelCatamaran.DoDragDrop(labelCatamaran.Text, DragDropEffects.Move |
DragDropEffects.Copy);
        }

        private void panelBoat_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.Text))
            {
                e.Effect = DragDropEffects.Copy;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }

        private void panelBoat_DragDrop(object sender, DragEventArgs e)
        {
            switch (e.Data.GetData(DataFormats.Text).ToString())
            {
                case "Лодка":
                    boat = new Boat((int)numericUpDownSpeed.Value, (int)numericUpDownWeight.Value, Color.White);
                    break;
                case "Катамаран":
                    boat = new Catamaran((int)numericUpDownSpeed.Value, (int)numericUpDownWeight.Value, Color.White, Color.Black, checkBoxPasSeats.Checked, checkBoxBobs.Checked);
                    break;
            }
            DrawBoat();
        }

        private void panelColor_MouseDown(object sender, MouseEventArgs e)
        {
            // Прописать логику вызова dragDrop для панелей, используя sender
            (sender as Panel).DoDragDrop((sender as Panel).BackColor, DragDropEffects.Move | DragDropEffects.Copy);
        }

        private void labelColor_DragEnter(object sender, DragEventArgs e)
        {
            // Прописать логику проверки приходящего значения на тип Color
            if (e.Data.GetDataPresent(typeof(Color)))
            {
                e.Effect = DragDropEffects.Copy;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }

        private void labelBaseColor_DragDrop(object sender, DragEventArgs e)
        {
            boat?.SetMainColor((Color)e.Data.GetData(typeof(Color)));
            DrawBoat();
        }

        private void labelDopColor_DragDrop(object sender, DragEventArgs e)
        {
            if (boat != null)
            {
                if (boat is Catamaran catamaran)
                {
                    catamaran.SetDopColor((Color)e.Data.GetData(typeof(Color)));
                }
                else
                {
                    MessageBox.Show("У лодки не может быть дополнительного цвета");
                }
                DrawBoat();
            }
        }

        private void ButtonAdd_Click(object sender, EventArgs e)
        {
            eventAddBoat?.Invoke(boat);
            Close();
        }
    }
}
