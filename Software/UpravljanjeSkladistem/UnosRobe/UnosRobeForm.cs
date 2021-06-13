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
    }
}
