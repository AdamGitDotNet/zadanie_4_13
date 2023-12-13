

namespace zadanie_4_13
{
    internal class FizzBuzz
    {
        private string wynik = string.Empty;
        public string SprawdzLiczbe(float liczba)
        {
            if (liczba % 3 == 0 && liczba % 5 == 0)
            {
                wynik = "FizzBuzz, Podaj kolejną liczbę";
            }
            else if (liczba % 3 == 0)
            {
                wynik = "Fizz, Podaj kolejną liczbę";
            }
            else if (liczba % 5 == 0)
            {
                wynik = "Buzz, Podaj kolejną liczbę";
            }
            else if (liczba % 3 != 0 && liczba % 5 != 0)
            {
                wynik = ($"Liczba {liczba} nie jest podzielna przez 3 i 5");
            }
            return wynik;
        }
    }
}
