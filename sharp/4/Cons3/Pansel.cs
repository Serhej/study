using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cons3
{
    class Pansel:IDraw
    {
        private string color;

        public string Color { get => color; set => color = value; }

        public Pansel()
        {
            Color = "red";
        }

        public void Draw()
        {
            Console.WriteLine("Квадрат Малевича " + color);
        }
    }
}
