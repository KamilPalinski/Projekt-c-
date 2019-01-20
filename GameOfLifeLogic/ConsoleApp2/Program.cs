using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            //opcje
            //Console.SetWindowSize(30,20);



            //plansza        
            



            //punkty początek
            //Console.SetCursorPosition(1, 21);
            //Console.Write("Ile liczb? " );
            //int liczba = Int16.Parse(Console.ReadLine());

            //for (int z = 0; z < liczba; z++)
            //{
            //    Console.SetCursorPosition(1, 21);
            //    Console.Write("Podaj x (pkt): ");
            //    int x = Int16.Parse(Console.ReadLine());
            //    Console.SetCursorPosition(1, 22);
            //    Console.Write("Podaj y (pkt): ");
            //    int y = Int16.Parse(Console.ReadLine());
            //    Console.Beep();
            //    Punkt pkt = new Punkt(x, y);
            //    punkt[x,y].RysujAktywny();

            //    Console.SetCursorPosition(1, 24 + z);
            //    Console.WriteLine("Punkt {0} ({1} x {2})", z + 1, x, y);

            //    Console.SetCursorPosition(1, 25 + z);
            //}
            //Console.ForegroundColor = ConsoleColor.White;

            //Console.WriteLine("Naciśnij s by wystartować");







            punkt[5, 6].RysujAktywny();
            punkt[5, 7].RysujAktywny();
            punkt[5, 7].RysujAktywny();
            punkt[6, 7].RysujAktywny();
            punkt[7, 7].RysujAktywny();
            punkt[7, 8].RysujAktywny();
            punkt[8, 8].RysujAktywny();
            punkt[6, 6].RysujAktywny();
            punkt[5, 5].RysujAktywny();







            // System.Threading.Thread.Sleep(1000); //wstrzymuje działanie


            //czy przezywa czy ozywa

            for (int g = 0; g < 10; g++)
            {


                for (int a = 0; a < wys; a++)
                {
                    for (int b = 0; b < szer; b++)
                    {

                        if (punkt[wys,szer].czyZywa == true && ((punkt[wys, szer].JacySasiedzi(wys, szer) == 3 )|| (punkt[wys, szer].JacySasiedzi(wys, szer) == 2)))
                        { punkt[wys, szer].RysujAktywny(); }
                        else
                        { punkt[wys, szer].RysujMartwy(); }

                        if (punkt[wys, szer].czyZywa == false && (punkt[wys, szer].JacySasiedzi(wys, szer) == 3))
                        { punkt[wys, szer].RysujAktywny(); }
                        else
                        { punkt[wys, szer].RysujMartwy(); }

                    }

                }
               
                System.Threading.Thread.Sleep(2000);
                Console.Clear();
            }












            Console.ReadLine();
        }
    }
}


