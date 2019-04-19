using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CW_4
{
    class EventArgs<T>
    {
        public T value { get; set; }
        public string listName { get; set; }
        public int totalNumber { get; set; }
        public EventArgs(T value, int totalNumber, string listName)
        { 
            this.value=value;
            this.totalNumber = totalNumber;
            this.listName = listName;
        }
    }
}
