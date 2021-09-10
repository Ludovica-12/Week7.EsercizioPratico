using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Week7.EsercizioPratico.Core.Entites;
using Week7.EsercizioPratico.Core.InterfaceRepository;

namespace Week7.EsercizioPratico.RepositoryMock
{
    public class RepositoryContattiMock : IRepositoryContatti
    {
        public static List<Contatto> Contatti = new List<Contatto>()
        {
            new Contatto{ContattoID = 1, Nome = "Mario", Cognome = "Rossi"},
            new Contatto{ContattoID = 2, Nome = "Paola", Cognome = "Gialli"},
        };

        public Contatto Add(Contatto contatti)
        {
            if(Contatti.Count() ==0)
            {
                contatti.ContattoID = 1;
            }
            else
            {
                contatti.ContattoID = Contatti.Max(c => c.ContattoID) + 1;
            }
            Contatti.Add(contatti);
            return contatti;
        }

        public bool Delete(Contatto contatti)
        {
            Contatti.Remove(contatti);
            return true;
        }

        public List<Contatto> GetAll()
        {
            return Contatti;
        }

        public Contatto GetById(int id)
        {
            return Contatti.Find(c => c.ContattoID == id);
        }
    }
}
