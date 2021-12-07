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

namespace Simulador
{
    public class Class1
    {

        private static System.Timers.Timer aTimer;

        public static void It()
        {
            // Create a timer and set a two second interval
            aTimer = new System.Timers.Timer();
            aTimer.Interval = 2000;

            // Hook up the Elapsed event for the timer. 
            aTimer.Elapsed += OnTimedEvent;

            // Have the timer fire repeated events (true is the default)
            aTimer.AutoReset = true;

            // Start the timer
            aTimer.Enabled = true;

            MessageBox.Show("teste");
        }

        private static void OnTimedEvent(Object source, System.Timers.ElapsedEventArgs e)
        {
            MessageBox.Show("teste");

            if (elevadorTrab2.Global.checkbox2)
            {
                Random randNum = new Random(); //criando um objeto aleatório chamado randNum
                elevadorTrab2.Global.statusElevador = randNum.Next(1, 5);
                // listaResultado.Items.Add(randNum.Next(6));


            }
        }
    }


}