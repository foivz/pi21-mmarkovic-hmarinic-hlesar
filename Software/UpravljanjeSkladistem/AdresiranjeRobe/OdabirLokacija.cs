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

namespace AdresiranjeRobe
{
    public partial class OdabirLokacija : Form
    {
        public Lokacija OdabranaLokacija;
        private Lokacija zadnjeOdabranaLokacija;
        private TreeNode zadnjeOdabraniNode;
        public OdabirLokacija()
        {
            InitializeComponent();
        }

        private void OdabirLokacija_Load(object sender, EventArgs e)
        {
            odabranaLokacijaLabel.Text = String.Empty;
            KreirajStablo();
        }

        private void KreirajStablo()
        {
            stableniPrikazTreeView.BeginUpdate();

            int i = 0;
            foreach (var bazicnaLokacija in Lokacija.DohvatiBazicneLokacije())
            {
                stableniPrikazTreeView.Nodes.Add(bazicnaLokacija.Naziv);
                stableniPrikazTreeView.Nodes[i].Tag = bazicnaLokacija;
                StabloLokacija(bazicnaLokacija, stableniPrikazTreeView.Nodes[i]);
                i++;
            }

            stableniPrikazTreeView.EndUpdate();
        }

        private void StabloLokacija(Lokacija lokacija, TreeNode node)
        {
            int i = 0;
            foreach (var podlokacija in lokacija.DohvatiPodlokacije())
            {
                node.Nodes.Add(podlokacija.Naziv);
                node.Nodes[i].Tag = podlokacija;
                StabloLokacija(podlokacija, node.Nodes[i]);
                i++;
            }
        }

        private void odaberiLokacijuButton_Click(object sender, EventArgs e)
        {
            OdabranaLokacija = zadnjeOdabranaLokacija;
            if (OdabranaLokacija == null)
            {
                MessageBox.Show("Niste odabrali lokaciju!");
                return;
            }
            Close();
        }

        private void stableniPrikazTreeView_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            zadnjeOdabranaLokacija = e.Node.Tag as Lokacija;
            zadnjeOdabraniNode = e.Node;
            odabranaLokacijaLabel.Text = zadnjeOdabranaLokacija.Naziv;
        }
    }
}
