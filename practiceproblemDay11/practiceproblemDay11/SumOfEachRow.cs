using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practiceproblemDay11
{
    internal class SumOfEachRow
    {
        public void SumOf()
        {

                int[,] matrix = {
            {1, 2, 3},
            {4, 5, 6},
            {7, 8, 9}
        };

                int rows = matrix.GetLength(0);
                int cols = matrix.GetLength(1);

                Console.WriteLine("Matrix:");

                // Print the matrix
                for (int i = 0; i < rows; i++)
                {
                    for (int j = 0; j < cols; j++)
                    {
                        Console.Write(matrix[i, j] + "\t");
                    }
                    Console.WriteLine();
                }

                Console.WriteLine("Sum of each row:");

                // Calculate and print the sum of each row
                for (int i = 0; i < rows; i++)
                {
                    int rowSum = 0;
                    for (int j = 0; j < cols; j++)
                    {
                        rowSum += matrix[i, j];
                    }
                    Console.WriteLine("Row " + (i + 1) + ": " + rowSum);
                }
            }
        }

    }
