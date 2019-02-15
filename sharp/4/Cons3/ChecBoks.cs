using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Cons3
{
    sealed class ChecBoks : ElemUpr
    {
        public override string Text { get; set; }

        public override void Click()
        {
            WriteLine("Чекбокс активорован");
        }

        public override void DoubleClick()
        {
            Click();
            Click();
        }

        public override void Show()
        {
            WriteLine("   ");
            base.Show();


        }
    }
}
