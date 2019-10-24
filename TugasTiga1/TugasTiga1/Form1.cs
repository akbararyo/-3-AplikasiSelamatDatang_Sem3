using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TugasTiga1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnTampil_Click(object sender, EventArgs e)
        {
            lblNimIsi.Text = ": 18.11.2354";
            lblNamaIsi.Text = ": CHANDRA";
            lblKelasIsi.Text = ": S1-IF08";
        }

        private void btnKosong_Click(object sender, EventArgs e)
        {
            lblNimIsi.Text = ": ";
            lblNamaIsi.Text = ": ";
            lblKelasIsi.Text = ": ";
        }
    }
}
