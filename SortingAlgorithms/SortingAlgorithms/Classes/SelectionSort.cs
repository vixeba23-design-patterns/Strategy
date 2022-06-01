using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingAlgorithms.Classes
{
    public class SelectionSort : IStrategy
    {
        public void SortIntegers(int[] data)
        {
            int indexOfMinValue = 0;
            for (int i = 0; i < data.Length; i++)
            {
                indexOfMinValue = i;
                for(int j = i; j < data.Length; j++)
                {
                    if (data[j] < data[indexOfMinValue])
                    {
                        indexOfMinValue = j;
                    }
                }

                (data[i], data[indexOfMinValue]) = (data[indexOfMinValue], data[i]);

            }
            Console.WriteLine("Sorted by Selection Sort");
        }
    }
}
