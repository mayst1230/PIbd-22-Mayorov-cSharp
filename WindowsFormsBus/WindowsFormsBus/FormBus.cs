using System;
using System.Drawing;
using System.Windows.Forms;

namespace WindowsFormsBus
{
    public partial class FormBus : Form
    {
        private ITransport Bus;
        public FormBus()
        {
            InitializeComponent();
        }

        public void Draw()
        {
            Bitmap bmp = new Bitmap(pictureBoxBus.Width, pictureBoxBus.Height);
            Graphics gr = Graphics.FromImage(bmp);
            Bus.DrawBus(gr);
            pictureBoxBus.Image = bmp;
        }

        private void buttonCreateBus_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            Bus = new Bus(rnd.Next(800, 900), rnd.Next(45000, 78000), Color.Green);
            Bus.SetPosition(rnd.Next(120, 150), rnd.Next(70, 100), pictureBoxBus.Width,
            pictureBoxBus.Height);
            Draw();
        }

        private void buttonMove_Click(object sender, EventArgs e)
        {
            if (Bus != null)
            {
                //получаем имя кнопки     
                string name = (sender as Button).Name;
                switch (name)
                {
                    case "buttonUp":
                        Bus.MoveBus(Direction.Up);
                        break;
                    case "buttonDown":
                        Bus.MoveBus(Direction.Down);
                        break;
                    case "buttonLeft":
                        Bus.MoveBus(Direction.Left);
                        break;
                    case "buttonRight":
                        Bus.MoveBus(Direction.Right);
                        break;
                }
                Draw();
            }
        }

        private void buttonCreateAccordionBus_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            Bus = new AccordionBus(rnd.Next(800, 900), rnd.Next(45000, 78000), Color.Green, Color.Gray, true, true, true, true, true, true, true, true, true);
            Bus.SetPosition(rnd.Next(120, 150), rnd.Next(70, 100), pictureBoxBus.Width,
            pictureBoxBus.Height);
            Draw();
        }
    }
}