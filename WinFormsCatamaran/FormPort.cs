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
    public partial class FormPort : Form
    {
        private readonly PortCollection portCollection;

        public FormPort()
        {
            InitializeComponent();
            portCollection = new PortCollection(pictureBoxPort.Width,
           pictureBoxPort.Height);
            Draw();
        }

        private void ReloadLevels()
        {
            int index = listBoxPorts.SelectedIndex;
            listBoxPorts.Items.Clear();
            for (int i = 0; i < portCollection.Keys.Count; i++)
            {
                listBoxPorts.Items.Add(portCollection.Keys[i]);
            }
            if (listBoxPorts.Items.Count > 0 && (index == -1 || index >=
           listBoxPorts.Items.Count))
            {
                listBoxPorts.SelectedIndex = 0;
            }
            else if (listBoxPorts.Items.Count > 0 && index > -1 && index <
           listBoxPorts.Items.Count)
            {
                listBoxPorts.SelectedIndex = index;
            }
        }

        private void Draw()
        {
            if (listBoxPorts.SelectedIndex > -1)
            {
                Bitmap bmp = new Bitmap(pictureBoxPort.Width,
               pictureBoxPort.Height);
                Graphics gr = Graphics.FromImage(bmp);
                portCollection[listBoxPorts.SelectedItem.ToString()].Draw(gr);
                pictureBoxPort.Image = bmp;
            }
        }

        private void buttonSetBoat_Click(object sender, EventArgs e)
        {
            if (listBoxPorts.SelectedIndex > -1)
            {
                ColorDialog dialog = new ColorDialog();
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    var boat = new Boat(100, 1000, dialog.Color);
                    if (portCollection[listBoxPorts.SelectedItem.ToString()] +
                   boat)
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

        private void buttonSetCatamaran_Click(object sender, EventArgs e)
        {
            if (listBoxPorts.SelectedIndex > -1)
            {
                ColorDialog dialog = new ColorDialog();
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    ColorDialog dialogDop = new ColorDialog();
                    if (dialogDop.ShowDialog() == DialogResult.OK)
                    {
                        var boat = new Catamaran(100, 1000, dialog.Color,
                       dialogDop.Color, true, true);
                        if (portCollection[listBoxPorts.SelectedItem.ToString()]
                       + boat)
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
        }

        private void buttonTakeBoat_Click(object sender, EventArgs e)
        {
            if (listBoxPorts.SelectedIndex > -1 && maskedTextBox.Text != "")
            {
                var boat = portCollection[listBoxPorts.SelectedItem.ToString()] -
               Convert.ToInt32(maskedTextBox.Text);
                if (boat != null)
                {
                    FormCatamaran form = new FormCatamaran();
                    form.SetBoat(boat);
                    form.ShowDialog();
                }
                Draw();
            }
        }

        private void ButtonAddParking_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxNewLevelName.Text))
            {
                MessageBox.Show("Введите название порта", "Ошибка",
               MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            portCollection.AddParking(textBoxNewLevelName.Text);
            ReloadLevels();
        }

        private void ButtonDelParking_Click(object sender, EventArgs e)
        {
            if (listBoxPorts.SelectedIndex > -1)
            {
                if (MessageBox.Show($"Удалить порт " + listBoxPorts.SelectedItem.ToString() + "?",
             "Удаление", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    portCollection.DelParking(listBoxPorts.SelectedItem.ToString());
                    ReloadLevels();
                }
            }        }

        private void listBoxParkings_SelectedIndexChanged(object sender, EventArgs e)
        {
            Draw();
        }
    }
}

