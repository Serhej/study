using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Cons3
{
    public class Knopka:ElemUpr
    {       
        
        public bool CanClick { get; set; }
        public override string Text { get; set; }
        public string Name { get; set; }

        delegate void Dele();
         
        public void Wyzow()
        {
            TextOutput("Wyzow metoda Wyzow");
        }
        
        public override void Click()  // metod
        {
            if (CanClick == true)
            {
                TextOutput("Вы нажали " + this + " " + Text);
                
            }
        }

        public override string ToString()
        {
            return "кнопка" + Name;
        }

        public override bool Equals(object obj)
        {
            if (obj == null)
                return false;
            Knopka m = obj as Knopka; // возвращает null если объект нельзя привести к типу Money
            if (m as Knopka == null)
                return false;

            return m.Name == this.Name;
        }

        public virtual void Click(int timePush)
        {
            if (CanClick == true)
            {
                TextOutput("Вы зажал кнопку " + Text + " на: " + timePush + " мс");
            }
        }

        public override void DoubleClick()
        {
            this.Click();
        }

        public void Block()
        {
            CanClick = false;
            TextOutput("Кнопка заблокирована");
        }
        public void UnBlock()
        {
            CanClick = true;
            TextOutput("Кнопка разблокирована");
        }

        public Knopka()  // конструктор
        {
            Color = ConsoleColor.DarkRed;
            Text = " Space";
            CanClick = true;
            Name = "Knop";
        }

        public Knopka(string set)
        {
            Name = set;
            Color = ConsoleColor.DarkRed;
            Text = " Space";
            CanClick = true;
        }

        public Knopka(string color, string text, bool canClick)  // конструктор
        {
            Color = ConsoleColor.Magenta;
            Text = text;
            CanClick = canClick;
            Name = "Knoppp";
        }


        public Knopka(Knopka ren) // констр копиров
        {
            this.Color = ren.Color;
            this.Text = ren.Text;
            CanClick = ren.CanClick;
            Name = ren.Name;

        }

        public Knopka(ConsoleColor col)
        {
            Color = col;
            Text = " Space";
            Name = "Knop";
            CanClick = true;
        }

        public override void Show()  /// переопределение базового метода
        {
            WriteLine("   ");
            base.Show();  
            if (CanClick == true)
            {
                TextOutput("Кнопка разблокирована");
            }
            else
            {
                TextOutput("Кнопка заблокирована");
            }
        }
    }
}


//индексаторы
class User
{
    public string Login { get; set; }
    public string Password { get; set; }

}
class Users
{
    private List<User> users = new List<User>() {
        new User() { Login = "erty", Password = "33553" },
        new User() { Login = "ffrf", Password = "53676" },
        new User() { Login = "rfrfr", Password = "76854" },
        new User() { Login = "rfrfrbyhyy", Password = "35343" } };

    public User this[int index]
    {
        get { return users[index]; }

    }
}
