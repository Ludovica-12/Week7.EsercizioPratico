using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week7.EsercizioPratico.Core.InterfaceRepository
{
    public interface IRepository<T>
    {
        public List<T> GetAll();
        public T Add(T item);
    }
}
