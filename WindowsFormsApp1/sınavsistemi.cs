using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class sınavsistemi : Form
    {
        public sınavsistemi()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Pc pc = new Pc();
            pc.mesut = label1.Text;
            pc.Show();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Mat mat = new Mat();
            mat.mesut = label1.Text;
            mat.Show();
        }

        public string kullaniciad;
        private void sınavsistemi_Load(object sender, EventArgs e)
        {
            label1.Text = kullaniciad;
            label1.Visible = false;
        }
    }
}
