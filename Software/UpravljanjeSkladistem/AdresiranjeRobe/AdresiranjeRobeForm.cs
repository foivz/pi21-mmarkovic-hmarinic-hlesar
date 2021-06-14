﻿using SkladisteDb;
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
    public partial class AdresiranjeRobeForm : Form
    {
        private Lokacija zadnjeOdabranaLokacija;
        private TreeNode zadnjeOdabraniNode;
        public AdresiranjeRobeForm()
        {
            InitializeComponent();
        }

        private void AdresiranjeRobe_Load(object sender, EventArgs e)
        {
            odabranaLokacijaLabel.Text = String.Empty;
            KreirajStablo();
        }

        private void dodajLokacijuButton_Click(object sender, EventArgs e)
        {
            string naziv = nazivNoveLokacijeTextBox.Text.Trim();
            
            if (naziv == String.Empty)
            {
                MessageBox.Show("Lokacija mora imati naziv!");
                return;
            }

            int? nadLokacija;
            if (nemaNadlokacijeCheckBox.Checked)
            {
                nadLokacija = null;
            }
            else
            {
                if (zadnjeOdabranaLokacija != null)
                {
                    nadLokacija = zadnjeOdabranaLokacija.Id;
                }
                else
                {
                    nadLokacija = null;
                }
            }

            Lokacija lokacija = new Lokacija
            {
                Naziv = naziv,
                Nadlokacija = nadLokacija,
            };

            Lokacija.DodajLokaciju(lokacija);
            if (lokacija.Nadlokacija == null)
            {
                DodajNodeUStablo(lokacija, true);
            }
            else
            {
                DodajNodeUStablo(lokacija);
            }
            MessageBox.Show("Uspješno dodana nova lokacija");
        }

        private void DohvatiRobu()
        {
            if (zadnjeOdabranaLokacija == null)
            {
                MessageBox.Show("Prvo odaberite lokaciju!");
                return;
            }

            if (!robaNaOdredenojLokacijiCheckBox.Checked)
            {
                robaBindingSource.DataSource = Roba.DohvatiSvuRobuNaLokaciji(zadnjeOdabranaLokacija);
            }
            else
            {
                robaBindingSource.DataSource = UkljuciRobuPodlokacija(zadnjeOdabranaLokacija);
            }
        }
        private void DohvatiSvuRobu(Lokacija odabranaLokacija, ref List<Roba> roba)
        {
           if (odabranaLokacija.RobaNaLokacijis.Count > 0)
           {
                List<Roba> dohvacenaRoba = Roba.DohvatiSvuRobuNaLokaciji(zadnjeOdabranaLokacija);
                foreach(var zapis in dohvacenaRoba)
                {
                    Roba pronadeniZapis = roba.Find(x => x.Id == zapis.Id);
                    if (pronadeniZapis == null)
                    {
                        roba.Add(zapis);
                    }
                    else
                    {
                        pronadeniZapis.Kolicina += zapis.Kolicina;
                    }
                }
           }

            using (var context = new SkladisteDatabase())
            {
                var query = from lok in context.Lokacijas
                            where lok.Nadlokacija == odabranaLokacija.Id
                            select lok;

                foreach (Lokacija lokacija in query.ToList())
                {
                    DohvatiSvuRobu(lokacija, ref roba);
                }
            }
        }

        private void robaNaOdredenojLokacijiCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            DohvatiRobu();
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

        private void stableniPrikazTreeView_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            zadnjeOdabranaLokacija = e.Node.Tag as Lokacija;
            zadnjeOdabraniNode = e.Node;
            odabranaLokacijaLabel.Text = zadnjeOdabranaLokacija.Naziv;
            DohvatiRobu();
        }

        private List<Roba> UkljuciRobuPodlokacija(Lokacija lokacija)
        {
            List<Roba> roba = new List<Roba>();
            lokacija.DohvatiRobuNaSvimPodlokacijama(ref roba);
            return roba;
        }
        private void DodajNodeUStablo(Lokacija lokacija, bool bazicnaLokacija = false)
        {
            stableniPrikazTreeView.BeginUpdate();
            if (bazicnaLokacija)
            {
                stableniPrikazTreeView.Nodes.Add(lokacija.Naziv);
                stableniPrikazTreeView.Nodes[stableniPrikazTreeView.Nodes.Count - 1].Tag = lokacija;
            }
            else
            {
                zadnjeOdabraniNode.Nodes.Add(lokacija.Naziv);
                zadnjeOdabraniNode.Nodes[zadnjeOdabraniNode.Nodes.Count - 1].Tag = lokacija;
            }
            stableniPrikazTreeView.EndUpdate();
        }

        private void izlazButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void obrisiOdabranuLokacijuButton_Click(object sender, EventArgs e)
        {
            if (zadnjeOdabranaLokacija == null)
            {
                MessageBox.Show("Lokacija nije odabrana!");
                return;
            }
            if (zadnjeOdabranaLokacija.ObrisiLokaciju())
            {
                stableniPrikazTreeView.BeginUpdate();
                if (zadnjeOdabraniNode.Parent == null)
                {
                    stableniPrikazTreeView.Nodes.Remove(zadnjeOdabraniNode);
                }
                else
                {
                    zadnjeOdabraniNode.Parent.Nodes.Remove(zadnjeOdabraniNode);
                }
                stableniPrikazTreeView.EndUpdate();
                zadnjeOdabranaLokacija = null;
                zadnjeOdabraniNode = null;
                odabranaLokacijaLabel.Text = String.Empty;
                MessageBox.Show("Lokacija je uspješno izbrisana!");
            }
            else
            {
                MessageBox.Show("Lokaciju nije moguće obrisati, nalazi se roba na lokaciji ili lokacija sadržava druge lokacije!");
            }
        }

        private void AdresiranjeRobeForm_HelpRequested(object sender, HelpEventArgs hlpevent)
        {
            Help.ShowHelp(this, "../../../Pomoc/f1-pomoc.chm", HelpNavigator.TopicId, "1020");
        }
    }
}
