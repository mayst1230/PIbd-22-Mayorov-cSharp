using System;
using System.Drawing;
using System.Windows.Forms;

namespace WindowsFormsBus
{
    public partial class FormBus : Form
    {
        private AccordionBus accordionBus;
        public FormBus()
        {
            InitializeComponent();
        }

        public void Draw()
        {
            Bitmap bmp = new Bitmap(pictureBoxBus.Width, pictureBoxBus.Height);
            Graphics gr = Graphics.FromImage(bmp);
            accordionBus.DrawBus(gr);
            pictureBoxBus.Image = bmp;
        }

        private void buttonCreate_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            accordionBus = new AccordionBus(rnd.Next(800, 900), rnd.Next(45000, 78000), Color.Green, Color.Gray, true, true, true, true, true);
            accordionBus.SetPosition(rnd.Next(120, 150), rnd.Next(70, 100), pictureBoxBus.Width,
            pictureBoxBus.Height);
            Draw();
        }

        private void buttonMove_Click(object sender, EventArgs e)
        {
            if (accordionBus != null)
            {
                //получаем имя кнопки     
                string name = (sender as Button).Name;
                switch (name)
                {
                    case "buttonUp":
                        accordionBus.MoveBus(Direction.Up);
                        break;
                    case "buttonDown":
                        accordionBus.MoveBus(Direction.Down);
                        break;
                    case "buttonLeft":
                        accordionBus.MoveBus(Direction.Left);
                        break;
                    case "buttonRight":
                        accordionBus.MoveBus(Direction.Right);
                        break;
                }
                Draw();
            }
        }
    }
}
