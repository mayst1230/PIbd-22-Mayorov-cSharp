using System.Drawing;


namespace WindowsFormsBus
{
    public class Bus : Vehicle
    {
        protected readonly int busWidth = 190;
        /// <summary>
        /// Высота отрисовки автомобиля
        /// </summary>
        protected readonly int busHeight = 100;
        /// <summary>
        /// Конструктор
        /// </summary>
        /// <param name="maxSpeed">Максимальная скорость</param>
        /// <param name="weight">Вес автомобиля</param>
        /// <param name="mainColor">Основной цвет кузова</param>
        public Bus(int maxSpeed, float weight, Color mainColor)
        {
            MaxSpeed = maxSpeed;
            Weight = weight;
            MainColor = mainColor;
        }
        /// <summary>
        /// Конструкторс изменением размеров машины
        /// </summary>
        /// <param name="maxSpeed">Максимальная скорость</param>
        /// <param name="weight">Вес автомобиля</param>
        /// <param name="mainColor">Основной цвет кузова</param>
        /// <param name="busWidth">Ширина отрисовки автомобиля</param>
        /// <param name="busHeight">Высота отрисовки автомобиля</param>
        protected Bus(int maxSpeed, float weight, Color mainColor, int busWidth, int busHeight)
        {
            MaxSpeed = maxSpeed;
            Weight = weight;
            MainColor = mainColor;
            this.busWidth = busWidth;
            this.busHeight = busHeight;
        }
        public override void MoveBus(Direction direction)
        {
            float step = MaxSpeed * 300 / Weight;
            switch (direction)
            {
                case Direction.Right:
                    if (_startPosX + step < pictureWidth - busWidth)
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
                    if (_startPosY + step < pictureHeight - busHeight)
                    {
                        _startPosY += step;
                    }
                    break;
            }
        }

        public override void DrawBus(Graphics g)
        {
            Pen pen = new Pen(Color.Black);
            Brush body = new SolidBrush(MainColor);
            Brush wheels = new SolidBrush(Color.Black);

            // передний корпус
            g.DrawRectangle(pen, _startPosX, _startPosY - 1, 160, 42);
            g.FillRectangle(body, _startPosX, _startPosY - 1, 160, 42);
            Brush brDarkGreen = new SolidBrush(Color.DarkGreen);
            g.FillRectangle(brDarkGreen, _startPosX, _startPosY - 1, 160, 25);

            //окна
            Brush brLightBlueWindows = new SolidBrush(Color.LightBlue);
            g.FillRectangle(brLightBlueWindows, _startPosX + 35, _startPosY + 5, 40, 20);
            g.FillRectangle(brLightBlueWindows, _startPosX + 105, _startPosY + 5, 40, 20);

            //водительское окно
            Brush brDarkBlueWindow = new SolidBrush(Color.DarkBlue);
            g.FillRectangle(brDarkBlueWindow, _startPosX, _startPosY - 1, 10, 25);

            //передние окна
            g.DrawRectangle(pen, _startPosX + 35, _startPosY + 5, 40, 20);
            g.DrawRectangle(pen, _startPosX + 105, _startPosY + 5, 40, 20);

            //передние колеса
            g.FillEllipse(wheels, _startPosX + 35, _startPosY + 30, 20, 20);
            g.FillEllipse(wheels, _startPosX + 125, _startPosY + 30, 20, 20);

            g.DrawEllipse(pen, _startPosX + 35, _startPosY + 30, 20, 20);
            g.DrawEllipse(pen, _startPosX + 125, _startPosY + 30, 20, 20);

            //передние двери
            Brush brBlue = new SolidBrush(Color.LightBlue);
            g.FillRectangle(brBlue, _startPosX + 10, _startPosY + 10, 20, 30);
            g.FillRectangle(brBlue, _startPosX + 80, _startPosY + 10, 20, 30);

            g.DrawRectangle(pen, _startPosX + 10, _startPosY + 10, 20, 30);
            g.DrawRectangle(pen, _startPosX + 18, _startPosY + 10, 2, 30);

            g.DrawRectangle(pen, _startPosX + 80, _startPosY + 10, 20, 30);
            g.DrawRectangle(pen, _startPosX + 88, _startPosY + 10, 2, 30);
        }
    }
}