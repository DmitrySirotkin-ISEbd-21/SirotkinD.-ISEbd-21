﻿using System;
using System.Drawing;
using System.Windows.Forms;

namespace WindowsFormsTrac
{
    public partial class FormTract : Form
    {
        private BigTract tractor;
        public FormTract()
        {
            InitializeComponent();
        }
        private void Draw()
        {
            Bitmap bmp = new Bitmap(pictureBoxTrac.Width, pictureBoxTrac.Height);
            Graphics gr = Graphics.FromImage(bmp);
            tractor.Drawtractor(gr);
            pictureBoxTrac.Image = bmp;
        }

        private void buttonCreate_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            tractor = new BigTract(rnd.Next(100, 300), rnd.Next(1000, 2000), Color.Blue, Color.Yellow,true, true);
            tractor.SetPosition(rnd.Next(10, 100), rnd.Next(10, 100), pictureBoxTrac.Width,
           pictureBoxTrac.Height);
            Draw();

        }

        private void buttonMove_Click(object sender, EventArgs e)
        {
            string name = (sender as Button).Name;
            switch (name)
            {
                case "buttonUp":
                    tractor.MoveTransport(Direction.Up);
                    break;
                case "buttonDown":
                    tractor.MoveTransport(Direction.Down);
                    break;
                case "buttonLeft":
                    tractor.MoveTransport(Direction.Left);
                    break;
                case "buttonRight":
                    tractor.MoveTransport(Direction.Right);
                    break;
            }
            Draw();
        }
    }
}
