using System.Numerics;

internal class Program
{
    private static void Main(string[] args)
    {
        //Declaración e instanciación de la matriz  

        int[,] matrix = new int[2, 4];

        //Crear objeto del random
         Random random = new Random();

        //Llenemos la primera fila
        for (int i = 0; i < 4; i++) 
        { matrix[0, i] = random.Next(1, 11); }


        //Llenamos la segunda fila
        for (int i = 0; i < 4; i++)

        { matrix[1, i] = matrix[0, i] * 3; }


        Console.Write($"------ Matrix 2x4 -------\n");

        //Con estos dos Fors anidados, muestro la Matriz
        for (int f = 0;f < 2; f++) //Comienzo con las filas
        {
            for (int c = 0; c < 4; c++) //Continuo con las columnas 
            {
                Console.Write($"{matrix[f,c]}\t");
            }

            Console.WriteLine();
        }

    }
}