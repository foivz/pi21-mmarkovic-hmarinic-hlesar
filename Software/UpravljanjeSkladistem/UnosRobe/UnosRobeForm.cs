using AdresiranjeRobe;
using PretragaRobe;
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

namespace UnosRobe
{
    public partial class UnosRobeForm : Form
    {

        private Lokacija odabranaLokacija;
        private Roba unosRobeLokacije;
        public UnosRobeForm()
        {
            InitializeComponent();
        }

        private void UnosRobeForm_Load(object sender, EventArgs e)
        {
            OsvjeziTablicu();
            OsvjeziMjerneJediniceComboBox();
        }

        private void dodajRobuButton_Click(object sender, EventArgs e)
        {
            string naziv = nazivRobeTextBox.Text.Trim();
            string opis = opisRobeTextBox.Text.Trim();
            MjernaJedinica mjernaJedinica = mjernaJedinicaComboBox.SelectedItem as MjernaJedinica;

            if (naziv == String.Empty)
            {
                MessageBox.Show("Roba mora imati naziv!");
                return;
            }
            if (mjernaJedinica == null)
            {
                MessageBox.Show("Roba mora imati mjernu jedinicu!");
                return;
            }

            Roba.NovaRoba(new Roba { Naziv = naziv, MjernaJedinica = mjernaJedinica.Id, Opis = opis });

            nazivRobeTextBox.Text = String.Empty;
            opisRobeTextBox.Text = String.Empty;
            OsvjeziTablicu();

            MessageBox.Show("Roba je uspješno dodana!");
        }

        private void dodajMjernuJedinicuButton_Click(object sender, EventArgs e)
        {
            string naziv = nazivMjerneJediniceTextBox.Text.Trim();
            string kratica = kraticaMjerneJediniceTextBox.Text.Trim();

            if (naziv == String.Empty)
            {
                MessageBox.Show("Mjerna jedinica mora imati naziv!");
                return;
            }
            else if (kratica == String.Empty)
            {
                MessageBox.Show("Mjerna jedinica mora imati kraticu!");
                return;
            }

            MjernaJedinica.NovaMjernaJedinica(new MjernaJedinica { Naziv = naziv, Kratica = kratica });

            nazivMjerneJediniceTextBox.Text = String.Empty;
            kraticaMjerneJediniceTextBox.Text = String.Empty;
            OsvjeziMjerneJediniceComboBox();

            MessageBox.Show("Mjerna jedinica je uspješno dodana");
        }

        private void OsvjeziMjerneJediniceComboBox()
        {
            mjernaJedinicaComboBox.DataSource = MjernaJedinica.DohvatiMjerneJedinice();
        }

        private void OsvjeziTablicu()
        {
            robaBindingSource.DataSource = Roba.DohvatiSvuRobu();
        }

        private void urediRobuButton_Click(object sender, EventArgs e)
        {
            Roba odabranaRoba = robaBindingSource.Current as Roba;
            if (odabranaRoba == null)
            {
                MessageBox.Show("Roba nije odabrana");
                return;
            }

            UrediForm urediForm = new UrediForm(odabranaRoba);
            urediForm.ShowDialog();
            
            if (urediForm.RobaUredena)
            {
                OsvjeziTablicu();
            }
        }

        private void obrisiRobuButton_Click(object sender, EventArgs e)
        {
            Roba odabranaRoba = robaBindingSource.Current as Roba;
            if (odabranaRoba == null)
            {
                MessageBox.Show("Roba nije odabrana");
                return;
            }

            if (odabranaRoba.ObrisiRobu())
            {
                MessageBox.Show("Roba je uspješno obrisana!");
                OsvjeziTablicu();
            }
            else
            {
                MessageBox.Show("Nije moguće obrisati robu sa skladišta, ima dodijeljenu lokaciju i količine!");
            }
        }

        private void robaBindingSource_CurrentChanged(object sender, EventArgs e)
        {
            Roba odabranaRoba = robaBindingSource.Current as Roba;
            if (odabranaRoba == null)
            {
                return;
            }
            unosRobeLokacije = odabranaRoba;
            PretpregledOdabraneRobe();
        }

        private void odabirLokacijeButton_Click(object sender, EventArgs e)
        {
            OdabirLokacijaForm f = new OdabirLokacijaForm();
            f.ShowDialog();
            
            if (f.OdabranaLokacija != null)
            {
                odabranaLokacija = f.OdabranaLokacija;
                odabranaLokacijaTextBox.Text = odabranaLokacija.Naziv;
            }
        }

        private void odabirRobeButton_Click(object sender, EventArgs e)
        {
            PretragaRobeForm f = new PretragaRobeForm(true);
            f.ShowDialog();
            unosRobeLokacije = f.zadnjeOdabranaRoba;
            PretpregledOdabraneRobe();
        }

        private void dodajNaLokacijuButton_Click(object sender, EventArgs e)
        {

            if (unosRobeLokacije == null)
            {
                MessageBox.Show("Roba nije odabrana!");
                return;
            }
            if (odabranaLokacija == null)
            {
                MessageBox.Show("Lokacija nije odabrana!");
                return;
            }

            string kolicina = kolicinaTextBox.Text.Trim();
            int kolicinaBroj = 0;
            try
            {
                kolicinaBroj = int.Parse(kolicina);
            }
            catch (Exception)
            {
                MessageBox.Show("Unesena količina nije cijeli broj!");
                return;
            }

            unosRobeLokacije.DodajRobuNaLokaciju(odabranaLokacija, kolicinaBroj);
            MessageBox.Show($"Roba [{unosRobeLokacije.Naziv}] je dodana na lokaciju [{odabranaLokacija.Naziv}] u količini [{kolicinaBroj}].");
        }

        private void PretpregledOdabraneRobe()
        {
            pregledNazivTextBox.Text = unosRobeLokacije.Naziv;
            pregledOpisTextBox.Text = unosRobeLokacije.Opis;
            pregledMjernaJedinicaTextBox.Text = unosRobeLokacije.NazivMjerneJedinice;
        }

        private void UnosRobeForm_HelpRequested(object sender, HelpEventArgs hlpevent)
        {
            Help.ShowHelp(this, "../../../Pomoc/f1-pomoc.chm", HelpNavigator.TopicId, "1010");
        }
    }
}
