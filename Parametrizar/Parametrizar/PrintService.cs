using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parametrizar
{
    internal class PrintService <T>
    {
        private T[] _vector = new T [10];
        private int count = 0;

        public void AddValue(T value)
        {
            if (count >= 10 )
            {
                throw new InvalidOperationException("Vector is full, not is possible added on value: ");
            }
            _vector[count] = value;
            count++;
        }

        public T First()
        {
            if (count == 0) { throw new AccessViolationException("The vector is empty."); }
            return _vector[0];
        }

        public void Print()
        {
            Console.Write("[");
            for (int i = 0; i < count -1; i++)
            {
                Console.Write($"{_vector[i]}, ");
            }
            Console.Write($"{_vector[count-1]}]");
        }

    }
}
