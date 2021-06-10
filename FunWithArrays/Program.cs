using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunWithArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayDeclarations();
            RecMultidimensionalArrays();
            JaggedMultidimensionalArray();

            Console.ReadLine();

        }

        private static void JaggedMultidimensionalArray()
        {
            Console.WriteLine("=> A Jagged multidimensional array");
            // declaring the jagged array
            int[][] myJaggedArray = new int[5][];
            //creating the array of arrays
            for(int i = 0; i < myJaggedArray.Length; i++)
            {
                myJaggedArray[i] =new int[i + 7];
            }
            // printing the jagged array
            for(int i = 0; i < 5; i++)
            {
                for (int j = 0; j < myJaggedArray[i].Length; j++)
                {
                    Console.Write(myJaggedArray[i][j] + "\t");
                }
                Console.WriteLine();
                Console.WriteLine();

            }

            Console.WriteLine();
        }

        private static void RecMultidimensionalArrays()
        {
            int[,] myMatrix = new int[3, 4];
            // feeding values to the matrix
            for(int i = 0; i < 3; i++)
            {
                for(int j = 0; j < 4; j++)
                {
                    myMatrix[i, j] = i * j;
                }
            }

            //printing the matrix

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    Console.Write(myMatrix[i,j]+ "\t");
                }
                Console.WriteLine();
                Console.WriteLine();

            }

        }

        private static void ArrayDeclarations()
        {
            //daclaring arrays
            int[] myInt = new int[] { 2, 3, 5, 7, 8 };

            //print the arrays
            foreach (int i in myInt)
            {
                Console.WriteLine("The integer values are: {0}", i);
                Console.WriteLine();
            }
        }
    }
}
