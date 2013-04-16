using System;
using System.Collections.Generic;
using MathToolBelt.Sorting.Contracts;

namespace MathToolBelt.Sorting
{
    public class MergeSort : AbstractSort
    {
        public override string Name
        {
            get { return "Merge Sort"; }
        }

        public override string HowItWorks
        {
            get
            {
                return
                    "1. Split the array in half => 2 virtual subarrays."                                                            + Environment.NewLine +
                    "2. Split the 2 halfs into sub-halfs => 4 subarrays."                                                           + Environment.NewLine +
                    "3. Etc, do it till you get a sub-sub-sub...sub-array of the size of 1 or 0."                                   + Environment.NewLine +
                    "4. Sort the sub-array of size 1 or 0."                                                                         + Environment.NewLine +
                    "5. Get one level up where you'll have 2 just-sorted sub-arrays. Sort them by formin one contgous sorted array" + Environment.NewLine +
                                                                                                                                      Environment.NewLine +
                    "The merge sort got its name because it tends to merge small sub-arrays into a bigger one.";
            }
        }

        public override string BigO
        {
            get { return "O( n log n )"; }
        }

        /// <summary>
        /// This is the in-place implementation, that needs no extra space, 
        /// we did this to be able to show it in the UI based on its indexes.
        /// </summary>
        /// <param name="array"></param>
        public override void Sort( double[] array )
        {
            DoMergeSort( array, 0, array.Length );

            NotifyFinished();
            Helpers.PrintArray( array );
        }

        private void DoMergeSort( double[] array, int startIndex, int endIndex )
        {
            if( endIndex - startIndex <= 1 ) 
                return;

            int midIndex = startIndex + ( endIndex - startIndex ) / 2;

            DoMergeSort( array, startIndex, midIndex );
            DoMergeSort( array, midIndex + 1, endIndex );

            Merge( array, startIndex, endIndex );
        }

        private void Merge( double[] array, int startIndex, int endIndex )
        {
            // Selection Sort
            for( int i=startIndex; i < endIndex; i++ )
            {
                double min = array[ i ];
                int minPosition = i;

                for( int j = i + 1; j < endIndex; j++ ) // Start from 1st element and find the minimal in the right subarray.
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
        }
    }
}
