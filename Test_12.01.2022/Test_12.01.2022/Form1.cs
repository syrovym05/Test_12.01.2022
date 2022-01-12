using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Test_12._01._2022
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }
        int[] pole = new int[11];
        double cislo1, cislo2, vysledek;
        bool plusB, minusB, kratB, delenoB,modulo, nadruhou,odmocnina;
        bool deleniNulou = false;

        private void nula_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            deleniNulou = delenoB;            
            textBox1.Text += "0";
        }
        private void jedna_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox1.Text  += "1";
        }
        private void dva_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox1.Text += "2";
        }

        private void tri_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox1.Text += "3";
        }

        private void ctyri_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox1.Text += "4";
        }

        private void pet_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox1.Text += "5";
        }

        private void sest_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox1.Text += "6";
        }

        private void sedm_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox1.Text += "7";
        }

        

        private void osm_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox1.Text += "8";
        }
       
        private void devet_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox1.Text += "9";
        }      

        private void AC_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
        }

        

        private void rovnase_Click(object sender, EventArgs e)
        {
            if (plusB)
            {                
                cislo2 = Convert.ToDouble(textBox1.Text);
                vysledek = cislo1 + cislo2;
                plusB = false;
            }
            if (minusB)
            {
                cislo2 = Convert.ToDouble(textBox1.Text);
                vysledek = cislo1 - cislo2;
                minusB = false;
            }
            if(kratB)
            {
                cislo2 = Convert.ToDouble(textBox1.Text);
                vysledek = cislo1 * cislo2;
                kratB = false;
            }
            if (deleniNulou) MessageBox.Show("Dělení nulou!!!", "Error",MessageBoxButtons.OK, MessageBoxIcon.Error);
            else {
                cislo2 = Convert.ToDouble(textBox1.Text);
                vysledek = cislo1 / cislo2;
                delenoB = false;
            }
            if(modulo)
            {
                cislo2 = Convert.ToDouble(textBox1.Text);
                vysledek = cislo1 % cislo2;
                modulo = false;
            }
            if(nadruhou)
            {
                cislo2 = Convert.ToDouble(textBox1.Text);
                vysledek = Math.Pow(cislo1, cislo2);
            }
            if(odmocnina)
            {
                
                vysledek = Math.Sqrt(cislo1);
                odmocnina = false;
            }
            textBox1.Text = vysledek.ToString();
            
        }

        private void plus_Click(object sender, EventArgs e)
        {
            cislo1 = Convert.ToDouble(textBox1.Text);
            textBox1.Text = "";
            textBox1.Text += "+";                       
            plusB = true;
        }
        private void minus_Click(object sender, EventArgs e)
        {
            cislo1 = Convert.ToDouble(textBox1.Text);
            textBox1.Text = "";
            textBox1.Text += "-";
            minusB = true;
        }
        private void krat_Click(object sender, EventArgs e)
        {
            cislo1 = Convert.ToDouble(textBox1.Text);
            textBox1.Text = "X";
            kratB = true;
        }
        private void deleno_Click(object sender, EventArgs e)
        {
            try
            {
                cislo1 = Convert.ToDouble(textBox1.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("Error");
            }
            textBox1.Text = "/";
            delenoB = true;
        }
        private void button19_Click(object sender, EventArgs e)
        {
            try
            {
                cislo1 = Convert.ToDouble(textBox1.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("Error");
            }
            textBox1.Text = "%";
            modulo = true;
        }
        private void button12_Click(object sender, EventArgs e)
        {
            try
            {
                cislo1 = Convert.ToDouble(textBox1.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("Error");
            }
            textBox1.Text = "SQRT";
            odmocnina = true;
        }
        private void button20_Click(object sender, EventArgs e)
        {
            try
            {
                cislo1 = Convert.ToDouble(textBox1.Text);
            }
            catch(Exception)
            {
                MessageBox.Show("Error");
            }
            textBox1.Text = "^2";
            nadruhou = true;
        }


    }
}
