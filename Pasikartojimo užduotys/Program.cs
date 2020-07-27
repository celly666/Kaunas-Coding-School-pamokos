using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace senos_uzduotys
{
    class Program
    {
        static void Main(string[] args)
        {

            // 1. Parašyti programą kuri sudaugintų 2 vartotojo įvestus skaičius, programoje negalimaa naudoti daygybos;

            Console.WriteLine("Iveskite pirmaji skaiciu");
            int skaicius1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Iveskite pirmaji skaiciu");
            int skaicius2 = Convert.ToInt32(Console.ReadLine());
            int sandauga = 0;

            for (int i = 0; i < skaicius1; i++)
            {
                sandauga += skaicius2;
            }
            Console.WriteLine(sandauga);
            Console.ReadLine();



            /*2. Kiekvieną dieną Petriukas, eidamas į mokyklą, skaičiuoja kiekvieną savo žingsnį
              ir žaidžia tokį žaidimą: kai žingsnių skaičius baigiasi nuliu, Petriukas suploja rankomis,
              o kai  penketu  -  spragteli  pirštais.  Parašykite  programą,  kuri  suskaičiuotų,  kiek  kartų 
              Petriukas suplos rankomis ir kiek – spragtels pirštais, jei jam iki mokyklos yra lygiai n žingsnių.*/

            Console.WriteLine("Iveskite kiek zingsniu iki mokyklos : ");
            int zingsniai = int.Parse(Console.ReadLine());

            int suplojimai = 0;
            int spragtelejimai = 0;

            for (int i = 1; i <= zingsniai; i++)
            {
                if (i % 10 == 0)
                {
                    suplojimai++;
                }
                else if (i % 5 == 0)
                {
                    spragtelejimai++;
                }

            }
            Console.WriteLine(" Suplos {0} kart, spragteles {1} kart .", suplojimai, spragtelejimai);
            Console.ReadKey();


            /*3. Prieš  Kalėdas  miško  urėdijos  prekiauja  įvairaus  aukščio  eglutėmis.
             Į prekybos  vietą  atvežta  n  eglučių.  Jų  aukščiai  yra  e1,  e2,  …,  en. 
            Parašykite  programą, skaičiuojančią vidutinį eglutės aukštį */

            Console.WriteLine(" Iveskite kiek egluciu atveze i prekybos vieta : ");
            int n = Convert.ToInt32(Console.ReadLine());

            int suma = 0, avg = 0;

            for (int i = 0; i < n; i++)
            {
                suma += i;
            }
            avg = suma / n;

            Console.WriteLine("Vidutinis eglutes aukstis yra {0}.", avg);


            /*4. Per atostogas Simas turėjo daugiau laisvo laiko ir nutarė suskaičiuoti,
              kiek sningant po jo namo langu nukrenta snaigių. Jis pastebėjo, kad kiekvieną kitą 
              sekundę nukrenta dvigubai daugiau snaigių, nei prieš tai buvusią. Parašykite programą, 
             skaičiuojančią kiek snaigių s bus nukritę per n sekundžių, kai per pirmąją sekundę nukrito k snaigių*/

            Console.WriteLine("Kiek sekundziu skaiciuosim? ");
            int sek = int.Parse(Console.ReadLine());
            Console.WriteLine("Kiek snaigiu nukripo per pirmaja sekunde?");
            int snaigesPerSek = int.Parse(Console.ReadLine());

            int snaigiuKiekis = snaigesPerSek;
            int dabarKiek = snaigesPerSek;

            for (int i = 2; i <= sek; i++)
            {
                dabarKiek = dabarKiek + 2;

                Console.WriteLine(" {0} sekunde nukrito {1} snaigiu.", i, dabarKiek);
                snaigiuKiekis += dabarKiek;
            }
            Console.WriteLine("Per {0} sekundziu nukris {1} snaigiu. ", sek, snaigiuKiekis);
        }
    }
}
