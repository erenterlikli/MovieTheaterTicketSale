using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SinemaBilet
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int seans1 = 0;
        int seans2 = 0;
        int seans3 = 0;
        int seans1tl = 0;
        int seans2tl = 0;
        int seans3tl = 0;
        int misir = 0;
        int misirtl = 0;
        int kola = 0;
        int kolatl = 0;
        int su = 0;
        int sutl = 0;
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            button1.Enabled = false;
            button3.Enabled = false;
            button5.Enabled = false;
            button8.Enabled = false;
            button11.Enabled = false;
            button12.Enabled = false;

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            button6.Enabled = true;
            seans3--;
            seans3tl = seans3tl - 10;
            textBox5.Text = seans3.ToString();
            textBox6.Text = seans3tl.ToString();

            if(textBox5.Text=="0" && textBox6.Text== "0")
            {
                button5.Enabled = false;
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            button5.Enabled = true;
            seans3++;
            seans3tl = seans3tl + 10;
            textBox5.Text = seans3.ToString();
            textBox6.Text = seans3tl.ToString();

            if(textBox5.Text== "20")
            {
                button6.Enabled = false;
            }
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
       {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void label19_Click(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            button2.Enabled = true;
            seans1--;
            seans1tl = seans1tl - 8;
            textBox1.Text = seans1.ToString();
            textBox2.Text = seans1tl.ToString();

            if(textBox1.Text=="0" && textBox2.Text== "0")
            {
                button1.Enabled = false;
            }

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            button1.Enabled = true;
            seans1++;
            seans1tl = seans1tl + 8;
            textBox1.Text = seans1.ToString();
            textBox2.Text = seans1tl.ToString();

            if(textBox1.Text == "20")
            {
                button2.Enabled = false;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            button3.Enabled = true;
            seans2++;
            seans2tl = seans2tl + 9;
            textBox3.Text = seans2.ToString();
            textBox4.Text = seans2tl.ToString();

            if(textBox3.Text=="20")
            {
                button4.Enabled = false;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            button4.Enabled = true;
            seans2--;
            seans2tl = seans2tl - 9;
            textBox3.Text = seans2.ToString();
            textBox4.Text = seans2tl.ToString();

            if(textBox3.Text== "0" && textBox4.Text== "0")
            {
                button3.Enabled = false;
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            int toplambilet, toplamtl;
            toplambilet = Convert.ToInt32(textBox1.Text) + Convert.ToInt32(textBox3.Text) + Convert.ToInt32(textBox5.Text);
            label15.Text = toplambilet.ToString();

            toplamtl = Convert.ToInt32(textBox2.Text) + Convert.ToInt32(textBox4.Text) + Convert.ToInt32(textBox6.Text);
            label16.Text = toplamtl.ToString()+"TL";


        }

        private void button8_Click(object sender, EventArgs e)
        {
            button9.Enabled = true;
            misir--;
            misirtl = misirtl - 5;
            textBox7.Text = misir.ToString();
            textBox8.Text = misirtl.ToString();

            if(textBox7.Text== "0")
            {
                button8.Enabled = false;
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            button8.Enabled = true;
            misir++;
            misirtl = misirtl + 5;
            textBox7.Text = misir.ToString();
            textBox8.Text = misirtl.ToString();

           
        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void button11_Click(object sender, EventArgs e)
        {
            button10.Enabled = true;
            kola--;
            kolatl = kolatl - 3;
            textBox9.Text = kola.ToString();
            textBox10.Text = kolatl.ToString();

            if(textBox9.Text== "0")
            {
                button11.Enabled = false;
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            button11.Enabled = true;
            kola++;
            kolatl = kolatl + 3;
            textBox9.Text = kola.ToString();
            textBox10.Text = kolatl.ToString();

        }

        private void button13_Click(object sender, EventArgs e)
        {
            button12.Enabled = true;
            su++;
            sutl = sutl + 1;
            textBox11.Text = su.ToString();
            textBox12.Text = sutl.ToString();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            button13.Enabled = true;
            su--;
            sutl = sutl - 1;
            textBox11.Text = su.ToString();
            textBox12.Text = sutl.ToString();

            if(textBox11.Text== "0")
            {
                button12.Enabled = false;
            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void label18_Click(object sender, EventArgs e)
        {

        }

        private void button14_Click(object sender, EventArgs e)
        {
            int toplamurun, toplamuruntl;

            toplamurun = Convert.ToInt32(textBox7.Text) + Convert.ToInt32(textBox9.Text) + Convert.ToInt32(textBox11.Text);
            label18.Text = toplamurun.ToString();

            toplamuruntl = Convert.ToInt32(textBox8.Text) + Convert.ToInt32(textBox10.Text) + Convert.ToInt32(textBox12.Text);
            label17.Text = toplamuruntl.ToString()+ "TL";
        }

       
    }
}
