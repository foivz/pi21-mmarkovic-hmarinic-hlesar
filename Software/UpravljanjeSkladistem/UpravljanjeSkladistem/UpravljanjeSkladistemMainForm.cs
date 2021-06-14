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
    }
}
