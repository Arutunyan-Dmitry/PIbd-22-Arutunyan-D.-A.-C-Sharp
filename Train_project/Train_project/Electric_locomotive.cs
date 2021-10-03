using System.Drawing;

namespace Train_project
{
    class Electric_locomotive
    {
        /// <summary>
        /// Левая координата отрисовки электровоза
        /// </summary>
        private float _startPosX;

        /// <summary>
        /// Правая кооридната отрисовки электровоза
        /// </summary>
        private float _startPosY;

        /// <summary>
        /// Ширина окна отрисовки
        /// </summary>
        private int _pictureWidth;

        /// <summary>
        /// Высота окна отрисовки
        /// </summary>
        private int _pictureHeight;

        /// <summary>
        /// Ширина отрисовки электровоза
        /// </summary>
        private readonly int TrainWidth = 200;

        /// <summary>
        /// Высота отрисовки электровоза
        /// </summary>
        private readonly int TrainHeight = 110;

        /// <summary>
        /// Максимальная скорость
        /// </summary>
        public int MaxSpeed { private set; get; }

        /// <summary>
        /// Вес электровоза
        /// </summary>
        public float Weight { private set; get; }

        /// <summary>
        /// Верхний цвет электровоза
        /// </summary>
        public Color UpperColor { private set; get; }

        /// <summary>
        /// Нижний цвет электровоза
        /// </summary>
        public Color LowerColor { private set; get; }

        /// <summary>
        /// Признак наличия токоприёмника
        /// </summary>
        public bool Collector { private set; get; }

        /// <summary>
        /// Признак наличия аккумулятора 
        /// </summary>
        public bool Battery { private set; get; }

        /// <summary>
        /// Инициализация свойств
        /// </summary>
        /// <param name="maxSpeed">Максимальная скорость</param>
        /// <param name="weight">Вес электровоза</param>
        /// <param name="upperColor">Верхний цвет электровоза</param>
        /// <param name="lowerColor">Нижний цвет электровоза</param>
        /// <param name="collector">Признак наличия токоприёмника</param>
        /// <param name="battery">Признак наличия аккумулятора</param>
        public void Init(int maxSpeed, float weight, Color upperColor, Color lowerColor,
        bool collector, bool battery)
        {
            MaxSpeed = maxSpeed;
            Weight = weight;
            UpperColor = upperColor;
            LowerColor = lowerColor;
            Collector = collector;
            Battery = battery;
        }

        /// <summary>
        /// Установка позиции электровоза
        /// </summary>
        /// <param name="x">Координата X</param>
        /// <param name="y">Координата Y</param>
        /// <param name="width">Ширина картинки</param>
        /// <param name="height">Высота картинки</param>
        public void SetPosition(int x, int y, int width, int height)
        {
            _startPosX = x;
            _startPosY = y;
            _pictureWidth = width;
            _pictureHeight = height;
        }

        /// <summary>
        /// Изменение направления пермещения
        /// </summary>
        /// <param name="direction">Направление</param>
        public void MoveTransport(Direction direction)
        {
            float step = MaxSpeed * 100 / Weight;
            switch (direction)
            {
                // вправо
                case Direction.Right:
                    if (_startPosX - step >= 0)
                    {
                        _startPosX -= step;
                    }
                    break;
                //влево
                case Direction.Left:
                    if (_startPosX + step < _pictureWidth - TrainWidth)
                    {
                        _startPosX += step;
                    }
                    break;
                //вверх
                case Direction.Up:
                    if (_startPosY - step >= 0)
                    {
                        _startPosY -= step;
                    }
                    break;
                //вниз
                case Direction.Down:
                    if (_startPosY + step < _pictureHeight - TrainHeight)
                    {
                        _startPosY += step;
                    }
                    break;
            }
        }

        /// <summary>
        /// Отрисовка электровоза
        /// </summary>
        /// <param name="g"></param>
        public void DrawTransport(Graphics g)
        {
            Pen pen = new Pen(Color.Black);
            // отрисуем токоприёмник 
            if (Collector)
            {
                PointF[] Cond_points = {
                    new PointF (_startPosX + 80, _startPosY),
                    new PointF(_startPosX + 95, _startPosY + 15),
                    new PointF(_startPosX + 80, _startPosY + 30),
                    new PointF(_startPosX + 65, _startPosY + 15) };
                g.DrawPolygon(pen, Cond_points);
            }
            // верхняя часть тепловоза
            // верхняя часть тепловоза
            Brush br = new SolidBrush(UpperColor);
            PointF[] Upper_part_points = {
                new PointF (_startPosX + 30, _startPosY + 30),
                new PointF (_startPosX + 190, _startPosY + 30),
                new PointF (_startPosX + 190, _startPosY + 60),
                new PointF (_startPosX + 10, _startPosY + 60)
            };
            g.FillPolygon(br, Upper_part_points);
            // нижняя часть тепловоза
            br = new SolidBrush(LowerColor);
            g.FillRectangle(br, _startPosX + 10, _startPosY + 60, 180, 30);
            // передний бампер
            br = new SolidBrush(Color.Black);
            PointF[] Front_bumper = {
                new PointF (_startPosX + 10, _startPosY + 90),
                new PointF (_startPosX + 80, _startPosY + 90),
                new PointF (_startPosX + 80, _startPosY + 100),
                new PointF (_startPosX, _startPosY + 100)

            };
            g.FillPolygon(br, Front_bumper);
            // задний бампер
            PointF[] Back_bumper = {
                new PointF (_startPosX + 120, _startPosY + 90),
                new PointF (_startPosX + 190, _startPosY + 90),
                new PointF (_startPosX + 200, _startPosY + 100),
                new PointF (_startPosX + 120, _startPosY + 100)

            };
            g.FillPolygon(br, Back_bumper);
            // колёса
            br = new SolidBrush(ColorTranslator.FromHtml("#A9A9A9"));
            g.FillEllipse(br, _startPosX + 20, _startPosY + 90, 20, 20);
            g.FillEllipse(br, _startPosX + 60, _startPosY + 90, 20, 20);
            g.FillEllipse(br, _startPosX + 120, _startPosY + 90, 20, 20);
            g.FillEllipse(br, _startPosX + 160, _startPosY + 90, 20, 20);
            //дверь
            br = new SolidBrush(Color.Black);
            g.FillRectangle(br, _startPosX + 70, _startPosY + 45, 20, 30);
            //окна
            br = new SolidBrush(Color.LightBlue);
            g.FillRectangle(br, _startPosX + 30, _startPosY + 40, 10, 15);
            g.FillRectangle(br, _startPosX + 50, _startPosY + 40, 10, 15);
            g.FillRectangle(br, _startPosX + 170, _startPosY + 40, 10, 15);
            //сцепка
            br = new SolidBrush(Color.Black);
            g.FillRectangle(br, _startPosX + 190, _startPosY + 40, 10, 40);
            //аккумулятор
            if (Battery)
            {
                br = new SolidBrush(Color.Red);
                g.FillRectangle(br, _startPosX + 110, _startPosY + 50, 30, 20);
            }
        }
    }
}
