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
    public partial class PregledPrimkiForm : Form
    {
        public PregledPrimkiForm()
        {
            InitializeComponent();
        }

        private void PregledPrimkiForm_Load(object sender, EventArgs e)
        {
            OsvjeziPrikazPrimki();
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

        private void novaPrimkaButton_Click(object sender, EventArgs e)
        {
            KreirajDokumentForm f = new KreirajDokumentForm("primka");
            f.ShowDialog();
            OsvjeziPrikazPrimki();
        }

        private void OsvjeziPrikazPrimki()
        {
            dokumentBindingSource.DataSource = Dokument.DohvatiDokumentePremaNazivu("primka");
        }

        private void obrisiPrimkuButton_Click(object sender, EventArgs e)
        {
            Dokument doc = dokumentBindingSource.Current as Dokument;
            doc.ObrisiDokument();
            OsvjeziPrikazPrimki();
            MessageBox.Show("Primka je obrisana!");
        }

        private void PregledPrimkiForm_HelpRequested(object sender, HelpEventArgs hlpevent)
        {
            Help.ShowHelp(this, "../../../Pomoc/f1-pomoc.chm", HelpNavigator.TopicId, "1040");
        }
    }
}
