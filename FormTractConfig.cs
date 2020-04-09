    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Data;
    using System.Drawing;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using System.Windows.Forms;

namespace WindowsFormsLab2
{
    public partial class FormTractConfig : Form
    {
        ITransport tractor = null;
        private event carDelegate eventAddtractor;

        public FormTractConfig()
        {
            InitializeComponent();
            panelBlack.MouseDown += panelColor_MouseDown;
            panelGold.MouseDown += panelColor_MouseDown;
            panelGray.MouseDown += panelColor_MouseDown;
            panelGreen.MouseDown += panelColor_MouseDown;
            panelRed.MouseDown += panelColor_MouseDown;
            panelWhite.MouseDown += panelColor_MouseDown;
            panelYellow.MouseDown += panelColor_MouseDown;
            panelBlue.MouseDown += panelColor_MouseDown;
            buttonCancel.Click += (object sender, EventArgs e) => { Close(); };
        }
        private void Draw()
        {
            if (tractor != null)
            {
                Bitmap bmp = new Bitmap(pictureBoxTR.Width, pictureBoxTR.Height);
                Graphics gr = Graphics.FromImage(bmp);
                tractor.SetPosition(5, 5, pictureBoxTR.Width, pictureBoxTR.Height);
                tractor.DrawTract(gr);
                pictureBoxTR.Image = bmp;
            }
        }
        public void AddEvent(carDelegate ev)
        {
            if (eventAddtractor == null)
            {
                eventAddtractor = new carDelegate(ev);
            }
            else
            {
                eventAddtractor += ev;
            }
        }
        private void labelDrawTract2_MouseDown(object sender, MouseEventArgs e)
        {
            labelDrawTract2.DoDragDrop(labelDrawTract2.Text, DragDropEffects.Move | DragDropEffects.Copy);
        }

        private void lableTractorOBV_MouseDown(object sender, MouseEventArgs e)
        {
            labelTractorOBV.DoDragDrop(labelTractorOBV.Text, DragDropEffects.Move | DragDropEffects.Copy);
        }
        private void panel1_DragEnter(object sender, DragEventArgs e)
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
        private void panel1_DragDrop(object sender, DragEventArgs e)
        {
            switch (e.Data.GetData(DataFormats.Text).ToString())
            {
                case "Без ковшей":
                    tractor = new Tract1(100, 500, Color.Gold);
                    break;
                case "С ковшами":
                    tractor = new Main(100, 500, Color.White, Color.Black, true, true);
                    break;
            }
            Draw();
        }

        private void panelColor_MouseDown(object sender, MouseEventArgs e)
        {
            (sender as Control).DoDragDrop((sender as Control).BackColor, DragDropEffects.Move | DragDropEffects.Copy);
        }
        private void labelMainColor_DragEnter(object sender, DragEventArgs e)
        {
            if (tractor != null)
            {
                tractor.SetMainColor((Color)e.Data.GetData(typeof(Color)));
                Draw();
            }
        }
        private void labelDopColor_DragEnter(object sender, DragEventArgs e)
        {

            if (tractor != null)
            {
                if (tractor is Main)
                {
                    (tractor as Main).SetDopColor((Color)e.Data.GetData(typeof(Color)));
                    Draw();
                }
            }
        }
        private void labelMainColor_DragDrop(object sender, DragEventArgs e)
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
        private void labelDopColor_DragDrop(object sender, DragEventArgs e)
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
        private void buttonOk_Click(object sender, EventArgs e)
        {
            eventAddtractor?.Invoke(tractor);
            Close();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
                Close();
        }
    }
}