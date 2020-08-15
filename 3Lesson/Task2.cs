using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3Lesson
{
    class Task2
    {
        public int count;

        public void ShakerSort(int[] name)
        {
            int b = 0;
            int left = 0;//Левая граница
            int right = name.Length - 1;//Правая граница
            while (left < right)
            {
                for (int i = left; i < right; i++)//Слева направо...
                {
                    count++;
                    if (name[i] > name[i + 1])
                    {
                        b = name[i];
                        name[i] = name[i + 1];
                        name[i + 1] = b;
                        b = i;
                    }
                }
                right = b;//Сохраним последнюю перестановку как границу
                if (left >= right) break;//Если границы сошлись выходим
                for (int i = right; i > left; i--)//Справа налево...
                {
                    count++;
                    if (name[i - 1] > name[i])
                    {
                        b = name[i];
                        name[i] = name[i - 1];
                        name[i - 1] = b;
                        b = i;
                    }
                }
                left = b;//Сохраним последнюю перестановку как границу
            }
        }
    }
}
