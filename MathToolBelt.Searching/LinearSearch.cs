using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathToolBelt.Searching
{
    public class LinearSearch
    {
        /// <summary>
        /// O( n )
        /// </summary>
        public bool Contains( double[] array, double value )
        {
            for( int i=0; i < array.Length; i++ )
            {
                if( array[ i ] == value )
                    return true;
            }

            return false;
        }
    }
}
