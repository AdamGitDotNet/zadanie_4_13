using System;
using zadanie_4_13;

namespace zadania
{
    class Program
    {
        static void Main(string[] args)
        {
            bool wyjscieZProgramu = false;
            try
            {
                Console.WriteLine("Podaj liczbę");
                FizzBuzz fizzBuzz = new FizzBuzz();

                do
                {
                    if (float.TryParse(Console.ReadLine(), out float wynik))
                    {
                        Console.WriteLine(fizzBuzz.SprawdzLiczbe(wynik));
                        Console.WriteLine("\nPodaj kolejną liczbę");
                    }
                    else
                    {
                        Console.WriteLine($"Podałeś niepoprawne dane.");
                        wyjscieZProgramu = true;
                    }
                }
                while (!wyjscieZProgramu);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
