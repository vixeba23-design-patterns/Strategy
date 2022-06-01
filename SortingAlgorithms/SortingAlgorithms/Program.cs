using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SortingAlgorithms.Classes;

namespace SortingAlgorithms
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] tab = { 5,4,3,2,1 };


            var context = new Context();

            Console.WriteLine("Strategy is set to Bubble Sort");
            context.SetStrategy(new BubbleSort());
            context.Sort(tab);

            Console.WriteLine();
            tab = new int[] { 5, 4, 3, 2, 1 };
            

            Console.WriteLine("Strategy is set to Selection Sort");
            context.SetStrategy(new SelectionSort());
            context.Sort(tab);
    

            Console.ReadKey();
        }
    }
}
