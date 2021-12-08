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
using automatico;

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
            Global.tempo++;
            //segundos--;
            if (Global.tempo == 3)
            {

                automatico.ClasseAutomatico.Aleatorio();
                Global.tempo = 0;
            }

            manual.ClasseManual.FuncManual();

            panel9.Visible = Global.panel_9;
            panel8.Visible = Global.panel_8;
            textBox1.Text = Global.text;
            
        }
        
        private void checkBox1_CheckedChanged(object sender, EventArgs e) //Manual
        {
            Global.checkbox1 = checkBox1.Checked;
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

        private void checkBox2_CheckedChanged(object sender, EventArgs e) //automatico
        {
            Global.checkbox2 = checkBox2.Checked;
            Global.statusAndar = new int[6] {0, 0, 0, 0, 0, 0};
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
        public static bool checkbox1 = false;
        public static bool panel_9 = false;
        public static bool panel_8 = false;
        public static string text = "1";
        public static int tempo = 2;
    }
}
