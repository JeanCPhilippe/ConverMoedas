using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConversordeMoedas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string moedaconv = Convert.ToString(textBox1.Text);
            if (moedaconv != "")
            {
                button1.Enabled = true;
            }
            else
            {
                button1.Enabled = false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string cmb1 = Convert.ToString(comboBox1.Text);
            string cmb2 = Convert.ToString(comboBox2.Text);
            double mconvert = Convert.ToDouble(textBox1.Text);
            if (cmb1 == cmb2)
            {
                MessageBox.Show("Informações incorretas");
                MessageBox.Show("Moedas escolhidas são iguais");            
            }
            
            if (cmb1 == "BRL")
            {
                if (cmb2 == "USD")
                {
                    mconvert = mconvert * 0.18;
                    textBox2.Text = Convert.ToString(mconvert);
                }
                else if (cmb2 == "EUR")
                {
                    mconvert = mconvert * 0.15;
                    textBox2.Text = Convert.ToString(mconvert);
                }
            } 
            if (cmb1 == "USD")
            {
                if (cmb2 == "BRL")
                {
                    mconvert = mconvert * 5.53;
                    textBox2.Text = Convert.ToString(mconvert);
                }
                else if (cmb2 == "EUR")
                {
                    mconvert = mconvert * 0.85;
                    textBox2.Text = Convert.ToString(mconvert);
                }
            }
            if (cmb1 == "EUR")
            {
                if (cmb2 == "USD")
                {
                    mconvert = mconvert * 1.16; 
                    textBox2.Text = Convert.ToString(mconvert);
                }
                else if (cmb2 == "BRL")
                {
                    mconvert = mconvert * 6.47;
                    textBox2.Text = Convert.ToString(mconvert);
                }
            }
               
                
        }
    }
}
