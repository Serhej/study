using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Cons3
{
    sealed class BottomImag:Knopka
    {
        private string images;

        public string Images { get => images; set => images = value; }

        public BottomImag()
        {
            Images = " HOHO.jpg";
        }
        
        public override void Show()
        {
            WriteLine("   ");
            base.Show();
            WriteLine("Адрес: " + Images);
        }

        public override string ToString()
        {
            return "кнопку с картинкой";
        }
    }
}
