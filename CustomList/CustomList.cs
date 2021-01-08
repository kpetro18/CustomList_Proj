using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomList
{
    public class CustomList <T> : IEnumerable
    {
        //member variables (has a)
        //setup for get/set(dont need set) and return to private variable
        public int Count; 
        T[] myList;
        public int capacity;
                    
        public T this[int i] 
        { 
            get 
            {
                return myList[i]; 
            }
        }


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
            T[] temporaryList = new T[capacity *= 2];
            for (int i = 0; i < Count; i++)
            {
                temporaryList[i] = myList[i];
            }
            myList = temporaryList;
        }

        public void Remove(T item)
        {
            CustomList<T> tempList = new CustomList<T>();
            int tempCount = Count;
            bool itemFound = false;

            for (int i = 0; i < tempCount; i++)
            {
                if (myList[i].Equals(item) && itemFound == false)
                {
                    Count--;
                    itemFound = true;
                }
                else
                {
                    tempList.Add(myList[i]);
                }
            }
            T[] tempArray = new T[tempList.Count];
            for (int i = 0; i < tempList.Count; i++)
            {
                tempArray[i] = tempList[i];
            }
            myList = tempArray;

        }

        public override string ToString()
        {
            string placeHolder = "";
            for (int i = 0; i < Count; i++)
            {
                placeHolder += myList[i].ToString();
            }
            return placeHolder;
            //look into string builder
        }

        public static CustomList<T> operator +(CustomList<T> listOne, CustomList<T> listTwo)
        {
            CustomList<T> combinedList = new CustomList<T>();
            for (int i = 0; i < listOne.Count; i++)
            {
                combinedList.Add(listOne[i]);
            }
            for (int i = 0; i < listTwo.Count; i++)
            {
                combinedList.Add(listTwo[i]);
            }
            return combinedList;
        }

        public static CustomList<T> operator -(CustomList<T> listOne, CustomList<T> listTwo)
        {
            CustomList<T> subtractedList = new CustomList<T>();
            subtractedList = listOne;
            foreach (T item in listTwo)
            {
                subtractedList.Remove(item);
            }
            return subtractedList;
        }

        public CustomList<T> Zip(CustomList<T> listTwo)
        {
            CustomList<T> tempList = new CustomList<T>();
            if (Count == listTwo.Count)
            {
                for (int i = 0; i < Count; i++)
                {
                    tempList.Add(myList[i]);
                    tempList.Add(listTwo[i]);
                }
                return tempList;
            }

            else if (Count > listTwo.Count)
            {
                for (int i = 0; i < Count; i++)
                {

                    tempList.Add(myList[i]);
                    if (listTwo.Count > i)
                    {
                        tempList.Add(listTwo[i]);

                    }
                }
                return tempList;
            }

            else if (Count < listTwo.Count)
            {
                for (int i = 0; i < listTwo.Count; i++)
                {
                    if (Count > i)
                    {
                        tempList.Add(myList[i]);
                    }
                    tempList.Add(listTwo[i]);

                }
                return tempList;
            }
            return tempList;
        }

        public IEnumerator GetEnumerator()
        {
            for (int i = 0; i < Count; i++)
            {
                yield return myList[i];
            }
        }
    }
}
