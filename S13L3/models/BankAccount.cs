namespace S13L3.models
{
    internal class BankAccount
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public int Balance { get; set; }

        public void OpenAccount(string name, string surname, int balance)
        {
                Name = name;
                Surname = surname;
                Balance = balance;
                Console.WriteLine($"Conto aperto con successo! Benvenuto {name} {surname}. Saldo iniziale: {balance}€");
        }

        public void Operation()
        {
            Console.WriteLine("Desidera effettuare altre operazioni? SI/NO");
            string response = Console.ReadLine();
            if (response.ToLower() == "si")
            {
                Console.WriteLine("Quale operazione desidera eseguire?");
                string response2 = Console.ReadLine();
                switch (response2)
                {
                    case "1":
                        AddBalance();
                        break;

                    case "2":
                        RemoveBalance();
                        break;

                    default:
                        Console.WriteLine("Inserisci un valore valido");
                        Operation();
                        break;
                }   
            }
            else if (response.ToLower() == "no")
            {
                Console.WriteLine("Arrivederci");
            }
            else
            {
                Console.WriteLine("inserisci una risposta valida");
                Operation();
            }
        }

        public void AddBalance()
        {
            Console.WriteLine("Inserisci la somma da vesare sul conto: ");
            string input = Console.ReadLine();
            if (int.TryParse(input, out int add))
            {
                Balance = Balance + add;
                Console.WriteLine($"Il tuo saldo: {Balance}€");
                Operation();
            }
            else 
            {
                Console.WriteLine("Inserisci una cifra valida!");
                AddBalance();
            }
        }

        public void RemoveBalance()
        {
            Console.WriteLine("Inserisci la somma da vesare sul conto: ");
            string input = Console.ReadLine();
            if (int.TryParse(input, out int remove))
            {
                if (Balance >= remove)
                {
                    Balance = Balance - remove;
                    Console.WriteLine($"Il tuo saldo: {Balance}€");
                    Operation();
                }
                else
                {
                    Console.WriteLine("Non puoi prelevare una quantità maggiore del saldo disponibile");
                    RemoveBalance();
                }
            }
            else
            {
                Console.WriteLine("Inserisci una cifra valida!");
                RemoveBalance();
            }
        }
    }
}
