using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace CustomListClassProject
{
    public class CustomList<T> : IEnumerable
    {
        T[] _items;
        int _capacity;
        int _count;

        public int Count
        {
            get
            {
                return _count;
            }
        }

        public int Capacity
        {
            get
            {
                return _capacity;
            }
            set
            {
                _capacity = value;
            }
        }

        public CustomList()
        {
            _count = 0;
            _capacity = 4;
            _items = new T[_capacity];
        }

        public void Add(T item)
        {
            if (_count == _capacity)
            {
                T[] tempArray = new T[_capacity *= 2];

                for (int i = 0; i < _count; i++) 
                {
                    tempArray[i] = _items[i];
                }


                _items = tempArray;
            }
            _items[_count] = item;
            _count++;
        }

        public T this[int index] 
        {
            get 
            {
                if(index >= _count)
                {
                    throw new ArgumentOutOfRangeException();
                }
                else
                {
                    return _items[index];
                }

            }
            set
            {
                _items[index] = value;
            }
        }

        public bool Remove(T item)
        {
            T[] customArray = new T[_capacity]; 
            bool isSame = false;
            for (int i = 0, j = 0; i < _count; i++)
            {
                if (i == j && _items[i].Equals(item))
                {
                    isSame = true;
                   
                }
                else
                {
                    customArray[j] = _items[i];
                    j++;
                }
            }
            if (isSame)
            {
                _count--;
                _items = customArray;
            }
            
           
            return isSame;
        }

        public IEnumerator GetEnumerator()
        {
            for (int i = 0; i < _count; i++)
            {
                yield return _items[i];
            }
        }

        public override string ToString()
        {
            string testList ="";
            for (int i = 0; i < _count; i++)
            {
                testList += _items[i].ToString();
            }
            return testList;
        }
    }
}
