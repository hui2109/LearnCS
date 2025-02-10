using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _53_MyEnumerator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] nums1 = { 1, 2, 3, 4, 5 };
            ReadOnlyCollection readOnlyCollection = new ReadOnlyCollection(nums1);
            foreach (int item in readOnlyCollection)
            {
                Console.WriteLine(item);
            }
        }
    }

    class ReadOnlyCollection : IEnumerable
    {
        private int[] _myIntArray;
        public ReadOnlyCollection(int[] intArray)
        {
            _myIntArray = intArray;
        }

        public IEnumerator GetEnumerator()
        {
            return new MyEnumerator(_myIntArray);
        }
    }

    class MyEnumerator : IEnumerator
    {
        private int[] _myIntArray;
        private int pointer = -1;

        public object Current => _myIntArray[pointer];

        public bool MoveNext()
        {
            if (++pointer < _myIntArray.Length)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public void Reset()
        {
            pointer = -1;
        }

        public MyEnumerator(int[] intArray)
        {
            _myIntArray = intArray;
        }
    }
}
