using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathToolBelt.Searching
{
    public class BinarySearch
    {
        /// <summary>
        /// O( log n )
        /// </summary>
        public bool Contains( double[] array, double value )
        {
            return ContainsImeplementation( array, value, 0, array.Length );
        }

        private bool ContainsImeplementation( double[] array, double value, int stratIndex, int endIndex )
        {
            int middleIndex = ( stratIndex + endIndex ) / 2;

            if( array[ middleIndex ] == value )
                return true;

            if( array[ middleIndex ] < value )
                return ContainsImeplementation( array, value, stratIndex, middleIndex - 1 );
            else
                return ContainsImeplementation( array, value, middleIndex + 1, endIndex );
        }
    }
}
