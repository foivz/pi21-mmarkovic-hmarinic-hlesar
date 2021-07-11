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
    public partial class ZaposleniciForm : Form
    {
        public ZaposleniciForm()
        {
            InitializeComponent();
        }

        private void ZaposleniciForm_Load(object sender, EventArgs e)
        {
            korisnikBindingSource.DataSource = Korisnik.DohvatiZaposlenike();
            ulogaBindingSource.DataSource = Uloga.DohvatiSveUloga();
        }

        private void IzlazButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void noviZaposlenikButton_Click(object sender, EventArgs e)
        {
            RegistracijaForm zaposlenikFrom = new RegistracijaForm();
            zaposlenikFrom.ShowDialog();
            OsvjeziZaposlenike();
        }

        private void AzurirajButton_Click(object sender, EventArgs e)
        {
            Korisnik selektiraniKorisnik = zaposleniciDataGridView.CurrentRow.DataBoundItem as Korisnik;
            RegistracijaForm zaposlenikAzuriranjeFrom = new RegistracijaForm(selektiraniKorisnik);
            zaposlenikAzuriranjeFrom.ShowDialog();
            OsvjeziZaposlenike();
        }

        private void ObrisiZaposlenikaButton_Click(object sender, EventArgs e)
        {
            Korisnik selektiraniKorisnik = zaposleniciDataGridView.CurrentRow.DataBoundItem as Korisnik;
            selektiraniKorisnik.ObrisiZaposlenika(selektiraniKorisnik.Id);
            OsvjeziZaposlenike();
        }

        private void OsvjeziZaposlenike()
        {
            korisnikBindingSource.Clear();
            korisnikBindingSource.DataSource = Korisnik.DohvatiZaposlenike();
        }
    }
}
