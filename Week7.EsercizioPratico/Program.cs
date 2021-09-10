using System;
using Week7.EsercizioPratico.Core.BusinessLayer;
using Week7.EsercizioPratico.Core.Entites;
using Week7.EsercizioPratico.RepositoryEF.RepositoryEF;
using Week7.EsercizioPratico.RepositoryMock;

namespace Week7.EsercizioPratico
{
    class Program
    {
        //private static readonly IBusinessLayer bl = new MainBusinessLayer(new RepositoryContattiMock(), new RepositoryIndirizziMock());
        private static readonly IBusinessLayer bl = new MainBusinessLayer(new RepositoryContattiEF(), new RepositoryIndirizziEF());


        static void Main(string[] args)
        {
            bool continuare = true;

            Console.WriteLine("***BENVENUTO***");

            do
            {
                Console.WriteLine("\nPremi 1 per visualizzare tutti i contatti");
                Console.WriteLine("Premi 2 per aggiungere un nuovo contatto");
                Console.WriteLine("Premi 3 per aggiungere un indirizzo");
                Console.WriteLine("Premi 4 per eliminare un contatto senza indirizzo associato");
                Console.WriteLine("Premi 0 per uscire");
                Console.WriteLine();
                string scelta = Console.ReadLine();

                switch (scelta)
                {
                    case "1":
                        //Visualizzare contatti
                        VisualizzaContatti();
                        break;
                    case "2":
                        //Aggiungere contatto
                        AggiungiNuovoContatto();
                        break;
                    case "3":
                        //Aggiungere indirizzo
                        AggiungiNuovoIndirizzo();
                        break;
                    case "4":
                        //Elimina contatto
                        EliminaContatto();
                        break;
                    case "0":
                        Console.WriteLine("Ciao alla prossima");
                        continuare = false;
                        break;
                    default:
                        Console.WriteLine("Scelta sbagliata riprova");
                        break;
                }
            } while (continuare);
        }

        private static void EliminaContatto()
        {
            Console.WriteLine("***Elenco dei Contatti presenti");
            VisualizzaContatti();
            Console.WriteLine("Quale contatto vuoi eliminare? inserisci il numero del contatto");
            int id = int.Parse(Console.ReadLine());

            var esito = bl.EliminaContatto(id);
            Console.WriteLine(esito);

        }

        private static void AggiungiNuovoIndirizzo()
        {
            Console.WriteLine("***Inserisci i dati del nuovo indirizzo:");

            Console.WriteLine("Inserisci la tipologia:");
            string tipologia = Console.ReadLine();

            Console.WriteLine("Inserisci la via:");
            string via = Console.ReadLine();

            Console.WriteLine("Inserisci la città:");
            string citta = Console.ReadLine();

            Console.WriteLine("Inserisci il CAP:");
            int cap = int.Parse(Console.ReadLine());

            Console.WriteLine("Inserisci la provincia:");
            string provincia = Console.ReadLine();

            Console.WriteLine("Inserisci la nazione:");
            string nazione = Console.ReadLine();

            Console.WriteLine("Inserisci il numero del contatto che vuoi associare:");
            VisualizzaContatti();
            int contattoId = int.Parse(Console.ReadLine());

            Indirizzo nuovoIndirizzo = new Indirizzo();
            nuovoIndirizzo.Tipologia = tipologia;
            nuovoIndirizzo.Via = via;
            nuovoIndirizzo.Citta = citta;
            nuovoIndirizzo.CAP = cap;
            nuovoIndirizzo.Provincia = provincia;
            nuovoIndirizzo.Nazione = nazione;
            nuovoIndirizzo.ContattoID = contattoId;

            string esito = bl.AggiungiIndirizzo(nuovoIndirizzo);
            Console.WriteLine(esito);

        }

        private static void AggiungiNuovoContatto()
        {
            Console.WriteLine("***Inserisci i dati del nuovo contatto:");

            Console.WriteLine("Inserisci il nome:");
            string nome = Console.ReadLine();

            Console.WriteLine("Inserisci il cognome:");
            string cognome = Console.ReadLine();

            Contatto nuovoContatto = new Contatto();
            nuovoContatto.Nome = nome;
            nuovoContatto.Cognome = cognome;

            var esito = bl.InserisciNuovoContatto(nuovoContatto);
            Console.WriteLine(esito);

        }

        private static void VisualizzaContatti()
        {
            var contatti = bl.GetAllContatti();
            if(contatti.Count == 0)
            {
                Console.WriteLine("Contatti non presenti");
            }
            else
            {
                Console.WriteLine("***In contatti presenti sono:\n");
                foreach(var c in contatti)
                {
                    Console.WriteLine(c.ToString());
                }
            }
        }
    }
}
