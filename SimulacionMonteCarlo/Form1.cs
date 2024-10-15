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
            List<Asignacion> listaPaneles = sim.Simulacion(n, minimo, maximo, valor_aleatorio);
            //x_b = x_b/n;
            //v_b = v_b / (n * (n - 1)) - ((x_b * x_b) / (n - 1));
            //MessageBox.Show("El valor de X_barra es: " + x_b + "\n"+ "El valor de V_barra es: " + v_b + "\n");
            llenarGrid(listaPaneles);


        }
        public void llenarGrid(List<Asignacion> lista)
        {
            //Paso 0: Indicas el numero de columnas 
            string numeroColumna1 = "1";
            string numeroColumna2 = "2";
            string numeroColumna3 = "3";
            string numeroColumna4 = "4";
            string numeroColumna5 = "5";
            string numeroColumna6 = "6";
            string numeroColumna7 = "7";

            //Paso 1: Determinas la cantidad de columnas 
            dataGridView1.Columns.Clear();
            dataGridView1.Columns.Add(numeroColumna1, "Id");
            dataGridView1.Columns.Add(numeroColumna2, "Panel1");
            dataGridView1.Columns.Add(numeroColumna3, "Panel2");
            dataGridView1.Columns.Add(numeroColumna4, "Panel3");
            dataGridView1.Columns.Add(numeroColumna5, "Panel4");
            dataGridView1.Columns.Add(numeroColumna6, "Panel5");
            dataGridView1.Columns.Add(numeroColumna7, "PanelE");

            //Paso 2: Recorres el grid para cada fila llenas los valores aleatorios 
            for (int i = 0; i < lista.Count; i++)
            {
                dataGridView1.Rows.Add();
                dataGridView1.Rows[i].Cells[Int32.Parse(numeroColumna1) - 1].Value = (lista[i].IdPunto).ToString();
                dataGridView1.Rows[i].Cells[Int32.Parse(numeroColumna2) - 1].Value = (lista[i].Panel1).ToString();
                dataGridView1.Rows[i].Cells[Int32.Parse(numeroColumna3) - 1].Value = (lista[i].Panel2).ToString();
                dataGridView1.Rows[i].Cells[Int32.Parse(numeroColumna4) - 1].Value = (lista[i].Panel3).ToString();
                dataGridView1.Rows[i].Cells[Int32.Parse(numeroColumna5) - 1].Value = (lista[i].Panel4).ToString();
                dataGridView1.Rows[i].Cells[Int32.Parse(numeroColumna6) - 1].Value = (lista[i].Panel5).ToString();
                dataGridView1.Rows[i].Cells[Int32.Parse(numeroColumna7) - 1].Value = (lista[i].PanelE).ToString();
            }
        }


    }
}
