using System;
using System.Timers;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using elevadorTrab2;

namespace automatico
{
    public class ClasseAutomatico
    {



        public async static void Aleatorio()
        {
            //MessageBox.Show("teste");

            if (elevadorTrab2.Global.checkbox2)
            {
                Random randNum = new Random(); //criando um objeto aleatório chamado randNum
                                               //for (int k = 1; k <= 30; k++)
                                               //{
                int numero = randNum.Next(6);
                elevadorTrab2.Global.statusAndar[numero] = 1;
                await Task.Delay(3000);
                // listaResultado.Items.Add(randNum.Next(6));
                //}

            }
        }
    }


}