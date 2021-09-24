using System.Drawing;

namespace Pr_Way_Lab1
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

        private int TrainWidth = 38;

        /// <summary>
        /// Высота отрисовки электровоза
        /// </summary>
        private int TrainHeight = 22;

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
        /// <param name="upperColor">Верхний цвет электровоза кузова</param>
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
        public void SetPosition(int x, int y, int width, int height, int sizeKp)
        {
            _startPosX = x;
            _startPosY = y;
            _pictureWidth = width;
            _pictureHeight = height;
            TrainHeight *= sizeKp;
            TrainWidth *= sizeKp;
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
                    new PointF (_startPosX + (float)(TrainWidth / 2.375), _startPosY), 
                    new PointF(_startPosX + (float)TrainWidth / 2, _startPosY + (float)(TrainHeight / 7.33333)), 
                    new PointF(_startPosX + (float)(TrainWidth / 2.375), _startPosY + (float)(TrainHeight / 3.66666)), 
                    new PointF(_startPosX + (float)(TrainWidth / 2.92308), _startPosY + (float)(TrainHeight / 7.33333)) };
                g.DrawPolygon(pen, Cond_points);
            }
            // верхняя часть тепловоза
            Brush br = new SolidBrush(UpperColor);
            PointF[] Upper_part_points = {
                new PointF (_startPosX + (float)(TrainWidth / 6.33333), _startPosY + (float)(TrainHeight / 3.66666)), 
                new PointF (_startPosX + TrainWidth, _startPosY + (float)(TrainHeight / 3.66666)),
                new PointF (_startPosX + TrainWidth, _startPosY + (float)(TrainHeight / 1.83333)), 
                new PointF (_startPosX + (float)TrainWidth / 19, _startPosY + (float)(TrainHeight / 1.83333))
            }; 
            g.FillPolygon(br, Upper_part_points);
            // нижняя часть тепловоза
            br = new SolidBrush(LowerColor);
            g.FillRectangle(br, _startPosX + (float)TrainWidth / 19, _startPosY + (float)(TrainHeight / 1.83333), (float)(TrainWidth / 1.05556), (float)(TrainHeight / 3.66666));
            // передний бампер
            br = new SolidBrush(Color.Black);
            PointF[] Front_bumper = {
                new PointF (_startPosX + (float)TrainWidth / 19, _startPosY + (float)(TrainHeight / 1.22222)),
                new PointF (_startPosX + (float)(TrainWidth / 2.375), _startPosY + (float)(TrainHeight / 1.22222)),
                new PointF (_startPosX + (float)(TrainWidth / 2.375), _startPosY + (float)(TrainHeight / 1.1)),
                new PointF (_startPosX, _startPosY + (float)(TrainHeight / 1.1))
                
            };
            g.FillPolygon(br, Front_bumper);
            // задний бампер
            PointF[] Back_bumper = {
                new PointF (_startPosX + (float)(TrainWidth / 1.58333), _startPosY + (float)(TrainHeight / 1.22222)),
                new PointF (_startPosX + TrainWidth, _startPosY + (float)(TrainHeight / 1.22222)),
                new PointF (_startPosX + (float)(TrainWidth / 0.95), _startPosY + (float)(TrainHeight / 1.1)),
                new PointF (_startPosX + (float)(TrainWidth / 1.58333), _startPosY + (float)(TrainHeight / 1.1))

            };
            g.FillPolygon(br, Back_bumper);
            // колёса
            br = new SolidBrush(ColorTranslator.FromHtml("#A9A9A9"));
            g.FillEllipse(br, _startPosX + (float)(TrainWidth / 9.5), _startPosY + (float)(TrainHeight / 1.22222), (float)(TrainWidth / 9.5), (float)(TrainWidth / 9.5));
            g.FillEllipse(br, _startPosX + (float)(TrainWidth / 3.16667), _startPosY + (float)(TrainHeight / 1.22222), (float)(TrainWidth / 9.5), (float)(TrainWidth / 9.5));
            g.FillEllipse(br, _startPosX + (float)(TrainWidth / 1.58333), _startPosY + (float)(TrainHeight / 1.22222), (float)(TrainWidth / 9.5), (float)(TrainWidth / 9.5));
            g.FillEllipse(br, _startPosX + (float)(TrainWidth / 1.1875), _startPosY + (float)(TrainHeight / 1.22222), (float)(TrainWidth / 9.5), (float)(TrainWidth / 9.5));
            //дверь
            br = new SolidBrush(Color.Black);
            g.FillRectangle(br, _startPosX + (float)(TrainWidth / 2.71429), _startPosY + (float)(TrainHeight / 2.44444), (float)(TrainWidth / 9.5), (float)(TrainHeight / 3.66667));
            //окна
            br = new SolidBrush(Color.LightBlue);
            g.FillRectangle(br, _startPosX + (float)(TrainWidth / 6.33333), _startPosY + (float)(TrainHeight / 2.75), (float)TrainWidth / 19, (float)(TrainHeight / 7.33333));
            g.FillRectangle(br, _startPosX + (float)(TrainWidth / 3.8), _startPosY + (float)(TrainHeight / 2.75), (float)TrainWidth / 19, (float)(TrainHeight / 7.33333));
            g.FillRectangle(br, _startPosX + (float)(TrainWidth / 1.11765), _startPosY + (float)(TrainHeight / 2.75), (float)TrainWidth / 19, (float)(TrainHeight / 7.33333));
            //сцепка
            br = new SolidBrush(Color.Black);
            g.FillRectangle(br, _startPosX + TrainWidth, _startPosY + (float)(TrainHeight / 2.75), (float)TrainWidth / 19, (float)(TrainHeight / 2.75));
            //аккумулятор
            if (Battery)
            {
                br = new SolidBrush(Color.Red);
                g.FillRectangle(br, _startPosX + (float)(TrainWidth / 1.72727), _startPosY + (float)(TrainHeight / 2.2), (float)(TrainWidth / 6.33333), (float)(TrainHeight / 5.5));
            }
        }
    }
}
