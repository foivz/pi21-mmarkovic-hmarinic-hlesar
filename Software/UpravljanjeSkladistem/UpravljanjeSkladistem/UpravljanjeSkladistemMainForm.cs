using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UnosRobe;
using AdresiranjeRobe;
using PretragaRobe;
using KreiranjePrimki;
using Login;
using Registracija_zaposlenika;

namespace UpravljanjeSkladistem
{
    public partial class UpravljanjeSkladistemMainForm : Form
    {
        public UpravljanjeSkladistemMainForm()
        {
            InitializeComponent();
        }

        private void izlazButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void unosRobeButton_Click(object sender, EventArgs e)
        {
            UnosRobeForm unosRobe = new UnosRobeForm();
            unosRobe.ShowDialog();
        }

        private void adresiranjeRobeButton_Click(object sender, EventArgs e)
        {
            AdresiranjeRobeForm adresiranjeRobe = new AdresiranjeRobeForm();
            adresiranjeRobe.ShowDialog();
        }

        private void pretragaRobeButton_Click(object sender, EventArgs e)
        {
            PretragaRobeForm pretragaRobe = new PretragaRobeForm();
            pretragaRobe.ShowDialog();
        }

        private void kreiranjePrimkiButton_Click(object sender, EventArgs e)
        {
            PregledPrimkiForm pregledPrimki = new PregledPrimkiForm();
            pregledPrimki.ShowDialog();
        }

        private void UpravljanjeSkladistemMainForm_HelpRequested(object sender, HelpEventArgs hlpevent)
        {
            Help.ShowHelp(this, "../../../Pomoc/f1-pomoc.chm", HelpNavigator.TopicId, "1000");
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            LoginForm login = new LoginForm();
            login.ShowDialog();
            if (PrijavljeniKorisnik.Prijavljen())
            {
                nazivLabel.Text = PrijavljeniKorisnik.GetNaziv();
                ulogaLabel.Text = PrijavljeniKorisnik.GetUloga();
                prijavljeniKorisnikGroupBox.Visible = true;
                OsvjeziGumbe();
            }


        }

        private void odjavaButton_Click(object sender, EventArgs e)
        {
            PrijavljeniKorisnik.OdjaviKorisnika();
            prijavljeniKorisnikGroupBox.Visible = false;
            OsvjeziGumbe();
        }

        private void OsvjeziGumbe()
        {
            if (PrijavljeniKorisnik.Prijavljen())
            {
                foreach (Button item in korisnickeKontroleGroupBox.Controls)
                {
                    item.Enabled = true;
                }
                odjavaButton.Enabled = true;
                loginButton.Enabled = false;
            }
            else
            {
                foreach (Button item in korisnickeKontroleGroupBox.Controls)
                {
                    item.Enabled = false;
                }
                odjavaButton.Enabled = false;
                loginButton.Enabled = true;
            }
            if (PrijavljeniKorisnik.GetUloga() == "Administrator")
            {
                registracijaButton.Enabled = true;
            }
            else
            {
                registracijaButton.Enabled = false;
            }
        }

        private void registracijaButton_Click(object sender, EventArgs e)
        {
            ZaposleniciForm registracija = new ZaposleniciForm();
            registracija.ShowDialog();
        }

        private void kreiranjeIzdatnicaButton_Click(object sender, EventArgs e)
        {
            PregledIzdatnicaForm pregledIzdatnica = new PregledIzdatnicaForm();
            pregledIzdatnica.ShowDialog();
        }
    }
}
