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
            {
                if (listBoxLVL.SelectedIndex > -1)
                {
                    if (maskedTextBox1.Text != "")
                    {
                        var car = parking[listBoxLVL.SelectedIndex] - Convert.ToInt32(maskedTextBox1.Text);
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
        }

        private void buttonSetH_Clik(object sender, EventArgs e)
        {
            if (listBoxLVL.SelectedIndex > -1)
            {
                ColorDialog dialog = new ColorDialog();
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    ColorDialog dialogDop = new ColorDialog();
                    if (dialogDop.ShowDialog() == DialogResult.OK)
                    {
                        var tractor = new Trac(100, 1000, dialog.Color, dialogDop.Color, true, true);
                        int place = parking[listBoxLVL.SelectedIndex] + tractor;
                        if (place == -1)
                        {
                            MessageBox.Show("Нет свободных мест", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        Draw();
                    }
                }
            }
        }

        private void buttonSetL_Click(object sender, EventArgs e)
        {
            if (listBoxLVL.SelectedIndex > -1)
            {
                ColorDialog dialog = new ColorDialog();
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    var tractor = new BigTract(100, 1000, dialog.Color);
                    int place = parking[listBoxLVL.SelectedIndex] + tractor;
                    if (place == -1)
                    {
                        MessageBox.Show("Нет свободных мест", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                Draw();
            }
        }

        private void listBoxLVL_SelectedIndexChanged(object sender, EventArgs e)
        {
            Draw();
        }
    }
}
