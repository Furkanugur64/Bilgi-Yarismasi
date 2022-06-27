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
using System.Drawing.Drawing2D;

namespace Bilgi_Yarışması
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        int zaman = 40;
        int sayac = 0;
        SqlConnection baglan = new SqlConnection("Data Source=Furkan-PC;Initial Catalog=bilgiyarısma;Integrated Security=True");
        public int kazanılan;
        private void Form3_Load(object sender, EventArgs e)
        {
            şıkpasif();
        }
        private void renkayar()
        {
            if (sayac >= 2 && sayac < 8)
            {
                Btn2000.BackColor = Color.Black;
                Btn3000.BackColor = Color.Black;
                Btn5000.BackColor = Color.Black;
                Btn7500.BackColor = Color.Black;
                Btn15000.BackColor = Color.Black;
            }
            else if (sayac >= 7 && sayac < 12)
            {
                Btn30000.BackColor = Color.Black;
                Btn60000.BackColor = Color.Black;
                Btn125000.BackColor = Color.Black;
                Btn250000.BackColor = Color.Black;
            }
            else
            {
                Btn500.BackColor = Color.Black;
                Btn1000.BackColor = Color.Black;
            }
        }
        private void kontrol()
        {
            if (sayac <= 2)
            {
                textBox1.Text = "Malesef Hiçbir Ödül kazanamadınız :(";
            }
            else if (sayac > 2 && sayac < 8)
            {
                textBox1.Text = "Tebrikler 1.000 TL kazandınız...";
            }
            else
            {
                textBox1.Text = "Tebrikler 15.000 TL kazandınız..";
            }
        }

        public void şıkpasif()
        {
            BtnA.Enabled = false;
            BtnB.Enabled = false;
            BtnC.Enabled = false;
            BtnD.Enabled = false;
        }
        private void aktif()
        {
            button1.Visible = true;
            button2.Visible = true;
            button3.Visible = true;
            button4.Visible = true;
            button5.Visible = true;
            button6.Visible = true;
            button7.Visible = true;
            button8.Visible = true;
            button9.Visible = true;
            button10.Visible = true;
            button11.Visible = true;
            button12.Visible = true;
            button13.Visible = true;
            button14.Visible = true;
            button15.Visible = true;
            button16.Visible = true;
            button17.Visible = true;
            button18.Visible = true;
            button19.Visible = true;
            button20.Visible = true;
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (sayac <= 7)
            {
                zaman--;
                BtnSüre.Text = zaman.ToString();
                if (zaman == 19)
                {
                    button1.Visible = false;
                }
                if (zaman == 18)
                {
                    button2.Visible = false;
                }
                if (zaman == 17)
                {
                    button3.Visible = false;
                }
                if (zaman == 16)
                {
                    button4.Visible = false;
                }
                if (zaman == 15)
                {
                    button5.Visible = false;
                }
                if (zaman == 14)
                {
                    button6.Visible = false;
                }
                if (zaman == 13)
                {
                    button7.Visible = false;
                }
                if (zaman == 12)
                {
                    button8.Visible = false;
                }
                if (zaman == 11)
                {
                    button9.Visible = false;
                }
                if (zaman == 10)
                {
                    button10.Visible = false;
                }
                if (zaman == 9)
                {
                    button11.Visible = false;
                }
                if (zaman == 8)
                {
                    button12.Visible = false;
                }
                if (zaman == 7)
                {
                    button13.Visible = false;
                }
                if (zaman == 6)
                {
                    button14.Visible = false;
                }
                if (zaman == 5)
                {
                    button15.Visible = false;
                }
                if (zaman == 4)
                {
                    button16.Visible = false;
                }
                if (zaman == 3)
                {
                    button17.Visible = false;
                }
                if (zaman == 2)
                {
                    button18.Visible = false;
                }
                if (zaman == 1)
                {
                    button19.Visible = false;
                }
                if (zaman == 0)
                {
                    axWindowsMediaPlayerseyirci.URL = "C:\\Users\\ASUS\\Desktop\\Çalışmalarım\\C# Form\\Projeler\\Bilgi yarışma\\müzik\\bitti.mp3";
                    axWindowsMediaPlayersüre.close();
                    button20.Visible = false;
                    Btnçekil.Visible = false;
                    Btnbitir.Visible = true;
                    timer1.Enabled = false;
                    textBox2.Visible = true;
                    textBox2.Text = "Maalesef Süre Doldu !!";
                    şıkpasif();
                    Btnsonraki.Visible = false;
                    Btnseyirci.Enabled = false;
                    Btnsüredur.Enabled = false;
                    Btnsorudegistir.Enabled = false;
                    Btnyarıyarıya.Enabled = false;
                    button21.Visible = true;
                    button22.Visible = true;
                    Btnçekil.Enabled = false;
                    kontrol();
                    renkayar();
                }
            }
            if (sayac > 7)
            {
                zaman--;
                BtnSüre.Text = zaman.ToString();
                if (zaman == 38)
                {
                    button1.Visible = false;
                }
                if (zaman == 36)
                {
                    button2.Visible = false;
                }
                if (zaman == 34)
                {
                    button3.Visible = false;
                }
                if (zaman == 32)
                {
                    button4.Visible = false;
                }
                if (zaman == 30)
                {
                    button5.Visible = false;
                }
                if (zaman == 28)
                {
                    button6.Visible = false;
                }
                if (zaman == 26)
                {
                    button7.Visible = false;
                }
                if (zaman == 24)
                {
                    button8.Visible = false;
                }
                if (zaman == 22)
                {
                    button9.Visible = false;
                }
                if (zaman == 20)
                {
                    button10.Visible = false;
                }
                if (zaman == 18)
                {
                    button11.Visible = false;
                }
                if (zaman == 16)
                {
                    button12.Visible = false;
                }
                if (zaman == 14)
                {
                    button13.Visible = false;
                }
                if (zaman == 12)
                {
                    button14.Visible = false;
                }
                if (zaman == 10)
                {
                    button15.Visible = false;
                }
                if (zaman == 8)
                {
                    button16.Visible = false;
                }
                if (zaman == 6)
                {
                    button17.Visible = false;
                }
                if (zaman == 4)
                {
                    button18.Visible = false;
                }
                if (zaman == 2)
                {
                    button19.Visible = false;
                }
                if (zaman == 0)
                {
                    axWindowsMediaPlayerseyirci.URL = "C:\\Users\\ASUS\\Desktop\\Çalışmalarım\\C# Form\\Projeler\\Bilgi yarışma\\müzik\\bitti.mp3";
                    axWindowsMediaPlayersüre.close();
                    Btnçekil.Visible = false;
                    Btnbitir.Visible = true;
                    timer1.Enabled = false;

                    textBox2.Visible = true;
                    textBox2.Text = "Maalesef Süre Doldu !!";
                    şıkpasif();
                    Btnsonraki.Visible = false;
                    Btnseyirci.Enabled = false;
                    Btnsüredur.Enabled = false;
                    Btnsorudegistir.Enabled = false;
                    Btnyarıyarıya.Enabled = false;
                    button20.Visible = false;
                    button21.Visible = true;
                    button22.Visible = true;
                    Btnçekil.Enabled = false;
                    kontrol();
                    renkayar();
                }
            }
        }

        private void Btnsonraki_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            axWindowsMediaPlayerdogru.close();
            axWindowsMediaPlayersüre.URL = "C:\\Users\\ASUS\\Desktop\\Çalışmalarım\\C# Form\\Projeler\\Bilgi yarışma\\müzik\\zaman.mp3";
            textBox2.Visible = false;
            Lblbilgi.Text = " ";
            Btnsonraki.Enabled = false;
            BtnA.BackColor = Color.AliceBlue;
            BtnB.BackColor = Color.AliceBlue;
            BtnC.BackColor = Color.AliceBlue;
            BtnD.BackColor = Color.AliceBlue;
            BtnA.Enabled = true;
            BtnB.Enabled = true;
            BtnC.Enabled = true;
            BtnD.Enabled = true;
            aktif();
            if (sayac < 7)
            {
                zaman = 20;
            }
            else
            {
                zaman = 40;
            }
            BtnSüre.Text = zaman.ToString();
            timer1.Enabled = true;
            Btnsonraki.Text = "Sonraki";
            sayac++;
            if (sayac == 1)
            {
                Btn500.BackColor = Color.Yellow;
                baglan.Open();
                SqlCommand komut = new SqlCommand("Select *From soru1 order by NEWID()", baglan);
                SqlDataReader oku = komut.ExecuteReader();
                while (oku.Read())
                {
                    BtnA.Text = (oku["a"].ToString());
                    BtnB.Text = (oku["b"].ToString());
                    BtnC.Text = (oku["c"].ToString());
                    BtnD.Text = (oku["d"].ToString());
                    textBox1.Text = (oku["soru"].ToString());
                    Lbldoğru.Text = (oku["dogru"].ToString());
                }
                baglan.Close();
                Lblsoruno.Text = "1.SORU";
            }
            if (sayac == 2)
            {
                Btn1000.BackColor = Color.Yellow;
                kazanılan = 500;
                baglan.Open();
                SqlCommand komut = new SqlCommand("Select *From soru2 order by NEWID()", baglan);
                SqlDataReader oku = komut.ExecuteReader();
                while (oku.Read())
                {
                    BtnA.Text = (oku["a"].ToString());
                    BtnB.Text = (oku["b"].ToString());
                    BtnC.Text = (oku["c"].ToString());
                    BtnD.Text = (oku["d"].ToString());
                    textBox1.Text = (oku["soru"].ToString());
                    Lbldoğru.Text = (oku["dogru"].ToString());
                }
                baglan.Close();
                Btn500.BackColor = Color.Green;
                Lblsoruno.Text = "2.SORU";
            }
            if (sayac == 3)
            {
                Btn2000.BackColor = Color.Yellow;
                kazanılan = 1000;
                baglan.Open();
                SqlCommand komut = new SqlCommand("Select *From soru3 order by NEWID()", baglan);
                SqlDataReader oku = komut.ExecuteReader();
                while (oku.Read())
                {
                    BtnA.Text = (oku["a"].ToString());
                    BtnB.Text = (oku["b"].ToString());
                    BtnC.Text = (oku["c"].ToString());
                    BtnD.Text = (oku["d"].ToString());
                    textBox1.Text = (oku["soru"].ToString());
                    Lbldoğru.Text = (oku["dogru"].ToString());
                }
                baglan.Close();
                Btn1000.BackColor = Color.Green;
                Lblsoruno.Text = "3.SORU";
            }
            if (sayac == 4)
            {
                Btn3000.BackColor = Color.Yellow;
                kazanılan = 2000;
                baglan.Open();
                SqlCommand komut = new SqlCommand("Select *From soru4 order by NEWID()", baglan);
                SqlDataReader oku = komut.ExecuteReader();
                while (oku.Read())
                {
                    BtnA.Text = (oku["a"].ToString());
                    BtnB.Text = (oku["b"].ToString());
                    BtnC.Text = (oku["c"].ToString());
                    BtnD.Text = (oku["d"].ToString());
                    textBox1.Text = (oku["soru"].ToString());
                    Lbldoğru.Text = (oku["dogru"].ToString());
                }
                baglan.Close();
                Btn2000.BackColor = Color.Green;
                Lblsoruno.Text = "4.SORU";
            }
            if (sayac == 5)
            {
                Btn5000.BackColor = Color.Yellow;
                kazanılan = 3000;
                baglan.Open();
                SqlCommand komut = new SqlCommand("Select *From soru5 order by NEWID()", baglan);
                SqlDataReader oku = komut.ExecuteReader();
                while (oku.Read())
                {
                    BtnA.Text = (oku["a"].ToString());
                    BtnB.Text = (oku["b"].ToString());
                    BtnC.Text = (oku["c"].ToString());
                    BtnD.Text = (oku["d"].ToString());
                    textBox1.Text = (oku["soru"].ToString());
                    Lbldoğru.Text = (oku["dogru"].ToString());
                }
                baglan.Close();
                Btn3000.BackColor = Color.Green;
                Lblsoruno.Text = "5.SORU";
            }
            if (sayac == 6)
            {
                Btn7500.BackColor = Color.Yellow;
                kazanılan = 5000;
                baglan.Open();
                SqlCommand komut = new SqlCommand("Select *From soru6 order by NEWID()", baglan);
                SqlDataReader oku = komut.ExecuteReader();
                while (oku.Read())
                {
                    BtnA.Text = (oku["a"].ToString());
                    BtnB.Text = (oku["b"].ToString());
                    BtnC.Text = (oku["c"].ToString());
                    BtnD.Text = (oku["d"].ToString());
                    textBox1.Text = (oku["soru"].ToString());
                    Lbldoğru.Text = (oku["dogru"].ToString());
                }
                baglan.Close();
                Btn5000.BackColor = Color.Green;
                Lblsoruno.Text = "6.SORU";
            }
            if (sayac == 7)
            {
                Btn15000.BackColor = Color.DarkRed;
                kazanılan = 7500;
                baglan.Open();
                SqlCommand komut = new SqlCommand("Select *From soru7 order by NEWID()", baglan);
                SqlDataReader oku = komut.ExecuteReader();
                while (oku.Read())
                {
                    BtnA.Text = (oku["a"].ToString());
                    BtnB.Text = (oku["b"].ToString());
                    BtnC.Text = (oku["c"].ToString());
                    BtnD.Text = (oku["d"].ToString());
                    textBox1.Text = (oku["soru"].ToString());
                    Lbldoğru.Text = (oku["dogru"].ToString());
                }
                baglan.Close();
                Btn7500.BackColor = Color.Green;
                Lblsoruno.Text = "7.SORU";
            }
            if (sayac == 8)
            {
                Btn30000.BackColor = Color.Yellow;
                kazanılan = 15000;
                baglan.Open();
                SqlCommand komut = new SqlCommand("Select *From soru8 order by NEWID()", baglan);
                SqlDataReader oku = komut.ExecuteReader();
                while (oku.Read())
                {
                    BtnA.Text = (oku["a"].ToString());
                    BtnB.Text = (oku["b"].ToString());
                    BtnC.Text = (oku["c"].ToString());
                    BtnD.Text = (oku["d"].ToString());
                    textBox1.Text = (oku["soru"].ToString());
                    Lbldoğru.Text = (oku["dogru"].ToString());
                }
                baglan.Close();
                Btn15000.BackColor = Color.Green;

                Lblsoruno.Text = "8.SORU";
            }
            if (sayac == 9)
            {
                Btn60000.BackColor = Color.Yellow;
                kazanılan = 30000;
                baglan.Open();
                SqlCommand komut = new SqlCommand("Select *From soru9 order by NEWID()", baglan);
                SqlDataReader oku = komut.ExecuteReader();
                while (oku.Read())
                {
                    BtnA.Text = (oku["a"].ToString());
                    BtnB.Text = (oku["b"].ToString());
                    BtnC.Text = (oku["c"].ToString());
                    BtnD.Text = (oku["d"].ToString());
                    textBox1.Text = (oku["soru"].ToString());
                    Lbldoğru.Text = (oku["dogru"].ToString());
                }
                baglan.Close();
                Btn30000.BackColor = Color.Green;
                Lblsoruno.Text = "9.SORU";
            }
            if (sayac == 10)
            {
                Btn125000.BackColor = Color.Yellow;
                kazanılan = 60000;
                baglan.Open();
                SqlCommand komut = new SqlCommand("Select *From soru10 order by NEWID()", baglan);
                SqlDataReader oku = komut.ExecuteReader();
                while (oku.Read())
                {
                    BtnA.Text = (oku["a"].ToString());
                    BtnB.Text = (oku["b"].ToString());
                    BtnC.Text = (oku["c"].ToString());
                    BtnD.Text = (oku["d"].ToString());
                    textBox1.Text = (oku["soru"].ToString());
                    Lbldoğru.Text = (oku["dogru"].ToString());
                }
                baglan.Close();
                Btn60000.BackColor = Color.Green;
                Lblsoruno.Text = "10.SORU";
            }
            if (sayac == 11)
            {
                Btn250000.BackColor = Color.Yellow;
                kazanılan = 125000;
                baglan.Open();
                SqlCommand komut = new SqlCommand("Select *From soru11 order by NEWID()", baglan);
                SqlDataReader oku = komut.ExecuteReader();
                while (oku.Read())
                {
                    BtnA.Text = (oku["a"].ToString());
                    BtnB.Text = (oku["b"].ToString());
                    BtnC.Text = (oku["c"].ToString());
                    BtnD.Text = (oku["d"].ToString());
                    textBox1.Text = (oku["soru"].ToString());
                    Lbldoğru.Text = (oku["dogru"].ToString());
                }
                baglan.Close();
                Btn125000.BackColor = Color.Green;
                Lblsoruno.Text = "11.SORU";
            }
            if (sayac == 12)
            {
                Btn1mlyn.BackColor = Color.Yellow;
                kazanılan = 250000;
                baglan.Open();
                SqlCommand komut = new SqlCommand("Select *From soru12 order by NEWID()", baglan);
                SqlDataReader oku = komut.ExecuteReader();
                while (oku.Read())
                {
                    BtnA.Text = (oku["a"].ToString());
                    BtnB.Text = (oku["b"].ToString());
                    BtnC.Text = (oku["c"].ToString());
                    BtnD.Text = (oku["d"].ToString());
                    textBox1.Text = (oku["soru"].ToString());
                    Lbldoğru.Text = (oku["dogru"].ToString());
                }
                baglan.Close();
                Btn250000.BackColor = Color.Green;
                Lblsoruno.Text = "12.SORU";
            }
            if (sayac == 13)
            {
                axWindowsMediaPlayersüre.close();
                axWindowsMediaPlayerdogru.close();
                axWindowsMediaPlayerseyirci.close();
                axWindowsMediaPlayeryanlıs.close();
                Lblsoruno.Text = "Yarışma Bitti";
                BtnA.Text = "";
                BtnB.Text = "";
                BtnC.Text = "";
                BtnD.Text = "";
                textBox1.Clear();
                BtnA.Enabled = false;
                BtnB.Enabled = false;
                BtnC.Enabled = false;
                BtnD.Enabled = false;
                kazanılan = 1000000;
                Btn1mlyn.BackColor = Color.Green;
                Btnsonraki.Visible = false;
                timer1.Enabled = false;
                Btnçekil.Text = "Bitir";
            }
        }

        private void BtnA_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayerseyirci.close();
            axWindowsMediaPlayersüre.close();
            Btnsonraki.Enabled = true;
            textBox2.Visible = false;
            şıkpasif();
            timer1.Enabled = false;
            if (BtnA.Text == Lbldoğru.Text)
            {
                axWindowsMediaPlayerdogru.URL = "C:\\Users\\ASUS\\Desktop\\Çalışmalarım\\C# Form\\Projeler\\Bilgi yarışma\\müzik\\doğru.mp3";
                BtnA.BackColor = Color.Green;
                Lblbilgi.Text = "Tebrikler Doğru Cevap";
            }
            else
            {
                axWindowsMediaPlayerdogru.URL = "C:\\Users\\ASUS\\Desktop\\Çalışmalarım\\C# Form\\Projeler\\Bilgi yarışma\\müzik\\Yanlış.mp3";
                Btnsüredur.Enabled = false;
                Btnseyirci.Enabled = false;
                Btnsorudegistir.Enabled = false;
                Btnyarıyarıya.Enabled = false;
                textBox2.Visible = true;
                Btnçekil.Visible = false;
                Btnbitir.Visible = true;
                Btnsonraki.Visible = false;
                BtnA.BackColor = Color.Red;
                textBox2.Text = "Malesef Yanlış Cevap cevap " + Lbldoğru.Text.ToString() + " olacaktı";
                kontrol();
                renkayar();
                if (BtnB.Text == Lbldoğru.Text)
                {
                    BtnB.BackColor = Color.Green;
                }
                if (BtnC.Text == Lbldoğru.Text)
                {
                    BtnC.BackColor = Color.Green;
                }
                if (BtnD.Text == Lbldoğru.Text)
                {
                    BtnD.BackColor = Color.Green;
                }
            }
        }

        private void BtnB_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayerseyirci.close();
            axWindowsMediaPlayersüre.close();
            Btnsonraki.Enabled = true;
            textBox2.Visible = false;
            şıkpasif();
            timer1.Enabled = false;
            if (BtnB.Text == Lbldoğru.Text)
            {
                axWindowsMediaPlayerdogru.URL = "C:\\Users\\ASUS\\Desktop\\Çalışmalarım\\C# Form\\Projeler\\Bilgi yarışma\\müzik\\doğru.mp3";
                BtnB.BackColor = Color.Green;
                Lblbilgi.Text = "Tebrikler Doğru Cevap";
            }
            else
            {
                axWindowsMediaPlayerdogru.URL = "C:\\Users\\ASUS\\Desktop\\Çalışmalarım\\C# Form\\Projeler\\Bilgi yarışma\\müzik\\Yanlış.mp3";
                Btnsüredur.Enabled = false;
                Btnseyirci.Enabled = false;
                Btnsorudegistir.Enabled = false;
                Btnyarıyarıya.Enabled = false;
                textBox2.Visible = true;
                Btnçekil.Visible = false;
                Btnbitir.Visible = true;
                Btnsonraki.Visible = false;
                BtnB.BackColor = Color.Red;
                textBox2.Text = "Malesef Yanlış Cevap cevap " + Lbldoğru.Text.ToString() + " olacaktı";
                kontrol();
                renkayar();
                if (BtnA.Text == Lbldoğru.Text)
                {
                    BtnA.BackColor = Color.Green;
                }
                if (BtnC.Text == Lbldoğru.Text)
                {
                    BtnC.BackColor = Color.Green;
                }
                if (BtnD.Text == Lbldoğru.Text)
                {
                    BtnD.BackColor = Color.Green;
                }
            }
        }

        private void BtnC_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayerseyirci.close();
            axWindowsMediaPlayersüre.close();
            Btnsonraki.Enabled = true;
            textBox2.Visible = false;
            şıkpasif();
            timer1.Enabled = false;
            if (BtnC.Text == Lbldoğru.Text)
            {

                axWindowsMediaPlayerdogru.URL = "C:\\Users\\ASUS\\Desktop\\Çalışmalarım\\C# Form\\Projeler\\Bilgi yarışma\\müzik\\doğru.mp3";
                BtnC.BackColor = Color.Green;
                Lblbilgi.Text = "Tebrikler Doğru Cevap";
            }
            else
            {
                axWindowsMediaPlayerdogru.URL = "C:\\Users\\ASUS\\Desktop\\Çalışmalarım\\C# Form\\Projeler\\Bilgi yarışma\\müzik\\Yanlış.mp3";
                Btnsüredur.Enabled = false;
                Btnseyirci.Enabled = false;
                Btnsorudegistir.Enabled = false;
                Btnyarıyarıya.Enabled = false;
                textBox2.Visible = true;
                Btnçekil.Visible = false;
                Btnbitir.Visible = true;
                Btnsonraki.Visible = false;
                BtnC.BackColor = Color.Red;
                textBox2.Text = "Malesef Yanlış Cevap cevap " + Lbldoğru.Text.ToString() + " olacaktı";
                kontrol();
                renkayar();
                if (BtnB.Text == Lbldoğru.Text)
                {
                    BtnB.BackColor = Color.Green;
                }
                if (BtnA.Text == Lbldoğru.Text)
                {
                    BtnA.BackColor = Color.Green;
                }
                if (BtnD.Text == Lbldoğru.Text)
                {
                    BtnD.BackColor = Color.Green;
                }
            }
        }

        private void BtnD_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayerseyirci.close();
            axWindowsMediaPlayersüre.close();
            Btnsonraki.Enabled = true;
            textBox2.Visible = false;
            şıkpasif();
            timer1.Enabled = false;
            if (BtnD.Text == Lbldoğru.Text)
            {
                axWindowsMediaPlayerdogru.URL = "C:\\Users\\ASUS\\Desktop\\Çalışmalarım\\C# Form\\Projeler\\Bilgi yarışma\\müzik\\doğru.mp3";
                BtnD.BackColor = Color.Green;
                Lblbilgi.Text = "Tebrikler Doğru Cevap";
            }
            else
            {
                axWindowsMediaPlayerdogru.URL = "C:\\Users\\ASUS\\Desktop\\Çalışmalarım\\C# Form\\Projeler\\Bilgi yarışma\\müzik\\Yanlış.mp3";
                Btnsüredur.Enabled = false;
                Btnseyirci.Enabled = false;
                Btnsorudegistir.Enabled = false;
                Btnyarıyarıya.Enabled = false;
                textBox2.Visible = true;
                Btnçekil.Visible = false;
                Btnbitir.Visible = true;
                Btnsonraki.Visible = false;
                BtnD.BackColor = Color.Red;
                textBox2.Text = "Malesef Yanlış Cevap cevap " + Lbldoğru.Text.ToString() + " olacaktı";
                kontrol();
                renkayar();
                if (BtnB.Text == Lbldoğru.Text)
                {
                    BtnB.BackColor = Color.Green;
                }
                if (BtnC.Text == Lbldoğru.Text)
                {
                    BtnC.BackColor = Color.Green;
                }
                if (BtnA.Text == Lbldoğru.Text)
                {
                    BtnA.BackColor = Color.Green;
                }
            }
        }
        private void button21_Click(object sender, EventArgs e)
        {
            Form3 yeni = new Form3();
            yeni.Show();
            this.Hide();
        }
        private void Btnçekil_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayerdogru.close();
            axWindowsMediaPlayerseyirci.close();
            axWindowsMediaPlayersüre.close();
            axWindowsMediaPlayeryanlıs.close();
            if (sayac == 1)
            {
                Btn500.BackColor = Color.Black;
            }
            if (sayac == 2)
            {
                Btn1000.BackColor = Color.Black;
            }
            if (sayac == 3)
            {
                Btn2000.BackColor = Color.Black;
            }
            if (sayac == 4)
            {
                Btn3000.BackColor = Color.Black;
            }
            if (sayac == 5)
            {
                Btn5000.BackColor = Color.Black;
            }
            if (sayac == 6)
            {
                Btn7500.BackColor = Color.Black;
            }
            if (sayac == 7)
            {
                Btn15000.BackColor = Color.Black;
            }
            if (sayac == 8)
            {
                Btn30000.BackColor = Color.Black;
            }
            if (sayac == 9)
            {
                Btn60000.BackColor = Color.Black;
            }
            if (sayac == 10)
            {
                Btn125000.BackColor = Color.Black;
            }
            if (sayac == 11)
            {
                Btn250000.BackColor = Color.Black;
            }
            if (sayac == 12)
            {
                Btn1mlyn.BackColor = Color.Black;
            }
            timer1.Enabled = false;
            Kaydetmeformu();
            Btnçekil.Enabled = false;
            Btnsüredur.Enabled = false;
            Btnseyirci.Enabled = false;
            Btnsorudegistir.Enabled = false;
            Btnyarıyarıya.Enabled = false;
            Btnsonraki.Visible = false;
            textBox2.Visible = false;
            BtnA.BackColor = Color.AliceBlue;
            BtnB.BackColor = Color.AliceBlue;
            BtnC.BackColor = Color.AliceBlue;
            BtnD.BackColor = Color.AliceBlue;
           
            BtnA.Text = " ";
            BtnB.Text = " ";
            BtnC.Text = " ";
            BtnD.Text = " ";
           
            textBox1.Text = "Tebrikler Yarışmamızdan " + kazanılan.ToString() + " TL kazandınız !!!!";
            textBox2.Visible = false;
            button21.Visible = true;
            button22.Visible = true;
            Btnçekil.Enabled = false;
           
            
        }

        private void button22_Click(object sender, EventArgs e)
        {
            Form1 yeni = new Form1();
            yeni.Show();
            this.Hide();
        }

        private void Btnseyirci_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayerseyirci.URL = "C:\\Users\\ASUS\\Desktop\\Çalışmalarım\\C# Form\\Projeler\\Bilgi yarışma\\müzik\\seyirci.mp3";
            axWindowsMediaPlayersüre.URL = "C:\\Users\\ASUS\\Desktop\\Çalışmalarım\\C# Form\\Projeler\\Bilgi yarışma\\müzik\\zaman.mp3";
            zaman = zaman + 5;
            Btnseyirci.Enabled = false;
            Random rastgele = new Random();
            int a = rastgele.Next(60, 100);
            textBox2.Visible = true;
            textBox2.Text = "Seyircilerimiz %" + a.ToString() + " oranında cevabın " + Lbldoğru.Text.ToString() + " olduğunu düşünüyorlar !!!";
        }

        private void Btnbitir_Click(object sender, EventArgs e)
        {
            Kazanılan_kontrol();
            Kaydetmeformu();
            axWindowsMediaPlayerdogru.close();
            axWindowsMediaPlayerseyirci.close();
            axWindowsMediaPlayersüre.close();
            axWindowsMediaPlayeryanlıs.close();
            Lblsoruno.Visible = false;
            Btnçekil.Enabled = false;
            Btnsüredur.Enabled = false;
            Btnseyirci.Enabled = false;
            Btnsorudegistir.Enabled = false;
            Btnyarıyarıya.Enabled = false;
            Btnsonraki.Visible = false;
            textBox2.Visible = false;
            BtnA.BackColor = Color.AliceBlue;
            BtnB.BackColor = Color.AliceBlue;
            BtnC.BackColor = Color.AliceBlue;
            BtnD.BackColor = Color.AliceBlue;
            timer1.Enabled = false;
            BtnA.Text = " ";
            BtnB.Text = " ";
            BtnC.Text = " ";
            BtnD.Text = " ";
            textBox2.Visible = false;
            button21.Visible = true;
            button22.Visible = true;
            Btnçekil.Enabled = false;
           
        }

        private void Btnyarıyarıya_Click(object sender, EventArgs e)
        {
            Btnyarıyarıya.Enabled = false;
            if (BtnA.Text == Lbldoğru.Text.ToString() || BtnD.Text == Lbldoğru.Text.ToString())
            {
                BtnB.Text = "";
                BtnC.Text = "";
            }
            else
            {
                BtnA.Text = "";
                BtnD.Text = "";
            }
        }

        private void Btnsorudegistir_Click(object sender, EventArgs e)
        {
            aktif();
            if (sayac < 8)
            {
                zaman = 20;
            }
            else
            {
                zaman = 40;
            }
            Btnsorudegistir.Enabled = false;
            if (sayac == 1)
            {
                baglan.Open();
                SqlCommand komut = new SqlCommand("Select *From soru1 order by NEWID()", baglan);
                SqlDataReader oku = komut.ExecuteReader();
                while (oku.Read())
                {
                    BtnA.Text = (oku["a"].ToString());
                    BtnB.Text = (oku["b"].ToString());
                    BtnC.Text = (oku["c"].ToString());
                    BtnD.Text = (oku["d"].ToString());
                    textBox1.Text = (oku["soru"].ToString());
                    Lbldoğru.Text = (oku["dogru"].ToString());
                }
                baglan.Close();
            }
            if (sayac == 2)
            {
                baglan.Open();
                SqlCommand komut = new SqlCommand("Select *From soru2 order by NEWID()", baglan);
                SqlDataReader oku = komut.ExecuteReader();
                while (oku.Read())
                {
                    BtnA.Text = (oku["a"].ToString());
                    BtnB.Text = (oku["b"].ToString());
                    BtnC.Text = (oku["c"].ToString());
                    BtnD.Text = (oku["d"].ToString());
                    textBox1.Text = (oku["soru"].ToString());
                    Lbldoğru.Text = (oku["dogru"].ToString());
                }
                baglan.Close();
            }
            if (sayac == 3)
            {
                baglan.Open();
                SqlCommand komut = new SqlCommand("Select *From soru3 order by NEWID()", baglan);
                SqlDataReader oku = komut.ExecuteReader();
                while (oku.Read())
                {
                    BtnA.Text = (oku["a"].ToString());
                    BtnB.Text = (oku["b"].ToString());
                    BtnC.Text = (oku["c"].ToString());
                    BtnD.Text = (oku["d"].ToString());
                    textBox1.Text = (oku["soru"].ToString());
                    Lbldoğru.Text = (oku["dogru"].ToString());
                }
                baglan.Close();
            }
            if (sayac == 4)
            {
                baglan.Open();
                SqlCommand komut = new SqlCommand("Select *From soru4 order by NEWID()", baglan);
                SqlDataReader oku = komut.ExecuteReader();
                while (oku.Read())
                {
                    BtnA.Text = (oku["a"].ToString());
                    BtnB.Text = (oku["b"].ToString());
                    BtnC.Text = (oku["c"].ToString());
                    BtnD.Text = (oku["d"].ToString());
                    textBox1.Text = (oku["soru"].ToString());
                    Lbldoğru.Text = (oku["dogru"].ToString());
                }
                baglan.Close();
            }
            if (sayac == 5)
            {
                baglan.Open();
                SqlCommand komut = new SqlCommand("Select *From soru5 order by NEWID()", baglan);
                SqlDataReader oku = komut.ExecuteReader();
                while (oku.Read())
                {
                    BtnA.Text = (oku["a"].ToString());
                    BtnB.Text = (oku["b"].ToString());
                    BtnC.Text = (oku["c"].ToString());
                    BtnD.Text = (oku["d"].ToString());
                    textBox1.Text = (oku["soru"].ToString());
                    Lbldoğru.Text = (oku["dogru"].ToString());
                }
                baglan.Close();
            }
            if (sayac == 6)
            {
                baglan.Open();
                SqlCommand komut = new SqlCommand("Select *From soru6 order by NEWID()", baglan);
                SqlDataReader oku = komut.ExecuteReader();
                while (oku.Read())
                {
                    BtnA.Text = (oku["a"].ToString());
                    BtnB.Text = (oku["b"].ToString());
                    BtnC.Text = (oku["c"].ToString());
                    BtnD.Text = (oku["d"].ToString());
                    textBox1.Text = (oku["soru"].ToString());
                    Lbldoğru.Text = (oku["dogru"].ToString());
                }
                baglan.Close();
            }
            if (sayac == 7)
            {
                baglan.Open();
                SqlCommand komut = new SqlCommand("Select *From soru7 order by NEWID()", baglan);
                SqlDataReader oku = komut.ExecuteReader();
                while (oku.Read())
                {
                    BtnA.Text = (oku["a"].ToString());
                    BtnB.Text = (oku["b"].ToString());
                    BtnC.Text = (oku["c"].ToString());
                    BtnD.Text = (oku["d"].ToString());
                    textBox1.Text = (oku["soru"].ToString());
                    Lbldoğru.Text = (oku["dogru"].ToString());
                }
                baglan.Close();
            }
            if (sayac == 8)
            {
                baglan.Open();
                SqlCommand komut = new SqlCommand("Select *From soru8 order by NEWID()", baglan);
                SqlDataReader oku = komut.ExecuteReader();
                while (oku.Read())
                {
                    BtnA.Text = (oku["a"].ToString());
                    BtnB.Text = (oku["b"].ToString());
                    BtnC.Text = (oku["c"].ToString());
                    BtnD.Text = (oku["d"].ToString());
                    textBox1.Text = (oku["soru"].ToString());
                    Lbldoğru.Text = (oku["dogru"].ToString());
                }
                baglan.Close();
            }
            if (sayac == 9)
            {
                baglan.Open();
                SqlCommand komut = new SqlCommand("Select *From soru9 order by NEWID()", baglan);
                SqlDataReader oku = komut.ExecuteReader();
                while (oku.Read())
                {
                    BtnA.Text = (oku["a"].ToString());
                    BtnB.Text = (oku["b"].ToString());
                    BtnC.Text = (oku["c"].ToString());
                    BtnD.Text = (oku["d"].ToString());
                    textBox1.Text = (oku["soru"].ToString());
                    Lbldoğru.Text = (oku["dogru"].ToString());
                }
                baglan.Close();
            }
            if (sayac == 10)
            {
                baglan.Open();
                SqlCommand komut = new SqlCommand("Select *From soru10 order by NEWID()", baglan);
                SqlDataReader oku = komut.ExecuteReader();
                while (oku.Read())
                {
                    BtnA.Text = (oku["a"].ToString());
                    BtnB.Text = (oku["b"].ToString());
                    BtnC.Text = (oku["c"].ToString());
                    BtnD.Text = (oku["d"].ToString());
                    textBox1.Text = (oku["soru"].ToString());
                    Lbldoğru.Text = (oku["dogru"].ToString());
                }
                baglan.Close();
            }
            if (sayac == 11)
            {
                baglan.Open();
                SqlCommand komut = new SqlCommand("Select *From soru11 order by NEWID()", baglan);
                SqlDataReader oku = komut.ExecuteReader();
                while (oku.Read())
                {
                    BtnA.Text = (oku["a"].ToString());
                    BtnB.Text = (oku["b"].ToString());
                    BtnC.Text = (oku["c"].ToString());
                    BtnD.Text = (oku["d"].ToString());
                    textBox1.Text = (oku["soru"].ToString());
                    Lbldoğru.Text = (oku["dogru"].ToString());
                }
                baglan.Close();
            }
            if (sayac == 12)
            {
                baglan.Open();
                SqlCommand komut = new SqlCommand("Select *From soru12 order by NEWID()", baglan);
                SqlDataReader oku = komut.ExecuteReader();
                while (oku.Read())
                {
                    BtnA.Text = (oku["a"].ToString());
                    BtnB.Text = (oku["b"].ToString());
                    BtnC.Text = (oku["c"].ToString());
                    BtnD.Text = (oku["d"].ToString());
                    textBox1.Text = (oku["soru"].ToString());
                    Lbldoğru.Text = (oku["dogru"].ToString());
                }
                baglan.Close();
            }
        }

        private void Btnsüredur_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;
            Btnsüredur.Enabled = false;
            axWindowsMediaPlayersüre.close();
        }
        
        private void Kaydetmeformu()
        {
            Form4 fr = new Form4();
            fr.Txtkazanılan.Text = kazanılan.ToString();
            fr.ShowDialog();

           
        }

        private void Kazanılan_kontrol()
        {
            if (sayac <= 2)
            {
                kazanılan = 0;
            }
            else if(sayac > 2 && sayac < 8)
            {
                kazanılan = 1000;
            }
            else
            {
                kazanılan = 15000;
            }
        }

       

    }
}
