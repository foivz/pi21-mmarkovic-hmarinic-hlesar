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

namespace Registracija_zaposlenika
{
    public partial class RegistracijaForm : Form
    {
        private Korisnik ucitaniKorisnik;
        public RegistracijaForm()
        {
            InitializeComponent();
        }

        public RegistracijaForm(Korisnik korisnik)
        {
            InitializeComponent();
            ucitaniKorisnik = korisnik;
        }

        private void RegistracijaForm_Load(object sender, EventArgs e)
        {
            if (ucitaniKorisnik != null)
            {
                imeTextBox.Text = ucitaniKorisnik.Ime;
                prezimeTextBox.Text = ucitaniKorisnik.Prezime;
                oibTextBox.Text = ucitaniKorisnik.OIB.ToString();
                kontaktBrojTextBox.Text = ucitaniKorisnik.KontaktBroj;
                emailTextBox.Text = ucitaniKorisnik.Email;
                korimeTextBox.Text = ucitaniKorisnik.KorisnickoIme;
                lozinkaTextBox.Text = ucitaniKorisnik.Lozinka;
                mjestoTextBox.Text = ucitaniKorisnik.Mjesto;
                adresaTextBox.Text = ucitaniKorisnik.Adresa;
                ibanTextBox.Text = ucitaniKorisnik.IBAN;
                if (ucitaniKorisnik.IdUloga == 2)
                {
                    administratorRadioButton.Checked = true;
                }
                else
                {
                    skladistarRadioButton.Checked = true;
                }
            }
            else
            {
                skladistarRadioButton.Checked = true;
            }
        }

        private void ponistiButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void spremiButton_Click(object sender, EventArgs e)
        {
            int idUcitanogKorisnika;
            if (ucitaniKorisnik == null)
            {
                idUcitanogKorisnika = 0;
            }
            else
            {
                idUcitanogKorisnika = ucitaniKorisnik.Id;
            }

            string provjeraUnosa = ProvjeraUnosa();
            if (provjeraUnosa == "")
            {
                if (Korisnik.SpremiZaposlenika(idUcitanogKorisnika, imeTextBox.Text, prezimeTextBox.Text, oibTextBox.Text, kontaktBrojTextBox.Text, emailTextBox.Text,
                korimeTextBox.Text, lozinkaTextBox.Text, mjestoTextBox.Text, adresaTextBox.Text, ibanTextBox.Text, OdabranaUloga()))
                {
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Korisničko ime je zauzeto!");
                }
            }
            else
            {
                MessageBox.Show(provjeraUnosa);
            }    
        }

        private string ProvjeraUnosa()
        {
            string upozorenje = "";
            bool popunjeno = true;
            foreach (Control item in this.Controls)
            {
                if (item is TextBox)
                {
                    if (item.Text == "")
                    {
                        popunjeno = false;
                        break;
                    }
                }
            }
            if (!popunjeno)
            {
                upozorenje += "Nisu popunjena sva polja!\n";
            }

            bool oibFormat = true;
            string znamenke = "0123456789";
            foreach (char item in oibTextBox.Text)
            {
                if (!znamenke.Contains(item))
                {
                    oibFormat = false;
                    break;
                }
            }
            if (oibFormat == false || oibTextBox.Text.Length != 11)
            {
                upozorenje += "OIB nije u dobrom formatu!\n";
            }

            return upozorenje;
        }

        private int OdabranaUloga()
        {
            if (skladistarRadioButton.Checked)
            {
                return 3;
            }
            else
            {
                return 2;
            }
        }

        private void generirajKorimeButton_Click(object sender, EventArgs e)
        {
            if(imeTextBox.Text == "" || prezimeTextBox.Text == "")
            {
                MessageBox.Show("Ime i prezime moraju biti popunjeni!");
            }
            else
            {
                korimeTextBox.Text = Generator.GenerirajKorisnickoIme(imeTextBox.Text, prezimeTextBox.Text);
            }         
        }

        private void generirajLozinkuButton_Click(object sender, EventArgs e)
        {
            lozinkaTextBox.Text = Generator.GenerirajLozinku();
        }
    }
}
