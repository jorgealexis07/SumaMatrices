using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace Matrices
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public void LlenarMatrizC(int Filas, int Columnas, int [,] MatrizA, int[,] MatrizB)
        {
            int[,] MatrizC = new int[Filas, Columnas];
            for (int i = 0; i < Filas; i++)
            {
                for (int j = 0; j < Columnas; j++)
                {
                    MatrizC[i, j] = MatrizA[i, j] + MatrizB[i, j] ;
                }
            }

            dataGridView3.ColumnCount = Columnas;
            dataGridView3.RowCount = Filas;
            for (int i = 0; i < Filas; i++)
            {
                for (int j = 0; j < Columnas; j++)
                {
                    dataGridView3.Rows[i].Cells[j].Value = MatrizC[i, j].ToString();
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int Filas = Convert.ToInt32(textBox1.Text);
            int Columnas = Convert.ToInt32(textBox2.Text);
            int[,] MatrizA = new int[Filas, Columnas];
            for (int i = 0; i < Filas; i++)
            {
                for (int j = 0; j < Columnas; j++)
                {
                    MatrizA[i, j] = int.Parse(Interaction.InputBox("Datos i,j", ""));
                }
            }
            MessageBox.Show("Matriz A llena Exitosamente :)");
            dataGridView1.ColumnCount = Columnas;
            dataGridView1.RowCount = Filas;
            for (int i = 0; i < Filas; i++)
            {
                for (int j = 0; j < Columnas; j++)
                {
                    dataGridView1.Rows[i].Cells[j].Value = MatrizA[i, j].ToString();
                }
            }

            //MATRIZ 2..
            int[,] MatrizB = new int[Filas, Columnas];
            for (int i = 0; i < Filas; i++)
            {
                for (int j = 0; j < Columnas; j++)
                {
                    MatrizB[i, j] = int.Parse(Interaction.InputBox("Datos i,j"));
                }
            }
            MessageBox.Show("Matriz B llena Exitosamente :)");

            dataGridView2.ColumnCount = Columnas;
            dataGridView2.RowCount = Filas;
            for (int i = 0; i < Filas; i++)
            {
                for (int j = 0; j < Columnas; j++)
                {
                    dataGridView2.Rows[i].Cells[j].Value = MatrizB[i, j].ToString();
                }
            }
            LlenarMatrizC(Filas,Columnas,MatrizA,MatrizB);
        }
    }
}
