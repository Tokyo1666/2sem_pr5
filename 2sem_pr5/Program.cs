using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _2sem_pr5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1.uzd

            Console.WriteLine("Ievadi skaitli: ");
            int Number = int.Parse(Console.ReadLine());

            int sum = NumberSum(Number); //// Izsauc rekursīvo funkciju, lai aprēķinātu skaitļa ciparu summu.
            Console.WriteLine("Ciparu summa ir: " + sum);
            Console.ReadLine();

            //2.uzd
            int a, n, d; // "a" - pirmās aritmētiskās progresijas vērtība
                         // "d" - aritmētiskās progresijas solis
                         // "n" - cik daudz elementu jāizvada

            Console.WriteLine("Cik elementus izvadit: ");
            n = Convert.ToInt32(Console.ReadLine()); // Saglabā ievadīto skaitli "n" mainīgajā, konvertējot to no string uz int datu tipu

            Console.WriteLine("Progresijas solis: ");
            d = Convert.ToInt32(Console.ReadLine()); // Saglabā ievadīto skaitli "d" mainīgajā, konvertējot to no string uz int datu tipu

            Console.WriteLine("Progresijas sākumu: ");
            a = Convert.ToInt32(Console.ReadLine()); // Saglabā ievadīto skaitli "a" mainīgajā, konvertējot to no string uz int datu tipu

            Aritm(a, d, n); // Izsauc funkciju "Aritm" ar "a", "d" un "n" kā parametriem

        }

        static int NumberSum(int Number) //1.uzd
        {
            int summa = 0;
            while (Number != 0)
            {
                summa += Number % 10; // Izvilk pēdējo ciparu no skaitļa un pievienot to summai.
                Number /= 10; // Noņemt pēdējo ciparu no skaitļa.
                NumberSum(Number);
            }
            return summa; // Atgriezt ciparu summu.
        }

        static void Aritm(int a, int d, int n)  // Šī funkcija aprēķina aritmētisko progresiju,
                                                // sākot no vērtības "a" un pievienojot soli "d"
                                                // ikvienam nākamajam elementam, līdz tiek izvadīti "n" elementi.
        {
            if (n == 0) 
                return; // Pārbauda, vai sasniedzis elementu skaita beigas, ja ir, tad atgriež funkcijas izsaukumu

            // Izvada pašreizējo skaitli un turpina aritmētisko progresiju rekursīvi, samazinot n par 1 un palielinot a ar d.
            Console.Write("{0} ", a); //{0 }it's a placeholder or "argument".
                                      //It means that in your example the variable text gets written where the {0} is placed in the preceding text. 

            Aritm(a + d, d, n - 1);
        }
    }
}
