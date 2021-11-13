using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace elevadorTrab2
{
    public partial class Form1 : Form
    {
        int segundos;
        int aux;

        public Form1()
        {
            InitializeComponent();
        }

        private void dButton1_Click(object sender, EventArgs e)
        {
            timer1.Start();
            aux = 1;
        }

        private void dButton2_Click(object sender, EventArgs e)
        {
            timer1.Start();            
            aux = 2;
        }                                    

        private void dButton3_Click(object sender, EventArgs e)
        {
            timer1.Start();
            aux = 3;
        }

        private void dButton4_Click(object sender, EventArgs e)
        {
            timer1.Start();
            aux = 4;
        }

        private void dButton5_Click(object sender, EventArgs e)
        {
            timer1.Start();
            aux = 5;
        }

        private void fButton1_Click(object sender, EventArgs e)
        {
            timer1.Start();
            aux = 1;
        }

        private void fButton2_Click(object sender, EventArgs e)
        {
            timer1.Start();
            aux = 2;
        }

        private void fButton3_Click(object sender, EventArgs e)
        {
            timer1.Start();
            aux = 3;
        }

        private void fButton4_Click(object sender, EventArgs e)
        {
            timer1.Start();
            aux = 4;
        }

        private void fButton5_Click(object sender, EventArgs e)
        {
            timer1.Start();
            aux = 5;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            segundos = 1;
            segundos--;
            if (segundos == 0)
            {
                if (aux == 1)
                {
                    timer1.Stop();
                    textBox1.Text = "1"; //Alterando as propriedades do Objeto 
                }
                if (aux == 2)
                {
                    timer1.Stop();
                    textBox1.Text = "2"; //Alterando as propriedades do Objeto 
                }
                if (aux == 3)
                {
                    timer1.Stop();
                    textBox1.Text = "3"; //Alterando as propriedades do Objeto 
                }
                if (aux == 4)
                {
                    timer1.Stop();
                    textBox1.Text = "4"; //Alterando as propriedades do Objeto 
                }
                if (aux == 5)
                {
                    timer1.Stop();
                    textBox1.Text = "5"; //Alterando as propriedades do Objeto 
                }
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e) //Manual
        {

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e) //Automático
        {

        }

        
    }
}
