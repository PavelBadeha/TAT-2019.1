using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CW_4
{
    class Element<T>
    {
        private T value;
        public Element<T> Next { get; set; }
        public Element(T value)
        {
            this.value = value;
        }
    }
}
