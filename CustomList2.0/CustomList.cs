using System;
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
            _count++;
            Resize();
            items[_count - 1] = item;
        }

        public void Add(T item, int item1)
        {
            _count++;
            Resize();

            for (int i = _count; i > item1; i--)
            {
                items[i] = items[i - 1];

            }
            items[item1] = item;
        }

    }
}
