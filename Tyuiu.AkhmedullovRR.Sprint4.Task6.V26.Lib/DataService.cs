﻿using tyuiu.cources.programming.interfaces.Sprint4;
namespace Tyuiu.AkhmedullovRR.Sprint4.Task6.V26.Lib
{
    public class DataService : ISprint4Task6V26
    {
        public string[] Calculate(string[] array)
        {
            string[] result = Array.FindAll(array, x => x.Length > 5);
            return result;
        }
    }
}