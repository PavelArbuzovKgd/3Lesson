using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3Lesson
{
    class Program
    {
        static void Main(string[] args)
        {
             /* 
            1. Попробовать оптимизировать пузырьковую сортировку. Сравнить количество операций сравнения оптимизированной и не оптимизированной программы. Написать функции сортировки, которые возвращают количество операций.
            2. *Реализовать шейкерную сортировку.
            3. Реализовать бинарный алгоритм поиска в виде функции, которой передается отсортированный массив. Функция возвращает индекс найденного элемента или -1, если элемент не найден.
            4. *Подсчитать количество операций для каждой из сортировок и сравнить его с асимптотической сложностью алгоритма.
            */

            #region Заполнение массива

            Random rnd = new Random();
            Console.WriteLine("Размер массива?");
            int N = Convert.ToInt32(Console.ReadLine());
            int[] sortMas = new int[N];
            for (int i = 0; i < sortMas.Length; i++)
            {
                sortMas[i] = rnd.Next(0, 100);
            }

            #endregion

            Task1 task1 = new Task1();
            Task2 task2 = new Task2();
            Task3 task3 = new Task3();


            task1.BubbleSort(sortMas);
            Console.WriteLine("Сортировка пузырьком");
            Console.WriteLine(task1.count);
            task2.ShakerSort(sortMas);
            Console.WriteLine("Шейкер сортировка");
            Console.WriteLine(task2.count);
            Console.WriteLine("Бинарный поиск");
            Console.WriteLine("Число для поиска");
            int number = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Индекс числа {number} ={task3.BinarySearch(sortMas, number, 0, sortMas.Length - 1)} ");           
            Console.WriteLine($"Число операций {task3.count}");


            Console.ReadLine();
        }
    }
}
