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

namespace manual
{
    public class ClasseManual
    {
        
      


        public async static void FuncManual()
        {
            if (elevadorTrab2.Global.checkbox1 || elevadorTrab2.Global.checkbox2)
            {

                for (int i = 1; i < 6; i++)
                {
                    if (elevadorTrab2.Global.statusAndar[i] == 1)
                    {
                        if (((Math.Abs(elevadorTrab2.Global.destino - elevadorTrab2.Global.statusElevador)) >= (Math.Abs(i - elevadorTrab2.Global.statusElevador))) || ((elevadorTrab2.Global.destino - elevadorTrab2.Global.statusElevador) == 0))
                        {
                            elevadorTrab2.Global.destino = i;

                        }

                    }

                }
                await Task.Delay(3000);
                if ((elevadorTrab2.Global.destino - elevadorTrab2.Global.statusElevador) > 0)
                {
                    elevadorTrab2.Global.statusElevador++;
                    elevadorTrab2.Global.panel_9 = false;
                    elevadorTrab2.Global.panel_8 = true;
                    elevadorTrab2.Global.text = elevadorTrab2.Global.statusElevador.ToString();
                    return;

                }
                if ((elevadorTrab2.Global.destino - elevadorTrab2.Global.statusElevador) < 0)
                {
                    elevadorTrab2.Global.statusElevador--;
                    elevadorTrab2.Global.panel_9 = true;
                    elevadorTrab2.Global.panel_8 = false;
                    elevadorTrab2.Global.text = elevadorTrab2.Global.statusElevador.ToString();
                    return;

                }
                if (elevadorTrab2.Global.statusElevador == elevadorTrab2.Global.destino)
                {
                    elevadorTrab2.Global.text = elevadorTrab2.Global.statusElevador.ToString();
                    elevadorTrab2.Global.panel_9 = false;
                    elevadorTrab2.Global.panel_8 = false;
                    elevadorTrab2.Global.statusAndar[elevadorTrab2.Global.destino] = 0;
                    



                }




                //}

                //}
                //}
            }
        }
    }


}