using Login;
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

namespace KreiranjePrimki
{
    public partial class KreirajDokumentForm : Form
    {
        private List<StavkeDokumenta> stavkeDokumenta = new List<StavkeDokumenta>();
        private string nazivVrsteDokumenta;
        public KreirajDokumentForm(string nazivVrsteDoku = "")
        {
            InitializeComponent();
            if (nazivVrsteDoku != "")
            {
                nazivVrsteDokumenta = nazivVrsteDoku;
                vrstaDokumentaComboBox.Enabled = false;
            }
        }

        private void KreirajDokumentForm_Load(object sender, EventArgs e)
        {
            if (nazivVrsteDokumenta != "")
            {
                List<VrstaDokumenta> vrste = VrstaDokumenta.DohvatiSveVrste();
                vrstaDokumentaComboBox.DataSource = vrste;
                int i = vrste.FindIndex(x => x.Naziv.ToLower() == nazivVrsteDokumenta.ToLower());
                vrstaDokumentaComboBox.SelectedIndex = i;
            }

            List<Uloga> uloga = Uloga.DohvatiUloguPoNazivu("klijent");
            if (uloga.Count == 0)
            {
                MessageBox.Show("Nema mogućih klijenata! Forma se zatvara!");
                Close();
            }

            List<Korisnik> klijenti = Korisnik.DohvatiKorisnikePremaUlozi(uloga[0]);

            odabirKlijentaComboBox.DataSource = klijenti;
            robaBindingSource.DataSource = Roba.DohvatiSvuRobu();
        }

        private void dodajStavkuButton_Click(object sender, EventArgs e)
        {
            Roba odabranaRoba = robaBindingSource.Current as Roba;
            if (odabranaRoba == null)
            {
                MessageBox.Show("Potrebno je odabrati barem jednu robu!");
                return;
            }
            string kolicina = kolicinaTextBox.Text.Trim();
            string jedinicnaCijena = jedinicnaCijenaTextBox.Text.Trim();

            int kolicinaBroj = 0;
            double jedinicnaCijenaBroj = 0;

            try
            {
                kolicinaBroj = int.Parse(kolicina);
            }
            catch (Exception)
            {
                MessageBox.Show("Količina nije cijeli broj!");
                return;
            }

            try
            {
                jedinicnaCijenaBroj = double.Parse(jedinicnaCijena);
            }
            catch (Exception)
            {
                MessageBox.Show("Jedinična cijena nije broj!");
                return;
            }

            StavkeDokumenta novaStavka = new StavkeDokumenta
            {
                Kolicina = kolicinaBroj,
                JedinicnaCijena = jedinicnaCijenaBroj,
                IdRoba = odabranaRoba.Id,
                NazivRobe = odabranaRoba.Naziv,
                OpisRobe = odabranaRoba.Opis,
            };

            if (stavkeDokumenta.Exists(x => x.IdRoba == novaStavka.IdRoba))
            {
                MessageBox.Show("Već postoji odabrana stavka!");
                return;
            }
            else
            {
                stavkeDokumenta.Add(novaStavka);
                OsvjeziOdabraneStavke();
            }
        }

        private void OsvjeziOdabraneStavke()
        {
            stavkeDokumentaBindingSource.DataSource = null;
            stavkeDokumentaBindingSource.DataSource = stavkeDokumenta;
        }

        private void stavkeDokumentaBindingSource_CurrentChanged(object sender, EventArgs e)
        {
            StavkeDokumenta odabranaStavka = stavkeDokumentaBindingSource.Current as StavkeDokumenta;
            if (odabranaStavka != null)
            {
                izmjeniKolicinaTextBox.Text = odabranaStavka.Kolicina.ToString();
                izmjeniJedinicnaCijenaTextBox.Text = odabranaStavka.JedinicnaCijena.ToString();
            }
        }

        private void izmjeniStavkuButton_Click(object sender, EventArgs e)
        {
            StavkeDokumenta odabranaStavka = stavkeDokumentaBindingSource.Current as StavkeDokumenta;
            if (odabranaStavka == null)
            {
                MessageBox.Show("Potrebno je odabrati barem jednu stavku!");
                return;
            }
            string kolicina = izmjeniKolicinaTextBox.Text.Trim();
            string jedinicnaCijena = izmjeniJedinicnaCijenaTextBox.Text.Trim();

            int kolicinaBroj = 0;
            double jedinicnaCijenaBroj = 0;

            try
            {
                kolicinaBroj = int.Parse(kolicina);
            }
            catch (Exception)
            {
                MessageBox.Show("Količina nije cijeli broj!");
                return;
            }

            try
            {
                jedinicnaCijenaBroj = double.Parse(jedinicnaCijena);
            }
            catch (Exception)
            {
                MessageBox.Show("Jedinična cijena nije broj!");
                return;
            }

            odabranaStavka.Kolicina = kolicinaBroj;
            odabranaStavka.JedinicnaCijena = jedinicnaCijenaBroj;
            OsvjeziOdabraneStavke();
        }

        private void obrisiStavkuButton_Click(object sender, EventArgs e)
        {
            StavkeDokumenta odabranaStavka = stavkeDokumentaBindingSource.Current as StavkeDokumenta;
            if (odabranaStavka == null)
            {
                MessageBox.Show("Potrebno je odabrati barem jednu stavku!");
                return;
            }

            stavkeDokumenta.Remove(odabranaStavka);
            OsvjeziOdabraneStavke();
        }

        private void spremiDokumentButton_Click(object sender, EventArgs e)
        {
            Korisnik klijent = odabirKlijentaComboBox.SelectedItem as Korisnik;
            VrstaDokumenta vrsta = vrstaDokumentaComboBox.SelectedItem as VrstaDokumenta;
            Dokument noviDokument = new Dokument
            {
                Datum = datumIzradeDatePicker.Value,
                Klijent = klijent.Id,
                Unio = PrijavljeniKorisnik.GetId(),
                Vrsta = vrsta.Id
            };

            Dokument.DodajDokument(noviDokument);

            foreach (var stavka in stavkeDokumenta)
            {
                noviDokument.DodajStavkuDokumenta(stavka);
            }
            Close();
        }

        private void KreirajDokumentForm_HelpRequested(object sender, HelpEventArgs hlpevent)
        {
            if (nazivVrsteDokumenta == "primka")
            {
                Help.ShowHelp(this, "../../../Pomoc/f1-pomoc.chm", HelpNavigator.TopicId, "1041");
            }
            else
            {
                Help.ShowHelp(this, "../../../Pomoc/f1-pomoc.chm", HelpNavigator.TopicId, "1051");
            }
            
        }
    }
}
