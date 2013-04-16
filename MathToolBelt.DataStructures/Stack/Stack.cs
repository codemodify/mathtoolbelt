using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathToolBelt.DataStructures.Stack
{
    public class Stack // LIFO
    {
        private SingleLinkedListNode _data;

        public void Push( double value )
        {
            // New value is stored
            SingleLinkedListNode newValue = new SingleLinkedListNode() { Value = value };

            // Fix the links
            if( _data == null )
            {
                _data = newValue;
            }
            else
            {
                newValue.Next = _data.Next; ;
                _data.Next = newValue;
            }
        }

        public double Pop()
        {
            double value = _data.Value;
            _data.Delete( value );

            return value;
        }
    }
}
