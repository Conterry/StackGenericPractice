using System;
using System.Collections.Generic;
using System.Text;

namespace StackGenericsPractice
{
    interface IStack<T>
    {
        void Add(T obj);
        void Take();
        T Pick();
    }
}
