using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase8MatrizMultidimensional
{
    internal class Matriz
    {
        //Creamos una clase Matriz, que permite procesar una matriz mediante unos parámetros o inicializarla por defecto en 2 filas y 3 columnas.
        //A su vez declaramos unas constantes que usaremos en los métodos Mostrar e Ingresar

        private int[,] _matriz;
        private const int DIMENSION_FILA = 0;
        private const int DIMENSION_COLUMNA = 1;


        public Matriz(int filas , int columnas)
        {




            if (columnas > 0 && filas > 0)
            {
                _matriz = new int[filas, columnas];
            }
            else
            {
                new Matriz();
            }


        }

        public Matriz()
        {
            _matriz = new int[2, 3]; //matriz por defecto
        }

        //Acá se muestra cómo recorrer una matriz mediante ciclos for anidados. Noten que para recorrer una Matriz deben tener en cuenta su dimensión.
        //En este caso la matriz es de 2 dimensiones, por lo tanto, necesitamos 2 ciclos para recorrer TODOS sus valores
        public void Ingresar()
        {     
            for (int filas = 0; filas < _matriz.GetLength(DIMENSION_FILA); filas++)
            {   
                for (int columnas = 0; columnas < _matriz.GetLength(DIMENSION_COLUMNA); columnas++)
                {
                    Console.WriteLine($"Ingrese valor entero en la posicion [{filas + 1} , {columnas + 1}] : ");
                    string linea;
                    linea = Console.ReadLine();
                    try 
                    {
                        _matriz[filas, columnas] = int.Parse(linea);
                    
                    }catch(Exception ex)
                    {
                        columnas = columnas - 1;
                        Console.WriteLine("ERROR CRITICO" + ex.Message );
                    }
                }
            }
        }

        public void Imprimir()
        {   
            for ( int filas = 0; filas < _matriz.GetLength(DIMENSION_FILA); filas++)
            {   
                for (int columnas = 0; columnas < _matriz.GetLength(DIMENSION_COLUMNA); columnas++)
                {
                    Console.WriteLine(_matriz[filas, columnas] + " ");
                }
                Console.WriteLine();
            }
        }

    }
}
