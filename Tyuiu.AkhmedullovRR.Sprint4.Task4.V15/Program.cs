using Tyuiu.AkhmeduloovRR.Sprint4.Task4.V15.Lib;

namespace Tyuiu.AkhmedullovRR.Sprint4.Task4.V15
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Спринт #4 | Выполнил: Ахмедуллов Р. Р. | ИСТНб-24-1";
            /*
                Спринт #4
                Тема: Двумерные массивы. (ввод с клавиатуры)
                Задание #4
                Вариант #15
                Выполнил: Ахмедуллов Равиль Радикович | ИСТНб-24-1

                УСЛОВИЕ:
                Дан двумерный целочисленный массив 5 на 5 элементов, заполненный значениями с
                клавиатуры в диапазоне от 2 до 6. Найдите сумму нечетных элементов массива.
                4, 2, 5, 5, 3,
                4, 2, 5, 2, 2,
                3, 2, 4, 2, 4, 
                3, 6, 4, 5, 4,
                2, 4, 6, 4, 2,




             */

            int[,] A = new int[5, 5] {
               { 4, 2, 5, 5, 3, },
               { 4, 2, 5, 2, 2, },
               { 3, 2, 4, 2, 4, },
               { 3, 6, 4, 5, 4, },
               { 2, 4, 6, 4, 2, }
            };

            DataService DS = new DataService();
            var Res = DS.Calculate(A);
            Console.WriteLine("РЕЗУЛЬТАТ: " + Res);
            Console.ReadKey();
        }
    }
}