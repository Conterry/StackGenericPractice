using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace StackGenericsPractice
{
    class Stack<T> : IStack<T>, IEnumerable
    {

        private Cell<T> GlobalCell;
        private int CountOfCells = 0;

        public void Add(T obj)
        {
            Cell<T> cell = new Cell<T>(obj, GlobalCell);
            GlobalCell = cell;
            CountOfCells++;
        }

        public void Take()
        {
            if(GlobalCell is null)
            {
                Console.WriteLine("Stack is empty");
                return;
            }
            else if(GlobalCell.GetPreviousCell() is null)
            {
                Pick();
                GlobalCell = null;
            }
            else
            {
                Cell<T> TemporaryCell = GlobalCell.GetPreviousCell();
                GlobalCell = TemporaryCell;
            }
            CountOfCells--;
        }

        public T Pick()
        {
            return GlobalCell.Current;
        }

        public override string ToString()
        {
            List<T> stack = new List<T>();
            foreach(T a in this)
            {
                stack.Add(a);
            }

            return string.Join(" ", stack);
        }

        public IEnumerator GetEnumerator()
        {
            yield return GlobalCell.Current;
            Cell<T> cell = GlobalCell.GetPreviousCell();
            for(int i=0; i<CountOfCells-1; i++)
            {
                yield return cell.Current;
                cell = cell.GetPreviousCell();
            }   
        }
    }
}
