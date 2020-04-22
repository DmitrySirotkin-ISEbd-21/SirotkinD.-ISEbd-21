using System.Drawing;
namespace WindowsFormsTrac
{
    public interface ITransport
    {
        void SetPosition(int x, int y, int width, int height);
        void MoveTransport(Direction direction);
        void Drawtractor(Graphics g);
        void SetMainColor(Color color);
    }
}
