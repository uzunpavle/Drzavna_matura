using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Drzavna_matura
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
        }

        private void Unesi_skolu_Click(object sender, EventArgs e)
        {
            Form2 Unesi_skolu = new Form2();
            Unesi_skolu.ShowDialog();
        }

        private void Unesi_ucenika_Click(object sender, EventArgs e)
        {
            Form3 Unesi_ucenika = new Form3();
            Unesi_ucenika.ShowDialog();
        }

        private void Pregledaj_ucenike_Click(object sender, EventArgs e)
        {
            Form4 Pregledaj_ucenike = new Form4();
            Pregledaj_ucenike.ShowDialog();
        }
    }
}
