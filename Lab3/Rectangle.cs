using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab3
{
    class Rectangle : Figure
    {
        public double Width { get; set; }
        public double Height { get; set; }

        public override double GetArea()
        {
            return Width * Height;
        }

        public override Point GetCenter()
        {
            return new Point((int)(Position.X + Width / 2), (int)(Position.Y + Height / 2));
        }

        public override void Draw(Graphics gr)
        {
            gr.DrawRectangle(new Pen(Color), Position.X, Position.Y, (int)Width, (int)Height);

            // Assuming you want to display the center coordinates as a string
            string centerString = $"Center: ({GetCenter().X}, {GetCenter().Y})";
            gr.DrawString(centerString, new Font("Arial", 9), Brushes.Black, GetCenter());
        }

    }
}
