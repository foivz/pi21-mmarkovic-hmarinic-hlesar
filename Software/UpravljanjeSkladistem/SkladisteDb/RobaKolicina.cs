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

        public RobaKolicina(RobaNaLokaciji zapis)
        {
            Id = zapis.Roba.Id;
            Kolicina = zapis.Kolicina;
            MjernaJedinica = zapis.Roba.MjernaJedinica;
            Naziv = zapis.Roba.Naziv;
        }

        public RobaKolicina() { }

        public static List<RobaKolicina> DohvatiSvuRobuRK()
        {
            List<RobaKolicina> roba = new List<RobaKolicina>();

            using (var context = new SkladisteDatabase())
            {
                var query = from rnl in context.RobaNaLokacijis
                            select rnl;

                List<RobaNaLokaciji> robaNaLokaciji = query.ToList();

                foreach (var zapis in robaNaLokaciji)
                {
                    RobaKolicina pronadeniZapis = roba.Find(x => x.Id == zapis.Roba.Id);
                    if (pronadeniZapis == null)
                    {
                        roba.Add(new RobaKolicina(zapis));
                    }
                    else
                    {
                        pronadeniZapis.Kolicina += zapis.Kolicina;
                    }
                }

            }
            return roba;
        }

        public static RobaKolicina DohvatiRobuPoNazivuRK(string naziv)
        {
            using (var context = new SkladisteDatabase())
            {
                var query = from r in context.Robas
                            where r.Naziv.ToLower().Contains(naziv.ToLower())
                            select r;

                try
                {
                    Roba dohvacenaRoba = query.Single();
                    var robaLokacijaQuery = from rnl in context.RobaNaLokacijis
                                            where rnl.IdRoba == dohvacenaRoba.Id
                                            select rnl;

                    RobaKolicina returnMe = null;

                    foreach (var zapis in robaLokacijaQuery.ToList())
                    {
                        if (returnMe == null)
                        {
                            returnMe = new RobaKolicina(zapis);
                        }
                        else
                        {
                            returnMe.Kolicina += zapis.Kolicina;
                        }
                    }
                    return returnMe;
                }
                catch (Exception)
                {
                    throw new NepronadenaVrijednostException($"Nije pronađena ni jedna roba s unesenim nazivom [{naziv}]!");
                }
            }
        }

        public static List<RobaKolicina> DohvatiRobuPoNazivuILokacijiRK(string naziv, Lokacija lokacija)
        {
            using (var context = new SkladisteDatabase())
            {
                var query = from rnl in context.RobaNaLokacijis
                            where rnl.IdLokacija == lokacija.Id && rnl.Roba.Naziv.ToLower().Contains(naziv.ToLower())
                            select new RobaKolicina
                            {
                                Id = rnl.IdRoba,
                                Kolicina = rnl.Kolicina,
                                MjernaJedinica = rnl.Roba.MjernaJedinica,
                                Naziv = rnl.Roba.Naziv
                            };

                return query.ToList();
            }
        }
    }
}
