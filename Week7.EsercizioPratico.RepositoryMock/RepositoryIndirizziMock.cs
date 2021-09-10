using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Week7.EsercizioPratico.Core.Entites;
using Week7.EsercizioPratico.Core.InterfaceRepository;

namespace Week7.EsercizioPratico.RepositoryMock
{
    public class RepositoryIndirizziMock : IRepositoryIndirizzi
    {
        public static List<Indirizzo> Indirizzi = new List<Indirizzo>()
        {
            new Indirizzo{Tipologia = "Domicilio", Via = "Nazionale", Citta = "Roma", CAP = 00182, Provincia = "RM", Nazione = "Italia"},
            new Indirizzo{Tipologia = "Residenza", Via = "Roma", Citta = "Milano", CAP = 00145, Provincia = "MI", Nazione = "Italia"},
        };

        public Indirizzo Add(Indirizzo indirizzo)
        {
            if(Indirizzi.Count() == 0)
            {
                indirizzo.ContattoID = 1;
            }
            else
            {
                indirizzo.ContattoID = Indirizzi.Max(i => i.ContattoID) + 1;
            }

            Indirizzi.Add(indirizzo);
            return indirizzo;
        }

        public List<Indirizzo> GetAll()
        {
            return Indirizzi;
        }

    }
}
