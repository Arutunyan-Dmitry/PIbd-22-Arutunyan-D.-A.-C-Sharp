using NLog;
using System;
using System.IO;
using System.Drawing;
using System.Windows.Forms;

namespace Train_project
{
    public partial class FormDepot : Form
    {
        /// <summary>
        /// Объект от класса-депо
        /// </summary>
        private readonly DepotCollection depotCollection;

        /// <summary>
        /// Логгер
        /// </summary>
        private readonly Logger logger;

        public FormDepot()
        {
            InitializeComponent();
            depotCollection = new DepotCollection(pictureBoxDepot.Width,
            pictureBoxDepot.Height);
            logger = LogManager.GetCurrentClassLogger();
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
            logger.Info($"Добавили депо {textBoxNewLevelName.Text}");
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
                    logger.Info($"Удалили депо{ listBoxDepot.SelectedItem.ToString()}");
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
            if (listBoxDepot.SelectedIndex > -1)
            {
                var formTrainConfig = new FormTrainConfig();
                formTrainConfig.AddEvent(AddTrain);
                formTrainConfig.Show();
            }
        }

        /// <summary>
        /// Метод добавления поезда
        /// </summary>
        /// <param name="car"></param>
        private void AddTrain(Vehicle train)
        {
            if (train != null && listBoxDepot.SelectedIndex > -1)
            {
                try
                {
                    if (((depotCollection[listBoxDepot.SelectedItem.ToString()]) + train) != -1)
                    {
                        Draw();
                        logger.Info($"Добавлен поезд {train}");
                    }
                    else
                    {
                        MessageBox.Show("Поезд не удалось поставить");
                    }
                    Draw();
                }
                catch (DepotOverflowException ex)
                {
                    logger.Warn($"Попытка поставить поезд в уже заполненное депо");
                    MessageBox.Show(ex.Message, "Переполнение", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (Exception ex)
                {
                    logger.Warn($"Неизвестная неудачная попытка поставить поезд в депо");
                    MessageBox.Show(ex.Message, "Неизвестная ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                try
                {
                    var train = depotCollection[listBoxDepot.SelectedItem.ToString()] - Convert.ToInt32(maskedTextBoxPlaceNumb.Text);
                    if (train != null)
                    {
                        FormElTrain form = new FormElTrain();
                        form.SetTrain(train);
                        form.ShowDialog();

                        logger.Info($"Изъят поезд {train} с места{ maskedTextBoxPlaceNumb.Text}");
                    }
                    Draw();
                } 
                catch(DepotNotFoundException ex)
                {
                    logger.Warn($"Попытка забрать поезд с не существующего места");
                    MessageBox.Show(ex.Message, "Не найдено", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (Exception ex)
                {
                    logger.Warn($"Неизвестная неудачная попытка забрать поезд");
                    MessageBox.Show(ex.Message, "Неизвестная ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        /// <summary>
        /// Метод обработки выбора элемента на listBoxLevels
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>  
        private void listBoxDepot_SelectedIndexChanged(object sender, EventArgs e)
        {
            logger.Info($"Перешли на парковку { listBoxDepot.SelectedItem.ToString()}");
            Draw();
        }

        private void сохранитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    depotCollection.SaveData(saveFileDialog.FileName);
                    MessageBox.Show("Сохранение прошло успешно", "Результат",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                    logger.Info("Сохранено в файл " + saveFileDialog.FileName);
                }
                catch (Exception ex)
                {
                    logger.Warn($"Неизвестная неудачная попытка сохранения файла");
                    MessageBox.Show(ex.Message, "Неизвестная ошибка при сохранении",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void загрузитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    depotCollection.LoadData(openFileDialog.FileName);
                    MessageBox.Show("Загрузка прошла успешно", "Результат", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    logger.Info("Загружено из файла " + openFileDialog.FileName);
                    ReloadLevels();
                    Draw();
                }
                catch (FileNotFoundException ex)
                {
                    logger.Warn($"Попытка найти не существующий фаил для загрузки");
                    MessageBox.Show(ex.Message, "Фаил отсутсвует", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                }
                catch (FileFormatException ex)
                {
                    logger.Warn($"Попытка загрузки файла с неверным форматом");
                    MessageBox.Show(ex.Message, "Неверный формат файла", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                }
                catch (TypeLoadException ex)
                {
                    logger.Warn($"Попытка загрузки в депо неизвестного типа обЪекта(ов)");
                    MessageBox.Show(ex.Message, "Неверный тип загружаемого объекта", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                }
                catch (Exception ex)
                {
                    logger.Warn($"Неизвестная неудачная попытка загрузки файла");
                    MessageBox.Show(ex.Message, "Неизвестная ошибка при сохранении",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}

