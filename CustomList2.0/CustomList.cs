﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomList2._0
{
    public class CustomList<T> : IEnumerable
    {
        private int _count;
        public int count { get { return _count; } }
        private int _defCapacity = 4;
        public int capacity { get { return _defCapacity; } set { _defCapacity = value; } }
        T[] items;
        public CustomList()
        {
            items = new T[_defCapacity];
        }

        public CustomList(int item)
        {
            _defCapacity = item;
            items = new T[_defCapacity];
        }


        public T this[int index]
        {
            get
            {
                return items[index];
            }
            set
            {

                items[index] = value;
            }
        }

        public void Add(T item)
        {
            ResizeArray();
            _count++;
            
            items[_count - 1] = item;
        }

        public void Add(T item, int item1)
        {
            ResizeArray();
            _count++;
            
            for (int i = _count; i > item1; i--)
            {
                items[i] = items[i - 1];

            }
            items[item1] = item;
        }

        public void Remove(T item)
        {

            for (int i = 0; i < items.Length; i++)
            {
                if (item.Equals(items[i]))
                {
                    items[i] = default(T);
                    _count--;
                    for (int j = i; j < _count; j++)
                    {
                        items[j] = items[j + 1];

                    }
                    items[_count] = default(T);
                    break; //once it removes said instance, breaks out of loop
                }
            }
        }

        public void ResizeArray()
        {
            if (_count == capacity)
            {
                capacity = capacity * 2;
                T[] temporaryItems = new T[capacity];
                for (int i = 0; i < items.Length; i++)
                {
                    temporaryItems[i] = items[i];
                }
                items = temporaryItems;
            }
        }

        public override string ToString()
        {

            string stringifiedList = "";
            for (int i = 0; i < _count; i++)
            {
                stringifiedList += items[i] + " ";
            }
            return stringifiedList;

        }

        public static CustomList<T> operator +(CustomList<T> List1, CustomList<T> List2)
        {
            CustomList<T> ResultList = new CustomList<T>();
            for (int i = 0; i < List1.count; i++)
            {
                ResultList.Add(List1[i]);
            }
            for (int j = 0; j < List2.count; j++)
            {
                ResultList.Add(List2[j]);
            }
            return ResultList;
        }

        public static CustomList<T> operator -(CustomList<T> List1, CustomList<T> List2)
        {
            CustomList<T> ResultList = new CustomList<T>();
            ResultList = List1;
            for (int i = 0; i < List2.count; i++)
            {
                ResultList.Remove(List2[i]);
            }
            ResultList.DesizeArray();
            return ResultList;
        }

        public void DesizeArray()
        {
            if ((capacity - _count) > 4)
            {
                capacity = capacity / 2;
                T[] temporaryItems = new T[capacity];
                for (int i = 0; i < capacity; i++)
                {
                    temporaryItems[i] = items[i];
                }
                items = temporaryItems;
            }
        }

        public CustomList<T> Zip(CustomList<T> list)
        {
            CustomList<T> ResultList = new CustomList<T>();
            int counter;
            if (list.count > this.count)
            {
                counter = list.count;

            }
            else
            {
                counter = this.count;

            }
            for (int i = 0; i < counter; i++)
            {
                if (i < this.count)
                {
                    ResultList.Add(this[i]);
                }
                if (i < list.count)
                {
                    ResultList.Add(list[i]);
                }
            }
            return ResultList;
        }

        public void Sort(CustomList<int> List)
        {
            int temp;
            for (int i = 0; i < _count; i++)
            {
                for (int j = i; j < _count; j++)
                {
                    if (List[i].CompareTo(List[j]) > 0)
                    {
                        temp = List[i];
                        List[i] = List[j];
                        List[j] = temp;

                    }
                }
            }
        }

        public IEnumerator GetEnumerator()
        {
            for (int index = 0; index < _count; index++)
            {
                yield return items[index];
            }
        }
    }
}
