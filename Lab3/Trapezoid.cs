using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab3
{
    class Trapezoid : Figure
    {
        public double TopBase { get; set; }
        public double BottomBase { get; set; }
        public double Height { get; set; }

        public override double GetArea()
        {
            return 0.5 * (TopBase + BottomBase) * Height;
        }
        public override Point GetCenter()
        {
            return new Point(Position.X + (int)(TopBase) / 2, Position.Y + (int)Height / 3);
        }
        public override void Draw(Graphics gr)
        {

            // Рассчитываем координаты вершин трапеции
            Point topRight = new Point(Position.X + (int)TopBase, Position.Y);
            Point bottomRight = new Point(Position.X + (int)BottomBase, Position.Y + (int)Height);
            Point bottomLeft = new Point(Position.X, Position.Y + (int)Height);
            Point topLeft = new Point(Position.X + (int)(BottomBase - TopBase), Position.Y);

            Point[] points = { topLeft, topRight, bottomRight, bottomLeft };

            gr.DrawPolygon(new Pen(Color), points);

            // Рисуем центр трапеции
            Point center = GetCenter();
            gr.DrawString($"({center.X}, {center.Y})", new Font("Arial", 9), Brushes.Black, center);
        }
    }
}


