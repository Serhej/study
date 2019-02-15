using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Cons3
{
    public abstract class ElemUpr:IDraw
    {
        protected int locationX;
        protected int locationY;
        protected ConsoleColor color;
        protected int razmer;
        protected static ElemUpr focus;
        protected int width;
        protected int height;

        public int LocationX { get => locationX; set => locationX = value; }
        public int LocationY { get => locationY; set => locationY = value; }
        public ConsoleColor Color { get => color; set => color = value; }
        public abstract string Text { get; set; }
        public int Razmer { get => razmer; set => razmer = value; }
        public int Width { get => width; set => width = value; }
        public int Height { get => height; set => height = value; }

        public event Action<string> Voxod;

        public ElemUpr()
        {
            LocationX = 14;
            LocationY = 23;
            Color = ConsoleColor.DarkYellow;
            Width = 5;
            Height = 3;
            
        }

        static ElemUpr()
        {
            focus = null;
        }

        public static void Focus(ElemUpr newFocus, Action focusChanged = null)
        {
            ElemUpr oldFocus = focus;
            focus = newFocus;
            if(oldFocus != null)
                oldFocus.Draw() ;
            focus.Draw();
            if(focusChanged != null)
            {
                focusChanged();
            }
        }

        public static ElemUpr GetFocus()
        {
            return focus;
        }


        public virtual void ChangePol(int polX, int polY )
        {
            
            if (Prow(polX, polY))
            {
                this.LocationX = polX;
                this.locationY = polY;
            }
        }

        public virtual bool Prow(int newX, int newY)
        {
            string direct = "";
            if ((newX + Width) < Console.WindowWidth)
            {
                direct = "выход за границу с права";
            }
            if ((newY + Height) < Console.WindowHeight)
            {
                direct = "выход за границу с низу";
            }
            if (newX >= 0)
            {
                direct = "выход за границу с лева";
            }
            if( newY >= 0)
            {
                TextOutput("Все ок");
                return true;
            }
            else
            {

                if (Voxod != null)
                    Voxod(direct);
                TextOutput("Элемент управления выходит за границу экрана");
                return false;
            }
        }

        public abstract void Click();

        public abstract void DoubleClick();

        public virtual void Show()
        {
            WriteLine("location " + LocationX + " x, " + LocationY + " y");
            WriteLine("Color " + Color);
            WriteLine("Text " + Text);
            WriteLine("Razmer " + Razmer);
        }


        public void Draw()
        {
            ConsoleColor col = Console.BackgroundColor;

            if (focus != this)
                Console.BackgroundColor = Color;
            else
                Console.BackgroundColor = ConsoleColor.White;

            
            Console.SetCursorPosition(LocationX, LocationY);
            for (int i = 0; i < Width; ++i)
            {
                Write(' ');
            }

            for (int i = 0; i < Height; i++)
            {
                Console.SetCursorPosition(LocationX, LocationY + i);
                WriteLine(' ');
            }

            Console.SetCursorPosition(LocationX, LocationY + 2);
            for (int i = 0; i < Width; ++i)
            {  
                Write(' ');
            }

            Console.SetCursorPosition(LocationX, LocationY);
            for (int i = 0; i < Height; i++)
            {
                Console.SetCursorPosition(LocationX + Width, LocationY + i);
                WriteLine(' ');
            }
            Console.BackgroundColor = col;
        }

        public void Clear(Action action = null)
        {
            string str = new string(' ', Width+1);
            Console.BackgroundColor = ConsoleColor.Black;
            for (int i = 0; i < Height; i++)
            {
                
                Console.SetCursorPosition(LocationX, LocationY+i);
                Write(str);
                
            }
            if (action != null)
                action();
        }

        public static void TextOutput(string line)
        {
            Console.SetCursorPosition(0, Console.WindowHeight - 4);
            string emptyLine = new string(' ', Console.WindowWidth);
            Console.BackgroundColor = ConsoleColor.Black;
            Console.WriteLine(emptyLine + emptyLine);
            Console.SetCursorPosition(0, Console.WindowHeight - 4);
            Console.WriteLine(line);
        }
    }
}
