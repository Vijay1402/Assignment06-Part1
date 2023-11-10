using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment06_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[][] matrix = new int[3][];
            matrix[0] = new int[4] { 8, 4, 3, 2 };
            matrix[1] = new int[2] { 12, 13 };
            matrix[2] = new int[3] { 0, 5, 9 };
            int element = matrix[0][1];

            Console.WriteLine("Values of the matrix are: "); 
            for (int i = 0; i < matrix.Length; i++)
            {
                for (int j = 0; j < matrix[i].Length; j++)
                {
                    Console.Write(matrix[i][j] + " ");
                }
                Console.WriteLine();
            }
            matrix[1][1] = 15;

            dynamic objectMatrix = new dynamic[2];
            objectMatrix[0] = new dynamic[3] { 69, "This is a string", 420.69 };
            objectMatrix[1] = new dynamic[3] { true, 'F', new DateTime(12,12,12) };

            Console.WriteLine("Values of the matrix are: ");
            for (int i = 0; i < objectMatrix.Length; i++)
            {
                for (int j = 0; j < objectMatrix[i].Length; j++)
                {
                    var temp = objectMatrix[i][j];
                    Console.WriteLine("The type of object is " + temp.GetType() + " and its value is "+temp);
                }
                Console.WriteLine();
            }

            Console.ReadKey();


        }
    }
}
