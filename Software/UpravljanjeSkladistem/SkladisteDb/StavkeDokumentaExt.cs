using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkladisteDb
{
    public partial class StavkeDokumenta
    {

        public string NazivRobe { get; set; }
        public string OpisRobe { get; set; }
        public string NazivMjerneJedinica { get; set; }
        public double UkupnaCijena {
            get { return (double)JedinicnaCijena * (double)Kolicina; }
            set { }
        }
    }
}
