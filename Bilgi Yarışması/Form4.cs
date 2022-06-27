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

namespace Bilgi_Yarışması
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }
        SqlConnection baglantı = new SqlConnection("Data Source=Furkan-PC;Initial Catalog=bilgiyarısma;Integrated Security=True");
        bool kayıt = false;
        private void Kayıt_kontrol()
        {
            baglantı.Open();
            SqlCommand komut = new SqlCommand("select * From Skor_tablosu where Adı=@p1 AND Soyadı=@p2 ", baglantı);
            komut.Parameters.AddWithValue("@p1", TxtAdı.Text);
            komut.Parameters.AddWithValue("@p2", TxtSoyadı.Text);
            SqlDataReader oku = komut.ExecuteReader();
            if(oku.Read())
            {
                kayıt = true;
            }
            else
            {
                kayıt = false;
            }
            baglantı.Close();
        }
        private void Form4_Load(object sender, EventArgs e)
        {
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {       
            if (TxtAdı.Text == "")
            {
                TxtAdı.BackColor = Color.Red;
                errorProvider1.SetError(TxtAdı, "Lütfen İsminizi Giriniz !!");
            }

           
            if (TxtSoyadı.Text == "")
            {
                TxtSoyadı.BackColor = Color.Red;
                errorProvider2.SetError(TxtSoyadı, "Lütfen Soyadınızı Giriniz !!");
            }
           
                
            if (comboBox1.Text == "")
            {
                comboBox1.BackColor = Color.Red;
                errorProvider3.SetError(comboBox1, "Lütfen Bir Seçim Yapınız !!");
            }
            if (TxtAdı.BackColor == Color.White && TxtSoyadı.BackColor == Color.White && comboBox1.BackColor == Color.White)
            {
                Kayıt_kontrol();
                 if (kayıt == false)
                {
                    baglantı.Open();
                    SqlCommand komut = new SqlCommand("insert into Skor_tablosu (Adı,Soyadı,Cinsiyet,Kazanılan) values (@p1,@p2,@p3,@p4)", baglantı);
                    komut.Parameters.AddWithValue("@p1", TxtAdı.Text);
                    komut.Parameters.AddWithValue("@p2", TxtSoyadı.Text);
                    komut.Parameters.AddWithValue("@p3", comboBox1.Text);
                    komut.Parameters.AddWithValue("@p4", Convert.ToInt32(Txtkazanılan.Text));
                    komut.ExecuteNonQuery();
                    baglantı.Close();
                    MessageBox.Show("Oyuncu Kaydınız Başarıyla Eklendi.", "Oyuncu Kayıt Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Hide();
                }
                if (kayıt == true)
                {
                    baglantı.Open();
                    SqlCommand komut = new SqlCommand("update Skor_tablosu set Kazanılan=@p1 where Adı=@p2 AND Soyadı=@p3", baglantı);
                    komut.Parameters.AddWithValue("@p1", Convert.ToInt32(Txtkazanılan.Text));
                    komut.Parameters.AddWithValue("@p2", TxtAdı.Text);
                    komut.Parameters.AddWithValue("@p3", TxtSoyadı.Text);
                    komut.ExecuteNonQuery();
                    baglantı.Close();
                    MessageBox.Show("Var olan kayıt Güncellendi", "Oyuncu Kayıt Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Hide();

                }
            }
            else
            {
                MessageBox.Show("Kırmızı Alanları Kontrol Ediniz !!", "Bilgilerde Eksik Var !!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void TxtAdı_TextChanged(object sender, EventArgs e)
        {
            if (TxtAdı.Text != "")
            {
                errorProvider1.Clear();
                TxtAdı.BackColor = Color.White;
            }
        }

        private void TxtSoyadı_TextChanged(object sender, EventArgs e)
        {
            string ilk = TxtSoyadı.Text;
            ilk = ilk.ToUpper();
            TxtSoyadı.Text = ilk;
            TxtSoyadı.Select(TxtSoyadı.Text.Length, 1);
           
            if (TxtSoyadı.Text != "")
            {
                errorProvider2.Clear();
                TxtSoyadı.BackColor = Color.White;
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.Text != "")
            {
                errorProvider3.Clear();
                comboBox1.BackColor = Color.White;
            }
        }
    }
}
