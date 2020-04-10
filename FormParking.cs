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
        Parking<ITransport> parking;
        public FormParking()
        {
            InitializeComponent();
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

        private void buttonParkingTractSKovshami_Clik(object sender, EventArgs e)
        {
            ColorDialog dialog = new ColorDialog();
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                ColorDialog dialogDop = new ColorDialog();
                if (dialogDop.ShowDialog() == DialogResult.OK)
                {
                    var car = new Trac(100, 1000, dialog.Color, dialogDop.Color, true, true);
                    int place = parking + car;
                    Draw();
                }
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

