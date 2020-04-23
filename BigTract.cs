using System;
using System.Drawing;

namespace WindowsFormsTrac
{
    public class BigTrac : Vehicle
    {
        protected const int tractorWidth = 100;
        protected const int tractorHeight = 60;
        public BigTrac(int maxSpeed, float weight, Color mainColor)
        {
            MaxSpeed = maxSpeed;
            Weight = weight;
            MainColor = mainColor;
        }
        public BigTract(string info)
        {
            string[] strs = info.Split(';');
            if (strs.Length == 3)
            {
                MaxSpeed = Convert.ToInt32(strs[0]);
                Weight = Convert.ToInt32(strs[1]);
                MainColor = Color.FromName(strs[2]);
            }
        }

        public override void MoveTransport(Direction direction)
        {
            float step = MaxSpeed * 100 / Weight;
            switch (direction)
            {
                case Direction.Right:
                    if (_startPosX + step < _pictureWidth - tractorWidth)
                    {
                        _startPosX += step;
                    }
                    break;
                case Direction.Left:
                    if (_startPosX - step > 0)
                    {
                        _startPosX -= step;
                    }
                    break;
                case Direction.Up:
                    if (_startPosY - step > 0)
                    {
                        _startPosY -= step;
                    }
                    break;
                case Direction.Down:
                    if (_startPosY + step < _pictureHeight - tractorHeight)
                    {
                        _startPosY += step;
                    }
                    break;
            }
        }
        public override void Drawtractor(Graphics g)
        {
            Brush K = new SolidBrush(MainColor);
            g.FillRectangle(K, _startPosX + 35, _startPosY + 20, 40, 25);
            Brush brRed = new SolidBrush(Color.Red);
            g.FillRectangle(brRed, _startPosX + 35, _startPosY, 20, 20);
            Brush br = new SolidBrush(Color.Black);
            g.FillEllipse(br, _startPosX + 20, _startPosY + 30, 25, 25);
            g.FillEllipse(br, _startPosX + 60, _startPosY + 40, 15, 15);
        }
        public override string ToString()
        {
            return MaxSpeed + ";" + Weight + ";" + MainColor.Name;
        }
    }
}
