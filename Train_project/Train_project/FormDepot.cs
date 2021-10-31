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
        private readonly DepotCollection depotCollection;
        public FormDepot()
        {
            InitializeComponent();
            depotCollection = new DepotCollection(pictureBoxDepot.Width,
            pictureBoxDepot.Height);
        }

        /// <summary>
        /// Заполнение listBoxLevels
        /// </summary>
        private void ReloadLevels()
        {
            int index = listBoxDepot.SelectedIndex;
            listBoxDepot.Items.Clear();
            for (int i = 0; i < depotCollection.Keys.Count; i++)
            {
                listBoxDepot.Items.Add(depotCollection.Keys[i]);
            }
            if (listBoxDepot.Items.Count > 0 && (index == -1 || index >=
            listBoxDepot.Items.Count))
            {
                listBoxDepot.SelectedIndex = 0;
            }
            else if (listBoxDepot.Items.Count > 0 && index > -1 && index <
            listBoxDepot.Items.Count)
            {
                listBoxDepot.SelectedIndex = index;
            }
        }

        /// <summary>
        /// Метод отрисовки депо
        /// </summary>
        private void Draw()
        {
            if (listBoxDepot.SelectedIndex > -1)
            {//если выбран один из пуктов в listBox (при старте программы ни один пункт
             //не будет выбран и может возникнуть ошибка, если мы попытаемся обратиться
             //к элементу listBox)
                Bitmap bmp = new Bitmap(pictureBoxDepot.Width, pictureBoxDepot.Height);
                Graphics gr = Graphics.FromImage(bmp);
                depotCollection[listBoxDepot.SelectedItem.ToString()].Draw(gr);
                pictureBoxDepot.Image = bmp;
            }
        }

        /// <summary>
        /// Обработка нажатия кнопки "Добавить депо"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonAddDepot_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxNewLevelName.Text))
            {
                MessageBox.Show("Введите название депо", "Ошибка",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            depotCollection.AddDepot(textBoxNewLevelName.Text);
            ReloadLevels();
        }
        /// <summary>
        /// Обработка нажатия кнопки "Удалить депо"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonDelDepot_Click(object sender, EventArgs e)
        {
            if (listBoxDepot.SelectedIndex > -1)
            {
                if (MessageBox.Show($"Удалить депо { listBoxDepot.SelectedItem}?", "Удаление", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    depotCollection.DelDepot(listBoxDepot.SelectedItem.ToString());
                    ReloadLevels();
                }
            }
            if (listBoxDepot.SelectedItem == null)
            {
                pictureBoxDepot.Image = null;
            }
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
                    if ((depotCollection[listBoxDepot.SelectedItem.ToString()] + train) != -1)
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
        /// Отработка нажатия кнопки "Поставить электровоз"
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
                        if ((depotCollection[listBoxDepot.SelectedItem.ToString()] + train) != -1)
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
        /// Отработка нажатия кнопки "Забрать поезд"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonTakeTrain_Click(object sender, EventArgs e)
        {
            if (listBoxDepot.SelectedIndex > -1 && maskedTextBoxPlaceNumb.Text != "")
            {
                var train = depotCollection[listBoxDepot.SelectedItem.ToString()] - Convert.ToInt32(maskedTextBoxPlaceNumb.Text);
                if (train != null)
                {
                    FormElTrain form = new FormElTrain();
                    form.SetTrain(train);
                    form.ShowDialog();
                }
                Draw();
            }
        }

        /// <summary>
        /// Метод обработки выбора элемента на listBoxLevels
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>  
        private void listBoxDepot_SelectedIndexChanged(object sender, EventArgs e)
        {
            Draw();
        }
    }
}

