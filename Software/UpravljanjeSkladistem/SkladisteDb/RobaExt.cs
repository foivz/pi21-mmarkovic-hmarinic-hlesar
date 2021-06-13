using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkladisteDb
{
    public partial class Roba
    {
        public string NazivMjerneJedinice { get; set; }
        public string Kolicina { get; set; }
        public static void NovaRoba(Roba roba)
        {
            using (var context = new SkladisteDatabase())
            {
                context.Robas.Add(roba);
                context.SaveChanges();
            }
        }

        public static List<Roba> DohvatiSvuRobu()
        {
            using (var context = new SkladisteDatabase())
            {
                var query = from r in context.Robas
                            join mj in context.MjernaJedinicas on r.MjernaJedinica equals mj.Id
                            select new
                            {
                                Id = r.Id,
                                Naziv = r.Naziv,
                                Opis = r.Opis,
                                MjernaJedinica = r.MjernaJedinica,
                                NazivMjerneJedinice = mj.Naziv,
                            };

                List<Roba> roba = new List<Roba>();

                foreach (var zapis in query)
                {
                    roba.Add(new Roba { Id = zapis.Id, Naziv = zapis.Naziv, Opis = zapis.Opis, NazivMjerneJedinice = zapis.NazivMjerneJedinice, MjernaJedinica = zapis.MjernaJedinica });
                }

                return roba;
            }
        }

        public static void UrediRobu(Roba odabranaRoba, string noviNaziv, string noviOpis, int novaMjernaJedinicaId)
        {
            using (var context = new SkladisteDatabase())
            {
                context.Robas.Attach(odabranaRoba);

                odabranaRoba.Naziv = noviNaziv;
                odabranaRoba.Opis = noviOpis;
                odabranaRoba.MjernaJedinica = novaMjernaJedinicaId;

                context.SaveChanges();
            }
        }

        public bool ObrisiRobu()
        {
            using (var context = new SkladisteDatabase())
            {
                context.Robas.Attach(this);
                context.Robas.Remove(this);
                try
                {
                    context.SaveChanges();
                    return true;
                }
                catch (Exception e)
                {
                    return false;
                }
            }
        }
    }
}
