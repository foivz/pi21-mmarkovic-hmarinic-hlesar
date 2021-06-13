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
        public PretragaRobeForm()
        {
            InitializeComponent();
        }

        private void PretragaRobeForm_Load(object sender, EventArgs e)
        {
            odabranaLokacijaLabel.Text = "Lokacija nije odabrana";
            robaKolicinaBindingSource.DataSource = RobaKolicina.DohvatiSvuRobu();
        }

        private void pretragaRobeButton_Click(object sender, EventArgs e)
        {
            List<RobaKolicina> roba = new List<RobaKolicina>();
            string nazivRobe = nazivRobeTextBox.Text.Trim();
            string minimumKolicina = minimumTextBox.Text.Trim();
            string maksimumKolicina = maksimumTextBox.Text.Trim();

            if (nazivRobe != String.Empty)
            {
                try
                {
                    RobaKolicina prodenaRoba = RobaKolicina.DohvatiRobuPoNazivu(nazivRobe);
                    roba.Add(prodenaRoba);
                }
                catch (NepronadenaVrijednostException err)
                {
                    MessageBox.Show(err.Poruka);
                    return;
                }
            }
            else
            {
                roba = RobaKolicina.DohvatiSvuRobu();
            }

            try
            {
                int minimumBroj = ParsirajUnosBroja(minimumKolicina);
                int maksimumBroj = ParsirajUnosBroja(maksimumKolicina);

                if (minimumBroj == 0 && maksimumBroj == 0)
                {
                    robaKolicinaBindingSource.DataSource = roba;
                }
                else
                {
                    robaKolicinaBindingSource.DataSource = FiltrirajRobu(minimumBroj, maksimumBroj, roba);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Uneseni minimum ili maksimum količine nije cijeli broj!");
            }
        }

        private List<RobaKolicina> FiltrirajRobu(int min, int max, List<RobaKolicina> roba)
        {
            List<RobaKolicina> filtriranaRoba = new List<RobaKolicina>();

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
                robaKolicinaBindingSource.DataSource = zadnjeOdabranaLokacija.DohvatiSvuRobuNaLokaciji();
            }
        }

        private void pretraziRobuNaOdabranojLokacijiButton_Click(object sender, EventArgs e)
        {
            List<RobaKolicina> roba = new List<RobaKolicina>();
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
                roba = RobaKolicina.DohvatiRobuPoNazivuILokaciji(nazivRobe, zadnjeOdabranaLokacija);

                if (roba.Count == 0)
                {
                    MessageBox.Show(($"Nije pronađena ni jedna roba s unesenim nazivom [{nazivRobe}]!"));
                    return;
                }
            }
            else
            {
                roba = zadnjeOdabranaLokacija.DohvatiSvuRobuNaLokaciji();
            }

            try
            {
                int minimumBroj = ParsirajUnosBroja(minimumKolicina);
                int maksimumBroj = ParsirajUnosBroja(maksimumKolicina);

                if (minimumBroj == 0 && maksimumBroj == 0)
                {
                    robaKolicinaBindingSource.DataSource = roba;
                }
                else
                {
                    robaKolicinaBindingSource.DataSource = FiltrirajRobu(minimumBroj, maksimumBroj, roba);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Uneseni minimum ili maksimum količine nije cijeli broj!");
            }
        }
    }
}
