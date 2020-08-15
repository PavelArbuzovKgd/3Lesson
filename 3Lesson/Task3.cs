using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3Lesson
{
    class Task3
    {
        public int count;

        public int BinarySearch(int[] array, int searchedValue, int left, int right)
        {          
            while (left <= right)
            {
                count++;
                var middle = (left + right) / 2;

                if (searchedValue == array[middle])
                {
                    return middle;
                }
                else if (searchedValue < array[middle])
                {                    
                    right = middle - 1;
                }
                else
                {                   
                    left = middle + 1;
                }
            }          
            return -1;
        }
    }
}
