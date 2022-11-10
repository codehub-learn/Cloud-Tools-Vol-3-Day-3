using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CTDay3
{
    internal class PluginMethods
    {
        public static List<int> IntArrayOperation(int[] numbers, OperationDelegate operation) 
        {
            List<int> operatedNumbers = new();

            foreach (int i in numbers)
            {
                int result = operation(i, "Iteration Complete");
                operatedNumbers.Add(result);
            }

            return operatedNumbers;
        }
    }
}
