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

        public void SetBus(ITransport Bus)
        {
            this.Bus = Bus;
            Draw();
        }

        public void Draw()
        {
            Bitmap bmp = new Bitmap(pictureBoxBus.Width, pictureBoxBus.Height);
            Graphics gr = Graphics.FromImage(bmp);
            Bus.DrawBus(gr);
            pictureBoxBus.Image = bmp;
        }

        private void buttonMove_Click(object sender, EventArgs e)
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
}