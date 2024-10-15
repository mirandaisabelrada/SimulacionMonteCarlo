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
        public (int Media, int Varianza) Simulacion(int n,int n1, int minimo, int maximo, Random valor_aleatorio)
        {
            int v_aleatorio = 0;
            int x_b=0;
            int v_b = 0;
            List<int> aleatorios = new List<int>();
            List<int> cuartos = new List<int>();
            List<int> cuadrados = new List<int>();
            int cuarto = 0;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n1; j++)
                {
                    v_aleatorio = valor_aleatorio.Next(minimo, maximo);
                    aleatorios.Add(v_aleatorio);
                }
                aleatorios.Sort();
                if (aleatorios.Count > 3)
                {
                    cuarto = aleatorios[aleatorios.Count - 2];
                    cuartos.Add(cuarto);
                    cuadrados.Add(cuarto*cuarto);
                }
                else
                {
                    cuarto = aleatorios[aleatorios.Count - 1];
                    cuartos.Add(cuarto);
                    cuadrados.Add(cuarto * cuarto);
                }
               
            x_b = cuartos.Sum();
            v_b = cuadrados.Sum();
            }
            return (x_b, v_b);
        }
    }
}
