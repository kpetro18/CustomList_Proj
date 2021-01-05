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
        public bool isFull;

        //construtor (spawner)
        public CustomList()
        {
            capacity = 4;
            isFull = false;
            myList = new T[capacity];
        }

        public void Add(T item)
        {

        }

        public void Remove()
        {

        }

    }
}
