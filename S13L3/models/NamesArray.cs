
namespace S13L3.models
{
    internal class NamesArray
    {
        string[] MyArray1 =
        {
            "Alessandra",
            "Marco",
            "Sofia",
            "Leonardo",
            "Giulia",
            "Tommaso",
            "Martina",
            "Francesco",
            "Emma",
            "Luca",
            "Chiara",
            "Matteo",
            "Aurora",
            "Gabriele",
            "Federica",
            "Antonio",
            "Valentina",
            "Edoardo",
            "Laura",
            "Andrea"
        };

        public void Input()
        {
            Console.WriteLine("Quanti nomi vuoi generare? (il numero massimo è 20)");
            string response = Console.ReadLine();
            if (int.TryParse(response, out int NamesNumber))
            {
                if (NamesNumber <=20)
                {
                    Array.Resize(ref MyArray1, NamesNumber);
                }
                else
                {
                    Console.WriteLine("Inserisci un numero inferiore a 20");
                }
            } 
            else
            {
                Console.WriteLine("Inserisci un numero valido");
                Input();
            }
        }

        public void Output()
        {
            Console.WriteLine("Quale nome stai cercando?");
            string response = Console.ReadLine();
            for (int i = 0; i < MyArray1.Length; i++) 
            {
                if (MyArray1[i].ToLower() == response.ToLower())
                {
                    Console.WriteLine($"Il nome {MyArray1[i]} è presente nella lista");
                    return;
                }
            }
            Console.WriteLine("Il nome che stai cercando non è nella lista");
        }
    }
}
