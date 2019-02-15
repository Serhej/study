using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Cons3
{
    class Knopka:ElemUpr
    {       
        public bool CanClick { get; set; }
        public override string Text { get; set; }
        

        public override void Click()  // metod
        {
            if (CanClick == true)
            {
                WriteLine("Вы нажали " + this + " " + Text);
            }
        }

        public override string ToString()
        {
            return "кнопка";
        }

        public virtual void Click(int timePush)
        {
            if (CanClick == true)
            {
                WriteLine("Вы зажал кнопку " + Text + " на: " + timePush + " мс");
            }
        }

        public override void DoubleClick()
        {
            this.Click();
        }

        public void Block()
        {
            CanClick = false;
            WriteLine("Кнопка заблокирована");
        }
        public void UnBlock()
        {
            CanClick = true;
            WriteLine("Кнопка разблокирована");
        }

        public Knopka()  // конструктор
        {
            Color = "grean";
            Text = " Delete";
            CanClick = true;
        }

        public Knopka(string color, string text, bool canClick)  // конструктор
        {
            Color = color;
            Text = text;
            CanClick = canClick;
        }


        public Knopka(Knopka ren) // констр копиров
        {
            this.Color = ren.Color;
            this.Text = ren.Text;
        }

        public override void Show()  /// переопределение базового метода
        {
            WriteLine("   ");
            base.Show();  
            if (CanClick == true)
            {
                WriteLine("Кнопка разблокированиа");
            }
            else
            {
                WriteLine("Кнопка заблокирована");
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
