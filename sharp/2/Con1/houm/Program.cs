using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace houm
{
    class Knopka
    {
        string raspoloz;
        string color;
        string text;
        static bool caps;
        bool canPush;
       
        public bool CanPush
        {
            set { canPush = value; }
            get { return canPush; }
        }

        public string Raspoloz   // swojswto
        {
            set {raspoloz = value;}
            get {return raspoloz;}
        }

        public string Color
        {
            get{return color ;}
            private set { color = value; }
        }

        public string Text
        {
            set{ text = value; }
            get
            {
                if (caps)
                    return text.ToUpper();
                else
                    return text;
            }
        }

        public static bool Caps
        {
            set {caps = value;}
            get {return caps;}
        }
        

        public void Push()  // metod
        {
            if (CanPush == true)
            {
                WriteLine("Вы нажали кнопку \"Нажать\"");
            }
        }
        public void Push(int timePush)
        {
            if (CanPush == true)
            {
                WriteLine("Вы зажал кнопку \"Нажать\" на: " + timePush + " мс");
            }
        }

        public void ChangePol(string pol)
        {
            WriteLine("кнопка была: " + Raspoloz);
            this.Raspoloz = pol;
            WriteLine("находится сейчас: " + Raspoloz);
            
        }


        public void Block()
        {
            CanPush = false;
            WriteLine("Кнопка заблокирована");

        }
        public void UnBlock()
        {
            CanPush = true;
            WriteLine("Кнопка разблокирована");
        }

        public Knopka()  // конструктор
        {
            Color = "grean";
            Raspoloz = "left";
            text = "Knopka";
            canPush = true;
        }

        static Knopka()
        {
            Caps = true;
        }

        public Knopka(Knopka ren) // констр копиров
        {
            this.Raspoloz = ren.Raspoloz;
            this.Color = ren.Color;
            this.Text = ren.Text;
            this.CanPush = ren.CanPush;
        }
       
        ~Knopka()  //финализатор
        {
            WriteLine($"Объект {CanPush}, {Raspoloz}, {Color} уничтожен");
        }
    }
            
    

    class Program
    {
        static void Main(string[] args)
        {
      
                Knopka ruch = new Knopka();
                ruch.Push();

                Knopka ras = new Knopka();  //instance
                WriteLine("Кнопка находится: ");
                
                string rnd;
                Random rand = new Random();

                int val = rand.Next(0, 2);
                if (val == 0)
                    rnd = "left";
                else if (val == 1)
                    rnd = "center";
                else
                    rnd = "right";

                ras.ChangePol(rnd);
              
                Knopka puch = new Knopka();
                puch.Push();
                puch.Push(4);

                Knopka color = new Knopka();
                WriteLine("She has: " + color.Color + " color.");

                Knopka text = new Knopka();
                WriteLine("Введите текст: ");
                string strText = ReadLine();
                text.Text = strText;
                WriteLine(text.Text);
        }
    }
}
