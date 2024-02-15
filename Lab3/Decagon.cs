using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    class Decagon : Figure
    {
        public double Side { get; set; }

        public double Radius { get; set; }

        public override double GetArea()
        {
            return Side * Radius * 0.5 * 10;
            throw new NotImplementedException();
        }
        public override Point GetCenter()
        {
            return new Point((int)(Position.X + Side / 2), (int)(Position.Y + Radius / 2));
        }

        public override void Draw(Graphics gr)

        {

            gr.DrawRectangle(new Pen(Color), Position.X, Position.Y, (int)Radius, (int)Radius);

            // Assuming you want to display the center coordinates as a string
            string centerString = $"Center: ({GetCenter().X}, {GetCenter().Y})";
            gr.DrawString(centerString, new Font("Arial", 9), Brushes.Black, GetCenter());
        }

    }
}
