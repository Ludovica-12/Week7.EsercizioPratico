using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Week7.EsercizioPratico.Core.Entites;
using Week7.EsercizioPratico.Core.InterfaceRepository;

namespace Week7.EsercizioPratico.RepositoryEF.RepositoryEF
{
    public class RepositoryIndirizziEF : IRepositoryIndirizzi
    {
        public Indirizzo Add(Indirizzo item)
        {
            using (var ctx = new Context())
            {
                ctx.Indirizzi.Add(item);
                ctx.SaveChanges();
            }
            return item;
        }

        public List<Indirizzo> GetAll()
        {
            using (var ctx = new Context())
            {
                return ctx.Indirizzi.ToList();
            }
        }
    }
}
