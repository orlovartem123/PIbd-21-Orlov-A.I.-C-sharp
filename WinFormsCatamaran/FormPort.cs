using NLog;
using System;
using System.IO;
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

        private readonly Logger logger;

        public FormPort()
        {
            InitializeComponent();
            portCollection = new PortCollection(pictureBoxPort.Width,
           pictureBoxPort.Height);
            Draw();
            logger = LogManager.GetCurrentClassLogger();
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

        private void buttonTakeBoat_Click(object sender, EventArgs e)
        {
            if (listBoxPorts.SelectedIndex > -1 && maskedTextBox.Text != "")
            {
                try
                {
                    var boat = portCollection[listBoxPorts.SelectedItem.ToString()] - Convert.ToInt32(maskedTextBox.Text);
                    if (boat != null)
                    {
                        FormCatamaran form = new FormCatamaran();
                        form.SetBoat(boat);
                        form.ShowDialog();
                        logger.Info($"Изъят транспорт {boat} с места {maskedTextBox.Text}");
                        Draw();
                    }
                }
                catch (PortNotFoundException ex)
                {
                    logger.Error(ex, ex.Message);
                    MessageBox.Show(ex.Message, "Не найдено", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (Exception ex)
                {
                    logger.Error(ex, ex.Message);
                    MessageBox.Show(ex.Message, "Неизвестная ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void ButtonAddPort_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxNewLevelName.Text))
            {
                MessageBox.Show("Введите название порта", "Ошибка",
               MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            logger.Info($"Добавили порт {textBoxNewLevelName.Text}");
            portCollection.AddParking(textBoxNewLevelName.Text);
            ReloadLevels();
        }

        private void ButtonDelPort_Click(object sender, EventArgs e)
        {
            if (listBoxPorts.SelectedIndex > -1)
            {
                if (MessageBox.Show($"Удалить порт " + listBoxPorts.SelectedItem.ToString() + "?",
             "Удаление", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    logger.Info($"Удалили порт {listBoxPorts.SelectedItem.ToString()}");
                    portCollection.DelParking(listBoxPorts.SelectedItem.ToString());
                    ReloadLevels();
                }
            }        }

        private void listBoxPorts_SelectedIndexChanged(object sender, EventArgs e)
        {
            logger.Info($"Перешли на порт {listBoxPorts.SelectedItem.ToString()}");
            Draw();
        }

        private void ButtonAddBoat_Click(object sender, EventArgs e)
        {
            var formBoatConfig = new FormBoatConfig();
            formBoatConfig.AddEvent(AddBoat);
            formBoatConfig.Show();
        }

        private void AddBoat(Vehicle boat)
        {
            if (boat != null && listBoxPorts.SelectedIndex > -1)
            {
                try
                {
                    if ((portCollection[listBoxPorts.SelectedItem.ToString()]) + boat)
                    {
                        Draw();
                        logger.Info($"Добавлен транспорт {boat}");
                    }
                    else
                    {
                        MessageBox.Show("Транспорт не удалось поставить");
                    }
                    Draw();
                }
                catch (PortOverflowException ex)
                {
                    logger.Error(ex, ex.Message);
                    MessageBox.Show(ex.Message, "Переполнение", MessageBoxButtons.OK,
                   MessageBoxIcon.Error);
                }
                catch (PortAlreadyHaveException ex)
                {
                    logger.Error(ex, ex.Message);
                    MessageBox.Show(ex.Message, "Уже есть", MessageBoxButtons.OK,
                   MessageBoxIcon.Error);
                }
                catch (Exception ex)
                {
                    logger.Error(ex, ex.Message);
                    MessageBox.Show(ex.Message, "Неизвестная ошибка",
                   MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void СохранитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    portCollection.SaveData(saveFileDialog.FileName);
                    MessageBox.Show("Сохранение прошло успешно", "Результат", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    logger.Info("Сохранено в файл " + saveFileDialog.FileName);
                }
                catch (Exception ex)
                {
                    logger.Error(ex, ex.Message);
                    MessageBox.Show(ex.Message, "Неизвестная ошибка при сохранении", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void ЗагрузитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    portCollection.LoadData(openFileDialog.FileName);
                    MessageBox.Show("Загрузили", "Результат", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    logger.Info("Загружено из файла " + openFileDialog.FileName);
                    ReloadLevels();
                    Draw();
                }
                catch (FileNotFoundException ex)
                {
                    logger.Error(ex, ex.Message);
                    MessageBox.Show(ex.Message, "Файл не найден", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (PortOverflowException ex)
                {
                    logger.Error(ex, ex.Message);
                    MessageBox.Show(ex.Message, "Некорректный формат файла", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (FormatException ex)
                {
                    logger.Error(ex, ex.Message);
                    MessageBox.Show(ex.Message, "Занятое место", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (PortAlreadyHaveException ex)
                {
                    logger.Error(ex, ex.Message);
                    MessageBox.Show(ex.Message, "Уже есть", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (Exception ex)
                {
                    logger.Error(ex, ex.Message);
                    MessageBox.Show(ex.Message, "Неизвестная ошибка при сохранении", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }            }
        }

        private void ButtonSort_Click(object sender, EventArgs e)
        {
            if (listBoxPorts.SelectedIndex > -1)
            {
                portCollection[listBoxPorts.SelectedItem.ToString()].Sort();
                Draw();
                logger.Info("Сортировка уровней");
            }
        }
    }
}

