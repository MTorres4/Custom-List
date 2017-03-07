using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomList
{
    public class CustomList<T> : IEnumerable
    {
        public T[] items;
        private int counter;
        public int Count { get { return counter; } }
        public CustomList()
        {
            items = new T[0];
        }

        public T this[int index]
        {
            get
            {
                return this.items[index];
            }
            set
            {
                this.items[index] = value;
            }
        }

        public T GetIndex(int index)
        {
            return items[index];
        }

        public void Add(T value)
        {
            T[] newitems = new T[items.Length + 1];
            for (int index = 0; index < items.Length; index++)
            {
                newitems[index] = items[index];
            }
                newitems[newitems.Length - 1] = value;
                items = newitems;

            counter++;
        }

        public bool Remove(T value)
        {
            int valueinstance = -1;
            for (int i = 0; i < counter; i++)
            {
                if (items[i].Equals(value))
                {
                    valueinstance = i;
                }
            }
            if(valueinstance == -1)
            {
                return false;
            }
            T[] newitems = new T[counter - 1];
            bool found = false;
            for (int j = 0; j < counter; j++)
                {
                    if (j == valueinstance)
                    {
                        found = true;
                        continue;
                    }
                if (found)
                {
                    newitems[j - 1] = items[j];
                }
                    else
                {
                    newitems[j] = items[j];
                }

                }
            counter--;
            return true;
        }

        public override string ToString()
        {
            string result =  "";
            foreach(T i in items)
            {
                result += items.ToString() + " , ";
            }
            return result;  
        }

        public static CustomList<T> operator +(CustomList<T> List1, CustomList<T> List2)
        {
            CustomList<T> TempList = new CustomList<T>();
            for(int i = 0; i < List1.Count; i++)
            {
                TempList.Add(List1 [i]);
            }
            for(int j = 0; j < List2.Count; j++)
            {
                TempList.Add(List2 [j]);
            }
            return TempList;
        }

        public static CustomList<T> operator -(CustomList<T> List1, CustomList<T> List2)
        {
            CustomList<T> TempList = new CustomList<T>();
            for (int i = 0; i < List1.Count; i++)
            {
                TempList.Remove(List1 [i]);
            }
            for (int j = 0; j < List2.Count; j++)
            {
                TempList.Remove(List2 [j]);
            }
            return TempList;
        }

        public CustomList<T> Zip(CustomList<T> List1, CustomList<T> List2)
        {
            CustomList<T> TemporaryList = new CustomList<T>();
            if(List1.Count < List2.Count || List1.Count == List2.Count)
            {
                for (int i = 0; i < List1.Count; i++)
                {
                    TemporaryList.Add(List1[i]);
                    TemporaryList.Add(List2[i]);
                }
            }
            else
            {
                for (int i = 0; i < List2.Count; i++)
                {
                    TemporaryList.Add(List1[i]);
                    TemporaryList.Add(List2[i]);
                }
            }
            return TemporaryList;
        }

        public IEnumerator GetEnumerator()
        {
            foreach(var item in items)
            {
                yield return " " ;
            }
        }
    }
}
