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
    public partial class UrediForm : Form
    {
        private Roba odabranaRoba;
        public bool RobaUredena = false;
        public UrediForm(Roba roba)
        {
            odabranaRoba = roba;
            InitializeComponent();
        }

        private void UrediForm_Load(object sender, EventArgs e)
        {
            nazivRobeTextBox.Text = odabranaRoba.Naziv;
            opisRobeTextBox.Text = odabranaRoba.Opis;
            List<MjernaJedinica> mjerneJedinice = MjernaJedinica.DohvatiMjerneJedinice();
            mjernaJedinicaComboBox.DataSource = mjerneJedinice;
            int i = mjerneJedinice.FindIndex(x => x.Id == odabranaRoba.MjernaJedinica);
            mjernaJedinicaComboBox.SelectedIndex = i;
        }

        private void odustaniButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void dodajRobuButton_Click(object sender, EventArgs e)
        {
            RobaUredena = true;

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

            Roba.UrediRobu(odabranaRoba, naziv, opis, mjernaJedinica.Id);

            Close();
        }
    }
}
