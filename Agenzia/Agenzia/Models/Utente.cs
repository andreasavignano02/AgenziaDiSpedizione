using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Agenzia.Models
{
    public class Utente
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string CodiceFiscale { get; set; }
        public string PartitaIVA { get; set; }
    }
}