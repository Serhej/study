using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Cons3
{
    class TextPole : ElemUpr
    {
        protected static bool caps;
        protected string text;

        public static bool Caps
        {
            set { caps = value; }
            get { return caps; }
        }

        public override string Text
        {
            set { text = value; }
            get
            {
                if (caps)
                    return text?.ToUpper();
                else
                    return text;
            }
        }

        static TextPole()
        {
            Caps = true;
        }

        public override void Click()
        {
            WriteLine("Курсор перемещен в текстовое поле!");
        }

        public override void DoubleClick()
        {
            WriteLine("Текст выделен");
        }

        public override void Show()
        {
            WriteLine("   ");
            base.Show();
            WriteLine("Caps " + Caps);
            WriteLine("Text " + Text);

        }
    }
}
