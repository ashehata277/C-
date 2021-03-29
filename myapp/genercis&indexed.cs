using System;
namespace myapp
{
    #region Region1
    /*
    class DataStore<T>
    {
        private T[] store; 

        public DataStore()
        {
            store = new T[10];
        }

        public DataStore(int length)
        {
            store = new T[length];
        }

        public T this[int index]
        {
            get
            {
                if (index < 0 &&  index >= store.Length)
                    throw new IndexOutOfRangeException("Index out of range");

                    return store[index];
             }

            set
            {
                if (index < 0 ||  index >= store.Length)
                    throw new IndexOutOfRangeException("Index out of range");

            store[index] = value;
            }
        }
        public int Length
        {
            get
            {
                return store.Length;
            }
        }
}
    class Program
    {
        static void Main()
        {
           DataStore<int> grades = new DataStore<int>();
            grades[0] = 100;
            grades[1] = 25;
            grades[2] = 34;
            grades[3] = 42;
            grades[4] = 12;
            grades[5] = 18;
            grades[6] = 2;
            grades[7] = 95;
            grades[8] = 75;
            grades[9] = 53;
            for (int i = 0; i < grades.Length;i++)
                Console.WriteLine(grades[i]);
        }
    }*/
    #endregion
}