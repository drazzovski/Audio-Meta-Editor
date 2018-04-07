using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MP3_meta_editor
{
    public partial class Sablon : Form
    {
        public Sablon()
        {
            InitializeComponent();
            textBox1.Text = "0";
        }

        public static int clanBr = 0;

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar)) return;
            if (Char.IsControl(e.KeyChar)) return;
            e.Handled = true;
        }
        
        private void btnPotvrditi_Click(object sender, EventArgs e)
        {
            clanBr = Int32.Parse(textBox1.Text);
            Form1.clanovi = clanBr;
            Close();
        }

        private void btnOtkazati_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
