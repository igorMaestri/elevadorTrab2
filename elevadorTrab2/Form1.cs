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
        int statusElevador=1; //auxiliar botoes
        int auxFinal = 0; //auxiliar botoes
        int[] statusAndar = new int[6] {0, 1, 0, 0, 0, 0 };
        public Form1()
        {
            InitializeComponent();          
        }

        

        private void dButton1_Click(object sender, EventArgs e) //botao acionado
        {
            if (checkBox1.Checked && !checkBox2.Checked)
            {
                timer1.Start(); //inicia a contagem do timer
                statusAndar[1] = 1;                
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
                statusAndar[2] = 1;

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
                statusAndar[3] = 1;

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
                statusAndar[4] = 1;

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
                statusAndar[5] = 1;

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
                statusAndar[1] = 1;

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
                statusAndar[2] = 1;

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
                statusAndar[3] = 1;

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
                statusAndar[4] = 1;

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
                statusAndar[5] = 1;

            }
            if (!checkBox1.Checked)
            {
                MessageBox.Show("Selecione o modo de operação Manual");
            }
        }

        private async void timer1_Tick(object sender, EventArgs e)
        {
            segundos = 1;
            segundos--;
            
            if (segundos == 0 && checkBox1.Checked)
            {
                
                for (int i = 1; i < 6; i++)
                {
                  

                    if (statusAndar[i] == 1)
                    {
                        if ((i - statusElevador) > 0)
                        {
                            statusElevador++;
                            panel9.Visible = false;
                            panel8.Visible = true;
                            textBox1.Text = statusElevador.ToString();
                            await Task.Delay(3000); ;
         
                        }
                        if ((i - statusElevador) < 0)
                        {
                            statusElevador--;
                            panel9.Visible = true;
                            panel8.Visible = false;
                            textBox1.Text = statusElevador.ToString();
                            await Task.Delay(3000); ;

                        }
                        if (i == statusElevador)
                        {
                            textBox1.Text = statusElevador.ToString();
                            panel9.Visible = false;
                            panel8.Visible = false;
                            statusAndar[i] = 0;
                            await Task.Delay(3000); 

                        }
                        
                    }

                    
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
