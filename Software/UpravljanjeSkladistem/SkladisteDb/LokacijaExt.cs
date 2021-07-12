using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkladisteDb
{
    partial class Lokacija
    {

        public static void DodajLokaciju(Lokacija lokacija)
        {
            using (var context = new SkladisteDatabase())
            {
                context.Lokacijas.Add(lokacija);
                context.SaveChanges();
            }
        }

        public static List<Lokacija> DohvatiSveLokacije()
        {
            using (var context = new SkladisteDatabase())
            {
                var query = from sveLokacije in context.Lokacijas.Include("RobaNaLokacijis")
                            select sveLokacije;

                return query.ToList();
            }
        }

        public static List<Lokacija> DohvatiBazicneLokacije()
        {
            using (var context = new SkladisteDatabase())
            {
                var query = from sveLokacije in context.Lokacijas.Include("RobaNaLokacijis")
                            where sveLokacije.Nadlokacija == null
                            select sveLokacije;

                return query.ToList();
            }
        }

        public static List<Lokacija> DohvatiLokavijePremaNazivu(string naziv)
        {
            using (var context = new SkladisteDatabase())
            {
                var query = from sveLokacije in context.Lokacijas.Include("RobaNaLokacijis")
                            where sveLokacije.Naziv.Contains(naziv)
                            select sveLokacije;

                return query.ToList();
            }
        }

        public static Lokacija DohvatiLokacijuPremaIdu(int id)
        {
            using (var context = new SkladisteDatabase())
            {
                var query = from sveLokacije in context.Lokacijas.Include("RobaNaLokacijis")
                            where sveLokacije.Id == id
                            select sveLokacije;

                return query.Single();
            }
        }

        public void DohvatiRobuNaSvimPodlokacijama(ref List<Roba> roba)
        {
            foreach (var zapis in Roba.DohvatiSvuRobuNaLokaciji(this))
            {
                Roba pronadeniZapis = roba.Find(x => x.Id == zapis.Id);
                if (pronadeniZapis == null)
                {
                    roba.Add(zapis);
                }
                else
                {
                    pronadeniZapis.Kolicina += zapis.Kolicina;
                    pronadeniZapis.DohvaceneLokacije.AddRange(zapis.DohvaceneLokacije);
                }
            }

            foreach (var podlokacija in this.DohvatiPodlokacije())
            {
                podlokacija.DohvatiRobuNaSvimPodlokacijama(ref roba);
            }
        }

        public static void PremjestiRobu(RobaNaLokaciji robaNaLokaciji, Lokacija lokacija, int kolicina)
        {
            using (var context = new SkladisteDatabase())
            {
                 var query = from rnl in context.RobaNaLokacijis
                                where robaNaLokaciji.IdRoba == rnl.IdRoba && lokacija.Id == rnl.IdLokacija
                                select rnl;
                RobaNaLokaciji postojecaRobaNaLokaciji = query.ToList()[0];

                if (postojecaRobaNaLokaciji != null)
                {
                    context.RobaNaLokacijis.Attach(postojecaRobaNaLokaciji);
                    postojecaRobaNaLokaciji.Kolicina += kolicina;
                }
                else
                {
                    RobaNaLokaciji novaRobaNaLokaciji = new RobaNaLokaciji();
                    novaRobaNaLokaciji.IdLokacija = lokacija.Id;
                    novaRobaNaLokaciji.IdRoba = robaNaLokaciji.IdRoba;
                    novaRobaNaLokaciji.Kolicina = kolicina;
                    context.RobaNaLokacijis.Add(novaRobaNaLokaciji);
                }
                context.SaveChanges();

                if (robaNaLokaciji.Kolicina - kolicina == 0)
                {
                    context.RobaNaLokacijis.Attach(robaNaLokaciji);
                    context.RobaNaLokacijis.Remove(robaNaLokaciji);
                }
                else
                {
                    context.RobaNaLokacijis.Attach(robaNaLokaciji);
                    robaNaLokaciji.Kolicina -= kolicina;
                }
                context.SaveChanges();
            }
        }

        private static bool ProvjeriPostojanjeRobeNaLokaciji(int idRoba, int id)
        {
            throw new NotImplementedException();
        }

        public List<Lokacija> DohvatiPodlokacije()
        {
            using (var context = new SkladisteDatabase())
            {
                var query = from podlokacije in context.Lokacijas
                            where podlokacije.Nadlokacija == this.Id
                            select podlokacije;

                return query.ToList();
            }
        }

        public bool ObrisiLokaciju()
        {
            using (var context = new SkladisteDatabase())
            {
                context.Lokacijas.Attach(this);
                context.Lokacijas.Remove(this);
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

        public Roba DohvatiRobuNaLokaciji(Roba roba)
        {
            using (var context = new SkladisteDatabase())
            {
                var query = from rnl in context.RobaNaLokacijis.Include("Lokacija")
                            where rnl.IdRoba == roba.Id && rnl.IdLokacija == this.Id
                            select new
                            {
                                Id = rnl.Roba.Id,
                                MjernaJedinica = rnl.Roba.MjernaJedinica,
                                NazivMjerneJedinice = rnl.Roba.MjernaJedinica1.Naziv,
                                Naziv = rnl.Roba.Naziv,
                                Kolicina = rnl.Kolicina,
                                Opis = rnl.Roba.Opis,
                                NalaziSeNa = rnl.Lokacija,
                            };

                var zapis = query.Single();

                Roba returnMe = new Roba
                {
                    Id = zapis.Id,
                    MjernaJedinica = zapis.MjernaJedinica,
                    NazivMjerneJedinice = zapis.NazivMjerneJedinice,
                    Naziv = zapis.Naziv,
                    Kolicina = zapis.Kolicina,
                    Opis = zapis.Opis,
                    NalaziSeNa = zapis.NalaziSeNa,
                };

                return returnMe;
            }
        }

        public void DohvatiPutDoBazicneLokacije(ref List<Lokacija> putDoBazicneLokacije)
        {
            using (var context = new SkladisteDatabase())
            {
                var query = from lok in context.Lokacijas
                            where lok.Id == this.Nadlokacija
                            select lok;

                List<Lokacija> nadlokacija = query.ToList();
                if (nadlokacija.Count > 0)
                {
                    putDoBazicneLokacije.Add(nadlokacija[0]);
                    nadlokacija[0].DohvatiPutDoBazicneLokacije(ref putDoBazicneLokacije);
                }
            }
        }

        public static List<Lokacija> DohvatiSvePodlokacije(Lokacija lokacija)
        {
            List<Lokacija> podlokacije = new List<Lokacija>();
            using (var context = new SkladisteDatabase())
            {
                podlokacije.AddRange(context.Lokacijas.ToList().FindAll(x => x.Nadlokacija == lokacija.Id));
                int l = podlokacije.Count();
                for (int i = 0; i < l; i++)
                {
                    podlokacije.AddRange(DohvatiSvePodlokacije(podlokacije[i]));
                }
            }
            return podlokacije;
            
        }

        public override string ToString()
        {
            return Naziv;
        }
    }
}
