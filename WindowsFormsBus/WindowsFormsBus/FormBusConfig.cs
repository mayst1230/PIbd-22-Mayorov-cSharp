using System;
using System.Drawing;
using System.Windows.Forms;

namespace WindowsFormsBus
{
    public partial class FormBusConfig : Form
    {
        private Vehicle bus = null;
        private event Action<Vehicle> eventAddBus;
        public FormBusConfig()
        {
            InitializeComponent();
            panelYellow.MouseDown += panelColor_MouseDown;
            panelRed.MouseDown += panelColor_MouseDown;
            panelBlack.MouseDown += panelColor_MouseDown;
            panelBlue.MouseDown += panelColor_MouseDown;
            panelGreen.MouseDown += panelColor_MouseDown;
            panelWhite.MouseDown += panelColor_MouseDown;
            panelGray.MouseDown += panelColor_MouseDown;
            panelOrange.MouseDown += panelColor_MouseDown;

            buttonCancelColor.Click += (object sender, EventArgs e) => { Close(); };
        }

        public void AddEvent(Action<Vehicle> ev)
        {
            if (eventAddBus == null)
            {
                eventAddBus = new Action<Vehicle>(ev);
            }
            else
            {
                eventAddBus += ev;
            }
        }

        private void DrawBus()
        {
            if (bus != null)
            {
                Bitmap bmp = new Bitmap(pictureBoxPresent.Width, pictureBoxPresent.Height);
                Graphics gr = Graphics.FromImage(bmp);
                bus.SetPosition(5, 5, pictureBoxPresent.Width, pictureBoxPresent.Height);
                bus.DrawBus(gr);
                pictureBoxPresent.Image = bmp;
            }
        }

        private void labelTypeBus_MouseDown(object sender, MouseEventArgs e)
        {
            labelTypeBus.DoDragDrop(labelTypeBus.Text, DragDropEffects.Move | DragDropEffects.Copy);
        }
        private void labelTypeAccordionBus_MouseDown(object sender, MouseEventArgs e)
        {
            labelTypeAccordionBus.DoDragDrop(labelTypeAccordionBus.Text, DragDropEffects.Move | DragDropEffects.Copy);
        }

        private void panelPicBox_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.Text))
            {
                e.Effect = DragDropEffects.Copy;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }

        private void panelPicBox_DragDrop(object sender, DragEventArgs e)
        {
            switch (e.Data.GetData(DataFormats.Text).ToString())
            {
                case "Автобус":
                    bus = new Bus(100, 500, Color.White);
                    break;
                case "Автобус с гармошкой":
                    bus = new AccordionBus(100, 500, Color.White, Color.Black, checkBoxAccordion.Checked, checkBoxBackDoors.Checked, checkBoxBackWindows.Checked);
                    break;
            }
            DrawBus();
        }

        private void panelColor_MouseDown(object sender, MouseEventArgs e)
        {
            (sender as Control).DoDragDrop((sender as Control).BackColor,
                 DragDropEffects.Move | DragDropEffects.Copy);
        }

        private void labelMainColor_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(typeof(Color)))
            {
                e.Effect = DragDropEffects.Copy;

            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }

        private void labelMainColor_DragDrop(object sender, DragEventArgs e)
        {
            if (bus != null)
            {
                bus.SetMainColor((Color)e.Data.GetData(typeof(Color)));
                DrawBus();
            }
        }

        private void labelOtherColor_DragDrop(object sender, DragEventArgs e)
        {
            if (bus != null)
            {
                if (bus is AccordionBus)
                {
                    (bus as AccordionBus).SetOtherColor((Color)e.Data.GetData(typeof(Color)));
                    DrawBus();
                }
            }
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            eventAddBus?.Invoke(bus);
            Close();
        }
    }
}