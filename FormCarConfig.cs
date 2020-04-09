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
    public partial class FormCarConfig : Form
    {
        ITransport tractor = null;

        private event TrucDelegate eventAddTruc;

        public FormCarConfig()
        {
            InitializeComponent();
            panelBlack.MouseDown += panelColor_MouseDown;
            panelOrange.MouseDown += panelColor_MouseDown;
            panelLime.MouseDown += panelColor_MouseDown;
            panelPurpule.MouseDown += panelColor_MouseDown;
            panelRed.MouseDown += panelColor_MouseDown;
            panelWhite.MouseDown += panelColor_MouseDown;
            panelYellow.MouseDown += panelColor_MouseDown;
            panelBlue.MouseDown += panelColor_MouseDown;
            buttonTake.Click += (object sender, EventArgs e) => { Close(); };

        }
        private void panelColor_MouseDown(object sender, MouseEventArgs e)
        {
            (sender as Control).DoDragDrop((sender as Control).BackColor, DragDropEffects.Move | DragDropEffects.Copy);
        }
        private void Drawtractor()
        {
            if (tractor != null)
            {
                Bitmap bmp = new Bitmap(pictureBoxTTT.Width, pictureBoxTTT.Height);
                Graphics gr = Graphics.FromImage(bmp);
                tractor.SetPosition(5, 5, pictureBoxTTT.Width, pictureBoxTTT.Height);
                tractor.Drawtractor(gr);
                pictureBoxTTT.Image = bmp;
            }
        }
        public void AddEvent(TrucDelegate ev)
        {
            if (eventAddTruc == null)
            {
                eventAddTruc = new TrucDelegate(ev);
            }
            else
            {
                eventAddTruc += ev;
            }
        }
        private void lable1_MouseDown(object sender, MouseEventArgs e)
        {
            label1.DoDragDrop(label1.Text, DragDropEffects.Move | DragDropEffects.Copy);
        }

        private void lable2_MouseDown(object sender, MouseEventArgs e)
        {
            label2.DoDragDrop(label2.Text, DragDropEffects.Move | DragDropEffects.Copy);
        }

        private void panelTTT_DragDrop(object sender, DragEventArgs e)
        {
            switch (e.Data.GetData(DataFormats.Text).ToString())
            {
                case "Лёгкий": tractor = new BigTract(100, 500, Color.White);
                    break;
                case "Тяжёлый": tractor = new Trac(100, 500, Color.White, Color.Black, true, true);
                    break;
            }
            Drawtractor();
        }

        private void panelTTT_DragEnter(object sender, DragEventArgs e)
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

        private void buttonTake_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void buttonSet_Click(object sender, EventArgs e)
        {
            eventAddTruc?.Invoke(tractor);
            Close();
        }

        private void lableDop_DragDrop(object sender, DragEventArgs e)
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

        private void labelDop_DragEnter(object sender, DragEventArgs e)
        {
            if (tractor != null)
            {
                if (tractor is Trac)
                {
                    (tractor as Trac).SetDopColor((Color)e.Data.GetData(typeof(Color))); 
                }
                Drawtractor();
            }
        }

        private void lableMain_DragDrop(object sender, DragEventArgs e)
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

        private void lableMain_DragEnter(object sender, DragEventArgs e)
        {
            if (tractor != null)
            {
                tractor.SetMainColor((Color)e.Data.GetData(typeof(Color)));
            }
            Drawtractor();
        }
    }
}

