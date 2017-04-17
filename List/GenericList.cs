using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace List
{
    public class GenericList<T> : IEnumerable<T>
    {
        public T[] myArray;
        private int count;
        public int Count { get; }

        public GenericList()
        {
            myArray = new T[count];
            count = 0;
        }

        public void Add(T item)
        {
            T[] addArray = new T[myArray.Length + 1];
            for (int i = 0; i < myArray.Length; i++)
            {
                addArray[i] = myArray[i];
            }
            addArray[myArray.Length] = item;
            myArray = addArray;
        }

        public void Remove(T item)
        {
            bool notFound = true;
            T[] removeArray = new T[myArray.Length - 1];
            for (int i = 0; i < myArray.Length; i++)
            {
                if (notFound)
                {
                    if (myArray[i].Equals(item))
                    {
                        notFound = false;
                    }
                    else
                    {
                        removeArray[i] = myArray[i];
                    }
                }
                else
                {
                    removeArray[i - 1] = myArray[i];
                }
            }
            myArray = removeArray;
        }


        public string GenericString()
        {
            string genericString = "";
            for (int i = 0; i < myArray.Length; i++)
            {
                genericString = genericString + ", " + myArray[i];
            }
            return genericString;
        }



        public void Print()
        {
            foreach (T item in myArray)
            {
                Console.WriteLine(item);
            }
        }

        public IEnumerator<T> GetEnumerator()
        {
            for (int i = 0; i < myArray.Length; i++)
            {
                yield return myArray[i];
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
