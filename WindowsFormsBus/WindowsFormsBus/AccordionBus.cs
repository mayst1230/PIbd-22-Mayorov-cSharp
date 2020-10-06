using System.Drawing;

namespace WindowsFormsBus
{
    internal class AccordionBus
    {
        private float _startPosX;
        private float _startPosY;
        private int pictureWidth;
        private int pictureHeight;
        private double changeWidth = 0.9;
        private double changeHeight = 1;
        private readonly int busWidth = 300;
        private readonly int busHeight = 50;
        public int Speed { private set; get; }
        public float Weight { private set; get; }
        public Color MainColor { private set; get; }
        public Color OtherColor { private set; get; }
        public bool BackBody { private set; get; }
        public bool BackDoors { private set; get; }
        public bool Accordion { private set; get; }
        public bool BackWindows { private set; get; }
        public bool BackWheels { private set; get; }

        public AccordionBus(int speed, float weight, Color mainColor, Color otherColor, bool accordion, bool backWheels, bool backBody, bool backDoors, bool backWindows)
        {
            Speed = speed;
            Weight = weight;
            MainColor = mainColor;
            OtherColor = otherColor;
            BackBody = backBody;
            BackWindows = backWindows;
            BackDoors = backDoors;
            Accordion = accordion;
            BackWheels = backWheels;
        }

        public void SetPosition(int x, int y, int width, int height)
        {
            _startPosX = x;
            _startPosY = y;
            pictureWidth = width;
            pictureHeight = height;
        }

        public void MoveBus(Direction direction)
        {
            float step = Speed * 300 / Weight;
            switch (direction)
            {
                case Direction.Right:
                    if (_startPosX + step < pictureWidth - busWidth * changeWidth)
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
                    if (_startPosY - step > 0 + busHeight)
                    {
                        _startPosY -= step;
                    }
                    break;

                case Direction.Down:
                    if (_startPosY + step < pictureHeight - busHeight * changeHeight)
                    {
                        _startPosY += step;
                    }
                    break;
            }

        }
        public void DrawBus(Graphics g)
        {
            Pen pen = new Pen(Color.Black);
            Brush body = new SolidBrush(MainColor);
            Brush wheels = new SolidBrush(Color.Black);
            Brush accordionBrush = new SolidBrush(OtherColor);
            Brush brLightBlueWindows = new SolidBrush(Color.LightBlue);
            Brush brBlue = new SolidBrush(Color.LightBlue);
            Brush brDarkGreen = new SolidBrush(Color.DarkGreen);

            g.DrawRectangle(pen, _startPosX, _startPosY - 1, 160, 42);
            g.FillRectangle(body, _startPosX, _startPosY - 1, 160, 42);
            g.FillRectangle(brDarkGreen, _startPosX, _startPosY - 1, 160, 25);

            if (BackBody)
            {
                g.DrawRectangle(pen, _startPosX + 190, _startPosY - 1, 80, 42);
                g.FillRectangle(body, _startPosX + 190, _startPosY - 1, 80, 42);
                g.FillRectangle(brDarkGreen, _startPosX + 190, _startPosY - 1, 80, 25);
            }

            if (Accordion)
            {
                g.FillRectangle(accordionBrush, _startPosX + 160, _startPosY, 5, 40);
                g.FillRectangle(accordionBrush, _startPosX + 165, _startPosY, 5, 40);
                g.FillRectangle(accordionBrush, _startPosX + 170, _startPosY, 5, 40);
                g.FillRectangle(accordionBrush, _startPosX + 175, _startPosY, 5, 40);
                g.FillRectangle(accordionBrush, _startPosX + 180, _startPosY, 5, 40);
                g.FillRectangle(accordionBrush, _startPosX + 185, _startPosY, 5, 40);

                g.DrawRectangle(pen, _startPosX + 160, _startPosY, 5, 40);
                g.DrawRectangle(pen, _startPosX + 165, _startPosY, 5, 40);
                g.DrawRectangle(pen, _startPosX + 170, _startPosY, 5, 40);
                g.DrawRectangle(pen, _startPosX + 175, _startPosY, 5, 40);
                g.DrawRectangle(pen, _startPosX + 180, _startPosY, 5, 40);
                g.DrawRectangle(pen, _startPosX + 185, _startPosY, 5, 40);
            }

            g.FillRectangle(brLightBlueWindows, _startPosX + 35, _startPosY + 5, 40, 20);
            g.FillRectangle(brLightBlueWindows, _startPosX + 105, _startPosY + 5, 40, 20);

            //водительское окно
            Brush brDarkBlueWindow = new SolidBrush(Color.DarkBlue);
            g.FillRectangle(brDarkBlueWindow, _startPosX, _startPosY - 1, 10, 25);

            //передние окна
            g.DrawRectangle(pen, _startPosX + 35, _startPosY + 5, 40, 20);
            g.DrawRectangle(pen, _startPosX + 105, _startPosY + 5, 40, 20);


            if (BackWindows)
            {
                g.FillRectangle(brLightBlueWindows, _startPosX + 220, _startPosY + 5, 20, 20);
                g.DrawRectangle(pen, _startPosX + 220, _startPosY + 5, 20, 20);
            }

            g.FillEllipse(wheels, _startPosX + 35, _startPosY + 30, 20, 20);
            g.FillEllipse(wheels, _startPosX + 125, _startPosY + 30, 20, 20);

            g.DrawEllipse(pen, _startPosX + 35, _startPosY + 30, 20, 20);
            g.DrawEllipse(pen, _startPosX + 125, _startPosY + 30, 20, 20);

            if (BackWheels)
            {
                g.FillEllipse(wheels, _startPosX + 220, _startPosY + 30, 20, 20);
                g.DrawEllipse(pen, _startPosX + 220, _startPosY + 30, 20, 20);
            }

            g.FillRectangle(brBlue, _startPosX + 10, _startPosY + 10, 20, 30);
            g.FillRectangle(brBlue, _startPosX + 80, _startPosY + 10, 20, 30);

            g.DrawRectangle(pen, _startPosX + 10, _startPosY + 10, 20, 30);
            g.DrawRectangle(pen, _startPosX + 18, _startPosY + 10, 2, 30);

            g.DrawRectangle(pen, _startPosX + 80, _startPosY + 10, 20, 30);
            g.DrawRectangle(pen, _startPosX + 88, _startPosY + 10, 2, 30);

            //задние двери
            g.FillRectangle(brBlue, _startPosX + 195, _startPosY + 10, 20, 30);
            g.FillRectangle(brBlue, _startPosX + 245, _startPosY + 10, 20, 30);

            g.DrawRectangle(pen, _startPosX + 195, _startPosY + 10, 20, 30);
            g.DrawRectangle(pen, _startPosX + 203, _startPosY + 10, 2, 30);

            g.DrawRectangle(pen, _startPosX + 245, _startPosY + 10, 20, 30);
            g.DrawRectangle(pen, _startPosX + 253, _startPosY + 10, 2, 30);

        }
    }
}
