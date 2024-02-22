using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    class Rhomb : Figure
    {
        public double Side { get; set; }

        public double Height { get; set; }

        public override double GetArea()
        {
            return Side * Height;
            throw new NotImplementedException();
        }
        public override Point GetCenter()
        {
            return new Point((int)(Position.X + Side / 2), (int)(Position.Y + Height / 2));
        }

        public override void Draw(Graphics gr)
        {
            // Четыре вершины ромба
            Point[] points = new Point[]
            {
            new Point(Position.X + (int)Height / 2, Position.Y), // Верх
            new Point(Position.X + (int)Height, Position.Y + (int)Height / 2), // Право
            new Point(Position.X + (int)Height / 2, Position.Y + (int)Height), // Низ
            new Point(Position.X, Position.Y + (int)Height / 2) // Лево
            };

            // Рисуем ромб
            gr.DrawPolygon(new Pen(Color), points);

            // Рисуем центр ромба
            Point center = GetCenter();
            gr.DrawString($"({center.X}, {center.Y})", new Font("Arial", 9), Brushes.Black, center);
        }
    }
}
