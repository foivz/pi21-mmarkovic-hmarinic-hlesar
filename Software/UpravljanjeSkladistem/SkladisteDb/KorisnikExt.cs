using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkladisteDb
{
    public partial class Korisnik
    {
        public override string ToString()
        {
            return $"{Prezime} {Ime}";
        }

        public static List<Korisnik> DohvatiSveKorisnike()
        {
            using (var context = new SkladisteDatabase())
            {
                var query = from kor in context.Korisniks
                            select kor;

                return query.ToList();
            }
        }

        public static List<Korisnik> DohvatiKorisnikePremaUlozi(Uloga uloga)
        {
            using (var context = new SkladisteDatabase())
            {
                var query = from kor in context.Korisniks
                            where kor.IdUloga == uloga.Id
                            select kor;

                return query.ToList();
            }
        }

        public static Korisnik DohvatiKorisnikaZaPrijavu(string korime, string lozinka)
        {
            Korisnik trazeniKorisnik = new Korisnik();

            using (var context = new SkladisteDatabase())
            {
                var query = from kor in context.Korisniks
                            where kor.IdUloga > 1
                            select kor;
                foreach (Korisnik item in query.ToList())
                {
                    if (item.KorisnickoIme == korime && item.Lozinka == lozinka)
                    {
                        trazeniKorisnik = item;
                    }
                }
            }
            return trazeniKorisnik;
        }

        public static List<Korisnik> DohvatiZaposlenike()
        {
            using (var context = new SkladisteDatabase())
            {
                var query = from kor in context.Korisniks.Include("Uloga")
                            where kor.IdUloga > 1
                            select kor;
                return query.ToList();
            }
        }

        public static bool SpremiZaposlenika(int id, string ime, string prezime, string oib, string kontaktBroj, string email,
            string korime, string lozinka, string mjesto, string adresa, string iban, int idUloga)
        {
            if (ProvjeriKorime(id, korime))
            {
                using (var context = new SkladisteDatabase())
                {
                    if (id == 0)
                    {
                        Korisnik noviKorisnik = new Korisnik()
                        {
                            Ime = ime,
                            Prezime = prezime,
                            OIB = long.Parse(oib),
                            KontaktBroj = kontaktBroj,
                            Email = email,
                            KorisnickoIme = korime,
                            Lozinka = lozinka,
                            Mjesto = mjesto,
                            Adresa = adresa,
                            IBAN = iban,
                            IdUloga = idUloga
                        };
                        context.Korisniks.Add(noviKorisnik);
                        context.SaveChanges();
                    }
                    else
                    {
                        Korisnik zaposlenik = context.Korisniks.First(x => x.Id == id);
                        if (zaposlenik != null)
                        {
                            zaposlenik.Ime = ime;
                            zaposlenik.Prezime = prezime;
                            zaposlenik.OIB = long.Parse(oib);
                            zaposlenik.KontaktBroj = kontaktBroj;
                            zaposlenik.Email = email;
                            zaposlenik.KorisnickoIme = korime;
                            zaposlenik.Lozinka = lozinka;
                            zaposlenik.Mjesto = mjesto;
                            zaposlenik.Adresa = adresa;
                            zaposlenik.IBAN = iban;
                            zaposlenik.IdUloga = idUloga;
                            context.SaveChanges();
                        }
                    }
                }
                return true;
            }
            else
            {
                return false;
            }
        }

        public void ObrisiZaposlenika(int id)
        {
            using (var context = new SkladisteDatabase())
            {
                Korisnik korisnikBrisanje = context.Korisniks.First(x => x.Id == id);
                context.Korisniks.Remove(korisnikBrisanje);
                context.SaveChanges();
            }
        }

        private static bool ProvjeriKorime(int id, string korime)
        {
            if (DohvatiZaposlenike().Exists(x => x.KorisnickoIme == korime) && id == 0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}
