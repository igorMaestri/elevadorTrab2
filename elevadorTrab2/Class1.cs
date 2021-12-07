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

namespace Simulador
{
    public class Class1
    {

        

        public static void aleatorio()
        {
            //MessageBox.Show("teste");

            if (elevadorTrab2.Global.checkbox2)
            {
                Random randNum = new Random(); //criando um objeto aleatório chamado randNum
                int numero = randNum.Next(1, 5);
                elevadorTrab2.Global.statusAndar[numero] = 1;
                // listaResultado.Items.Add(randNum.Next(6));


            }
        }
    }


}