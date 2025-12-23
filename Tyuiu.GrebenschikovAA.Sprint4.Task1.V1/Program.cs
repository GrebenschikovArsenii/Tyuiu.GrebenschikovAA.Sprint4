using Tyuiu.GrebenschikovAA.Sprint4.Task1.V1.Lib;

namespace Tyuiu.GrebenschikovAA.Sprint4.Task1.V1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            int[] array = new int[10];
            Console.Title = "Спринт #4 | Выполнил: Гребенщиков А.А. | ИБКСб-24-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #4                                                               *");
            Console.WriteLine("* Тема: Одномерные массивы (статический ввод)                             *");
            Console.WriteLine("* Задание #0                                                              *");
            Console.WriteLine("* Вариант #27                                                             *");
            Console.WriteLine("* Выполнил: Гребенщиков Арсений | ИБКСб-24-1                              *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Дан одномерный целочисленный массив на 10 элементов,                    *");
            Console.WriteLine("* заполненный значениями с клавиатуры в диапазоне от 0 до 8.              *");
            Console.WriteLine("* Подсчитать сумму нечетных элементов массива.                            *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Исходные данные:                                                        *");
            Console.WriteLine("***************************************************************************");

            for (int i = 0; i < array.Length; i++)
            {
                Console.Write("Введите {0} элемент массива: ", i + 1);
                array[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Результат:                                                              *");
            Console.WriteLine("***************************************************************************");

            Console.Write("Сумма нечетных элементов массива равна " + ds.Calculate(array));
            Console.ReadLine();
        }
    }
}
