using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CW_4
{
    class MyList<T>
    {
        private Element<T> head;
        private Element<T> tail;
        private string listName;
        private int Count = 0;
        public void Add(T value)
        {
            if(head==null)
            {
                head = new Element<T>(value);
            }
            else
            {
                tail.Next = new Element<T>(value);
            }
            tail = new Element<T>(value);
            Count++;
        }
    }
}
