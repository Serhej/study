using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;


namespace Cons3
{
    class Program
    {
        static void Main(string[] args)
        {
            //инспользование индексаторов 
            //Users res = new Users();

            //WriteLine(res[0]);

            //for(int i = 0; i < 4; i++)
            //{
            //    WriteLine(res[i].Login);
            //}


            //ElemUpr elem = new Knopka(); //полиморфизм: elem - ссылка на базовай класс, которая указывает на производный тип Кнопка
            //elem.Show();


            //  вызов метода Show
            //Knopka knop = new Knopka();
            //knop.Show();

            //RBottom rBottom = new RBottom();
            //rBottom.Show();

            //BottomImag bottImag = new BottomImag();
            //bottImag.Show();

            //TextPole texPol = new TextPole();
            //texPol.Show();

            //ChecBoks checBock = new ChecBoks();
            //checBock.Show();

            RBottom rew = new RBottom();
            rew.ChangePol(15, 25);


            //string rnd;
            //Random rand = new Random();

            //int val = rand.Next(0, 2);
            //if (val == 0)
            //    rnd = "left";
            //else if (val == 1)
            //    rnd = "center";
            //else
            //    rnd = "right";

            ChecBoks checBoks = new ChecBoks();
            checBoks.Click();
            WriteLine("");
            checBoks.DoubleClick();

            checBoks.Prow(78, 20);

            WriteLine("");
            TextPole textPole = new TextPole();
            textPole.DoubleClick();

            Knopka knopka = new Knopka();
            knopka.Click();

            RBottom rBottom = new RBottom();
            rBottom.Click(10);
            rBottom.Click();

        }
    }
}
