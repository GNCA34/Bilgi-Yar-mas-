using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bilgi_Yarismasi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int soruno = 0, dogru = 0, yanlis = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            button1.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = false;
            button5.Enabled = true;
            label7.Text = button1.Text;
            if (label4.Text == label7.Text)
            {
                dogru++;
                label5.Text = dogru.ToString();


            }
            else
            {
                yanlis++;
                label6.Text = yanlis.ToString();


            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            button1.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = false;
            button5.Enabled = true;

            label7.Text = button2.Text;
            if (label4.Text == label7.Text)
            {
                dogru++;
                label5.Text = dogru.ToString();

            }
            else
            {
                yanlis++;
                label6.Text = yanlis.ToString();

            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            button1.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = false;
            button5.Enabled = true;

            label7.Text = button3.Text;
            if (label4.Text == label7.Text)
            {
                dogru++;
                label5.Text = dogru.ToString();


            }
            else
            {
                yanlis++;
                label6.Text = yanlis.ToString();


            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            button1.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = false;
            button5.Enabled = true;

            label7.Text = button4.Text;
            if (label4.Text == label7.Text)
            {
                dogru++;
                label5.Text = dogru.ToString();


            }
            else
            {
                yanlis++;
                label6.Text = yanlis.ToString();


            }
        }

        

        private void button5_Click(object sender, EventArgs e)
        {
            button1.Enabled = true;
            button2.Enabled = true;
            button3.Enabled = true;
            button4.Enabled = true;
            button5.Enabled = false;

            soruno++;
            LblSoruno.Text = soruno.ToString();
            if (soruno==1)
            {
                richTextBox1.Text = "Cumhuriyet kaç yılında ilan edilmiştir";
                button1.Text = "1920";
                button2.Text = "1921";
                button3.Text = "1922";
                button4.Text = "1923";
                label4.Text = "1923";
            }
            if (soruno==2)
            {
                richTextBox1.Text = "Hangi il Ege bölgemizde bulunmaz?";
                button1.Text = "İzmir";
                button2.Text = "Balıkesir";
                button3.Text = "Aydın";
                button4.Text = "Manisa";
                label4.Text = "Balıkesir";

            }
            if(soruno==3)
            {
                richTextBox1.Text = "Son Kuşlar hangi yazarımıza aittir?";
                button1.Text = "Sait Faik";
                button2.Text = "Cemal Süreyya";
                button3.Text = "Atilla İlhan";
                button4.Text = "Reşat Nuri";
                label4.Text = "Sait Faik";
                button5.Text = "Sonuçlar:";


            }
            if (soruno==4)
            {
                button1.Enabled = false;
                button2.Enabled = false;
                button3.Enabled = false;
                button4.Enabled = false;
                button5.Enabled = false;
                MessageBox.Show("Doğru sayısı:" + dogru +" yanlış sayısı:"+yanlis);

            }
        }
    }
}
