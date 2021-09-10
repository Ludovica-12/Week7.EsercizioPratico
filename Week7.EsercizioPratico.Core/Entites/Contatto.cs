using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week7.EsercizioPratico.Core.Entites
{
    public class Contatto
    {
        public int ContattoID { get; set; }
        public string Nome { get; set; }
        public string  Cognome { get; set; }

        public List<Indirizzo> Indirizzi { get; set; } = new List<Indirizzo>();

        public override string ToString()
        {
            return $"Contatto: {ContattoID}\tNome: {Nome}\tCognome: {Cognome}";
        }
    }
}
