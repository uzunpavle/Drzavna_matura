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
    }
}
