using System.Drawing;

namespace Train_project
{
    public class Electric_locomotive : Train
    {
        /// <summary>
        /// Признак наличия токоприёмника
        /// </summary>
        public bool Collector { private set; get; }

        /// <summary>
        /// Признак наличия аккумулятора 
        /// </summary>
        public bool Battery { private set; get; }

        public Color ColColor { private set; get; }

        /// <summary>
        /// Инициализация свойств
        /// </summary>
        /// <param name="maxSpeed">Максимальная скорость</param>
        /// <param name="weight">Вес электровоза</param>
        /// <param name="upperColor">Верхний цвет электровоза кузова</param>
        /// <param name="lowerColor">Нижний цвет электровоза</param>
        /// <param name="collector">Признак наличия токоприёмника</param>
        /// <param name="battery">Признак наличия аккумулятора</param>
        public Electric_locomotive(int maxSpeed, float weight, Color upperColor, Color lowerColor, Color colColor,
        bool collector, bool battery) : base(maxSpeed, weight, upperColor, upperColor, 200, 110)

        {
            MaxSpeed = maxSpeed;
            Weight = weight;
            UpperColor = upperColor;
            LowerColor = lowerColor;
            ColColor = colColor;
            Collector = collector;
            Battery = battery;
        }

        /// <summary>
        /// Отрисовка электровоза
        /// </summary>
        /// <param name="g"></param>
        public override void DrawTransport(Graphics g)
        {
            Pen pen = new Pen(ColColor, 2);

            // отрисуем основной каркас поезда
            base.DrawTransport(g);

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

            // отрисуем аккумулятор
            if (Battery)
            {
                Brush br = new SolidBrush(Color.Red);
                g.FillRectangle(br, _startPosX + 110, _startPosY + 50, 30, 20);
            }
        }
    }
}
