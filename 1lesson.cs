using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static float hind;
        static string pileti_tuup;
        
        static void Main(string[] args)
        {
            Console.WriteLine("Sinu nimi");
            string nimi1 = Console.ReadLine();
            Console.WriteLine();

        }   
    }
}


//double hind = 10;
//Console.WriteLine("Mis on sinu nimi?");
//string eesnimi = Console.ReadLine();
//Console.Write("Tere tulemast {0}!", eesnimi);
//Console.ReadKey();
//if (eesnimi.ToLower() == "juku")
//{
//    Console.WriteLine("Tule külla!, lähme kinno");
//    string vastus = Console.ReadLine();
//    if (vastus.ToUpper() == "JAH" || vastus.ToUpper() == "YES")
//    {
//        Console.WriteLine("Kui vana sa oled?");
//        int vanus = int.Parse(Console.ReadLine());
//        if (vanus < 6 || vanus >= 65)
//        {
//            hind -= hind * 1;
//            pileti_tuup = "tasuta";
//        }
//        else if (vanus >= 6 && vanus < 12)
//        {
//            hind = hind * 0.3;
//            pileti_tuup = "soodus";
//        }
//        else if (vanus >= 12 && vanus < 18)
//        {
//            hind -= hind * 0.1;
//            pileti_tuup = "väike soodus";
//        }
//        else if (vanus < 0 && vanus > 108)
//        {
//            Console.WriteLine("Viga!");
//            pileti_tuup = "ei saa määrata";
//        }
//        char[] tahed = eesnimi.ToCharArray();
//        int i = 0;
//        eesnimi = "";
//        foreach (var t in tahed)
//        {
//            if (i == 0)
//            {
//                eesnimi += t.ToString().ToUpper();
//            }
//            else
//            {
//                eesnimi += t.ToString().ToLower();
//            }
//            i += 1;
//        }
//        Console.WriteLine("{0}, sul on vaja maksta {1}", eesnimi, hind);
//    }

//}
//else
//{
//    Console.WriteLine("Mind täna kodus pole! :(");
//}
//Console.ReadKey();

