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
        int segundos; //auxiliar timer
        int aux=0; //auxiliar botoes
        int auxFinal = 0; //auxiliar botoes

        public Form1()
        {
            InitializeComponent();          
        }

        

        private void dButton1_Click(object sender, EventArgs e) //botao acionado
        {
            if (checkBox1.Checked && !checkBox2.Checked)
            {
                timer1.Start(); //inicia a contagem do timer
                aux = 1;                
            }

            if (!checkBox1.Checked)
            {
                MessageBox.Show("Selecione o modo de operação Manual");
            }
        }

        private void dButton2_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked && !checkBox2.Checked)
            {
                timer1.Start();
                aux = 2;
                
            }
            if (!checkBox1.Checked)
            {
                MessageBox.Show("Selecione o modo de operação Manual");
            }
        }

        private void dButton3_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked && !checkBox2.Checked)
            {
                timer1.Start();
                aux = 3;
               
            }
            if (!checkBox1.Checked)
            {
                MessageBox.Show("Selecione o modo de operação Manual");
            }
        }

        private void dButton4_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked && !checkBox2.Checked)
            {
                timer1.Start();
                aux = 4;
               
            }
            if (!checkBox1.Checked)
            {
                MessageBox.Show("Selecione o modo de operação Manual");
            }
        }

        private void dButton5_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked && !checkBox2.Checked)
            {
                timer1.Start();
                aux = 5;
              
            }
            if (!checkBox1.Checked)
            {
                MessageBox.Show("Selecione o modo de operação Manual");
            }
        }

        private void fButton1_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked && !checkBox2.Checked)
            {
                timer1.Start();
                aux = 1;
               
            }
            if (!checkBox1.Checked)
            {
                MessageBox.Show("Selecione o modo de operação Manual");
            }
        }

        private void fButton2_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked && !checkBox2.Checked)
            {
                timer1.Start();
                aux = 2;
                
            }
            if (!checkBox1.Checked)
            {
                MessageBox.Show("Selecione o modo de operação Manual");
            }
        }

        private void fButton3_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked && !checkBox2.Checked)
            {
                timer1.Start();
                aux = 3;
               
            }
            if (!checkBox1.Checked)
            {
                MessageBox.Show("Selecione o modo de operação Manual");
            }
        }

        private void fButton4_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked && !checkBox2.Checked)
            {
                timer1.Start();
                aux = 4;
               
            }
            if (!checkBox1.Checked)
            {
                MessageBox.Show("Selecione o modo de operação Manual");
            }
        }

        private void fButton5_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked && !checkBox2.Checked)
            {
                timer1.Start();
                aux = 5;
               
            }
            if (!checkBox1.Checked)
            {
                MessageBox.Show("Selecione o modo de operação Manual");
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            segundos = 1;
            segundos--;
            
            if (segundos == 0 && checkBox1.Checked)
            {
                //loop

                //while
                //if (aux > auxFinal)
                //{
                    //aux--;


                    //if (aux < auxFinal)
                    //{
                        //aux++;


                        //if (aux == auxFinal)
                        //{




                            if (aux == 1)
                            {
                                timer1.Stop();
                                auxFinal = aux;
                                textBox1.Text = "1"; //Alterando as propriedades do Objeto 
                            }
                            if (aux == 2)
                            {
                                timer1.Stop();
                                auxFinal = aux;
                                textBox1.Text = "2"; //Alterando as propriedades do Objeto 
                                panel8.Visible = false;
                            }
                            if (aux == 3)
                            {
                                timer1.Stop();
                                auxFinal = aux;
                                textBox1.Text = "3"; //Alterando as propriedades do Objeto 
                            }
                            if (aux == 4)
                            {
                                timer1.Stop();
                                auxFinal = aux;
                                textBox1.Text = "4"; //Alterando as propriedades do Objeto 
                            }
                            if (aux == 5)
                            {
                                timer1.Stop();
                                auxFinal = aux;
                                textBox1.Text = "5"; //Alterando as propriedades do Objeto 
                            }
                        //}

                    //}
                //}
            }
            
        }    
        
        private void checkBox1_CheckedChanged(object sender, EventArgs e) //Manual
        {
            if (checkBox1.Checked && !checkBox2.Checked)
            {
                MessageBox.Show("Elevador em modo Manual");
            }
            if (checkBox1.Checked && checkBox2.Checked)
            {
                //checkBox2.CheckState = false;
                //checkBox1.CheckState = false;
                MessageBox.Show("Selecione apenas um modo de operação");
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e) //Automatico
        {
            if(checkBox2.Checked && !checkBox1.Checked)
            {
                MessageBox.Show("Elevador em modo Automático"); 
                //lógica automático
            }
            if (checkBox1.Checked && checkBox2.Checked)
            {
                //checkBox2.CheckState = false;
                //checkBox1.CheckState = false;
                MessageBox.Show("Selecione apenas um modo de operação");
            }
        }
    }
}
