using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pr_Way_Lab1
{
    public partial class FormElTrain : Form
    {
        private Electric_locomotive train;

        /// <summary>
        /// Конструктор
        /// </summary>
        public FormElTrain()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Метод отрисовки электровоза
        /// </summary>
        private void Draw()
        {
            Bitmap bmp = new Bitmap(pictureBoxElTrain.Width, pictureBoxElTrain.Height);
            Graphics gr = Graphics.FromImage(bmp);
            train.DrawTransport(gr);
            pictureBoxElTrain.Image = bmp;
        }

        /// <summary>
        /// Обработка нажатия кнопки "Создать"
        /// </summary>
        private void buttonCreate_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            train = new Electric_locomotive();
            train.Init(rnd.Next(100, 300), rnd.Next(1000, 2000), ColorTranslator.FromHtml("#F4A460"),Color.Yellow, true, true); 
            train.SetPosition(rnd.Next(10, 100), rnd.Next(10, 100), pictureBoxElTrain.Width, pictureBoxElTrain.Height, 5);
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
                    train.MoveTransport(Direction.Up);
                    break;
                case "buttonDown":
                    train.MoveTransport(Direction.Down);
                    break;
                case "buttonLeft":
                    train.MoveTransport(Direction.Left);
                    break;
                case "buttonRight":
                    train.MoveTransport(Direction.Right);
                    break;
            }
            Draw();
        }
    }
}
