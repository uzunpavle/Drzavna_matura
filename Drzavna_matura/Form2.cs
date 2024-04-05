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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int br = Convert.ToInt32(label1.Text);
            br++;
            label1.Text = br.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Hide();
        }
    }
}
