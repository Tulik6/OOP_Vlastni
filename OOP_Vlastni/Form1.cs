using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP_Vlastni
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Zvire zvire = new Zvire("Lev", "Divoké");
            zvire.SetKrmivo(20);
            MessageBox.Show(zvire.ToString());
            zvire.Jez();
            MessageBox.Show(zvire.ToString());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Pes pes = new Pes("Pes", "Domácí", "Labrador");
            pes.SetKrmivo(15);
            MessageBox.Show(pes.ToString());
            pes.Jez();
            MessageBox.Show(pes.ToString());
            pes.SetPlemeno("Retrívr");
            MessageBox.Show(pes.GetPlemeno());
        }
    }
}
