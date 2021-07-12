using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkladisteDb
{
    public partial class RobaNaLokaciji
    {
        public static List<RobaNaLokaciji> DohvatiRobuNaLokaciji(Lokacija lokacija)
        {
            using (var context = new SkladisteDatabase())
            {
                var query = from rnl in context.RobaNaLokacijis.Include("Lokacija").Include("Roba")
                            where rnl.IdLokacija == lokacija.Id
                            select rnl;
                return query.ToList();
            }
        }

        public static void AzurirajRobu (RobaNaLokaciji robaNaLokaciji, int kolicina)
        {
            using (var context = new SkladisteDatabase())
            {
                context.RobaNaLokacijis.Attach(robaNaLokaciji);
                robaNaLokaciji.Kolicina += kolicina;
                if (robaNaLokaciji.Kolicina == 0)
                {
                    context.RobaNaLokacijis.Remove(robaNaLokaciji);
                }
                context.SaveChanges();
            }
        }
    }
}
