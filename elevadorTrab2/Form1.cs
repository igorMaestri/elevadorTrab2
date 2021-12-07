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
using Simulador;

namespace elevadorTrab2
{
    

    public partial class Form1 : Form
    {
        //int statusElevador=1; 
        //int[] statusAndar = new int[6] {0, 1, 0, 0, 0, 0 };
        //int destino = 1;

        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public Form1()
        {
            InitializeComponent();
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Start();
            log.Info("Aplicaçao iniciada");
            
            //MessageBox.Show("teste");
        }


        private void dButton1_Click(object sender, EventArgs e) //botao acionado
        {
            if (checkBox1.Checked || checkBox2.Checked)
            {
                 //inicia a contagem do timer
                Global.statusAndar[1] = 1;                
            }

            if (!checkBox1.Checked && !checkBox2.Checked)
            {
                MessageBox.Show("Selecione um modo de operação");
            }
        }

        private void dButton2_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked || checkBox2.Checked)
            {
                //inicia a contagem do timer
                Global.statusAndar[2] = 1;
            }

            if (!checkBox1.Checked && !checkBox2.Checked)
            {
                MessageBox.Show("Selecione um modo de operação");
            }
        }

        private void dButton3_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked || checkBox2.Checked)
            {
                //inicia a contagem do timer
                Global.statusAndar[3] = 1;
            }

            if (!checkBox1.Checked && !checkBox2.Checked)
            {
                MessageBox.Show("Selecione um modo de operação");
            }
        }

        private void dButton4_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked || checkBox2.Checked)
            {
                //inicia a contagem do timer
                Global.statusAndar[4] = 1;
            }

            if (!checkBox1.Checked && !checkBox2.Checked)
            {
                MessageBox.Show("Selecione um modo de operação");
            }
        }

        private void dButton5_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked || checkBox2.Checked)
            {
                //inicia a contagem do timer
                Global.statusAndar[5] = 1;
            }

            if (!checkBox1.Checked && !checkBox2.Checked)
            {
                MessageBox.Show("Selecione um modo de operação");
            }
        }

        private void fButton1_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked && !checkBox2.Checked)
            {

                Global.statusAndar[1] = 1;

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

                Global.statusAndar[2] = 1;

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

                Global.statusAndar[3] = 1;

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

                Global.statusAndar[4] = 1;

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

                Global.statusAndar[5] = 1;

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
            Simulador.Class1.aleatorio();
           
            
            if (checkBox1.Checked || checkBox2.Checked)
            {

                for (int i = 1; i < 6; i++)
                {
                    if (Global.statusAndar[i] == 1)
                    {
                        if (((Math.Abs(Global.destino - Global.statusElevador)) >= (Math.Abs(i - Global.statusElevador))) || ((Global.destino - Global.statusElevador) == 0))
                        {
                            Global.destino = i;

                        }

                    }

                }
                if ((Global.destino - Global.statusElevador) > 0)
                {
                    Global.statusElevador++;
                    panel9.Visible = false;
                    panel8.Visible = true;
                    textBox1.Text = Global.statusElevador.ToString();
                    await Task.Delay(3000);

                }
                if ((Global.destino - Global.statusElevador) < 0)
                {
                    Global.statusElevador--;
                    panel9.Visible = true;
                    panel8.Visible = false;
                    textBox1.Text = Global.statusElevador.ToString();
                    await Task.Delay(3000);

                }
                if (Global.statusElevador == Global.destino)
                {
                    textBox1.Text = Global.statusElevador.ToString();
                    panel9.Visible = false;
                    panel8.Visible = false;
                    Global.statusAndar[Global.destino] = 0;
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
            Global.checkbox2 = checkBox2.Checked;
            if (checkBox2.Checked && !checkBox1.Checked)
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
    public static class Global
    {
        public static int statusElevador = 1;
        public static int[] statusAndar = new int[6] { 0, 1, 0, 0, 0, 0 };
        public static int destino = 1;
        public static bool checkbox2 = false;
    }
}
