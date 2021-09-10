﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week7.EsercizioPratico.Core.Entites
{
    public class Indirizzo
    {
        public int IndirizzoID { get; set; }
        public string Tipologia { get; set; }
        public string Via { get; set; }
        public string Citta { get; set; }
        public int CAP { get; set; }
        public string  Provincia { get; set; }
        public string Nazione { get; set; }

        public int ContattoID { get; set; }
        public Contatto Contatto { get; set; }

        public override string ToString()
        {
            return $"Indirizzo: {IndirizzoID}\tTipologia: {Tipologia}\tVia: {Via}\tCittà: {Citta}\n Cap: {CAP}\n Provincia: {Provincia}\n Nazione: {Nazione}\t Contatto: {Contatto.ToString()}\n";
        }

    }
}