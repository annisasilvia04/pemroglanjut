using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tugas3._4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblAnimasi.Left -= 10;
            if (lblAnimasi.Left < -lblAnimasi.Width) lblAnimasi.Left = this.Width;
        }

        private void btnKeluar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
