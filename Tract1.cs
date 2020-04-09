using System;
using System.Drawing;
public enum Direction
{
    Up,
    Down,
    Left,
    Right
}
namespace WindowsFormsLab2
{
    public class Tract1 : Vehicle, IComparable<Tract1>, IEquatable<Tract1>
    {
        protected const int tractorWidth = 100;
        protected const int tractorHeight = 60;

        public Color DopColor { get; internal set; }

        /// <summary>
        /// Конструктор
        /// </summary>
        /// <param name="maxSpeed">Максимальная скорость</param>
        /// <param name="weight">Вес </param>
        /// <param name="mainColor">Основной цвет </param>

        public Tract1(int maxSpeed, float weight, Color mainColor)
        {
            MaxSpeed = maxSpeed;
            Weight = weight;
            MainColor = mainColor;
        }
        /// <summary>         
        /// Конструктор         
        /// </summary>         
        /// <param name="info">Информация по объекту</param>
        public Tract1(string info)
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
        public override void DrawTract(Graphics g)
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
        public int CompareTo(Tract1 other)
        {
            if (other == null)
            {
                return 1;
            }
            if (MaxSpeed != other.MaxSpeed)
            {
                return MaxSpeed.CompareTo(other.MaxSpeed);
            }
            if (Weight != other.Weight)
            {
                return Weight.CompareTo(other.Weight);
            }
            if (MainColor != other.MainColor)
            {
                return MainColor.Name.CompareTo(other.MainColor.Name);
            }
            return 0;
        }

        public bool Equals(Tract1 other)
        {
            if (other == null)
            {
                return false;
            }
            if (MaxSpeed != other.MaxSpeed)
            {
                return false;
            }
            if (Weight != other.Weight)
            {
                return false;
            }
            if (MainColor != other.MainColor)
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

            Tract1 Obj = obj as Tract1;
            if (Obj == null)
            {
                return false;
            }
            else
            {
                if (Obj.GetType().Name == "Tract1")
                {
                    return Equals(Obj);
                }
                else
                {
                    return false;
                }
            }
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

    }
}
