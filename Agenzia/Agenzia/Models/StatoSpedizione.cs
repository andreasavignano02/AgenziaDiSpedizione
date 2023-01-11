using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Agenzia.Models
{
    public class StatoSpedizione
    {
        public int Id { get; set; }
        public string Partenza { get; set; }
        public string Meta { get; set; }
        public string Consegnato { get; set; }
    }
}