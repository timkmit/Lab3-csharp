using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    class Trapezoid : Figure
    {
        public double Side { get; set; }
        public double Side2 { get; set; }

        public double Height { get; set; }

        public override double GetArea()
        {
            return Height * 0.5 * (Side + Side2);
            throw new NotImplementedException();
        }
        public override Point GetCenter()
        {
            return new Point((int)(Position.X + Side / 2), (int)(Position.Y + Side2 / 2));
        }

        public override void Draw(Graphics gr)
        {
            gr.DrawRectangle(new Pen(Color), Position.X, Position.Y, (int)Side, (int)Side2);

            // Assuming you want to display the center coordinates as a string
            string centerString = $"Center: ({GetCenter().X}, {GetCenter().Y})";
            gr.DrawString(centerString, new Font("Arial", 9), Brushes.Black, GetCenter());
        }
    }
}
