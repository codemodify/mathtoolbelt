using System;
using System.Collections.Generic;
using MathToolBelt.Sorting.Contracts;

namespace MathToolBelt.Sorting
{
    public class BubleSort : AbstractSort
    {
        public override string Name
        {
            get { return "Buble Sort"; }
        }

        public override string HowItWorks
        {
            get
            {
                return
                    "1. Assume the array is sorted."                                                                                    + Environment.NewLine +
                    "2. Compare the elements in the array by 2, swap them if they are not in order and mark the assumption as false."   + Environment.NewLine +
                    "3. Continue to do this until we reach the last entry."                                                             + Environment.NewLine +
                    "4. Repeat 1,2,3 until the assumtion rests true."                                                                   + Environment.NewLine +
                                                                                                                                          Environment.NewLine +
                    "The buble sort got its name because the next largest element is pushed to the end in a buble fashion.";
            }
        }

        public override string BigO
        {
            get { return "O( n² )"; }
        }

        public override void Sort( double[] array )
        {
            bool isSorted = false;
            int alreadySortedCount = 0;

            while( !isSorted )
            {
                isSorted = true;

                for( int i=0; i < array.Length - 1 - alreadySortedCount; i++ )
                {
                    NotifyItemsCompared( new ItemsEventArgs() { I = i, J = i + 1, Ivalue = array[ i ], Jvalue = array[ i + 1 ] } );
                    if( array[ i ] > array[ i + 1 ] )
                    {
                        SwapValues( array, i, i + 1 );
                        NotifyItemsSwaped( new ItemsEventArgs() { I = i, J = i + 1, Ivalue = array[ i ], Jvalue = array[ i + 1 ] } );

                        isSorted = false;
                    }
                }

                alreadySortedCount++;
            }

            NotifyFinished();
        }
    }
}
