using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace atsiskaitymo_uzdaviniai_ciklai
{
    class Program
    {
        static void Main(string[] args)
        {
            //1. Parašykite programą, kuri suskaičiuotų skaičių nuo 1 iki 100 sumą s = 1 + 2 + 3 ...+ 100.

            int s = 0;

            for (int i = 1; i <= 100; i++)
            {
                s += i;
            }
            Console.WriteLine(s);

            Console.WriteLine("-------------------------------------------------------------------------------");


            //2. Parašykite programą, kuri suskaičiuotų skaičių nuo 1 iki n sumą s = 1 + 2 + 3... + n.

            int s = 0;

            Console.WriteLine("Iveskite skaiciu iki kurio norite apskaiciuoti visu skaiciu suma, t.y. pradedant nuo 1 ir baigiant jusu ivestu skaiciu");
            int n = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                s += i;
            }
            Console.WriteLine(s);

            Console.WriteLine("-----------------------------------------------------------------------------------");

            //3. Parašykite programą, kuri suskaičiuotų skaičių nuo m iki n sumą s = m + (m+1) +... + n.

            int s = 0;

            Console.WriteLine("Iveskite skaiciu, nuo kurio norite pradeti skaiciuoti skaiciu suma ");
            int m = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Iveskite skaiciu, iki kurio norite skaiciuoti skaiciu suma ");
            int n = Convert.ToInt32(Console.ReadLine());

            for (int i = m; i <= n; i++)
            {
                s += i;
            }
            Console.WriteLine(s);

            Console.WriteLine("--------------------------------------------------------------------------------------");

            /*4. Vaikui gimus tėvas padovanojo 5 litus. Kiekvienais kitais metais gimtadienio
             proga padovanodavo tiek litų, kiek jam sueidavo metų. Parašykite programą, kuri 
            suskaičiuotų, kiek jis turės litų, kai jam sueis n metų.*/

            int pinigai = 5;

            Console.WriteLine("Iveskite metu skaiciu ");
            int n = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i <= n; i++)
            {
                pinigai += i;
            }
            Console.WriteLine("Kai jam bus {0} metu, jis tures {1} pinigu .", n, pinigai);

            Console.WriteLine("-----------------------------------------------------------------------------------------");

            //5. Parašykite programą, kuri suskaičiuotų skaičiaus n faktorialą s= 1 * 2 *... * n.

            int i, s = 1;

            Console.Write("Iveskite skaiciu : ");
            int n = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                s *= i;
            }
            Console.WriteLine("Skaiciaus {0} faktorialas yra {1} .", n, s);

            Console.WriteLine("--------------------------------------------------------------------------------------------");

            /*6. Parašykite programą, kuri suskaičiuotų, kiek yra triženklių skaičių,
             besibaigiančių ketvertu ir išvestų juos į ekraną. */

            int kiekis = 0;

            for (int i = 100; i <= 999; i++)
            {
                int paskutinisSkaitmuo = i % 10;

                if (paskutinisSkaitmuo==4)
                {
                    Console.WriteLine(i);
                    kiekis++;
                }
                else
                {
                    continue;
                }

            }
            Console.WriteLine("Trizenkliu skaiciu, kuriu paskutinis skaitmuo 4 yra : " + kiekis);

            Console.WriteLine("-----------------------------------------------------------------------------------------");

            /*7. Parašykite programą, kuri rastų ir išvestų į ekraną visus dviženklius 
              skaičius, kurių abu skaitmenys yra lyginiai, rastų jų kiekį ir juos susumuotų.*/

            int lyginiai = 0;
            int suma = 0;
            var pirmasLyginis = true;
            var antrasLyginis = true;



            for (int i = 10; i <= 99; i++)

            {
                var _n = i;

                {
                    var digit = _n % 10;
                    if (digit % 2 == 0)
                    {
                        pirmasLyginis = true;
                        _n /= 10;
                        if (_n % 2 == 0)
                        {
                            antrasLyginis = true;
                            suma += i;
                            lyginiai++;
                            Console.WriteLine(i);
                        }
                        if (antrasLyginis == false)
                        {
                            continue;
                        }

                        if (pirmasLyginis == false)
                        {

                            continue;
                        }


                    }


                }
            }
            Console.WriteLine("Dvizenkliu skaiciu, kuriu abu skaitmenys lyginiai yra " + lyginiai + ", ju suma yra " + suma + " .");

            Console.WriteLine("-------------------------------------------------------------------------------------");


            /*8. Parašykite programą, kuri suskaičiuotų, kiek yra keturženklių skaičių,
            kurių pirmųjų dviejų skaitmenų suma yra lygi likusių dviejų skaitmenų sumai, ir išvestų juos į ekraną. */

            int m, c;

            int kiekis = 0;
            for (int i = 1000; i <= 9999; i++)

            {
                var k = i;
                int paskutiniuSuma = 0;
                int pirmuSuma = 0;
                while (k > 99)
                {

                    m = k % 10;
                    k = k / 10;
                    paskutiniuSuma += m;


                }
                while (k <= 99 && k > 0)
                {
                    c = k % 10;
                    k = k / 10;
                    pirmuSuma += c;
                }
                if (paskutiniuSuma == pirmuSuma)
                {
                    kiekis++;
                    Console.WriteLine(i);
                }
                else

                {
                    continue;
                }

            }
            Console.WriteLine("Keturzenkliu skaiciu, kuriu pirmuju dvieju skaitmenu suma yra lygi kitu dvieju skaitmenu sumai yra " + kiekis + " .");

            Console.WriteLine("-----------------------------------------------------------------------------------------");

            /* 9-10. Parašykite programą, kuri išvestų visus duotojo skaičiaus n daliklius.
             Papildykite šią programą taip, kad ji ne tik išvestų visus duotojo skaičiaus 
            daliklius, bet ir suskaičiuotų jų kiekį, surastų šių daliklių sumą ir sandaugą. */

            int sum = 0;
            int kiekis = 0;
            int sandauga = 1;
            Console.WriteLine("Iveskite skaiciu");
            int n = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Skaiciaus {0} dalikliai yra : ", n);

            for (int i = 1; i <= n; i++)
            {
                if (n % i == 0)
                {
                    kiekis++;
                    sum += i;
                    Console.Write("{0} ", i);
                    sandauga *= i;
                }

                else
                {
                    continue;
                }
            }
            Console.WriteLine("\nSkaicius {0} , turi {1} daliklius ir ju visu suma  yra {2} , visu dalikliu sandauga yra {3} .", n, kiekis, sum, sandauga);

            Console.WriteLine("-----------------------------------------------------------------------------------------------");

            //*11. Parašykite programą, kuri nustatytų, ar duotas skaičius n yra pirminis (turi tik du daliklius: vienetą ir patį save)

            Console.WriteLine("Iveskite skaiciu");
            int i = Convert.ToInt32(Console.ReadLine());

            int j;
            bool sudetinis = false;
            {
                for (j = 2; j < i; j++)
                {
                    if (i % j == 0)
                    {
                        sudetinis = true;
                        Console.WriteLine("Skaicius yra sudetinis " + i);
                    }
                }
            }
            if (sudetinis == false)
            {
                Console.WriteLine("Skaicius yra pirminis " + i);
            }

            Console.WriteLine("---------------------------------------------------------------------------------------------------");

        }
    }
}
