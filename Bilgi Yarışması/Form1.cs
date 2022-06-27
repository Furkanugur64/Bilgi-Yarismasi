using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bilgi_Yarışması
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }



        private void button2_Click(object sender, EventArgs e)
        {

            axWindowsMediaPlayer1.close();
            Form2 yeni = new Form2();
            yeni.Show();

            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            axWindowsMediaPlayer1.close();
            Form3 yeni = new Form3();
            yeni.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {

            axWindowsMediaPlayer1.close();
            Form5 frm = new Form5();
            frm.ShowDialog();

        }


        int sayac = 0;
        private void Form1_Load(object sender, EventArgs e)
        {
          if (sayac == 0)
            {
                axWindowsMediaPlayer1.URL = "C:\\Users\\ASUS\\Desktop\\Çalışmalarım\\C# Form\\Projeler\\Bilgi yarışma\\müzik\\giriş.mp3";
            }
            sayac++;
        }
    }
}
