using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1ITA1_cela_cisla
{
    public class Prvocisla
    {
        public static void run()
        {
            Console.WriteLine("Hello from Prvocisla");


            //vypiseme do konzole "Datove t*py"
            Console.WriteLine("Datove t*py");
            //text musi byt v uvozovkach, nezapominame na strednik za prikazem

            //datovy typ cela cisla
            //Integer
            int celeCislo; //vytvorili jsme si promennou s jmenem 
            //celeCislo a datovym typem celeho cisla int
            //promenne a jmena objektu nesmi zaciant cislici
            celeCislo = 3323; //do promenne celeCislo jsme vlozili 3323

            Console.WriteLine(celeCislo); //bez uvozovek, vypiseme hodnotu,
            //ktera je ulozena v promenne celeCislo

            celeCislo = 123;
            //prepsali jsme hodnotu 3323 na novou 123
            Console.WriteLine(celeCislo);

            int koktejl = 3;
            Console.WriteLine(koktejl);

            //operace s cislama
            celeCislo = celeCislo + koktejl;
            //nejdrive se provede to co je napravo od rovnitka
            //a pak teprve prirazeni
            Console.WriteLine(celeCislo);

            int vysledek;
            //obsah ctverce a*a
            int a = 5;
            vysledek = a * a;
            //vysledek bude obsahovat obsah ctverce
            Console.WriteLine(vysledek);

            //vyzkousejte si ruzne matematicke vzorecky
            //obvod a obsah: ctverec, obdelnik, 
            //obvod trojuhelniku
            //objem ci povrch:krychle, kvadr, kolmy hranol

        }
    }
}

