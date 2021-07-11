using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Registracija_zaposlenika
{
    public static class Generator
    {
        public static string GenerirajKorisnickoIme(string ime, string prezime)
        {
            string korime = ime.ToLower()[0] + PrezimeString(prezime);
            return ZamjeniHrvZnakove(korime);
        }

        private static string PrezimeString(string prezime)
        {
            if(prezime.Length <= 8)
            {
                return prezime.ToLower();
            }
            else
            {
                return prezime.Substring(0, 8).ToLower();
            }
        }

        private static string ZamjeniHrvZnakove(string korime)
        {
            korime = korime.Replace('č', 'c');
            korime = korime.Replace('ć', 'c');
            korime = korime.Replace('đ', 'd');
            korime = korime.Replace('š', 's');
            korime = korime.Replace('ž', 'z');
            return korime;
        }

        public static string GenerirajLozinku()
        {
            string lozinka = "";
            Random rand = new Random();
            for (int i = 0; i < 4; i++)
            {
                lozinka += (char)('a' + rand.Next(0, 26));
            }
            for (int i = 0; i < 4; i++)
            {
                lozinka += rand.Next(0,10).ToString();
            }
            return lozinka;
        }
    }
}
