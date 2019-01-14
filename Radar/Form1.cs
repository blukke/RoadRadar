using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Radar
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

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            float r1, r2, t, vm;
            r1 = float.Parse(textBox1.Text);
            r2 = float.Parse(textBox2.Text);
            t = int.Parse(textBox3.Text);
            vm = (r2 - r1) / (t);
            label5.Text = ("Velocidade média: " + vm.ToString());
            label4.Visible = true;
            if (vm > 80)
            {
                label4.Text = ("Excesso de velocidade, multa aplicada");
            }
            else
            {
                label4.Text = "Parabéns, estás dentro dos limites parça";
            
            }

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
