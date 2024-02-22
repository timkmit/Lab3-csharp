using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    internal class Triangle : Figure
    {
        public double Base { get; set; } // Основание треугольника
        public double Height { get; set; } // Высота треугольника

        public override double GetArea()
        {
            return (Base * Height) / 2;
        }

        public override Point GetCenter()
        {
            
            return new Point(Position.X + (int)(Base / 6), Position.Y + (int)(Height / 2));
        }

        public override void Draw(Graphics gr)
        {
            // Три вершины треугольника
            Point[] points = new Point[]
            {
            new Point(Position.X, Position.Y), // Верхняя точка
            new Point(Position.X + (int)Base, Position.Y + (int)Height), // Нижняя правая точка
            new Point(Position.X - (int)Base , Position.Y + (int)Height) // Нижняя левая точка
            };

            // Рисуем треугольник
            gr.DrawPolygon(new Pen(Color), points);

            // Рисуем центр треугольника
            Point center = GetCenter();
            gr.DrawString($"({center.X}, {center.Y})", new Font("Arial", 9), Brushes.Black, center);
        }
    }
}

