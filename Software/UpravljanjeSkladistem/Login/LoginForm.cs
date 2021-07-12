using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Login
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void prijavaButton_Click(object sender, EventArgs e)
        {
            if(PrijavljeniKorisnik.PrijaviKorisnika(korimeTextBox.Text, lozinkaTextBox.Text))
            {
                this.Close();
            }
            else
            {
                MessageBox.Show("Prijava neuspješna!");
            }
        }

        private void LoginForm_HelpRequested(object sender, HelpEventArgs hlpevent)
        {
            Help.ShowHelp(this, "../../../Pomoc/f1-pomoc.chm", HelpNavigator.TopicId, "1060");
        }
    }
}
