using System;
using System.Drawing;
using System.Windows.Forms;

namespace Train_project
{
    public partial class FormElTrain : Form
    {
        private ITransport train;

        /// <summary>
        /// Конструктор
        /// </summary>
        public FormElTrain()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Передача поезда на форму
        /// </summary>
        /// <param name="car"></param>
        public void SetTrain(ITransport train)
        {
            this.train = train;
            Draw();
        }

        /// <summary>
        /// Метод отрисовки электровоза
        /// </summary>
        private void Draw()
        {
            Bitmap bmp = new Bitmap(pictureBoxElTrain.Width, pictureBoxElTrain.Height);
            Graphics gr = Graphics.FromImage(bmp);
            train?.DrawTransport(gr);
            pictureBoxElTrain.Image = bmp;
        }

        /// <summary>
        /// Обработка нажатия кнопки "Создать поезд"
        /// </summary>
        private void buttonCreateTrain_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            train = new Train(rnd.Next(100, 300), rnd.Next(1000, 2000), ColorTranslator.FromHtml("#F4A460"), Color.Yellow);
            train.SetPosition(rnd.Next(10, 100), rnd.Next(10, 100), pictureBoxElTrain.Width, pictureBoxElTrain.Height);
            Draw();
        }

        /// <summary>
        /// Обработка нажатия кнопки "Создать электровоз"
        /// </summary>
        private void ButtonCreateElectricTrain_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            train = new Electric_locomotive(rnd.Next(100, 300), rnd.Next(1000, 2000), ColorTranslator.FromHtml("#F4A460"), Color.Yellow, ColorTranslator.FromHtml("#FF1493"), true, true);
            train.SetPosition(rnd.Next(10, 100), rnd.Next(10, 100), pictureBoxElTrain.Width, pictureBoxElTrain.Height);
            Draw();
        }

        /// <summary>
        /// Обработка нажатия кнопок управления
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void buttonMove_Click(object sender, EventArgs e)
        {
            //получаем имя кнопки
            string name = (sender as Button).Name;
            switch (name)
            {
                case "buttonUp":
                    train?.MoveTransport(Direction.Up);
                    break;
                case "buttonDown":
                    train?.MoveTransport(Direction.Down);
                    break;
                case "buttonLeft":
                    train?.MoveTransport(Direction.Left);
                    break;
                case "buttonRight":
                    train?.MoveTransport(Direction.Right);
                    break;
            }
            Draw();
        }
    }
}
