using System.Drawing;

namespace Train_project
{
    public abstract class Vehicle : ITransport
    {
        /// <summary>
        /// Левая координата отрисовки транспорта
        /// </summary>
        protected float _startPosX;

        /// <summary>
        /// Правая кооридната отрисовки транспорта
        /// </summary>
        protected float _startPosY;

        /// <summary>
        /// Ширина окна отрисовки
        /// </summary>
        protected int _pictureWidth;

        /// <summary>
        /// Высота окна отрисовки
        /// </summary>
        protected int _pictureHeight;

        /// <summary>
        /// Максимальная скорость
        /// </summary>
        public int MaxSpeed { protected set; get; }

        /// <summary>
        /// Вес транспорта
        /// </summary>
        public float Weight { protected set; get; }

        /// <summary>
        /// Верхний цвет кузова
        /// </summary>
        public Color UpperColor { protected set; get; }

        /// <summary>
        /// Нижний цвет кузова
        /// </summary>
        public Color LowerColor { protected set; get; }
        public void SetPosition(int x, int y, int width, int height)
        {
            _startPosX = x;
            _startPosY = y;
            _pictureWidth = width;
            _pictureHeight = height;
        }
        public abstract void DrawTransport(Graphics g);
        public abstract void MoveTransport(Direction direction);
    }
}

