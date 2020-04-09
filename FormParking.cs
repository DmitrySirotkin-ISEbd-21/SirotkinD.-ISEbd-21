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
            parking = new Parking<ITransport>(20, pictureBoxTrac1.Width, pictureBoxTrac1.Height);
            Draw();
        }
        private void Draw()
        {
            Bitmap bmp = new Bitmap(pictureBoxTrac1.Width, pictureBoxTrac1.Height);
            Graphics gr = Graphics.FromImage(bmp);
            parking.Draw(gr);
            pictureBoxTrac1.Image = bmp;
        }
        private void buttonTake_Click(object sender, EventArgs e)
        {
            if (maskedTextBox1.Text != "")
            {
                var car = parking - Convert.ToInt32(maskedTextBox1.Text);
                if (car != null)
                {
                    Bitmap bmp = new Bitmap(pictureBox1.Width, pictureBox1.Height);
                    Graphics gr = Graphics.FromImage(bmp);
                    car.SetPosition(5, 5, pictureBox1.Width, pictureBox1.Height);
                    car.Drawtractor(gr); pictureBox1.Image = bmp;
                }
                else
                {
                    Bitmap bmp = new Bitmap(pictureBox1.Width, pictureBox1.Height);
                    pictureBox1.Image = bmp;
                }
                Draw();
            }
        }
    

        private void buttonSetL_Clik(object sender, EventArgs e)
        {
            ColorDialog dialog = new ColorDialog();
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                var tractor = new BigTract(100, 1000, dialog.Color);
                int place = parking + tractor;
                Draw();
            }
        }

        private void buttonSetH_Clik(object sender, EventArgs e)
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
    }
}
