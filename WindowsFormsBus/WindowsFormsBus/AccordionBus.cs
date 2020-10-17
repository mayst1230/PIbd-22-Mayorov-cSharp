using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsBus
{
     class AccordionBus : Bus
    {
        public Color OtherColor { private set; get; }

        public bool BackBody { private set; get; }

        public bool BackDoors { private set; get; }

        public bool Accordion { private set; get; }

        public bool BackWindows { private set; get; }

        public bool BackWheels { private set; get; }

        public AccordionBus(int maxSpeed, float weight, Color mainColor, Color otherColor, 
            bool accordion, bool frontWheels, bool backWheels, bool frontBody, 
            bool backBody, bool frontDoors, bool backDoors, bool frontWindows, 
            bool backWindows) : base(maxSpeed, weight, mainColor, 300, 100)
        {
            OtherColor = otherColor;       
            BackBody = backBody;     
            BackWindows = backWindows;
            BackDoors = backDoors;
            Accordion = accordion;  
            BackWheels = backWheels;
        }

        public override void DrawBus(Graphics g) 
        {
            Pen pen = new Pen(Color.Black);
            Brush wheels = new SolidBrush(Color.Black);
            Brush body = new SolidBrush(MainColor);
            Brush accordionBrush = new SolidBrush(OtherColor);

            if (BackBody)
            {
                g.DrawRectangle(pen, _startPosX + 190, _startPosY - 1, 80, 42);
                g.FillRectangle(body, _startPosX + 190, _startPosY - 1, 80, 42);

                Brush brDarkGreen = new SolidBrush(Color.DarkGreen);
                g.FillRectangle(brDarkGreen, _startPosX + 190, _startPosY - 1, 80, 25);
            }

            base.DrawBus(g);

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

            if (BackWindows) {
                //заднее окно
                Brush brLightBlueWindows = new SolidBrush(Color.LightBlue);
                g.FillRectangle(brLightBlueWindows, _startPosX + 220, _startPosY + 5, 20, 20);
                g.DrawRectangle(pen, _startPosX + 220, _startPosY + 5, 20, 20);
            }

            if (BackWheels)
            {
                //заднее колесо
                g.FillEllipse(wheels, _startPosX + 220, _startPosY + 30, 20, 20);
                g.DrawEllipse(pen, _startPosX + 220, _startPosY + 30, 20, 20);
            }

            if (BackDoors) {
                //задние двери
                Brush brBlue = new SolidBrush(Color.LightBlue);               
                g.FillRectangle(brBlue, _startPosX + 195, _startPosY + 10, 20, 30);
                g.FillRectangle(brBlue, _startPosX + 245, _startPosY + 10, 20, 30);

                g.DrawRectangle(pen, _startPosX + 195, _startPosY + 10, 20, 30);
                g.DrawRectangle(pen, _startPosX + 203, _startPosY + 10, 2, 30);

                g.DrawRectangle(pen, _startPosX + 245, _startPosY + 10, 20, 30);
                g.DrawRectangle(pen, _startPosX + 253, _startPosY + 10, 2, 30);
            }
        }
    }
}
