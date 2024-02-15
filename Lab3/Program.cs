
using System;
using System.Numerics;
using System.Drawing;
using System.Diagnostics;
using System.Windows.Forms;
using System.Security.Cryptography.X509Certificates;

namespace Lab3
{
    
        class Program
        {
            public static Figure[] figures =
            {
            new Rectangle()
            {
                Color = Color.Green,
                Position = new Point(30, 30),
                Name = "Прямоугольник А",
                Height = 40,
                Width = 45
            },
            new Circle()
            {
                Color = Color.Red,
                Position = new Point(70, 70),
                Name = "Прямоугольник Б",
                Radius = 45,
                
            },
            new Decagon()
            {
                Color = Color.Red,
                Position = new Point(150, 150),
                Name = "Прямоугольник Б",
                Side = 50,
                Radius = 54
            }
        };

            static void Main(string[] args)
            {
                Form frm = new Form()
                {
                    Size = new Size(800, 800),
                    StartPosition = FormStartPosition.CenterScreen
                };

                frm.Paint += Frm_Paint;

                Application.Run(frm);
            }

            private static void Frm_Paint(object sender, PaintEventArgs e)
            {
                foreach (Figure f in figures)
                {
                    f.Draw(e.Graphics);
                }
            }
        }
    }

    
