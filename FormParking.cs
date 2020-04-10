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
            parking = new MultiLevelParking(countLevel, pictureBoxParkovka.Width, pictureBoxParkovka.Height);
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
                Bitmap bmp = new Bitmap(pictureBoxParkovka.Width, pictureBoxParkovka.Height);
                Graphics gr = Graphics.FromImage(bmp);
                parking[listBoxLVL.SelectedIndex].Draw(gr);
                pictureBoxParkovka.Image = bmp;
            }
        }

        private void buttonParkingTractBezKovshey_Click(object sender, EventArgs e)
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
            parking = new Parking<ITransport>(20, pictureBoxTracSpawn.Width, pictureBoxTracSpawn.Height);
            Draw();
        }
        private void Draw()
        {
            Bitmap bmp = new Bitmap(pictureBoxTracSpawn.Width, pictureBoxTracSpawn.Height);
            Graphics gr = Graphics.FromImage(bmp);
            parking.Draw(gr);
            pictureBoxTracSpawn.Image = bmp;
        }

        private void buttonZabratTractor_Click(object sender, EventArgs e)
        {
            if (NomerMesta.Text != "")
            {
                var car = parking - Convert.ToInt32(NomerMesta.Text);
                if (car != null)
                {
                    Bitmap bmp = new Bitmap(pictureBoxTractAfterZabrat.Width, pictureBoxTractAfterZabrat.Height);
                    Graphics gr = Graphics.FromImage(bmp);
                    car.SetPosition(5, 5, pictureBoxTractAfterZabrat.Width, pictureBoxTractAfterZabrat.Height);
                    car.Drawtractor(gr); pictureBoxTractAfterZabrat.Image = bmp;
                }
                else
                {
                    Bitmap bmp = new Bitmap(pictureBoxTractAfterZabrat.Width, pictureBoxTractAfterZabrat.Height);
                    pictureBoxTractAfterZabrat.Image = bmp;
                }
                Draw();
            }
        }

        private void listBoxLVL_SelectedIndexChanged(object sender, EventArgs e)
        {
            Draw();
        }
        private void buttonParkingTractSKovshami_Clik(object sender, EventArgs e)
        {

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
                }
                Draw();
            }
        }

        private void buttonParkingTractBezKovshey_Clik(object sender, EventArgs e)
        {
            ColorDialog dialog = new ColorDialog();
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                var tractor = new BigTract(100, 1000, dialog.Color);
                int place = parking + tractor;
                Draw();
            }
        }
    }
}

