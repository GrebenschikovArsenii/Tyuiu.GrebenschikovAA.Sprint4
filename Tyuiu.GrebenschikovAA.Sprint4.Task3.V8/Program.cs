using Tyuiu.GrebenschikovAA.Sprint4.Task3.V8.Lib;

namespace Tyuiu.GrebenschikovAA.Sprint4.Task3.V8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            int[,] nums = { { 4,8,3,4,8 },
                { 5,3,5,7,8 },
                { 3,7,2,7,7 },
                { 5,2,4,6,4 },
                { 4,4,6,7,2 } };
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
            Console.WriteLine("* заполненный статическими значениями в диапазоне от 1 до 9.              *");
            Console.WriteLine("* Подсчитать произведение нечетных элементов массива.                     *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* { 9, 6, 9, 3, 7 }                                                       *");
            Console.WriteLine("* { 3, 3, 3, 8, 2 }                                                       *");
            Console.WriteLine("* { 2, 1, 3, 5, 2 }                                                       *");
            Console.WriteLine("* { 6, 2, 3, 2, 5 }                                                       *");
            Console.WriteLine("* { 4, 5, 6, 9, 5 }                                                       *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Результат:                                                              *");
            Console.WriteLine("***************************************************************************");

            Console.Write("Количество нечетных элементов массива равно " + ds.Calculate(nums));
            Console.ReadLine();
        }
    }
}
