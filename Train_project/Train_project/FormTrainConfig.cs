using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Train_project
{
    public partial class FormTrainConfig : Form
    {
        /// <summary>
        /// Переменная-выбранная поезд
        /// </summary>
        Vehicle train = null;

        /// <summary>
        /// Событие
        /// </summary>
        public Action<Vehicle> eventAddTrain;

        public FormTrainConfig()
        {
            InitializeComponent();

            panelRed.MouseDown += panelColor_MouseDown;
            panelOrange.MouseDown += panelColor_MouseDown;
            panelYellow.MouseDown += panelColor_MouseDown;
            panelGreen.MouseDown += panelColor_MouseDown;
            panelLightBlue.MouseDown += panelColor_MouseDown;
            panelBlue.MouseDown += panelColor_MouseDown;
            panelPurple.MouseDown += panelColor_MouseDown;
            panelBlack.MouseDown += panelColor_MouseDown;

            buttonCancel.Click += (object sender, EventArgs e) => { Close(); };            
        }

        /// <summary>
        /// Отрисовать поезд
        /// </summary>
        private void DrawTrain()
        {
            if (train != null)
            {
                Bitmap bmp = new Bitmap(pictureBoxTrain.Width, pictureBoxTrain.Height);
                Graphics gr = Graphics.FromImage(bmp);
                train.SetPosition(5, 5, pictureBoxTrain.Width, pictureBoxTrain.Height);
                train.DrawTransport(gr);
                pictureBoxTrain.Image = bmp;
            }
        }

        /// <summary>
        /// Добавление события
        /// </summary>
        /// <param name="ev"></param>
        public void AddEvent(Action<Vehicle> ev)
        {
            if (eventAddTrain == null)
            {
                eventAddTrain = new Action<Vehicle>(ev);
            }
            else
            {
                eventAddTrain += ev;
            }
        }

        /// <summary>
        /// Передаем информацию при нажатии на Label (поезд)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void labelTrain_MouseDown(object sender, MouseEventArgs e)
        {
            labelTrain.DoDragDrop(labelTrain.Text, DragDropEffects.Move |
            DragDropEffects.Copy);
        }

        /// <summary>
        /// Передаем информацию при нажатии на Label (Электровоз)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void labelElTrain_MouseDown(object sender, MouseEventArgs e)
        {
            labelElTrain.DoDragDrop(labelElTrain.Text, DragDropEffects.Move |
            DragDropEffects.Copy);
        }

        /// <summary>
        /// Проверка получаемой информации (ее типа на соответствие требуемому)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void panelTrain_DragEnter(object sender, DragEventArgs e)
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

        /// <summary>
        /// Действия при приеме перетаскиваемой информации
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void panelTrain_DragDrop(object sender, DragEventArgs e)
        {
            switch (e.Data.GetData(DataFormats.Text).ToString())
            {
                case "Тепловоз":
                    train = new Train((int)numericUpDownSpeed.Value,
                        (int)numericUpDownWeight.Value, Color.White, Color.LightGray);
                    break;
                case "Электровоз":
                    train = new Electric_locomotive((int)numericUpDownSpeed.Value,
                        (int)numericUpDownWeight.Value, Color.White, Color.LightGray,
                        Color.Gray,
                        checkBoxCollector.Checked, checkBoxBattery.Checked);
                    break;
            }
            DrawTrain();
        }

        /// <summary>
        /// Отправляем цвет с панели
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void panelColor_MouseDown(object sender, MouseEventArgs e)
        {
            (sender as Control).DoDragDrop((sender as Control).BackColor, DragDropEffects.Move | DragDropEffects.Copy);
        }

        /// <summary>
        /// Проверяем информацию с labelbase на соответствие
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void labelBaseDownColor_DragEnter(object sender, DragEventArgs e)
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

        /// <summary>
        /// Действия при приеме перетаскиваемого цвета (Down)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void labelBaseDownColor_DragDrop(object sender, DragEventArgs e)
        {
            if (train != null)
            {
                train.SetDownColor((Color)e.Data.GetData(typeof(Color)));
                DrawTrain();
            }
        }

        /// <summary>
        /// Проверяем информацию с labelbase на соответствие
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void labelBaseUpColor_DragEnter(object sender, DragEventArgs e)
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

        /// <summary>
        /// Действия при приеме перетаскиваемого цвета (Up)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void labelBaseUpColor_DragDrop(object sender, DragEventArgs e)
        {
            if (train != null)
            {
                train.SetUpColor((Color)e.Data.GetData(typeof(Color)));
                DrawTrain();
            }
        }

        /// <summary>
        /// Проверяем информацию с labelDop на соответствие
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void labelDopColor_DragEnter(object sender, DragEventArgs e)
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

        /// <summary>
        /// Действия при приеме перетаскиваемого цвета (Dop)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void labelDopColor_DragDrop(object sender, DragEventArgs e)
        {
            if (train != null)
            {
                if (train is Electric_locomotive)
                {
                    (train as Electric_locomotive).SetDopColor((Color)e.Data.GetData(typeof(Color)));
                    DrawTrain();
                }
            }
        }

        /// <summary>
        /// Добавление поезда
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        ///        
        private void buttonOk_Click(object sender, EventArgs e)
        {
            eventAddTrain?.Invoke(train);        
            Close();
        }
    }
}
