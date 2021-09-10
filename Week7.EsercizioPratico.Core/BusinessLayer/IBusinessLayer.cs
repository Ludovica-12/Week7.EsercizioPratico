using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Week7.EsercizioPratico.Core.Entites;

namespace Week7.EsercizioPratico.Core.BusinessLayer
{
    public interface IBusinessLayer
    {
        //Visualizza contatti
        public List<Contatto> GetAllContatti();
        //Inserisci nuovo contatto
        public string InserisciNuovoContatto(Contatto nuovoContatto);
        //Aggiungi nuovo indirizzo
        public string AggiungiIndirizzo(Indirizzo nuovoIndirizzo);
        //Elimina contatto
        public string EliminaContatto(int contattoDaEliminare);

    }
}
