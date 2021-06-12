using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkladisteDb
{
    public class RobaKolicina
    {
        public int Id { get; set; }
        public Nullable<int> MjernaJedinica { get; set; }
        public string Naziv { get; set; }
        public Nullable<int> Kolicina { get; set; }
    }
}
