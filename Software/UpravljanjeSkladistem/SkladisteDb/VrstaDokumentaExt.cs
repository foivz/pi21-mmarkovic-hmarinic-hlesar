using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkladisteDb
{
    public partial class VrstaDokumenta
    {

        public override string ToString()
        {
            return Naziv;
        }
        public static List<VrstaDokumenta> DohvatiSveVrste()
        {
            using (var context = new SkladisteDatabase())
            {
                var query = from vd in context.VrstaDokumentas
                            select vd;

                return query.ToList();
            }
        }

        public static List<VrstaDokumenta> DohvatiVrstuPoNazivu(string naziv)
        {
            using (var context = new SkladisteDatabase())
            {
                var query = from vd in context.VrstaDokumentas
                            where vd.Naziv.ToLower() == naziv.ToLower()
                            select vd;

                return query.ToList();
            }
        }
    }
}
