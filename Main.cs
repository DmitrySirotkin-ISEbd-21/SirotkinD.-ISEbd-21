using System;
using System.Drawing;
namespace WindowsFormsLab2
{
    /// <summary>
    /// Класс отрисовки трактора
    /// </summary>
    public class Main : Tract1
    {
        public bool FrontKovsh { private set; get; }
        public bool BackKovsh { private set; get; }
        public Color DopColor { protected set; get; }
        /// <summary>
        /// Конструктор
        /// </summary>
        /// <param name="maxSpeed">Максимальная скорость</param>
        /// <param name="weight">Вес </param>
        /// <param name="mainColor">Основной цвет кузова</param>
        /// <param name="dopColor">Дополнительный цвет</param>
        /// <param name="FrontKovsh">Признак наличия переднего </param>
        /// <param name="BackKovsh">Признак наличия заднего </param>
        public Main(int maxSpeed, float weight, Color mainColor, Color dopColor, bool frontKovsh, bool backKovsh) : base(maxSpeed, weight, mainColor)
        {
            FrontKovsh = frontKovsh;
            BackKovsh = backKovsh;
            DopColor = dopColor;
        }
        public Main(string info) : base(info)
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
        public override void DrawTract(Graphics g)
        {
            Brush dop = new SolidBrush(DopColor);
            Pen pen = new Pen(Color.Black);
            base.DrawTract(g);
            Brush K = new SolidBrush(MainColor);
            g.FillRectangle(K, _startPosX + 35, _startPosY + 20, 40, 25);
            Brush brRed = new SolidBrush(Color.Red);
            g.FillRectangle(brRed, _startPosX + 35, _startPosY, 20, 20);
            Brush br = new SolidBrush(Color.Black);
            g.FillEllipse(br, _startPosX + 20, _startPosY + 30, 25, 25);
            g.FillEllipse(br, _startPosX + 60, _startPosY + 40, 15, 15);
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
        }
        public void SetDopColor(Color color)
        {   
            DopColor = color;
        }
        public override string ToString()
        {
            return base.ToString() + ";" + DopColor.Name + ";" + FrontKovsh + ";" + BackKovsh;
        }
    }
}
