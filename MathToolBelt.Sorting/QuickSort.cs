using System;
using System.Collections.Generic;
using MathToolBelt.Sorting.Contracts;

namespace MathToolBelt.Sorting
{
    public class QuickSort : AbstractSort
    {
        public override string Name
        {
            get { return "Quick Sort"; }
        }

        public override string HowItWorks
        {
            get
            {
                return
                    "1. Choose a reference element (aka pivot) then re-arrange the array so that smaller elements are to the left and bigger to the right." + Environment.NewLine +
                    "2. At this point you have 2 virtual sub-arrays elements of which are smaller {pivot} bigger."                                          + Environment.NewLine +
                    "3. Make a recursive call of the same function for the left sub-array and the right sub-array."                                         + Environment.NewLine +
                    "4. Repeat 1, 2, 3 until the size of the array to be sorted it 1"                                                                       + Environment.NewLine +
                                                                                                                                                              Environment.NewLine +
                    "The quick sort got its name because this is how its creator Tony Hoare name it.";
            }
        }

        public override string BigO
        {
            get { return "O( n log n )"; }
        }

        public override void Sort( double[] array )
        {
            DoQuickSort( array, 0, array.Length-1 );
        }

        private void DoQuickSort( double[] array, int startIndex, int endIndex )
        {
            if( endIndex - startIndex <= 0 )
                return;

            #region Partition

            int pivotIndex = startIndex; // there are whole sutdies how to choose a pivot, but for learning we're keeping it simple

            SwapValues( array, pivotIndex, endIndex );
            NotifyItemsSwaped( new ItemsEventArgs() { I = pivotIndex, J = endIndex, Ivalue = array[ pivotIndex ], Jvalue = array[ endIndex ] } );

            pivotIndex = endIndex;
            int leftFinger = startIndex;
            int rightFinger = endIndex;

            while( leftFinger < rightFinger )
            {
                NotifyItemsCompared( new ItemsEventArgs() { I = leftFinger, J = pivotIndex, Ivalue = array[ leftFinger ], Jvalue = array[ pivotIndex ] } );
                if( array[ leftFinger ] < array[ pivotIndex ] )
                    leftFinger++;
                else
                {
                    rightFinger--;
                    SwapValues( array, leftFinger, rightFinger );
                    NotifyItemsSwaped( new ItemsEventArgs() { I = leftFinger, J = rightFinger, Ivalue = array[ leftFinger ], Jvalue = array[ rightFinger ] } );

                }
            }
            SwapValues( array, rightFinger, pivotIndex );
            NotifyItemsSwaped( new ItemsEventArgs() { I = rightFinger, J = pivotIndex, Ivalue = array[ rightFinger ], Jvalue = array[ pivotIndex ] } );

            pivotIndex = rightFinger;

            #endregion

            DoQuickSort( array, startIndex, pivotIndex - 1 );
            DoQuickSort( array, pivotIndex + 1, endIndex );

            NotifyFinished();
        }
    }
}
