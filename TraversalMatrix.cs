using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


    //Tiempo empleado: 2 horas
    public class TraversalMatrix
    {
        static void Main(string[] args)
        {
        int rows = 5;
        int columns = 5;


        int[,] matrix = { { 1, 2, 3, 4, 5 },
                          { 6, 7, 8, 9, 10},
                          { 11, 12, 13, 14, 15 },
                          { 16, 17, 18, 19, 20 },
                          { 21, 22, 23, 24, 25 } };

        TraversalMatrix matrixClass = new TraversalMatrix();

        Console.WriteLine(matrixClass.traversal(matrix, rows, columns));
        Console.In.Read();
        }


        private string traversal(int[,] m, int r, int c)
        {
            string stringBuffer = string.Empty;

        int i;
        int r_index = 0; 
        int c_index = 0;

        /* 
        r_index - index de la primera fila
        c_index - index de la primera columna
        r - nº de filas total
        c - nº de columnas total
        */

        //Límites para moverse dentro del array (index menor que nº de filas y de columnas)
        while (r_index < r && c_index < c)
        {
            //Anexamos la primera fila
            for (i = c_index; i < c; i++)
            {
                stringBuffer += m[r_index, i] + " ";
            }

            //Pasamos a la siguiente fila para la próxima iteración
            r_index++;

            //Anexamos la última columna de las columnas restantes
            for (i = r_index; i < r; i++)
            {
                stringBuffer += m[i, c - 1] + " ";
            }

            //Disminuimos el número de columnas total
            c--;

            //Si el index es menor que el número de filas total
            if (r_index < r)
            {
                //Anexamos la última fila de las filas restantes en sentido ascendente
                //Se tiene en cuenta que la fila anterior ya se había anexado
                for (i = c - 1; i >= c_index; i--)
                {
                    stringBuffer += m[r - 1, i] + " ";
                }
                //Disminuimos el número de filas total
                r--;
            }

            //Si el index es menor que el número de columnas total
            if (c_index < c)
            {
                //Anexamos la primera columna de las columas restantes
                //Se tiene en cuenta que la columna anterior ya se había anexado
                for (i = r - 1; i >= r_index; i--)
                {
                    stringBuffer += m[i, c_index] + " ";
                }

                //Pasamos a la siguiente fila para la próxima iteración
                c_index++;
            }
        }

        return stringBuffer;

        }

    }