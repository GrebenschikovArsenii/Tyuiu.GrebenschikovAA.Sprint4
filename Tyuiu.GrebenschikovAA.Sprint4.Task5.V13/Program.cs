using Tyuiu.GrebenschikovAA.Sprint4.Task5.V13.Lib;

namespace Tyuiu.GrebenschikovAA.Sprint4.Task5.V13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Random rnd = new Random();
            Console.Title = "Спринт #4 | Выполнил: Гребенщиков А.А. | ИБКСб-24-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #4                                                               *");
            Console.WriteLine("* Тема: Одномерные массивы (статический ввод)                             *");
            Console.WriteLine("* Задание #0                                                              *");
            Console.WriteLine("* Вариант #27                                                             *");
            Console.WriteLine("* Выполнил: Гребенщиков Арсений | ИБКСб-24-1                              *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Дан двумерный целочисленный массив 5 на 5 элементов,                    *");
            Console.WriteLine("* заполненный случайными значениями в диапазоне от -8 до 9.               *");
            Console.WriteLine("* Подсчитать количество отрицательных элементов массива.                  *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            int[,] array = new int[5, 5];
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    array[i, j] = rnd.Next(-8, 10);
                    Console.Write(array[i, j] + " ");
                }
                Console.WriteLine();
            }

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Результат:                                                              *");
            Console.WriteLine("***************************************************************************");

            Console.Write("Количество элементов массива равно " + ds.Calculate(array));
            Console.ReadLine();
        }
    }
}
