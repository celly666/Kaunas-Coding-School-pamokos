using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace adjajfdsfs
{
    class Miestai
    {

        public Miestai(string name)
        {
            Name = name;
        }
        public string Name { get; set; }

        public string Country { get; set; }
        class Program
    {
        static void Main(string[] args)
        {
                StreamReader stream = new StreamReader("miestai.txt");

                string line;

                List<Miestai> miestai = new List<Miestai>();
                while ((line = stream.ReadLine()) != null)
                {

                    string[] eilute = line.Split(' ');


                    var obj = new Miestai(eilute[0]);


                    obj.Country = eilute[1];


                    miestai.Add(obj);


                }
                while (miestai.Count >= 1)
                {

                    string valstybees = miestai[0].Country;

                    int kiek = miestai.Where(p => p.Country == valstybees).Count();

                    miestai.RemoveAll(p => p.Country == valstybees);


                    Console.WriteLine("Valstybe {0} turi {1} miestu .", valstybees, kiek);
                }

                stream.Close();
                Console.ReadLine();
            }
        }
    }
}
