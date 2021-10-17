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
    public partial class FormDepot : Form
    {
        /// <summary>
        /// Объект от класса-депо
        /// </summary>
        private readonly Depots<Train> depots;
        public FormDepot()
        {
            InitializeComponent();
            depots = new Depots<Train>(pictureBoxDepot.Width,
            pictureBoxDepot.Height);
            Draw();
        }

        /// <summary>
        /// Метод отрисовки депо
        /// </summary>
        private void Draw()
        {
            Bitmap bmp = new Bitmap(pictureBoxDepot.Width, pictureBoxDepot.Height);
            Graphics gr = Graphics.FromImage(bmp);
            depots.Draw(gr);
            pictureBoxDepot.Image = bmp;
        }

        /// <summary>
        /// Обработка нажатия кнопки "Поставить поезд"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonSetTrain_Click(object sender, EventArgs e)
        {
            ColorDialog dialogLow = new ColorDialog();
            if (dialogLow.ShowDialog() == DialogResult.OK)
            {
                ColorDialog dialogUp = new ColorDialog();
                if (dialogUp.ShowDialog() == DialogResult.OK)
                {
                    var train = new Train(100, 1000, dialogUp.Color, dialogLow.Color);
                    if ((depots + train) != -1)
                    {
                        Draw();
                    }
                    else
                    {
                        MessageBox.Show("Депо переполнено");
                    }
                }              
            }
        }

        /// <summary>
        /// Обработка нажатия кнопки "Поставить электровоз"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonSetElecrticTrain_Click(object sender, EventArgs e)
        {
            ColorDialog dialogLow = new ColorDialog();
            if (dialogLow.ShowDialog() == DialogResult.OK)
            {
                ColorDialog dialogUp = new ColorDialog();
                if (dialogUp.ShowDialog() == DialogResult.OK)
                {
                    ColorDialog dialogDop = new ColorDialog();
                    if (dialogDop.ShowDialog() == DialogResult.OK)
                    {
                        var train = new Electric_locomotive(100, 1000, dialogUp.Color, dialogLow.Color, dialogDop.Color, true, true);
                        if ((depots + train) != -1)
                        {
                            Draw();
                        }
                        else
                        {
                            MessageBox.Show("Депо переполнено");
                        }
                    }
                }
            }
        }

        /// <summary>
        /// Обработка нажатия кнопки "Забрать поезд"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonTakeTrain_Click(object sender, EventArgs e)
        {
            if (maskedTextBoxPlaceNumb.Text != "")
            {
                var train = depots - Convert.ToInt32(maskedTextBoxPlaceNumb.Text);
                if (train != null)
                {
                    FormElTrain form = new FormElTrain();
                    form.SetTrain(train);
                    form.ShowDialog();
                }
                Draw();
            }
        }
    }
}

