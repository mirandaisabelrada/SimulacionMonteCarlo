using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimulacionMonteCarlo.Clase
{
    public class AlgoritmoSimulacionMontecarlo
    {
        public AlgoritmoSimulacionMontecarlo() { }
        public List<Asignacion> Simulacion(int n, int minimo, int maximo, Random valor_aleatorio)
        {
            //int v_aleatorio = 0;
            int x_b=0;
            int v_b = 0;
            List<int> aleatorios = new List<int>();
            //List<int> cuartos = new List<int>();
            //List<int> cuadrados = new List<int>();
            List<Asignacion> Paneles = new List<Asignacion>();
            //int cuarto = 0;
            for (int i = 0; i < n; i++)
            {
                Asignacion panel = new Asignacion();
                panel.IdPunto = i;
                panel.Panel1 = valor_aleatorio.Next(minimo, maximo);
                panel.Panel2 = valor_aleatorio.Next(minimo, maximo);
                panel.Panel3 = valor_aleatorio.Next(minimo, maximo);
                panel.Panel4 = valor_aleatorio.Next(minimo, maximo);
                panel.Panel5 = valor_aleatorio.Next(minimo, maximo);
                aleatorios.Add(panel.Panel1);
                aleatorios.Add(panel.Panel2);
                aleatorios.Add(panel.Panel3 );
                aleatorios.Add(panel.Panel4);
                aleatorios.Add(panel.Panel5);
                aleatorios.Sort();
                if (aleatorios.Count > 3)
                {
                    panel.PanelE = aleatorios[aleatorios.Count - 2];
                    //cuartos.Add(panel.PanelE);
                    //cuadrados.Add(panel.PanelE * panel.PanelE);
                }
                else
                {
                    panel.PanelE = aleatorios[aleatorios.Count - 1];
                    //cuartos.Add(panel.PanelE);
                    //cuadrados.Add(panel.PanelE * panel.PanelE);
                }
            Paneles.Add(panel);
            //x_b = cuartos.Sum();
            //v_b = cuadrados.Sum();
            }
            return Paneles;
        }
    }
}
