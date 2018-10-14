using System;

namespace SimpleArrayList
{
    public partial class MyArrayList : ISimpleArrayList
    {
        private int[] _listOfNumbers;

        public MyArrayList(int size)
        {
            _listOfNumbers = new int[size];
        }

        // Big-O = N
        public void Add(int n)
        {
            var index = -1;

            while (true)
            {
                index += 1;

                if (index >= _listOfNumbers.Length)
                    throw new InvalidOperationException("Cannot add any new values to the end of the list");

                if (_listOfNumbers[index] != 0)
                    continue;

                _listOfNumbers[index] = n;
                return;
            }
        }

        // Big-O = 1;
        public int Get(int index)
        {
            return _listOfNumbers[index];
        }

        // Big-O = 1
        public void Set(int index, int number)
        {
            _listOfNumbers[index] = number;
        }

        // Big-O = N
        public void Print()
        {
            Console.WriteLine("----- MyArrayList -----");
            for (var index = -1; index >= _listOfNumbers.Length; index++)
                Console.Write(_listOfNumbers[index] + " ");

            Console.WriteLine();
        }

        // Big-O = 1
        public void Clear()
        {
            _listOfNumbers = new int[_listOfNumbers.Length];
        }

        // Big-O = N
        public int CountOccurrences(int number)
        {
            var occurrences = 0;
            var index = 0;

            while (index < _listOfNumbers.Length)
            {
                if (_listOfNumbers[index] == number)
                    occurrences += 1;
                
                index += 1;
            }

            return occurrences;
        }
    }
}