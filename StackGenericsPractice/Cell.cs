using System;
using System.Collections.Generic;
using System.Text;

namespace StackGenericsPractice
{
    class Cell<T>
    {
        private Cell<T> Previous;
        public T Current;

        public Cell(T Current, Cell<T> Next)
        {
            this.Previous = Next;
            this.Current = Current;
        }

        public Cell<T> GetPreviousCell()
        {
            return this.Previous;
        }
    }
}
