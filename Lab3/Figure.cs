using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab3
{
    public abstract class Figure
    {
        public string Name { get; set; }
        public Color Color { get; set; }
        public Point Position { get; set; }

        public abstract double GetArea();
        public abstract Point GetCenter();
        public abstract void Draw(Graphics gr);

    }
}
