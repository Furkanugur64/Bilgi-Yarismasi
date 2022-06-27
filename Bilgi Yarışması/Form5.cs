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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }
        SqlConnection baglantı = new SqlConnection("Data Source=Furkan-PC;Initial Catalog=bilgiyarısma;Integrated Security=True");

        private void Verileri_göster()
        {
            baglantı.Open();
            DataTable tablo = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select * from Skor_tablosu", baglantı);
            da.Fill(tablo);
            dataGridView1.DataSource = tablo;
            baglantı.Close();
            renklendir();
        }
        private void Form5_Load(object sender, EventArgs e)
        {
            Verileri_göster();
            
        }

        void renklendir()
        {
            for (int i = 0; i < dataGridView1.Rows.Count-1; i++)
            {
                DataGridViewCellStyle renk = new DataGridViewCellStyle();
                
                if (Convert.ToInt32(dataGridView1.Rows[i].Cells[3].Value)<=1000)
                {
                    renk.BackColor = Color.Red;
                    renk.ForeColor = Color.White;
                }
                else if ((Convert.ToInt32(dataGridView1.Rows[i].Cells[3].Value) > 1000) && (Convert.ToInt32(dataGridView1.Rows[i].Cells[3].Value) <= 15000))
                {
                    renk.BackColor = Color.Orange;
                    renk.ForeColor = Color.Black;
                }
                else if ((Convert.ToInt32(dataGridView1.Rows[i].Cells[3].Value) > 15000) && (Convert.ToInt32(dataGridView1.Rows[i].Cells[3].Value) <=250000))
                {
                    renk.BackColor = Color.Yellow;
                    renk.ForeColor = Color.Black;
                }                
                else
                {
                    
                    renk.BackColor = Color.Lime;
                    renk.ForeColor = Color.Black;
                }
                dataGridView1.Rows[i].DefaultCellStyle = renk;
            }
        }

        private void BtnSifre_Click(object sender, EventArgs e)
        {
            
            if (TxtSifre.Text=="12346")
            {
                panel1.Enabled = true;
                TxtSifre.Visible = false;
                BtnSifre.Visible = false;
                label5.Visible = false;
            }
            else
            {
                MessageBox.Show("Yanlış Şifre !!!");
            }
            TxtSifre.Clear();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            TxtAdı.Text = dataGridView1.CurrentRow.Cells["Adı"].Value.ToString();
            TxtSoyadı.Text = dataGridView1.CurrentRow.Cells["Soyadı"].Value.ToString();
            TxtCinsiyet.Text = dataGridView1.CurrentRow.Cells["Cinsiyet"].Value.ToString();
            TxtKazanılan.Text = dataGridView1.CurrentRow.Cells["Kazanılan"].Value.ToString();

        }

        private void button3_Click(object sender, EventArgs e)
        {

            DialogResult Cevap = MessageBox.Show("Silme İşlemini Onaylıyor musunuz ?", "Oyuncu Kayıt Bilgi", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
            if (Cevap == DialogResult.Yes)
            {


                if (TxtAdı.Text != "")
                {
                    baglantı.Open();
                    SqlCommand komut = new SqlCommand("delete Skor_tablosu where Adı=@p1", baglantı);
                    komut.Parameters.AddWithValue("@p1", TxtAdı.Text);
                    komut.ExecuteNonQuery();
                    baglantı.Close();
                    MessageBox.Show("Kayıt Silindi", "Oyuncu Kayıt Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Verileri_göster();
                    temizle();
                }
                else
                {
                    MessageBox.Show("Bir isim Girin");
                }
            }

        }
        void temizle()
        {
            foreach (Control item in panel1.Controls)
            {
                if (item is TextBox)
                {
                    item.Text = "";
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (TxtAdı.Text != "" && TxtSoyadı.Text != "" && TxtKazanılan.Text != "" && TxtCinsiyet.Text != "")
            {
                baglantı.Open();
                SqlCommand komut = new SqlCommand("update Skor_tablosu set Soyadı=@p1 ,Cinsiyet=@p2,Kazanılan=@p3 where Adı=@p4 ", baglantı);
                komut.Parameters.AddWithValue("@p1", TxtSoyadı.Text);
                komut.Parameters.AddWithValue("@p2", TxtCinsiyet.Text);
                komut.Parameters.AddWithValue("@p3",Convert.ToInt32(TxtKazanılan.Text));
                komut.Parameters.AddWithValue("@p4", TxtAdı.Text);
                komut.ExecuteNonQuery();
                baglantı.Close();
                MessageBox.Show("Kayıt Güncellendi", "Oyuncu Kayıt Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Verileri_göster();
                temizle();
            }
            else
                MessageBox.Show("Boş Değer Bırakmayın !!");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 fr = new Form1();
            fr.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            baglantı.Open();
            SqlDataAdapter da = new SqlDataAdapter("select * from Skor_tablosu where Kazanılan<=1000 ",baglantı);
            DataTable tablo = new DataTable();
            da.Fill(tablo);
            dataGridView1.DataSource = tablo;
            baglantı.Close();
            
            for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
            {
                DataGridViewCellStyle renk = new DataGridViewCellStyle();
                renk.SelectionBackColor = Color.Red;
                renk.SelectionForeColor = Color.White;
                renk.BackColor = Color.Red;
                renk.ForeColor = Color.White;
                dataGridView1.Rows[i].DefaultCellStyle = renk;
            }

        }

        private void button5_Click(object sender, EventArgs e)
        {
            baglantı.Open();
            SqlDataAdapter da = new SqlDataAdapter("select * from Skor_tablosu where Kazanılan>1000 AND Kazanılan<=15000", baglantı);
            DataTable tablo = new DataTable();
            da.Fill(tablo);
            dataGridView1.DataSource = tablo;
            baglantı.Close();

            for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
            {
                DataGridViewCellStyle renk = new DataGridViewCellStyle();
                renk.SelectionBackColor = Color.Orange;
                renk.SelectionForeColor = Color.Black;
                renk.BackColor = Color.Orange;
                renk.ForeColor = Color.Black;
                dataGridView1.Rows[i].DefaultCellStyle = renk;
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Verileri_göster();
          
        }

        private void button6_Click(object sender, EventArgs e)
        {
            baglantı.Open();
            SqlDataAdapter da = new SqlDataAdapter("select * from Skor_tablosu where Kazanılan>15000 AND Kazanılan<=250000", baglantı);
            DataTable tablo = new DataTable();
            da.Fill(tablo);
            dataGridView1.DataSource = tablo;
            baglantı.Close();

            for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
            {
                DataGridViewCellStyle renk = new DataGridViewCellStyle();
                renk.SelectionBackColor = Color.Yellow;
                renk.SelectionForeColor = Color.Black;
                renk.BackColor = Color.Yellow;
                renk.ForeColor = Color.Black;
                dataGridView1.Rows[i].DefaultCellStyle = renk;
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            baglantı.Open();
            SqlDataAdapter da = new SqlDataAdapter("select * from Skor_tablosu where Kazanılan=1000000 ", baglantı);
            DataTable tablo = new DataTable();
            da.Fill(tablo);
            dataGridView1.DataSource = tablo;
            baglantı.Close();

            for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
            {
                DataGridViewCellStyle renk = new DataGridViewCellStyle();
                renk.SelectionBackColor = Color.Lime;
                renk.SelectionForeColor = Color.Black;
                renk.BackColor = Color.Lime;
                renk.ForeColor = Color.Black;
                dataGridView1.Rows[i].DefaultCellStyle = renk;
            }
        }
    }
}
