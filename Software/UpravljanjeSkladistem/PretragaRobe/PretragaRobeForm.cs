using AdresiranjeRobe;
using SkladisteDb;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PretragaRobe
{
    public partial class PretragaRobeForm : Form
    {
        private Lokacija zadnjeOdabranaLokacija;
        public Roba zadnjeOdabranaRoba;
        public PretragaRobeForm()
        {
            InitializeComponent();
        }
        public PretragaRobeForm(bool zaOdabir)
        {
            InitializeComponent();
            odaberiRobuButton.Visible = true;
        }

        private void PretragaRobeForm_Load(object sender, EventArgs e)
        {
            odabranaLokacijaLabel.Text = "Lokacija nije odabrana";
            robaBindingSource.DataSource = Roba.DohvatiSvuRobu();
            lokacijaOznaceneRobeLabel.Text = "Nema označene robe";
        }

        private void pretragaRobeButton_Click(object sender, EventArgs e)
        {
            List<Roba> roba = new List<Roba>();
            string nazivRobe = nazivRobeTextBox.Text.Trim();
            string minimumKolicina = minimumTextBox.Text.Trim();
            string maksimumKolicina = maksimumTextBox.Text.Trim();

            if (nazivRobe != String.Empty)
            {
                roba = Roba.DohvatiRobuPoNazivu(nazivRobe);
                if (roba.Count == 0)
                {
                    MessageBox.Show($"Nije pronađena ni jedna roba s unesenim nazivom [{nazivRobe}]!");
                    return;
                }
            }
            else
            {
                roba = Roba.DohvatiSvuRobu();
            }

            try
            {
                int minimumBroj = ParsirajUnosBroja(minimumKolicina);
                int maksimumBroj = ParsirajUnosBroja(maksimumKolicina);

                if (minimumBroj == 0 && maksimumBroj == 0)
                {
                    robaBindingSource.DataSource = roba;
                }
                else
                {
                    robaBindingSource.DataSource = FiltrirajRobu(minimumBroj, maksimumBroj, roba);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Uneseni minimum ili maksimum količine nije cijeli broj!");
            }
        }

        private List<Roba> FiltrirajRobu(int min, int max, List<Roba> roba)
        {
            List<Roba> filtriranaRoba = new List<Roba>();

            if (max == 0)
            {
                foreach (var zapis in roba)
                {
                    if (zapis.Kolicina >= min)
                    {
                        filtriranaRoba.Add(zapis);
                    }
                }
            }
            else
            {
                foreach(var zapis in roba)
                {
                    if (zapis.Kolicina >= min && zapis.Kolicina <= max)
                    {
                        filtriranaRoba.Add(zapis);
                    }
                }
            }


            return filtriranaRoba;
        }

        private int ParsirajUnosBroja(string unos)
        {
            if (unos == String.Empty)
            {
                return 0;
            }
            else
            {
                return int.Parse(unos);
            }
        }

        private void izborLokacijeButton_Click(object sender, EventArgs e)
        {
            OdabirLokacijaForm odabirLokacijaForm = new OdabirLokacijaForm();
            odabirLokacijaForm.ShowDialog();
            
            if (odabirLokacijaForm.OdabranaLokacija != null)
            {
                zadnjeOdabranaLokacija = odabirLokacijaForm.OdabranaLokacija;
                odabranaLokacijaLabel.Text = zadnjeOdabranaLokacija.Naziv;
                robaBindingSource.DataSource = UkljuciRobuPodlokacija(zadnjeOdabranaLokacija);
            }
        }

        private List<Roba> UkljuciRobuPodlokacija(Lokacija lokacija)
        {
            List<Roba> roba = new List<Roba>();
            lokacija.DohvatiRobuNaSvimPodlokacijama(ref roba);
            return roba;
        }
        private void pretraziRobuNaOdabranojLokacijiButton_Click(object sender, EventArgs e)
        {
            string nazivRobe = nazivRobeTextBox.Text.Trim();
            string minimumKolicina = minimumTextBox.Text.Trim();
            string maksimumKolicina = maksimumTextBox.Text.Trim();

            if (zadnjeOdabranaLokacija == null)
            {
                MessageBox.Show(("Lokacija nije odabrana!"));
                return;
            }

            List<Roba> roba = UkljuciRobuPodlokacija(zadnjeOdabranaLokacija);


            if (nazivRobe != String.Empty)
            {
                List<Roba> tempRoba = new List<Roba>();
                foreach (var r in roba)
                {
                    if (r.Naziv.ToLower().Contains(nazivRobe.ToLower()))
                    {
                        tempRoba.Add(r);
                    }
                }

                roba = tempRoba;

                if (roba.Count == 0)
                {
                    MessageBox.Show(($"Nije pronađena ni jedna roba s unesenim nazivom [{nazivRobe}]!"));
                    return;
                }
            }

            try
            {
                int minimumBroj = ParsirajUnosBroja(minimumKolicina);
                int maksimumBroj = ParsirajUnosBroja(maksimumKolicina);

                if (minimumBroj == 0 && maksimumBroj == 0)
                {
                    robaBindingSource.DataSource = roba;
                }
                else
                {
                    robaBindingSource.DataSource = FiltrirajRobu(minimumBroj, maksimumBroj, roba);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Uneseni minimum ili maksimum količine nije cijeli broj!");
            }
        }

        private void prikaziSvuRobuButton_Click(object sender, EventArgs e)
        {
            robaBindingSource.DataSource = Roba.DohvatiSvuRobu();
        }

        private void robaBindingSource_CurrentChanged(object sender, EventArgs e)
        {
            if (robaBindingSource.Current as Roba != null)
            {
                zadnjeOdabranaRoba = robaBindingSource.Current as Roba;

                List<Roba> oznacenaRobaZapisi = new List<Roba>();
                foreach (var zapis in zadnjeOdabranaRoba.DohvaceneLokacije)
                {
                    oznacenaRobaZapisi.Add(zapis.DohvatiRobuNaLokaciji(zadnjeOdabranaRoba));
                }

                oznacenaRobaBindingSource.DataSource = oznacenaRobaZapisi;
            }
            else
            {
                oznacenaRobaBindingSource.DataSource = null;
            }
        }

        private void odaberiRobu_Click(object sender, EventArgs e)
        {
            if (zadnjeOdabranaRoba == null)
            {
                MessageBox.Show("Niste odabrali robu!");
                return;
            }

            Close();
        }

        private void oznacenaRobaBindingSource_CurrentChanged(object sender, EventArgs e)
        {
            Roba oznacenaRoba = oznacenaRobaBindingSource.Current as Roba;
            if (oznacenaRoba != null)
            {
                Lokacija pocetnaLokacija = oznacenaRoba.NalaziSeNa;
                List<Lokacija> lok = new List<Lokacija>();
                pocetnaLokacija.DohvatiPutDoBazicneLokacije(ref lok);

                string lokacijaString = "";
                for (int i = lok.Count - 1; i >= 0; i--)
                {
                    lokacijaString += $"{lok[i].Naziv} -> ";
                }
                lokacijaString += $"{oznacenaRoba.NalaziSeNa.Naziv}";
                lokacijaOznaceneRobeLabel.Text = lokacijaString;
            }
            else
            {
                lokacijaOznaceneRobeLabel.Text = "Nema označene robe";
            }
        }

        private void PretragaRobeForm_HelpRequested(object sender, HelpEventArgs hlpevent)
        {
            Help.ShowHelp(this, "../../../Pomoc/f1-pomoc.chm", HelpNavigator.TopicId, "1030");
        }
    }
}
