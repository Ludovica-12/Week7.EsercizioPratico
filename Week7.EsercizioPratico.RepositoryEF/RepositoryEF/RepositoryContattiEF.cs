using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Week7.EsercizioPratico.Core.Entites;
using Week7.EsercizioPratico.Core.InterfaceRepository;

namespace Week7.EsercizioPratico.RepositoryEF.RepositoryEF
{
    public class RepositoryContattiEF : IRepositoryContatti
    {
        public Contatto Add(Contatto item)
        {
            using (var ctx = new Context())
            {
                ctx.Contatti.Add(item);
                ctx.SaveChanges();
            }
            return item;
        }

        public bool Delete(Contatto item)
        {
            using (var ctx = new Context())
            {
                ctx.Contatti.Remove(item);
                ctx.SaveChanges();
            }
            return true;
        }

        public List<Contatto> GetAll()
        {
            using (var ctx = new Context())
            {
                return ctx.Contatti.Include(c => c.Indirizzi).ToList();
            }
        }

        public Contatto GetById(int id)
        {
            using (var ctx = new Context())
            {
                return ctx.Contatti.Include(c => c.Indirizzi).FirstOrDefault(c => c.ContattoID == id);
            }
        }
    }
}
