using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingAlgorithms
{
    public class Context
    {
        private IStrategy _strategy;

        public Context() { }

        public Context(IStrategy strategy)
        {
            this._strategy = strategy;
        }

        public void SetStrategy(IStrategy strategy)
        {
            this._strategy = strategy;
        }

        public void Sort(int[] data)
        {
            this._strategy.SortIntegers(data);

            Print(data);
        }

        public void Print(int[] data)
        {
            Console.WriteLine("Printed data:");
            for (int i = 0; i < data.Length; i++) { Console.Write(data[i]+" "); }
        }
    }
}
