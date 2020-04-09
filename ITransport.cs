using System.Drawing;
namespace WindowsFormsLab2
{
    public interface ITransport
    {
 /// <summary>
 /// Установка позиции трактора
 /// </summary>
 /// <param name="x">Координата X</param>
 /// <param name="y">Координата Y</param>
 /// <param name="width">Ширина картинки</param>
 /// <param name="height">Высота картинки</param>
 void SetPosition(int x, int y, int width, int height); 
        /// <summary>
        /// Изменение направления пермещения
        /// </summary>
        /// <param name="direction">Направление</param>
        void MoveTransport(Direction direction);
        /// <summary>
        /// Отрисовка трактора
        /// </summary>
        /// <param name="g"></param>
        void DrawTract(Graphics g);
        void SetMainColor(Color color);
    }
}