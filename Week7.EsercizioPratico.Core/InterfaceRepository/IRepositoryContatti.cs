using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Week7.EsercizioPratico.Core.Entites;

namespace Week7.EsercizioPratico.Core.InterfaceRepository
{
    public interface IRepositoryContatti : IRepository<Contatto>
    {
        public Contatto GetById(int id);
        public bool Delete(Contatto item);
    }
}
