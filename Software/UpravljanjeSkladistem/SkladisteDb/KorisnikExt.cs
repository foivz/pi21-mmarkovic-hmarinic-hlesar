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
    }
}
