using System;
using System.Drawing;
using System.Windows.Forms;

namespace WindowsFormsBus
{
    public partial class FormParking : Form
    {
        private readonly Parking<Bus> parking;

        public FormParking()
        {
            InitializeComponent();
            parking = new Parking<Bus>(pictureBoxParking.Width, pictureBoxParking.Height);
            Draw();
        }

        private void Draw()
        {
            Bitmap bmp = new Bitmap(pictureBoxParking.Width, pictureBoxParking.Height);
            Graphics gr = Graphics.FromImage(bmp);
            parking.Draw(gr);
            pictureBoxParking.Image = bmp;
        }

        private void parkingButtonBus_Click(object sender, EventArgs e)
        {
            ColorDialog dialog = new ColorDialog();
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                Bus bus = new Bus(100, 1000, dialog.Color);
                if (parking + bus)
                {
                    Draw();
                }
                else
                {
                    MessageBox.Show("Парковка переполнена");
                }
            }
        }

        private void parkingButtonAccordionBus_Click(object sender, EventArgs e)
        {
            ColorDialog dialog = new ColorDialog();
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                ColorDialog dialogDop = new ColorDialog();
                if (dialogDop.ShowDialog() == DialogResult.OK)
                {
                    AccordionBus bus = new AccordionBus(100, 1000, dialog.Color, dialogDop.Color, true, true, true, true, true, true, true, true, true);
                    if (parking + bus)
                    {
                        Draw();
                    }
                    else
                    {
                        MessageBox.Show("Парковка переполнена");
                    }
                }
            }
        }

        private void pickUpBus_Click(object sender, EventArgs e)
        {
            if (maskedTextBoxBus.Text != "")
            {
                Bus bus = parking - Convert.ToInt32(maskedTextBoxBus.Text);
                if (bus != null)
                {
                    FormBus form = new FormBus();
                    form.SetBus(bus);
                    form.ShowDialog();
                }
                else {
                    MessageBox.Show("Парковочное место пустое");
                }
                Draw();
            }
        }
    }
}
