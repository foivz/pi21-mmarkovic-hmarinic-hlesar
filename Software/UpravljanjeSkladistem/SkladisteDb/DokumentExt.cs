using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkladisteDb
{
    public partial class Dokument
    {
        public static List<Dokument> DohvatiDokumentePremaNazivu(string naziv)
        {
            using (var context = new SkladisteDatabase())
            {
                var query = from dok in context.Dokuments.Include("Korisnik")
                            where dok.VrstaDokumenta.Naziv.ToLower().Contains(naziv.ToLower())
                            select dok;

                return query.ToList();
            }
        }

        public static void DodajDokument(Dokument dokument)
        {
            using (var context = new SkladisteDatabase())
            {
                context.Dokuments.Add(dokument);
                Console.WriteLine(dokument);
                context.SaveChanges();
            }
        }

        public List<StavkeDokumenta> DohvatiStavkeDokumenta()
        {
            using (var context = new SkladisteDatabase())
            {
                var query = from stavke in context.StavkeDokumentas.Include("Roba")
                            where stavke.IdDokument == this.Id
                            select stavke;

                return query.ToList();
            }
        }
        public void DodajStavkuDokumenta(StavkeDokumenta stavka)
        {
            using (var context = new SkladisteDatabase())
            {
                stavka.IdDokument = this.Id;
                context.StavkeDokumentas.Add(stavka);
                context.SaveChanges();
            }
        }
    }
}
