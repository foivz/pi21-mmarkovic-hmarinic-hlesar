using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkladisteDb
{
    public partial class Uloga
    {
        public static List<Uloga> DohvatiSveUloga()
        {
            using (var context = new SkladisteDatabase())
            {
                var query = from uloga in context.Ulogas
                            select uloga;

                return query.ToList();
            }
        }

        public static List<Uloga> DohvatiUloguPoNazivu(string naziv)
        {
            using (var context = new SkladisteDatabase())
            {
                var query = from uloga in context.Ulogas
                            where uloga.Naziv.ToLower() == naziv.ToLower()
                            select uloga;

                return query.ToList();
            }
        }

        public static List<Uloga> DohvatiUlogeZaposlenika()
        {
            using (var context = new SkladisteDatabase())
            {
                var query = from uloga in context.Ulogas
                            where uloga.Id > 1
                            select uloga;

                return query.ToList();
            }
        }

        public override string ToString()
        {
            return Naziv;
        }
    }
}
