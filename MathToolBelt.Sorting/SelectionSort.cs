using System;
using System.Collections.Generic;
using MathToolBelt.Sorting.Contracts;

namespace MathToolBelt.Sorting
{
    public class SelectionSort : AbstractSort
    {
        public override string Name
        {
            get { return "Selection Sort"; }
        }

        public override string HowItWorks
        {
            get
            {
                return
                    "1. Assume your array is composed from 2 virtual subarrays, left is sorted, right is unsorted. Initially the left subarray is empty."   + Environment.NewLine +
                    "2. Start from 1st element and find the minimal in the right subarray."                                                                 + Environment.NewLine +
                    "3. Exchnage values: 1st element with the minimal that was found. Now we have that left subarray(sorted) has +1 element & right -1."    + Environment.NewLine +
                    "4. Repeat 2 and 3 for by starting with the next element until there is no more elements in right array."                               + Environment.NewLine +
                                                                                                                                                              Environment.NewLine +
                    "The selection sort got its name because we select the next element that is sorted and move it to its place.";
            }
        }

        public override string BigO
        {
            get { return "O( n² )"; }
        }

        public override void Sort( double[] array )
        {
            for( int i=0; i < array.Length; i++ )
            {
                double min = array[ i ];
                int minPosition = i;

                for( int j = i+1; j < array.Length; j++ ) // Start from 1st element and find the minimal in the right subarray.
                {
                    NotifyItemsCompared( new ItemsEventArgs() { I = minPosition, J = j, Ivalue = min, Jvalue = array[ j ] } );
                    if( min > array[ j ] )
                    {
                        min = array[ j ];
                        minPosition = j;
                    }
                }

                SwapValues( array, i, minPosition );
                NotifyItemsSwaped( new ItemsEventArgs() { I = i, J = minPosition, Ivalue = array[ i ], Jvalue = array[ minPosition ] } );
            }

            NotifyFinished();
        }
    }
}
