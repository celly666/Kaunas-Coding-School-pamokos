using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace atsiskaitymo_uzduotis_1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Vidurio kurso patikra
            // 2020-06-01
            // Ramunė Alionytė




            // 1.Aprašykite kintamąjį x, realiųjų skaičių tipu.

            float xf;


            /* 2.Parašykite funkciją, kuri konvertuotų žodinį kintamąjį “žodis”
             į sveikąjį skaičių ir priskirtų jį sveikajam kintamajam a.*/

            string zodis = "zodis";
            int a = Int32.Parse(zodis);
            Console.WriteLine(a);


            // 3.Parašykite ciklą for kuris į ekraną išvetų visus skaičius nuo 0 iki 10.

            for (var i = 0; i <= 10; i++)
            {
                Console.WriteLine(i);
            }

            // 4.Parašykite kodą kuris iš 3 skaičių rastų didžiausią.

            Console.WriteLine("Iveskite pirma skaiciu");
            int sk1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Iveskite antra skaiciu");
            int sk2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Iveskite trecia skaiciu");
            int sk3 = Convert.ToInt32(Console.ReadLine());

            if (sk1 > sk2)
            {
                if (sk1 > sk3)
                {
                    Console.WriteLine("Pirmas skaicius yra didziausias");
                }
                else
                {
                    Console.WriteLine("Trecias skaicius yra didziausias");
                }
            }
            else if (sk2 > sk3)
                Console.WriteLine("Antras skaicius yra didziausias");
            else
                Console.WriteLine("Trecias skaicius yra didziausias");




            /* 5.Parašykite programą kuri turėtų prekių sąrašą
          (sąrašą sugalvokite patys, sąraše turėtų būti bent 7 prekės.)
            Programa turi sudaryti pirkinių sąrašą ir pateikti kokia bus pilna 
            apsipirkimo suma. */

            int suma = 0;
            string Sarasas = "1) Duona - 2eur/vnt." + System.Environment.NewLine +
                             "2) Kava - 4eur/vnt." + System.Environment.NewLine +
                             "3) Sūris- 3eur/vnt." + System.Environment.NewLine +
                             "4) Jogurtas- 1eur/vnt. " + System.Environment.NewLine +
                             "5) Pienas - 2eur/vnt. " + System.Environment.NewLine +
                             "6) Vištiena- 5eur/vnt. " + System.Environment.NewLine +
                             "7) Aliejus- 6eur/vnt. " + System.Environment.NewLine +
                             "8) Apsipirkimo pabaiga ";


            Console.WriteLine("Prekių sąrašas :");
            Console.WriteLine(Sarasas);
            Console.WriteLine("-------------------------------------");
            Console.Write(" Ka jus noretumete isigyti ?" + System.Environment.NewLine);
            string pirkiniuSarasas = "0";

            while (pirkiniuSarasas != "8")
            {
                pirkiniuSarasas = Console.ReadLine().Trim();
                switch (pirkiniuSarasas)
                {
                    case "1":
                        Console.WriteLine("Kiek duonos kepalu noresite isigyti?");
                        string duonosPasirinkimas = Console.ReadLine();
                        int duonoskiekis = Int32.Parse(duonosPasirinkimas);
                        Console.WriteLine("Ką dar norėsite įsigyti?");
                        suma += 2 * duonoskiekis;
                        break;

                    case "2":
                        Console.WriteLine("Kiek vienetu kavos noresite isigyti?");
                        string kavaPasirinkimas = Console.ReadLine();
                        int kavosKiekis = Int32.Parse(kavaPasirinkimas);
                        Console.WriteLine("Ką dar norėsite įsigyti?");
                        suma += 4 * kavosKiekis;
                        break;

                    case "3":
                        Console.WriteLine("Kiek vienetu surio noresite isigyti?");
                        string surisPasirinkimas = Console.ReadLine();
                        int surisKiekis = Int32.Parse(surisPasirinkimas);
                        Console.WriteLine("Ką dar norėsite įsigyti?");
                        suma += 3 * surisKiekis;
                        break;

                    case "4":
                        Console.WriteLine("Kiek vienetu jogurto noresite isigyti?");
                        string jogurtasPasirinkimas = Console.ReadLine();
                        int jogurtasKiekis = Int32.Parse(jogurtasPasirinkimas);
                        Console.WriteLine("Ką dar norėsite įsigyti?");
                        suma += 1 * jogurtasKiekis;
                        break;

                    case "5":
                        Console.WriteLine("Kiek vienetu pieno noresite isigyti?");
                        string pienasPasirinkimas = Console.ReadLine();
                        int pienasKiekis = Int32.Parse(pienasPasirinkimas);
                        Console.WriteLine("Ką dar norėsite įsigyti?");
                        suma += 2 * pienasKiekis;
                        break;

                    case "6":
                        Console.WriteLine("Kiek vienetu vistienos noresite isigyti?");
                        string vistienaPasirinkimas = Console.ReadLine();
                        int vistienaKiekis = Int32.Parse(vistienaPasirinkimas);
                        Console.WriteLine("Ką dar norėsite įsigyti?");
                        suma += 5 * vistienaKiekis;
                        break;

                    case "7":
                        Console.WriteLine("Kiek vienetu aliejaus noresite isigyti?");
                        string aliejusPasirinkimas = Console.ReadLine();
                        int aliejusKiekis = Int32.Parse(aliejusPasirinkimas);
                        Console.WriteLine("Ką dar norėsite įsigyti?");
                        suma += 6 * aliejusKiekis;
                        break;

                    case "8":

                        Console.WriteLine("Moketi reikia : " + suma + " eurus(-a).");
                        Console.WriteLine("Aciu, kad perkate, grazios dienos :)");
                        break;

                    default:
                        Console.WriteLine("Neteisingai ivestas skaicius, iveskite skaiciu nuo 1-8.");
                        break;





                }
            }
        }
    }
}

            
            




