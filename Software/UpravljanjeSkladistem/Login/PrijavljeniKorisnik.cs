using SkladisteDb;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Login
{
    public static class PrijavljeniKorisnik
    {
        private static Korisnik prijavljeniKorisnik = new Korisnik();

        public static bool PrijaviKorisnika(string korime, string lozinka)
        {
            Korisnik trazeniKorisnik = new Korisnik();
            trazeniKorisnik = SkladisteDb.Korisnik.DohvatiKorisnikaZaPrijavu(korime, lozinka);
            if (trazeniKorisnik.Id != 0)
            {
                prijavljeniKorisnik = trazeniKorisnik;
                return true;
            }
            else
            {
                return false;
            }
        }

        public static void OdjaviKorisnika()
        {
            prijavljeniKorisnik = null;
        }

        public static bool Prijavljen()
        {
            if (prijavljeniKorisnik == null)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public static int GetId()
        {
            return prijavljeniKorisnik.Id;
        }

        public static string GetNaziv()
        {
            return prijavljeniKorisnik.Ime + " " + prijavljeniKorisnik.Prezime;
        }

        public static string GetUloga()
        {
            if (prijavljeniKorisnik != null)
            {
                if (prijavljeniKorisnik.IdUloga == 2)
                {
                    return "Administrator";
                }
                else
                {
                    return "Skladištar";
                }
            }
            return "";
        }

    }
}
