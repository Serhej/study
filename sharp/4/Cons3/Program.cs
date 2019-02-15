using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

using System.Threading;


namespace Cons3
{
    class Program
    {
        static void Main(string[] args)
        {
           
            //    Console.Write("{0,3}:   ");
            //    Console.BackgroundColor = ConsoleColor.DarkMagenta;
            //    Console.Write(' ');
            //    Console.BackgroundColor = ConsoleColor.Black;
            //    Console.WriteLine();
            //Console.CursorVisible = false; // гасим курсор


            List<ElemUpr> uprs = new List<ElemUpr>();

            Knopka elemUpr = new Knopka();
            uprs.Add(elemUpr);
            elemUpr.ChangePol(5, 5);
            elemUpr.Draw();

            Knopka knopka = new Knopka(ConsoleColor.Red);
            uprs.Add(knopka);
            knopka.ChangePol(15, 5);
            knopka.Draw();

            Knopka knop = new Knopka(ConsoleColor.Green);
            uprs.Add(knop);
            knop.ChangePol(25, 5);
            knop.Draw();

            Knopka kopka = new Knopka(ConsoleColor.Yellow);
            uprs.Add(kopka);
            kopka.ChangePol(15, 15);
            kopka.Draw();

            ConsoleKeyInfo k;
            int u = 0;

            ElemUpr.Focus(knop);


            do
            {
                k = Console.ReadKey(true);

                
                switch (k.Key)
                {
                    case ConsoleKey.LeftArrow :
                        {
                            u--;
                            if (u == -1)
                            {
                                u = uprs.Count - 1;
                            }
                            ElemUpr.Focus(uprs[u], ()=>ElemUpr.TextOutput("Left"));
                            break;
                        }
                       
                    case ConsoleKey.RightArrow :
                        {
                            u++;
                            u = u % uprs.Count;
                            ElemUpr.Focus(uprs[u], () => ElemUpr.TextOutput("Right"));
                            break;
                        }
                       
                    case ConsoleKey.Spacebar:
                        {
                            ElemUpr kna = ElemUpr.GetFocus();
                            kna.Click();
                            break;
                        }
                    case ConsoleKey.W:
                        {
                            ElemUpr kna = ElemUpr.GetFocus();
                            kna.Clear(()=>ElemUpr.TextOutput("Произошло удаление"));
                            kna.ChangePol(kna.LocationX, kna.LocationY-1);
                            kna.Draw();
                            break;
                        }
                    case ConsoleKey.S:
                        {
                            ElemUpr kna = ElemUpr.GetFocus();
                            kna.Clear();
                            kna.ChangePol(kna.LocationX, kna.LocationY + 1);
                            kna.Draw();
                            break;
                        }
                    case ConsoleKey.A:
                        {
                            ElemUpr kna = ElemUpr.GetFocus();
                            kna.Clear();
                            kna.ChangePol(kna.LocationX - 1 , kna.LocationY);
                            kna.Draw();
                            break;
                        }
                    case ConsoleKey.D:
                        {
                            ElemUpr kna = ElemUpr.GetFocus();
                            kna.Clear();
                            kna.ChangePol(kna.LocationX + 1, kna.LocationY);
                            kna.Draw();
                            break;
                        }
                }                
            }
            while (k.Key != ConsoleKey.Escape);


            

                               
            //ConsoleKeyInfo k;

            //do
            //{ 
            //    Console.SetCursorPosition(x, y);

            //    Knopka knop = new Knopka();
            //    knop.Draw(x, y);

            //    k = Console.ReadKey(true);

            //    if (k.Key == ConsoleKey.UpArrow)
            //        y--;
            //    else if (k.Key == ConsoleKey.DownArrow)
            //        y++;
            //    else if (k.Key == ConsoleKey.LeftArrow)
            //        x--;
            //    else if (k.Key == ConsoleKey.RightArrow)
            //        x++;

            //    Console.Clear();


            //} while (k.Key != ConsoleKey.Escape); // выходим из цикла по нажатию Esc


            //WriteLine(" ");

            //List<IDraw> draws = new List<IDraw>();
            //for (int i = 0; i < 5; i++)
            //{
            //    Knopka bottom = new Knopka();
            //    Pansel pansel = new Pansel();

            //    draws.Add(bottom);
            //    draws.Add(pansel);
            //}

            //WriteLine("Введите число от 0 до " + draws.Count);

            //int t = Int32.Parse(Console.ReadLine());
            //draws[t].Draw();

            //x = 5;
            //Console.SetCursorPosition(x, y);
            //for (int i = 0; i < height; i++)
            //{
            //    Console.BackgroundColor = ConsoleColor.DarkMagenta;
            //    WriteLine(' ');
            //    Console.BackgroundColor = ConsoleColor.Black;
            //}


            //RBottom rew = new RBottom();
            //rew.ChangePol(15, 25);

            //ChecBoks checBoks = new ChecBoks();
            //checBoks.Click();
            //WriteLine("");
            //checBoks.DoubleClick();

            //checBoks.Prow(78, 20);

            //WriteLine("");
            //TextPole textPole = new TextPole();
            //textPole.DoubleClick();

            //Knopka knopka = new Knopka();
            //knopka.Click();

            //RBottom rBottom = new RBottom();
            //rBottom.Click(10);
            //rBottom.Click();

        }
    }
}



