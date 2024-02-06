using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2D_array_sum_26821
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;
            int[][] score = new int[2][] { new int[] { 1, 2, 3, 4, 5 }, new int[] { 6, 7, 8, 9 } };
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    Console.Write(score[i][j] + " ");
                    sum += Convert.ToInt32(score[i][j]); 
                }
                    Console.Write(" = " + sum);
                    sum = 0;
                    Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}
