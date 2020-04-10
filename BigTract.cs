using System.Drawing;

namespace WindowsFormsTrac
{
    public class BigTract
    {
        private float _startPosX;
        private float _startPosY;
        private int _pictureWidth;
        private int _pictureHeight;
        private const int tractorWidth = 100;
        private const int tractorHeight = 60;
        public int MaxSpeed { private set; get; }
        public float Weight { private set; get; }
        public Color MainColor { private set; get; }
        public Color DopColor { private set; get; }
        public bool FrontKovsh { private set; get; }
        public bool BackKovsh { private set; get; }
        public BigTract(int maxSpeed, float weight, Color mainColor, Color dopColor,
       bool frontKovsh, bool backKovsh)
        {
            MaxSpeed = maxSpeed;
            Weight = weight;
            MainColor = mainColor;
            DopColor = dopColor;
            FrontKovsh = frontKovsh;
            BackKovsh = backKovsh;
        }

        public void SetPosition(int x, int y, int width, int height)
        {
            _startPosX = x;
            _startPosY = y;
            _pictureWidth = width;
            _pictureHeight = height;
        }
        public void MoveTransport(Direction direction)
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
        public void Drawtractor(Graphics g)
        {
            Pen pen = new Pen(Color.Black);
            if (FrontKovsh)
            {
                Brush FrontKovsh = new SolidBrush(Color.Gray);
                g.FillRectangle(FrontKovsh, _startPosX + 75, _startPosY + 30, 20, 20);
            }
            Brush K = new SolidBrush(DopColor);
            g.FillRectangle(K, _startPosX + 35, _startPosY + 20, 40, 25);
            Brush brRed = new SolidBrush(Color.Red);
            g.FillRectangle(brRed, _startPosX + 35, _startPosY, 20, 20);
            Brush br = new SolidBrush(Color.Black);
            g.FillEllipse(br, _startPosX + 20, _startPosY + 30, 25, 25);
            g.FillEllipse(br, _startPosX + 60, _startPosY + 40, 15, 15);

            if (BackKovsh)
            {
                Brush BackKovsh = new SolidBrush(Color.Gray);
                g.FillRectangle(BackKovsh, _startPosX + 25, _startPosY, 10, 30);
            }
        }
    }
}

