
namespace S13L3.models
{
    internal class RandomNumbers
    {
        List<int> numbers = new List<int>();
        Random rnd = new Random();
        int counter = 0;

        public void GenerateNumbers()
        {
            Console.WriteLine("Quanti numeri vuoi generare? (il numero massimo è 99)");
            string response = Console.ReadLine();
            if (int.TryParse(response, out int NamesNumber))
            {
                if (NamesNumber <= 99)
                { 
                    for (int i = 0; i < NamesNumber; i++)
                    {
                        int randomNumber = rnd.Next(1, 100);
                        numbers.Add(randomNumber);
                        Console.WriteLine(numbers[i]);
                    }
                    Sum();
                    AverageNum();
                }
                else
                {
                    Console.WriteLine("Inserisci un numero inferiore a 99");
                }
            }
            else
            {
                Console.WriteLine("Inserisci un numero valido");
                GenerateNumbers();
            }
        }

        public void Sum()
        {
            foreach (int i in numbers)
            {
                counter += i;
            }
            Console.WriteLine($"La somma dei numeri è {counter}");
        }

        public void AverageNum()
        {
            double average = numbers.Average();
            Console.WriteLine($"La media dei numeri è {average}");
        }
    }
}
