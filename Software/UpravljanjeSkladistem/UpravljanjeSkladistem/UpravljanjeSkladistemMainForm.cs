using AdresiranjeRobe;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UpravljanjeSkladistem
{
    public partial class UpravljanjeSkladistemMainForm : Form
    {
        public UpravljanjeSkladistemMainForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AdresiranjeRobeForm f = new AdresiranjeRobeForm();
            f.ShowDialog();
        }
    }
}
