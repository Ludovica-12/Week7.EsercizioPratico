using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Week7.EsercizioPratico.Core.Entites;
using Week7.EsercizioPratico.Core.InterfaceRepository;

namespace Week7.EsercizioPratico.Core.BusinessLayer
{
    public class MainBusinessLayer : IBusinessLayer
    {
        private readonly IRepositoryContatti contattiRepo;
        private readonly IRepositoryIndirizzi indirizziRepo;

        public MainBusinessLayer(IRepositoryContatti contatti, IRepositoryIndirizzi indirizzi)
        {
            contattiRepo = contatti;
            indirizziRepo = indirizzi;

        }

        public string AggiungiIndirizzo(Indirizzo nuovoIndirizzo)
        {
            var contatto = contattiRepo.GetById(nuovoIndirizzo.ContattoID);
            if (contatto == null)
            {
                return "Numero Contatto errato o inesistente";
            }

            indirizziRepo.Add(nuovoIndirizzo);
            return "Indirizzo aggiunto correttamente";
        }

        public string EliminaContatto(int contattoDaEliminare)
        {
            Contatto contattoEsistente = contattiRepo.GetById(contattoDaEliminare);
            if (contattoEsistente == null)
            {
                return "Errore! Contatto errato o non presente";
            }
            var contattoAssociatoIndirizzo = GetAllIndirizzi().FirstOrDefault(a => a.ContattoID == contattoEsistente.ContattoID);
            if (contattoAssociatoIndirizzo != null)
            {
                return "Impossibile cancellare i contatto perchè risulta associato ad un indirizzo";
            }

            contattiRepo.Delete(contattoEsistente);
            return "Compilenti! Il contatto è stato eliminato con successo";
        }

        private List<Indirizzo> GetAllIndirizzi()
        {
            return indirizziRepo.GetAll();
        }

        public List<Contatto> GetAllContatti()
        {
            return contattiRepo.GetAll();
        }

        public string InserisciNuovoContatto(Contatto nuovoContatto)
        {
            Contatto contattoEsistente = contattiRepo.GetAll().FirstOrDefault(c => c.Nome == nuovoContatto.Nome && c.Cognome == nuovoContatto.Cognome);
            if(contattoEsistente != null)
            {
                return "Errore! Contatto non inserito correttamente";
            }

            contattiRepo.Add(nuovoContatto);
            return "Complimenti! Contatto inserito correttamente";
        }
    }
}
