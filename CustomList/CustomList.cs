using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomList
{
    public class CustomList <T>
    {
        //member variables (has a)
        //setup for get/set(dont need set) and return to private variable
        public int Count; 
        T[] myList;
        public int capacity;

        //construtor (spawner)
        public CustomList()
        {
            Count = 0;
            capacity = 4;
            myList = new T[capacity];
        }

        public void Add(T item)
        {
            if (Count == capacity)
            {
                DoubleArraySize();
            }

            myList[Count] = item;
            Count++;

        }

        public void DoubleArraySize()
        {
            T[] temporaryList = new T[capacity * 2];
            for (int i = 0; i <= Count; i++)
            {
                temporaryList[i] = myList[i];
            }
            myList = temporaryList;
        }

        public void Remove(T item)
        {

        }

        public void ToString(T item)
        {

        }
    }
}
