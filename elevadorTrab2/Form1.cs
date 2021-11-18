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
        int statusElevador=1; 
        int[] statusAndar = new int[6] {0, 1, 0, 0, 0, 0 };
        int destino = 1;

        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public Form1()
        {
            InitializeComponent();          
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Start();
            log.Info("Aplicaçao iniciada");
        }


        private void dButton1_Click(object sender, EventArgs e) //botao acionado
        {
            if (checkBox1.Checked && !checkBox2.Checked)
            {
                 //inicia a contagem do timer
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
                
                statusAndar[5] = 1;

            }
            if (!checkBox1.Checked)
            {
                MessageBox.Show("Selecione o modo de operação Manual");
            }
        }

        private async void timer1_Tick(object sender, EventArgs e)
        {
            //segundos = 1;
            //segundos--;
            
            if (checkBox1.Checked)
            {

                for (int i = 1; i < 6; i++)
                {
                    if (statusAndar[i] == 1)
                    {
                        if (((Math.Abs(destino - statusElevador)) >= (Math.Abs(i - statusElevador))) || ((destino - statusElevador) == 0)){
                            destino = i;

                        }

                    }

                }    
                        if ((destino - statusElevador) > 0)
                        {
                            statusElevador++;
                            panel9.Visible = false;
                            panel8.Visible = true;
                            textBox1.Text = statusElevador.ToString();
                            await Task.Delay(3000);
         
                        }
                        if ((destino - statusElevador) < 0)
                        {
                            statusElevador--;
                            panel9.Visible = true;
                            panel8.Visible = false;
                            textBox1.Text = statusElevador.ToString();
                            await Task.Delay(3000);

                        }
                        if (statusElevador == destino)
                        {
                            textBox1.Text = statusElevador.ToString();
                            panel9.Visible = false;
                            panel8.Visible = false;
                            statusAndar[destino] = 0;
                            await Task.Delay(3000); 

                        
                        
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
