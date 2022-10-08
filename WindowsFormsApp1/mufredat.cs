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
    public partial class mufredat : Form
    {
        public mufredat()
        {
            InitializeComponent();
        }

        private void mufredat_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'sinavsistemiDataSet3.Dersler' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.derslerTableAdapter.Fill(this.sinavsistemiDataSet3.Dersler);

        }
    }
}
