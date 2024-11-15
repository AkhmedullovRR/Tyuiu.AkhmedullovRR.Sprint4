﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using tyuiu.cources.programming.interfaces.Sprint4;
namespace Tyuiu.AkhmedullovRR.Sprint4.Task5.V23.Lib
{
    public class DataService : ISprint4Task5V23

    {
        public int[,] Calculate(int[,] matrix)
        {
            int rows = matrix.GetUpperBound(0) + 1; // количество строк
            int columns = matrix.Length / rows;             // количество столбцов
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < rows; j++)
                {
                    if (matrix[i, j] < 0)
                    {
                        matrix[i, j] = 0;
                    }
                }
            }
            return matrix;
        }
    }
}