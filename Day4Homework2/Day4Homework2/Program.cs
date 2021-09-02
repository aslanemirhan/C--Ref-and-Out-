using System;

namespace Day4Homework2
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDictionary<int,string> myDictionary = new MyDictionary<int,string>();
            myDictionary.Add(1,"Emirhan Aslan");
            myDictionary.Add(2,"Engin Demiroğ");
            Console.WriteLine(myDictionary.Count);
            Console.WriteLine("---------------------");
            myDictionary.Add(3,"Murat Kurtboğan");
            Console.WriteLine(myDictionary.Count);
        }
    }

    public class MyDictionary<T,V>
    {
        T[] kArray;
        V[] vArray;
        T[] temptArray;
        V[] tempvArray;

        // constructor for dictionary
        public MyDictionary()
        {
            kArray = new T[0];
            vArray = new V[0];
        }

        //Adding key and values
        public void Add(T key, V value)
        {
            temptArray = kArray;
            kArray = new T[kArray.Length + 1];
            tempvArray = vArray;
            vArray = new V[vArray.Length + 1];

            for (int i = 0; i < temptArray.Length; i++)
            {
                kArray[i] = temptArray[i];
            }
             kArray[kArray.Length - 1] = key;

            for (int j = 0; j < tempvArray.Length; j++)
            {
                vArray[j] = tempvArray[j]; 
            }
                vArray[vArray.Length - 1] = value;
        }

        //getting value of index 
        public V[] ValueArray
        {
            get { return vArray; }
        }
        //getting key of index
        public T[] KeyArray
        {
            get { return kArray; }
        }
        public int Count
        {
            get { return kArray.Length; }
        }

    }
}
