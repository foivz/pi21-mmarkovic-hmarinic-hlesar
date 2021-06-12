using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkladisteDb
{
    partial class Lokacija
    {
        public List<RobaKolicina> DohvatiRobuNaLokaciji()
        {
            using (var context = new SkladisteDatabase())
            {
                var query = from rnl in context.RobaNaLokacijis
                            where rnl.IdLokacija == this.Id
                            select new RobaKolicina
                            {
                                Id = rnl.Roba.Id,
                                MjernaJedinica = rnl.Roba.MjernaJedinica,
                                Naziv = rnl.Roba.Naziv,
                                Kolicina = rnl.Kolicina,
                            };

                return query.ToList();
            }
        }
        public override string ToString()
        {
            return Naziv;
        }
    }
}
