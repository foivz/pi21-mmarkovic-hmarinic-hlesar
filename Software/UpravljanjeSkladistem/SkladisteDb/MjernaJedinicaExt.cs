using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkladisteDb
{
    public partial class MjernaJedinica
    {
        public override string ToString()
        {
            return $"{Naziv} [{Kratica}]";
        }

        public static void NovaMjernaJedinica(MjernaJedinica mjernaJedinca)
        {
            using (var context = new SkladisteDatabase())
            {
                context.MjernaJedinicas.Add(mjernaJedinca);
                context.SaveChanges();
            }
        }

        public static List<MjernaJedinica> DohvatiMjerneJedinice()
        {
            using (var context = new SkladisteDatabase())
            {
                var query = from mj in context.MjernaJedinicas
                            select mj;

                return query.ToList();
            }
        }

        public static MjernaJedinica DohvatiMjernuJedinicuPoIdu(int id)
        {
            using (var context = new SkladisteDatabase())
            {
                var query = from mj in context.MjernaJedinicas
                            where mj.Id == id
                            select mj;

                return query.Single();
            }
        }
    }
}
