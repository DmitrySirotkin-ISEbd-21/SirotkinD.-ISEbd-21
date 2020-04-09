using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsTrac
{
    public partial class FormParking : Form
    {
        MultiLevelParking parking;

        private const int countLevel = 5;
        FormCarConfig form;

        public FormParking()
        {
            InitializeComponent();
            parking = new MultiLevelParking(countLevel, pictureBoxTrac1.Width, pictureBoxTrac1.Height);
            for (int i = 0; i < countLevel; i++)
            {
                listBox123.Items.Add("Уровень " + (i + 1));
            }
            listBox123.SelectedIndex = 0;
        }
        private void Draw()
        {
            if (listBox123.SelectedIndex > -1)
            {
                Bitmap bmp = new Bitmap(pictureBoxTrac1.Width, pictureBoxTrac1.Height);
                Graphics gr = Graphics.FromImage(bmp);
                parking[listBox123.SelectedIndex].Draw(gr);
                pictureBoxTrac1.Image = bmp;
            }
        }


        private void buttonTake_Click(object sender, EventArgs e)
        {
                if (listBox123.SelectedIndex > -1)
                {
                    if (maskedTextBox1.Text != "")
                    {
                        var car = parking[listBox123.SelectedIndex] - Convert.ToInt32(maskedTextBox1.Text);
                        if (car != null)
                        {
                            Bitmap bmp = new Bitmap(pictureBox1.Width, pictureBox1.Height);
                            Graphics gr = Graphics.FromImage(bmp); car.SetPosition(5, 5, pictureBox1.Width, pictureBox1.Height);
                            car.Drawtractor(gr);
                            pictureBox1.Image = bmp;
                        }
                        else
                        {
                            Bitmap bmp = new Bitmap(pictureBox1.Width, pictureBox1.Height); pictureBox1.Image = bmp;
                        }
                        Draw();
                    }
                }Draw();        
        }


        private void listBox123_SelectedIndexChanged(object sender, EventArgs e)
        {
            Draw();
        }
        private void AddTruc(ITransport tractor)
        {
            if (tractor != null && listBox123.SelectedIndex > -1)
            {
                int place = parking[listBox123.SelectedIndex] + tractor;
                if (place > -1)
                {
                    Draw();
                }
                else
                {
                    MessageBox.Show("Машину не удалось поставить");
                }
            }
        }
        private void buttonAdd1_Click(object sender, EventArgs e)
        {
            form = new FormCarConfig();
            form.AddEvent(AddTruc);
            form.Show();
        }

        private void сохранитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                if (parking.SaveData(saveFileDialog1.FileName))
                {
                    MessageBox.Show("Сохранение успешно", "Результат", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("?Не сохранилось", "Результат", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void загрузитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                if (parking.LoadData(openFileDialog1.FileName))
                {
                    MessageBox.Show("загрузили", "результат", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("не загрузили", "результат", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            Draw();
        }
    }
}
