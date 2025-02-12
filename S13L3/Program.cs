using S13L3.models;

//Esercizio 1

//Console.WriteLine("Per aprire il conto inserisci i tuoi dati ed esegui un versamento di almeno 1000€");
//Console.WriteLine("Inserisci nome: ");
//string name = Console.ReadLine();
//Console.WriteLine("Inserisci cognome: ");
//string surname = Console.ReadLine();

//int balance;
//bool validBalance = false;


//do
//{
//    Console.WriteLine("Inserisci somma per il versamento: ");
//    string input = Console.ReadLine();
//    if (int.TryParse(input, out balance))
//    {
//        if (balance >= 1000)
//        {
//            validBalance = true;
//        }
//        else
//        {
//            Console.WriteLine("La somma da lei inserita non è sufficiente per l'apertura del conto, inserire nuovamente.");
//        }
//    }
//    else
//    {
//        Console.WriteLine("Per favore, inserisci un numero valido.");
//    }
//} while (!validBalance);

//BankAccount bankAccount = new BankAccount();

//bankAccount.OpenAccount(name, surname, balance);
//bankAccount.Operation();




//Esercizio 2

//NamesArray names = new NamesArray();

//names.Input();
//names.Output();




//Esercizio 3

RandomNumbers numbers = new RandomNumbers();

numbers.GenerateNumbers();