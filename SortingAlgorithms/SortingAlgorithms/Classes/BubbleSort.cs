using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingAlgorithms.Classes
{
    public class BubbleSort:IStrategy
    {
        public void SortIntegers(int[] arrayOfIntegers)
        {
            for ( int i = 0; i<arrayOfIntegers.Length; i++)
            {
                for( int j = 0; j<arrayOfIntegers.Length-1; j++)
                {
                    if ( arrayOfIntegers[j] > arrayOfIntegers[j+1])
                    {
                        //Swap
                        (arrayOfIntegers[j] , arrayOfIntegers[j+1]) = (arrayOfIntegers[j+1],arrayOfIntegers[j]);
                    }
                }
            }
            Console.WriteLine("Sorted by Bubble Sort");
        }

    }
}
