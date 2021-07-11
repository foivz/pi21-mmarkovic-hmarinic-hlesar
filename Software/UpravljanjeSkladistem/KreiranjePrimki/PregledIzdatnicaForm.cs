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
    public partial class PregledIzdatnicaForm : Form
    {
        public PregledIzdatnicaForm()
        {
            InitializeComponent();
        }

        private void PregledIzdatnicaForm_Load(object sender, EventArgs e)
        {
            OsvjeziIzdatnice();
        }

        private void dokumentBindingSource_CurrentChanged(object sender, EventArgs e)
        {
            Dokument odabraniDokument = dokumentBindingSource.Current as Dokument;
            if (odabraniDokument != null)
            {
                List<StavkeDokumenta> stavkeDokumenta = odabraniDokument.DohvatiStavkeDokumenta();
                foreach (var stavka in stavkeDokumenta)
                {
                    Roba roba = Roba.DovhatiRobuPoIdu(stavka.IdRoba);
                    stavka.NazivRobe = roba.Naziv;
                    stavka.OpisRobe = roba.Opis;
                    MjernaJedinica mjernaJedinica = SkladisteDb.MjernaJedinica.DohvatiMjernuJedinicuPoIdu((int)roba.MjernaJedinica);
                    stavka.NazivMjerneJedinica = mjernaJedinica.Naziv;
                }
                stavkeDokumentaBindingSource.DataSource = stavkeDokumenta;
            }
            else
            {
                stavkeDokumentaBindingSource.DataSource = null;
            }
        }

        private void novaIzdatnicaButton_Click(object sender, EventArgs e)
        {
            KreirajDokumentForm novaIzdatnica = new KreirajDokumentForm("izdatnica");
            novaIzdatnica.ShowDialog();
            OsvjeziIzdatnice();
        }
        private void obrisiIzdatnicuButton_Click(object sender, EventArgs e)
        {
            Dokument doc = dokumentBindingSource.Current as Dokument;
            doc.ObrisiDokument();
            OsvjeziIzdatnice();
            MessageBox.Show("Izdatnica je obrisana!");
        }

        private void OsvjeziIzdatnice()
        {
            dokumentBindingSource.DataSource = Dokument.DohvatiDokumentePremaNazivu("izdatnica");
        }

    }
}
