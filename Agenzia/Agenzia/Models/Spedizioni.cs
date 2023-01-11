using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Agenzia.Models
{
    public class Spedizioni
    {
        public int ID { get; set; }
        public string NomeArticolo { get; set; }
        public int NumeroIdentificativo { get; set; }
        public DateTime DataDiSpedizione { get; set; }
        public double Peso { get; set; }
        public string CittaDestinatario { get; set; }
        public string Indirizzo { get; set; }
        public string NomeDestinatario { get; set; }
        public decimal CostoArticolo { get; set; }
        public DateTime DataDiArrivo { get; set; } 
    }
}