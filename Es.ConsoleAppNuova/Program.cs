// See https://aka.ms/new-console-template for more information
using EserWeek4.Core.BusinessLayer;
using EseWeek4.RepositoryEF.RepositoryEF;

Console.WriteLine("Hello, World!");
Console.WriteLine("*****Gestione Spese*****");

//private static readonly IBusinessLayer mBl = new MainBusinessLayer(new RepositorySpeseEF());
//ho un errore in mBL

bool quit = false;
do
{
    Console.WriteLine($"-------Menu--------");
    Console.WriteLine();
    Console.WriteLine("[ 1 ] - Inserire una nuova Spesa\n");
    Console.WriteLine("[ 2 ] - Approva Spesa\n");
    Console.WriteLine("[ 3 ] - Cancella Spesa Esistente\n");
    Console.WriteLine("[ 4 ] - Mostra elenco Spese Approvate\n");
    Console.WriteLine("[ 5 ] - Mostra l'elenco delle spese di uno specifico utente\n");
    Console.WriteLine("[ 6 ] - Mostra il totale delle spese per categoria\n");
    Console.WriteLine("[ q ] - QUIT\n");


    // scelta utente
    Console.Write("> ");
    string scelta = Console.ReadLine();
    Console.WriteLine();

    switch (scelta)
    {
        case "1":
         
            break;
        case "2":
         
            break;
        case "3":
           
            break;
        case "4":
           
            break;
        case "5":
            Console.WriteLine("Inserire il nome utente: ");
            string utente = Console.ReadLine();
         
            break;
        case "6":
            //ConnectedMode.TotaleSpeseCategoriaSceltaDallUtente();
            
            break;
        case "q":
            quit = true;
            break;
        default:
            Console.WriteLine("Comando sconosciuto.");
            break;
    }

} while (!quit);
