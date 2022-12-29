using System;

namespace MyDictionaryExample
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDictionary<string> mydictionary = new MyDictionary<string>();

            mydictionary.Add("ADD");
        }
    }
    class MyDictionary<T>
    {
        T[] array;
        T[] _tempArray;
        public MyDictionary()
        {
            array = new T[0];
        }

        public void Add(T item) 
        {
            _tempArray = array;
            array = new T[_tempArray.Length+1];
            for (int i = 0; i < array.Length; i++)
            {
                _tempArray[i] = array[i];
            }

            array[array.Length - 1] = item;
        }
    }
}
