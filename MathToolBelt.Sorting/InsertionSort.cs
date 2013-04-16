using System;
using System.Collections.Generic;
using MathToolBelt.Sorting.Contracts;

namespace MathToolBelt.Sorting
{
    public class InsertionSort : AbstractSort
    {
        public override string Name
        {
            get { return "Insertion Sort"; }
        }

        public override string HowItWorks
        {
            get
            {
                return
                    "1. Start from 2nd element and compare with all previous elements, shift all elements and place 2nd element in its real postion."   + Environment.NewLine +
                    "2. Start from 3rd element and compare with all previous elements, shift all elements and place 3rd element in its real postion."   + Environment.NewLine +
                    "Do this until we reach the last entry."                                                                                            + Environment.NewLine +
                                                                                                                                                      Environment.NewLine +
                    "The insertion sort got its name because the element is taken out of its current postion and inserted into its real positon.";
            }
        }

        public override string BigO
        {
            get { return "O( n² )"; }
        }

        public override void Sort( double[] array )
        {
            double copyOfElement = -1;

            for( int i=1; i < array.Length; i++ ) // start from second element (or i+1)
            {
                int j;
                for( j=i; j > 0; j-- ) // compare with all previous
                {
                    NotifyItemsCompared( new ItemsEventArgs() { I = i, J = j - 1, Ivalue = array[ i ], Jvalue = array[ j - 1 ] } );
                    if( array[ i ] < array[ j - 1 ] )
                    {
                        continue;
                    }
                    else
                    {
                        break;
                    }
                }

                // shift all elements and place the element in its real postion
                {
                    copyOfElement = array[ i ];

                    for( int k=i; k > j; k-- )
                    {
                        array[ k ] = array[ k - 1 ];
                        NotifyItemCopied( new ItemsEventArgs() { I = k - 1, J = k, Ivalue = array[ k - 1 ], Jvalue = array[ k ] } );
                    }

                    array[ j ] = copyOfElement;
                    NotifyItemCopied( new ItemsEventArgs() { I = j, J = j, Ivalue = array[ j ], Jvalue = array[ j ] } );
                }
            }

            NotifyFinished();
        }
    }
}
