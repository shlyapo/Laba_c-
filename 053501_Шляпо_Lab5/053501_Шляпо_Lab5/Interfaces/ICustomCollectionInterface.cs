using System;
using System.Collections.Generic;
using System.Text;

namespace _053501_Шляпо_Lab5
{
    interface ICustomCollection<T>
    {
        T this[int index] { get; set; }
        public void Reset();
        void Next();
        public T Current();
        int Count { get; }
        void Add(T item);
        void Remove(T item);
        T RemoveCurrent();
    }
}
