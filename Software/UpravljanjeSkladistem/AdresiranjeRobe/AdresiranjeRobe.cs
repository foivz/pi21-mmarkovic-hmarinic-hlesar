using SkladisteDb;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdresiranjeRobe
{
    public partial class AdresiranjeRobe : Form
    {
        public AdresiranjeRobe()
        {
            InitializeComponent();
        }

        private void PrikaziPregledLokacija()
        {
            using (var context = new SkladisteDatabase())
            {
                var query = from sveLokacije in context.Lokacijas.Include("RobaNaLokacijis")
                            select sveLokacije;

                lokacijaBindingSource.DataSource = query.ToList();
                nadlokacijaComboBox.DataSource = query.ToList();
            }
        }

        private void AdresiranjeRobe_Load(object sender, EventArgs e)
        {
            PrikaziPregledLokacija();
        }

        private void dodajLokacijuButton_Click(object sender, EventArgs e)
        {
            string naziv = nazivNoveLokacijeTextBox.Text.Trim();
            if (naziv == String.Empty)
            {
                MessageBox.Show("Lokacija mora imati naziv!");
                return;
            }

            int? nadLokacija;
            if (nemaNadlokacijeCheckBox.Checked)
            {
                nadLokacija = null;
            }
            else
            {
                /* Lokacija nl = nadlokacijaComboBox.SelectedItem as Lokacija;
                if (nl == null)
                {
                    nadLokacija = null;
                }
                else
                {
                    nadLokacija = nl.Id;
                } */
                Lokacija odabranaLokacija = lokacijaBindingSource.Current as Lokacija;
                if (odabranaLokacija != null)
                {
                    nadLokacija = odabranaLokacija.Id;
                }
                else
                {
                    nadLokacija = null;
                }
            }

            Lokacija lokacija = new Lokacija
            {
                Naziv = naziv,
                Nadlokacija = nadLokacija,
            };

            using (var context = new SkladisteDatabase())
            {
                context.Lokacijas.Add(lokacija);
                context.SaveChanges();
                PrikaziPregledLokacija();
                MessageBox.Show("Uspješno dodana nova lokacija");
            }
        }

        private void nemaNadlokacijeCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (nadlokacijaComboBox.Enabled)
            {
                nadlokacijaComboBox.Enabled = false;
            } 
            else
            {
                nadlokacijaComboBox.Enabled = true;
            }
        }

       private void lokacijaBindingSource_CurrentChanged(object sender, EventArgs e)
        {
            DohvatiRobu();
            PrikaziPodlokacije();
        }

        private void DohvatiRobu()
        {
            Lokacija odabranaLokacija = lokacijaBindingSource.Current as Lokacija;
            if (robaNaOdredenojLokacijiCheckBox.Checked)
            {
                using (var context = new SkladisteDatabase())
                {
                    var query = from rnl in context.RobaNaLokacijis
                                where rnl.IdLokacija == odabranaLokacija.Id
                                select new
                                {
                                    Id = rnl.Roba.Id,
                                    Naziv = rnl.Roba.Naziv,
                                    Kolicina = rnl.Kolicina,
                                    MjernaJedinica = rnl.Roba.MjernaJedinica,
                                };

                    robaBindingSource.DataSource = query.ToList();
                }
            }
            else
            {
                List<RobaKolicina> roba = new List<RobaKolicina>();
                DohvatiSvuRobu(odabranaLokacija, ref roba);
                robaBindingSource.DataSource = roba;
            }
        }
        private void DohvatiSvuRobu(Lokacija odabranaLokacija, ref List<RobaKolicina> roba)
        {
           if (odabranaLokacija.RobaNaLokacijis.Count > 0)
           {
                List<RobaKolicina> dohvacenaRoba = odabranaLokacija.DohvatiRobuNaLokaciji();
                foreach(var zapis in dohvacenaRoba)
                {
                    RobaKolicina pronadeniZapis = roba.Find(x => x.Id == zapis.Id);
                    if (pronadeniZapis == null)
                    {
                        roba.Add(zapis);
                    }
                    else
                    {
                        pronadeniZapis.Kolicina += zapis.Kolicina;
                    }
                }
           }

            using (var context = new SkladisteDatabase())
            {
                var query = from lok in context.Lokacijas
                            where lok.Nadlokacija == odabranaLokacija.Id
                            select lok;

                foreach (Lokacija lokacija in query.ToList())
                {
                    DohvatiSvuRobu(lokacija, ref roba);
                }
            }
        }

        private void robaNaOdredenojLokacijiCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            DohvatiRobu();
        }

        private void PrikaziPodlokacije() 
        {
            Lokacija odabranaLokacija = lokacijaBindingSource.Current as Lokacija;
            using (var context = new SkladisteDatabase())
            {
                var query = from podL in context.Lokacijas
                            where podL.Nadlokacija == odabranaLokacija.Id
                            select podL;

                podlokacijaBindingSource.DataSource = query.ToList();
            }
        }
    }
}
