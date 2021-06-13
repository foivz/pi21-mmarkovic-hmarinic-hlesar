using AdresiranjeRobe;
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
                // robaBindingSource.DataSource = Roba.DohvatiSvuRobuNaLokaciji(zadnjeOdabranaLokacija);
                robaBindingSource.DataSource = UkljuciRobuPodlokacija(zadnjeOdabranaLokacija);
            }
        }

        private List<Roba> UkljuciRobuPodlokacija(Lokacija lokacija)
        {
            List<Roba> roba = new List<Roba>();
            lokacija.DohvatiRobuNaSvimPodlokacijama(ref roba);
            return roba;
        }

        /*
        private void pretraziRobuNaOdabranojLokacijiButton_Click(object sender, EventArgs e)
        {
            List<Roba> roba = new List<Roba>();
            string nazivRobe = nazivRobeTextBox.Text.Trim();
            string minimumKolicina = minimumTextBox.Text.Trim();
            string maksimumKolicina = maksimumTextBox.Text.Trim();

            if (zadnjeOdabranaLokacija == null)
            {
                MessageBox.Show(("Lokacija nije odabrana!"));
                return;
            }

            if (nazivRobe != String.Empty)
            {
                roba = Roba.DohvatiRobuPoNazivuILokaciji(nazivRobe, zadnjeOdabranaLokacija);

                if (roba.Count == 0)
                {
                    MessageBox.Show(($"Nije pronađena ni jedna roba s unesenim nazivom [{nazivRobe}]!"));
                    return;
                }
            }
            else
            {
                roba = Roba.DohvatiSvuRobuNaLokaciji(zadnjeOdabranaLokacija);
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
        } */

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
    }
}
