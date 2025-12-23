using Tyuiu.GrebenschikovAA.Sprint4.Task6.V3.Lib;

namespace Tyuiu.GrebenschikovAA.Sprint4.Task6.V3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            string[] names = ["Январь", "Февраль", "Март", "Апрель", "Май", "Июнь", "Июль", "Август", "Сентябрь", "Октябрь", "Ноябрь", "Декабрь"];
            Console.Title = "Спринт #4 | Выполнил: Гребенщиков А.А. | ИБКСб-24-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #4                                                               *");
            Console.WriteLine("* Тема: Одномерные массивы (статический ввод)                             *");
            Console.WriteLine("* Задание #0                                                              *");
            Console.WriteLine("* Вариант #27                                                             *");
            Console.WriteLine("* Выполнил: Гребенщиков Арсений | ИБКСб-24-1                              *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Дан строковый массив данных, используя класс Array,                     *");
            Console.WriteLine("* выведите элементы массива, длина которых равна 5 символам.              *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* { \"Борис\", \"Анна\", \"Михаил\", \"Ирина\", \"Сергей\", \"Татьяна\", \"Олег\" }     *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Результат:                                                              *");
            Console.WriteLine("***************************************************************************");

            string[] res = ds.Calculate(names);

            Console.Write("Элементы массива, имеющие длину меньше 6 символов: ");
            for (int i = 0; i < res.Length; i++) { Console.Write(res[i] + " "); }
            Console.ReadLine();
        }
    }
}
