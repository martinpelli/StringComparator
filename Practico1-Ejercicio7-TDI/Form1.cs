using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practico1_Ejercicio7_TDI
{
    public partial class Form1 : Form
    {
        private string string1;
        private string string2;
        private int sizeS1;
        private int sizeS2;
        private int[,] matrix;
        public Form1()
        {
            InitializeComponent();
        }

        private void compareButton_Click(object sender, EventArgs e)
        {
            string1 = stringTextBox.Text;
            string2 = string2TextBox.Text;
            sizeS1 = string1.Length;
            sizeS2 = string2.Length;
            matrix = new int[sizeS2, sizeS1];
            buildMatrix();
            MessageBox.Show("Cadena 1: " + string1 + "\nCadena 2: " + string2 + "\nDistancia de Levenshtein: " + matrix[sizeS2 - 1,sizeS1 - 1].ToString());

        }

        private void buildMatrix()
        {
            //Se inicializa la primer fila de la matriz con la secuencia 0,1,2,...,x
            for (int i = 0; i < sizeS1; i++)
            {
                matrix[0,i] = i;
            }

            //Se inicializa la primer columna de la matriz con la secuencia 0,1,2,...,Y
            for (int j = 0; j < sizeS2; j++)
            {
                matrix[j,0] = j;
            }

            //Si h1(j) es igual a h2(i) el costo de la celda es 0.
            //Si h1(j) es diferente a h2(i) el costo de la celda es 1.
            for (int i = 1; i < sizeS2; i++)
            {
                for (int j = 1; j < sizeS1; j++)
                {
                    if (string1.Substring(j, 1) == string2.Substring(i, 1))
                    {
                        matrix[i,j] = 0;
                    }
                    else
                    {
                        matrix[i,j] = 1;
                    }
                }
            }

            /* El valor de la celda d(i,j) es el mínimo de:
       *     - Valor de la celda (i-1,j) + 1. (eliminación)
       *     - Valor de la celda (i,j-1) + 1. (inserción)
       *     - Valor de la celda (i-1,j-1) + costo de la celda (i,j). (substitución)
            */
            int min = 0;
            for (int i = 1; i < sizeS2; i++)
            {
                for (int j = 1; j < sizeS1; j++)
                {
                    min = minimo(matrix[i - 1,j] + 1, matrix[i,j - 1] + 1);
                    matrix[i,j] = minimo(matrix[i - 1,j - 1] + matrix[i,j], min);
                }
            }

            string output = "";
            for (int i = 0; i < sizeS2; i++)
            {
                for (int j = 0; j < sizeS1; j++)
                {
                    output += (matrix[i,j].ToString() + " ");
                }
                output += "\n";
            }

            MessageBox.Show(output);


        }

        int minimo(int a, int b)
        {
            return a < b ? a : b;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}







