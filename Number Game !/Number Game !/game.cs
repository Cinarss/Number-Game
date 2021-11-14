using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Number_Game__
{
    public partial class game : Form
    {
        public game()
        {
            InitializeComponent();
        }
        public int rastgele_sayi;
        int sayi;
        int can = 3;
        public int new_rastgele_sayi;
        int yeni_can = 3;



        private void button1_Click(object sender, EventArgs e)
        {
            sayi = Convert.ToInt32(textBox1.Text);

            if(sayi == rastgele_sayi)
            {
                label5.Text = "Tebrikler Kazandınız !!";
                button1.Enabled = false;
            }
            else if(sayi > rastgele_sayi)
            {
                label5.Text = "Aşağı";
                can = can - 1;
                label4.Text = can.ToString();
                textBox1.Clear();
            }
            else if(sayi < rastgele_sayi)
            {
                label5.Text = "Yukarı";
                can = can - 1;
                label4.Text = can.ToString();
                textBox1.Clear();
            }
            if(can == 0)
            {
                label5.Text = "Canınız kalmadı oyunu kaybettiniz";
                button1.Enabled = false;
            }

            if (sayi == new_rastgele_sayi)
            {
                label5.Text = "Tebrikler Oyunu Kazandınız";
                button1.Enabled = false;
            }
            else if (sayi > new_rastgele_sayi)
            {
                label5.Text = "Aşağı";
                yeni_can = yeni_can - 1;
                label4.Text = yeni_can.ToString();
                textBox1.Clear();
            }
            else if (sayi < new_rastgele_sayi)
            {
                label5.Text = "Yukarı";
                yeni_can = yeni_can - 1;
                label4.Text = yeni_can.ToString();
            }


            if (yeni_can == 0)
            {
                label5.Text = "Canınız kalmadı oyunu kaybettiniz";
                button1.Enabled = false;
            }

        }

        private void game_Load(object sender, EventArgs e)
        {
            Random rastgele = new Random();
            rastgele_sayi = rastgele.Next(11);
            label6.Text = rastgele_sayi.ToString();
        }

       

        private void button2_Click(object sender, EventArgs e)
        {
            Random rastgele = new Random();
            new_rastgele_sayi = rastgele.Next(11);
            label6.Text = new_rastgele_sayi.ToString();
            label4.Text = yeni_can.ToString();
            button1.Enabled = true;

            

        }
    }
}
