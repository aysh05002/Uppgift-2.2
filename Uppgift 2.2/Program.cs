using System;

namespace Uppgift_2_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Elin och Alma, längdhoppstävling \nOBS:Mätt i meter\n");
            Console.Write("Hur långt har Elin hoppat ? =");
            double Elin = Convert.ToDouble(Console.ReadLine());
            Console.Write("Hur långt har Alma hoppat ? =");
            double Alma = Convert.ToDouble(Console.ReadLine());
            double längre = Elin - Alma;
            Console.WriteLine("Elin hoppade " + längre + " meter längre än Alma");
        }
    }
}