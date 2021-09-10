using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Week7.EsercizioPratico.Core.BusinessLayer;
using Week7.EsercizioPratico.RepositoryMock;
using Xunit;

namespace Week7.EsercizioPratico.Test
{
    public class EsercizioTest
    {
        [Fact]
        public void Test1()
        {
            //ARRAGE
            MainBusinessLayer mbl = new MainBusinessLayer(new RepositoryContattiMock(), new RepositoryIndirizziMock());

            ////ACT
            //string newContatto = mbl.InserisciNuovoContatto(nuovoContatto);

            //// ASSERT
            //Assert.Equal("Nuovo contatto inserito correttamente", newContatto);

        }
    }
}
