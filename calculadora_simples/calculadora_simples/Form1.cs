using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calculadora_simples
{
    public partial class Form1 : Form
    {
        int v1, v2, resultado; //declaração global
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
             

            v1 = int.Parse(textBox1.Text); 

            v2 = Convert.ToInt32(textBox2.Text); 

            resultado = v1 + v2;
            textBox3.Text = resultado.ToString();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Application.Exit(); //Codigo para fechar app
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Text = "          ";
        }

        private void button2_Click(object sender, EventArgs e)
        {
         

            v1 = int.Parse(textBox1.Text);

            v2 = Convert.ToInt32(textBox2.Text);

            resultado = v1 - v2;
            textBox3.Text = resultado.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
         

            v1 = int.Parse(textBox1.Text);

            v2 = Convert.ToInt32(textBox2.Text);

            resultado = v1 * v2;
            textBox3.Text = resultado.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
        

            v1 = int.Parse(textBox1.Text);

            v2 = Convert.ToInt32(textBox2.Text);

            resultado = v1 / v2;
            textBox3.Text = resultado.ToString();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
