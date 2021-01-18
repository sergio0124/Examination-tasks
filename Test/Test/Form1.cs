/*using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;*/
using System.Windows.Forms;/*

namespace WindowsFormsAutoTrain
{
    public partial class FormCarConfig : Form
    {
        private event Action<Vehicle> eventAddCar;

        Vehicle car = null;
        public FormCarConfig()
        {
            InitializeComponent();

            foreach (var Item in groupBox3.Controls)
            {
                if (Item is Panel)
                {
                    ((Panel)Item).MouseDown += panelColor_MouseDown;
                }
            }

            buttonCancel.Click += (object sender, EventArgs e) => { Close(); };
        }

        public void AddEvent(Action<Vehicle> ev)
        {
            if (eventAddCar == null)
            {
                eventAddCar = new Action<Vehicle>(ev);
            }
            else
            {
                eventAddCar += ev;
            }
        }

        private void panelColor_MouseDown(object sender, EventArgs e)
        {
            ((Panel)sender).DoDragDrop(((Panel)sender).BackColor, DragDropEffects.Move |
DragDropEffects.Copy);
        }

        private void Draw()
        {
            Bitmap bmp = new Bitmap(pictureBoxCarConfig.Width,
            pictureBoxCarConfig.Height);
            Graphics gr = Graphics.FromImage(bmp);
            car.SetPosition(5, 5, pictureBoxCarConfig.Width, pictureBoxCarConfig.Height);
            car.DrawCars(gr);
            pictureBoxCarConfig.Image = bmp;
        }

        private void labelHeavyCar_MouseDown(object sender, MouseEventArgs e)
        {
            labelHeavyCar.DoDragDrop(labelHeavyCar.Name, DragDropEffects.Move |
DragDropEffects.Copy);
        }

        private void panelDrop_DragEnter(object sender, DragEventArgs e)
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

        private void panelDrop_DragDrop(object sender, DragEventArgs e)
        {
            switch (e.Data.GetData(DataFormats.Text).ToString())
            {
                case "labelHeavyCar":
                    car = new HeavyCar((int)numericUpDownSpeed.Value, (int)numericUpDownWeight.Value, Color.White);
                    break;
                case "labelAutoTrain":
                    car = new AutoTrain(Color.White, Color.Green, checkBoxLine.Checked, checkBoxContainer.Checked,
                   checkBoxBeacon.Checked);
                    break;
            }
            Draw();
        }

        private void labelAutoTrain_MouseDown(object sender, MouseEventArgs e)
        {
            labelAutoTrain.DoDragDrop(labelAutoTrain.Name, DragDropEffects.Move |
DragDropEffects.Copy);
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

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            eventAddCar?.Invoke(car);
            Close();
        }

        private void labelMainColor_DragDrop(object sender, DragEventArgs e)
        {
            car?.SetMainColor((Color)e.Data.GetData(typeof(Color)));
            Draw();
        }

        private void labelDopColor_DragDrop(object sender, DragEventArgs e)
        {
            if (car is AutoTrain)
            {
                AutoTrain autoTrain = (AutoTrain)car;
                autoTrain.SetDopColor((Color)e.Data.GetData(typeof(Color)));
                car = autoTrain;
                Draw();
            }
        }
    }
}
*/