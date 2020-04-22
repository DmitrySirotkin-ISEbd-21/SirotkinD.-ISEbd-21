using System;
using System.Drawing;
namespace WindowsFormsTrac
{
    public class Trac : BigTract, IComparable<Trac>, IEquatable<Trac>
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
        public Trac(string info) : base(info)
        {
            string[] strs = info.Split(';');
            if (strs.Length == 6)
            {
                MaxSpeed = Convert.ToInt32(strs[0]);
                Weight = Convert.ToInt32(strs[1]);
                MainColor = Color.FromName(strs[2]);
                DopColor = Color.FromName(strs[3]);
                FrontKovsh = Convert.ToBoolean(strs[4]);
                BackKovsh = Convert.ToBoolean(strs[5]);
            }
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
        public override string ToString()
        {
            return base.ToString() + ";" + DopColor.Name + ";" + FrontKovsh + ";" + BackKovsh;
        }
        public int CompareTo(Trac other)
        {
            var res = (this as BigTract).CompareTo(other as BigTract);
            if (res != 0)
            {
                return res;
            }
            if (DopColor != other.DopColor)
            {
                return DopColor.Name.CompareTo(other.DopColor.Name);
            }
            if (FrontKovsh != other.FrontKovsh)
            {
                return FrontKovsh.CompareTo(other.FrontKovsh);
            }
            if (BackKovsh != other.BackKovsh)
            {
                return BackKovsh.CompareTo(other.BackKovsh);
            }

            return 0;
        }

        public bool Equals(Trac other)
        {
            var res = (this as BigTract).Equals(other as BigTract);
            if (!res)
            {
                return res;
            }
            if (DopColor != other.DopColor)
            {
                return false;
            }
            if (FrontKovsh != other.FrontKovsh)
            {
                return false;
            }
            if (BackKovsh != other.BackKovsh)
            {
                return false;
            }
            return true;
        }

        public override bool Equals(object obj)
        {
            if (obj == null)
            {
                return false;
            }

            Trac trucObj = obj as Trac;
            if (trucObj == null)
            {
                return false;
            }
            else
            {
                return Equals(trucObj);
            }
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }
}
