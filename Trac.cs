using System;
using System.Drawing;
namespace WindowsFormsTrac
{
    public class Trac : BigTract
    {
        public bool FrontKovsh { private set; get; }
        public bool BackKovsh { private set; get; }
        public Color DopColor { protected set; get; }
        public Trac(int maxSpeed, float weight, Color mainColor, Color dopColor, bool frontKovsh, bool backKovsh) : base(maxSpeed, weight, mainColor)
        {
            FrontKovsh = frontKovsh;
            BackKovsh = backKovsh;
            DopColor = dopColor;
        }
        public override void Drawtractor(Graphics g)
        {
            Pen pen = new Pen(Color.Black);
            if (FrontKovsh)
            {
                Brush dopBrush = new SolidBrush(DopColor);
                g.FillRectangle(dopBrush, _startPosX + 75, _startPosY + 30, 20, 20);
            }
            if (BackKovsh)
            {
                Brush dopBrush = new SolidBrush(DopColor);
                g.FillRectangle(dopBrush, _startPosX + 25, _startPosY, 10, 30);
            }
            base.Drawtractor(g);
        }
        public void SetDopColor(Color color)
        {
            DopColor = color;
        }
    }
}
