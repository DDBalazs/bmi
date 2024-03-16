using System.Threading.Channels;

namespace Testtömeg_index
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Kérem adja meg a testsúlyát: ");
            double kg = double.Parse(Console.ReadLine());
            Console.Write("Kérem adja meg a magasságát: ");
            double m = double.Parse(Console.ReadLine());
            //double m2 = m % 10;
            double bmi = kg / (m*m) *10000;
            Console.WriteLine($"A testtömeg indexe: {bmi:00.00}");

            if (bmi < 16) { Console.WriteLine("Ön súlyosan sovány"); }
            else if (16 <= bmi & bmi < 17) { Console.WriteLine("Ön mérsékelten sovány"); }
            else if (17 <= bmi & bmi < 18.5) { Console.WriteLine("Ön enhén sovány"); }
            else if (18.5 <= bmi & bmi < 25) { Console.WriteLine("Ön normál testsúlyban van"); }
            else if (25 <= bmi & bmi < 30) { Console.WriteLine("Ön túlsúlyos"); }
            else if (30 <= bmi & bmi < 35) { Console.WriteLine("Ön 1. fokozatos túlsúlyos"); }
            else if (35 <= bmi & bmi < 40) { Console.WriteLine("Ön 2. fokozatos túlsúlyos"); }
            else if (40 <= bmi) { Console.WriteLine("Ön 3. fokozatos túlsúlyos"); }
            else { Console.Write("Nem adott meg normális adatokat"); }
        }
    }
}
