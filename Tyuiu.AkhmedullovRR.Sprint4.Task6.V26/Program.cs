using Tyuiu.AkhmedullovRR.Sprint4.Task6.V26.Lib;
namespace Tyuiu.AkhmedullovRR.Sprint4.Task6.V26
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт #4 | Выполнил: Ахмедуллов Р. Р. | ИСТНБ-24-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #4                                                               *");
            Console.WriteLine("* Тема: Класс Array                                                       *");
            Console.WriteLine("* Задание #6                                                              *");
            Console.WriteLine("* Вариант #26                                                             *");
            Console.WriteLine("* Выполнил: Ахмедулллв Равиль Радикович | ИСТНБ-24-1                      *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Дан строковый массив данных [\"Тюмень\", \"Тамбов\", \"Томск\", \"Омск\", \"Орёл\" *");
            Console.WriteLine("* используя класс Array, выведите элементы массива, длина которых больше 5 символов. *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("Массив: ");
            string[] array = ["Тюмень, Тамбов, Томск, Омск, Орёл"];
            foreach (string i in array)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            string[] res = ds.Calculate(array);
            Console.WriteLine("Элементы массива, длина которых больше 5 символов: ");
            foreach (string i in res)
            {
                Console.Write(i + " ");
            }
        }
    }
}