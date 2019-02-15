using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Cons3
{
    abstract class ElemUpr
    {
        protected int locationX;
        protected int locationY;
        protected string color;
        protected int razmer;


        public int LocationX { get => locationX; set => locationX = value; }
        public int LocationY { get => locationY; set => locationY = value; }
        public string Color { get => color; set => color = value; }
        public abstract string Text { get; set; }
        public int Razmer { get => razmer; set => razmer = value; }

        public ElemUpr()
        {
            LocationX = 14;
            LocationY = 23;
            Color = "white";
        }

        public virtual void ChangePol(int polX, int polY)
        {
            WriteLine("кнопка была: " + LocationX + " x " + LocationY + " y");
            this.LocationX = polX;
            this.locationY = polY;
            WriteLine("находится сейчас: " + LocationX + " x " + locationY + " y");
        }

        public virtual bool Prow(int maxX, int maxY)
        {
            if((LocationX + Razmer/2.0) <= maxX && 
                (LocationY + Razmer/2.0) <= maxY &&
                (LocationX - Razmer / 2.0) >= 0 && 
                (LocationY - Razmer / 2.0) >= 0)
            {
                WriteLine("Все ок");
                return true;
            }
            else
            {
                WriteLine("Элемент управления выходит за границу экрана");
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

    }
}
