using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WindowsFormsApp1
{
    public partial class Mat : Form
    {
        public Mat()
        {
            InitializeComponent();
        }
        public string mesut;
        sqlbaglantisi bgl=new sqlbaglantisi();  
        private void Mat_Load(object sender, EventArgs e)
        {
            label6.Text = mesut;
            label5.Visible = false;
            label1.Visible = false;
            label2.Visible = false;
            label3.Visible = false;
            label4.Visible = false;
            button7.Visible= false; 
            if(sayac==6)
            {
                button7.Visible = true;
            }
        }
        int sayac = 0;
        int dogru = 20;
        int puan = 0;
        

        private void button6_Click(object sender, EventArgs e)
        {
            button1.Enabled = true;
            button2.Enabled = true;
            button3.Enabled = true;
            button4.Enabled = true;
            sayac++;
            SqlCommand komut = new SqlCommand("Select Matsoru,Mata,Matb,Matc,Matd from Matsinavv where Matid=@p1",bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", sayac);
            label5.Text = sayac.ToString();
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                richTextBox1.Text = dr[0].ToString();
                button1.Text = dr[1].ToString();
                button2.Text = dr[2].ToString();
                button3.Text = dr[3].ToString();
                button4.Text = dr[4].ToString();
            }

            
            button2.BackColor = Color.Transparent;
            button4.BackColor = Color.Transparent;
            button1.BackColor = Color.Transparent;
            button3.BackColor = Color.Transparent;
          
            if (sayac==6)
            {
                button7.Visible = true;
                button6.Visible = false;

                MessageBox.Show("Sınavdan " + puanlar + " Aldınız ");

            }

            
            
        }

        private void button5_Click(object sender, EventArgs e)
        {
            sayac++;

            button5.Visible = false;
            SqlCommand cmd = new SqlCommand("Select Matsoru,Mata,Matb,Matc,Matd from Matsinavv where Matid=@p1",bgl.baglanti());
            cmd.Parameters.AddWithValue("@p1", sayac);
            label5.Text = sayac.ToString();
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                richTextBox1.Text = dr[0].ToString();
                button1.Text = dr[1].ToString();
                button2.Text = dr[2].ToString();
                button3.Text = dr[3].ToString();
                button4.Text = dr[4].ToString();
                
            }



        }

        private void button1_Click(object sender, EventArgs e)
        {
            button2.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = false;
            if (sayac == 3)
            {
                button1.BackColor = Color.Green;
                button4.BackColor = Color.Red;
                button3.BackColor = Color.Red;
                button2.BackColor = Color.Red;
                puan = dogru + puan;
                puanlar = puan;
                label3.Text = puanlar.ToString();

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            button1.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = false;
            if (sayac == 1)
            {
                button2.BackColor = Color.Green;
                button1.BackColor = Color.Red;
                button3.BackColor = Color.Red;
                button4.BackColor = Color.Red;
                puan = dogru + puan;
                puanlar = puan;
                label3.Text = puanlar.ToString();

            }
            if (sayac == 4)
            {
                button2.BackColor = Color.Green;
                button1.BackColor = Color.Red;
                button3.BackColor = Color.Red;
                button4.BackColor = Color.Red;
                puan = dogru + puan;
                puanlar = puan;
                label3.Text = puanlar.ToString();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            button2.Enabled = false;
            button1.Enabled = false;
            button4.Enabled = false;
            if (sayac == 5)
            {
                button3.BackColor = Color.Green;
                button1.BackColor = Color.Red;
                button4.BackColor = Color.Red;
                button2.BackColor = Color.Red;
                puan = dogru + puan;
                puanlar = puan;
                label3.Text = puanlar.ToString();

            }
        }
        int puanlar = 0;

        private void button4_Click(object sender, EventArgs e)
        {
            button2.Enabled = false;
            button3.Enabled = false;
            button1.Enabled = false;
            if (sayac == 2)
            {
                button4.BackColor = Color.Green;
                button1.BackColor = Color.Red;
                button3.BackColor = Color.Red;
                button2.BackColor = Color.Red;

                puan = dogru + puan;
                puanlar = puan;
                label3.Text = puanlar.ToString();

            }

        }

        private void button7_Click(object sender, EventArgs e)
        {
            SqlCommand komut2 = new SqlCommand("update KullaniciBilgiler set  Matsonucu=@p1 where Kullaniciid=" + label6.Text, bgl.baglanti()); ;
            komut2.Parameters.AddWithValue("@p1", puanlar.ToString());
            komut2.ExecuteNonQuery();
            Application.Exit();

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
    }
