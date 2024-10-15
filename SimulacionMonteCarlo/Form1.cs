using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SimulacionMonteCarlo.Clase;

namespace SimulacionMonteCarlo

{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Equals("") || textBox2.Text.Equals("") || textBox3.Text.Equals("") || textBox4.Text.Equals(""))
            {
                MessageBox.Show("Este valor tiene que ser mayor que 0, no debe estar vacio");
                return;
            }
            int n = Convert.ToInt32(textBox1.Text);
            int n1 = Convert.ToInt32(textBox2.Text);
            int minimo = Convert.ToInt32(textBox3.Text);
            int maximo = Convert.ToInt32(textBox4.Text);
            Random valor_aleatorio = new Random();
            AlgoritmoSimulacionMontecarlo sim = new AlgoritmoSimulacionMontecarlo();
            (int x_b, int v_b) = sim.Simulacion(n, n1, minimo, maximo, valor_aleatorio);
            x_b = x_b/n;
            v_b = v_b / (n * (n - 1)) - ((x_b * x_b) / (n - 1));
            MessageBox.Show("El valor de X_barra es: " + x_b + "\n"+ "El valor de V_barra es: " + v_b + "\n");



        }


    }
}
