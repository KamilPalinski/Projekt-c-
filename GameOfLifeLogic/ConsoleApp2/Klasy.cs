using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{

    class RysujPlansze
    {
        int wys = 20;
        int szer = 40;

        public plansza {

        Punkt[,] plansza = new Punkt[wys, szer];
        for (int a = 0; a<wys; a++)
        {
            for (int b = 0; b<szer; b++)
            {
                plansza[a, b] = new Punkt();
                plansza[a, b].wys = b;
                plansza[a, b].szer = a;
                plansza[a, b].RysujMartwy();
    }

    Console.WriteLine("\n");
    }
}
}
    
    class Punkt
    {
        public int szer;
        public int wys;
        public bool czyZywa = false;

        public Punkt(int x, int y)
        {
            szer = x;
            wys = y;

        }
        public Punkt()
        {

        }

        public void RysujMartwy()
        {

            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.SetCursorPosition(wys, szer);
            Console.Write("X");
            czyZywa = false;
        }

        public void RysujAktywny()
        {

            Console.ForegroundColor = ConsoleColor.Red;
            Console.SetCursorPosition(wys, szer);
            Console.Write("O");
            czyZywa = true;
        }

        public int JacySasiedzi(int wys, int szer)
        {


            int aktywne = 0;
            int martwe = 0;

            Punkt nowy1 = new Punkt(wys - 1, szer - 1);
            if (nowy1.czyZywa == true) { aktywne++; } else { martwe++; }
            Punkt nowy2 = new Punkt(wys - 1, szer);
            if (nowy2.czyZywa == true) { aktywne++; } else { martwe++; }
            Punkt nowy3 = new Punkt(wys - 1, szer + 1);
            if (nowy3.czyZywa == true) { aktywne++; } else { martwe++; }
            Punkt nowy4 = new Punkt(wys, szer - 1);
            if (nowy4.czyZywa == true) { aktywne++; } else { martwe++; }
            Punkt nowy5 = new Punkt(wys, szer + 1);
            if (nowy5.czyZywa == true) { aktywne++; } else { martwe++; }
            Punkt nowy6 = new Punkt(wys + 1, szer - 1);
            if (nowy6.czyZywa == true) { aktywne++; } else { martwe++; }
            Punkt nowy7 = new Punkt(wys + 1, szer);
            if (nowy7.czyZywa == true) { aktywne++; } else { martwe++; }
            Punkt nowy8 = new Punkt(wys + 1, szer + 1);
            if (nowy8.czyZywa == true) { aktywne++; } else { martwe++; }

            return aktywne;


        }
        
}

   
   
}
