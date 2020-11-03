using System.Drawing;

namespace WindowsFormsBus
{
    public interface ITransport
    {
        /// <param name="x">Координата X</param>
        /// <param name="y">Координата Y</param>
        /// <param name="width">Ширина картинки</param>
        /// <param name="height">Высота картинки</param>
        void SetPosition(int x, int y, int width, int height);

        /// <param name="direction">Направление</param>
        void MoveBus(Direction direction);

        /// <param name="g"><
        void DrawBus(Graphics g);

        void SetMainColor(Color color);
    }
}