using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Cons3
{
    sealed class RBottom:Knopka
    {
        string colorBackground;
        
        
        //public int Border { get; set; }
        public string ColorBackground { get => colorBackground; set => colorBackground = value; }

        public RBottom()
        {
            ColorBackground = "while";
        }

        public override void Show()
        {
            WriteLine("   ");
            base.Show();
            WriteLine("ColorBackground" + ColorBackground); 
            
        }

        public override string ToString()
        {
            return "круглая  кнопка";
        }

    }
}
