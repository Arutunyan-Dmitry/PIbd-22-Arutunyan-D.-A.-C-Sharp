using System.Drawing;

namespace Train_project
{
    public class Train : Vehicle
    {
        /// <summary>
        /// Ширина отрисовки поезда
        /// </summary>
        protected readonly int TrainWidth = 200;

        /// <summary>
        /// Высота отрисовки поезда
        /// </summary>
        protected readonly int TrainHeight = 110;

        /// Конструктор
        /// </summary>
        /// <param name="maxSpeed">Максимальная скорость</param>
        /// <param name="weight">Вес поезда</param>
        /// <param name="upperColor">Верхний цвет поезда</param>
        /// <param name="lowerColor">Нижний цвет поезда</param>
        public Train(int maxSpeed, float weight, Color upperColor, Color lowerColor)
        {
            MaxSpeed = maxSpeed;
            Weight = weight;
            UpperColor = upperColor;
            LowerColor = lowerColor;
        }
        /// <summary>
        /// Конструктор с изменением размеров поезда
        /// </summary>
        /// <param name="maxSpeed">Максимальная скорость</param>
        /// <param name="weight">Вес поезда</param>
        /// <param name="lowerColor">Нижний цвет поезда</param>
        /// <param name="upperColor">Верхний цвет поезда</param>
        /// <param name="trainWidth">Ширина отрисовки поезда</param>
        /// <param name="trainHeight">Высота отрисовки поезда</param>
        protected Train(int maxSpeed, float weight, Color lowerColor, Color upperColor, int TrainWidth, int
        TrainHeight)
        {
            MaxSpeed = maxSpeed;
            Weight = weight;
            LowerColor = lowerColor;
            UpperColor = upperColor;
            this.TrainWidth = TrainWidth;
            this.TrainHeight = TrainHeight;
        }
        public override void MoveTransport(Direction direction)
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

        public override void DrawTransport(Graphics g)
        {
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
        }
    }
}

