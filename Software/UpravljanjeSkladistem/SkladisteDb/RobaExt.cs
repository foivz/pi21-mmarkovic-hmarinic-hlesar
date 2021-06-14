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
        public int? Kolicina { get; set; }
        public List<Lokacija> DohvaceneLokacije = new List<Lokacija>();
        public Lokacija NalaziSeNa;

        public Roba(RobaNaLokaciji zapis)
        {
            Id = zapis.Roba.Id;
            Kolicina = zapis.Kolicina;
            MjernaJedinica = zapis.Roba.MjernaJedinica;
            Naziv = zapis.Roba.Naziv;
            NazivMjerneJedinice = zapis.Roba.MjernaJedinica1.Naziv;
        }

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
                    Roba novaRoba = new Roba
                    {
                        Id = zapis.Id,
                        Naziv = zapis.Naziv,
                        Opis = zapis.Opis,
                        NazivMjerneJedinice = zapis.NazivMjerneJedinice,
                        MjernaJedinica = zapis.MjernaJedinica,
                        Kolicina = 0,
                    };

                    var kolicinaQuery = from rnl in context.RobaNaLokacijis.Include("Lokacija")
                                        where rnl.IdRoba == novaRoba.Id
                                        select rnl;

                    foreach(var z in kolicinaQuery)
                    {
                        novaRoba.DohvaceneLokacije.Add(z.Lokacija);
                        novaRoba.NalaziSeNa = z.Lokacija;
                        novaRoba.Kolicina += z.Kolicina;
                    }

                    roba.Add(novaRoba);
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
                catch (Exception)
                {
                    return false;
                }
            }
        }

        public void DodajRobuNaLokaciju(Lokacija lokacija, int kolicina)
        {
            using (var context = new SkladisteDatabase())
            {
                var query = from rnl in context.RobaNaLokacijis
                            where rnl.IdLokacija == lokacija.Id && rnl.IdRoba == this.Id
                            select rnl;

                List<RobaNaLokaciji> zapisi = query.ToList();

                if (zapisi.Count == 0)
                {
                    context.RobaNaLokacijis.Add(new RobaNaLokaciji { IdRoba = this.Id, IdLokacija = lokacija.Id, Kolicina = kolicina });
                }
                else
                {
                    foreach(var zapis in query.ToList())
                    {
                        zapis.Kolicina += kolicina;
                    }
                }

                context.SaveChanges();
            }
        }

        public static List<Roba> DohvatiRobuPoNazivu(string naziv)
        {
            using (var context = new SkladisteDatabase())
            {
                var query = from r in context.Robas.Include("MjernaJedinica1")
                            where r.Naziv.ToLower().Contains(naziv.ToLower())
                            select r;

                List<Roba> svaDohvacenaRoba = query.ToList();
                List<Roba> returnMe = new List<Roba>();
                foreach (var dohvacenaRoba in svaDohvacenaRoba)
                {
                    dohvacenaRoba.Kolicina = 0;
                    dohvacenaRoba.NazivMjerneJedinice = dohvacenaRoba.MjernaJedinica1.Naziv;
                    returnMe.Add(dohvacenaRoba);
                    var robaLokacijaQuery = from rnl in context.RobaNaLokacijis.Include("Lokacija")
                                            where rnl.IdRoba == dohvacenaRoba.Id
                                            select rnl;

                    foreach (var zapis in robaLokacijaQuery.ToList())
                    {
                        dohvacenaRoba.DohvaceneLokacije.Add(zapis.Lokacija);
                        Roba zapisanaRoba = returnMe.Find(x => x.Id == zapis.IdRoba);
                        if (zapisanaRoba != null)
                        {
                            zapisanaRoba.Kolicina += zapis.Kolicina;
                        }
                    }
                }
                return returnMe;
            }
        }

        public static List<Roba> DohvatiRobuPoNazivuILokaciji(string naziv, Lokacija lokacija)
        {
            using (var context = new SkladisteDatabase())
            {
                var query = from rnl in context.RobaNaLokacijis.Include("Lokacija")
                            where rnl.IdLokacija == lokacija.Id && rnl.Roba.Naziv.ToLower().Contains(naziv.ToLower())
                            select new
                            {
                                Id = rnl.IdRoba,
                                Kolicina = rnl.Kolicina,
                                MjernaJedinica = rnl.Roba.MjernaJedinica,
                                NazivMjerneJedinice = rnl.Roba.MjernaJedinica1.Naziv,
                                Naziv = rnl.Roba.Naziv,
                                Opis = rnl.Roba.Opis,
                            };

                List<Roba> roba = new List<Roba>();
                foreach (var zapis in query.ToList())
                {
                    roba.Add(new Roba
                    {
                        Id = zapis.Id,
                        MjernaJedinica = zapis.MjernaJedinica,
                        NazivMjerneJedinice = zapis.NazivMjerneJedinice,
                        Naziv = zapis.Naziv,
                        Kolicina = zapis.Kolicina,
                        Opis = zapis.Opis,
                    });
                }

                return roba;
            }
        }

        public static List<Roba> DohvatiSvuRobuNaLokaciji(Lokacija lokacija)
        {
            using (var context = new SkladisteDatabase())
            {
                var query = from rnl in context.RobaNaLokacijis
                            where rnl.IdLokacija == lokacija.Id
                            select new
                            {
                                Id = rnl.Roba.Id,
                                MjernaJedinica = rnl.Roba.MjernaJedinica,
                                NazivMjerneJedinice = rnl.Roba.MjernaJedinica1.Naziv,
                                Naziv = rnl.Roba.Naziv,
                                Kolicina = rnl.Kolicina,
                                Opis = rnl.Roba.Opis,
                            };

                List<Roba> roba = new List<Roba>();
                foreach (var zapis in query.ToList())
                {
                    Roba novaRoba = new Roba
                    {
                        Id = zapis.Id,
                        MjernaJedinica = zapis.MjernaJedinica,
                        NazivMjerneJedinice = zapis.NazivMjerneJedinice,
                        Naziv = zapis.Naziv,
                        Kolicina = zapis.Kolicina,
                        Opis = zapis.Opis,
                    };
                    novaRoba.DohvaceneLokacije.Add(lokacija);
                    roba.Add(novaRoba);
                }

                return roba;
            }
        }

        public static Roba DovhatiRobuPoIdu(int id)
        {
            using (var context = new SkladisteDatabase())
            {
                var query = from roba in context.Robas
                            where roba.Id == id
                            select roba;

                return query.Single();
            }
        }
    }
}
