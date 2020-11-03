using System.Drawing;

namespace WindowsFormsBus
{
    public abstract class Vehicle : ITransport

    {
        protected int pictureWidth;

        protected int pictureHeight;

        protected float _startPosX;

        protected float _startPosY;

        public int MaxSpeed { protected set; get; }

        public float Weight { protected set; get; }

        public Color MainColor { protected set; get; }
        public void SetPosition(int x, int y, int width, int height)
        {
            _startPosX = x;
            _startPosY = y;
            pictureWidth = width;
            pictureHeight = height;
        }

        public void SetMainColor(Color color)
        {
            MainColor = color;
        }

        public abstract void DrawBus(Graphics g);
        public abstract void MoveBus(Direction direction);
    }
}