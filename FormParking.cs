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
                listBoxLVL.Items.Add("Уровень " + (i + 1));
            }
            listBoxLVL.SelectedIndex = 0;
        }
        private void Draw()
        {
            if (listBoxLVL.SelectedIndex > -1)
            {
                Bitmap bmp = new Bitmap(pictureBoxTrac1.Width, pictureBoxTrac1.Height);
                Graphics gr = Graphics.FromImage(bmp);
                parking[listBoxLVL.SelectedIndex].Draw(gr);
                pictureBoxTrac1.Image = bmp;
            }
        }


        private void buttonTake_Click(object sender, EventArgs e)
        {
                if (listBoxLVL.SelectedIndex > -1)
                {
                    if (NomerMesta.Text != "")
                    {
                        var car = parking[listBoxLVL.SelectedIndex] - Convert.ToInt32(NomerMesta.Text);
                        if (car != null)
                        {
                            Bitmap bmp = new Bitmap(pictureBoxTractAfterZabrat.Width, pictureBoxTractAfterZabrat.Height);
                            Graphics gr = Graphics.FromImage(bmp); car.SetPosition(5, 5, pictureBoxTractAfterZabrat.Width, pictureBoxTractAfterZabrat.Height);
                            car.Drawtractor(gr);
                            pictureBoxTractAfterZabrat.Image = bmp;
                        }
                        else
                        {
                            Bitmap bmp = new Bitmap(pictureBoxTractAfterZabrat.Width, pictureBoxTractAfterZabrat.Height); pictureBoxTractAfterZabrat.Image = bmp;
                        }
                        Draw();
                    }
                }Draw();        
        }

        private void AddTruc(ITransport tractor)
        {
            if (tractor != null && listBoxLVL.SelectedIndex > -1)
            {
                int place = parking[listBoxLVL.SelectedIndex] + tractor;
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

        private void listBoxLVL_SelectedIndexChanged(object sender, EventArgs e)
        {
            Draw();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            form = new FormCarConfig();
            form.AddEvent(AddTruc);
            form.Show();
        }
    }
}
