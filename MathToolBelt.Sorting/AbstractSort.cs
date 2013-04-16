using System;
using System.Collections.Generic;
using MathToolBelt.Sorting.Contracts;

namespace MathToolBelt.Sorting
{
    public abstract class AbstractSort : ISort
    {
        public abstract string Name { get; }
        public abstract string HowItWorks { get; }
        public abstract string BigO { get; }

        public abstract void Sort( double[] array );

        public event EventHandler<ItemsEventArgs> ItemsSwaped = delegate { };
        protected void NotifyItemsSwaped( ItemsEventArgs e )
        {
            ItemsSwaped( this, e );
        }

        public event EventHandler<ItemsEventArgs> ItemsCompared = delegate { };
        protected void NotifyItemsCompared( ItemsEventArgs e )
        {
            ItemsCompared( this, e );
        }

        public event EventHandler<ItemsEventArgs> ItemCopied = delegate { };
        protected void NotifyItemCopied( ItemsEventArgs e )
        {
            ItemCopied( this, e );
        }

        public event EventHandler<EventArgs> Finished = delegate { };
        protected void NotifyFinished()
        {
            Finished( this, null );
        }

        // We do this here to be able to show it in a Combo
        public override string ToString()
        {
            return Name;
        }

        // Helper
        protected void SwapValues( double[] array, int i, int j )
        {
            double tempValue = 0;

            tempValue = array[ i ];
            array[ i ] = array[ j ];
            array[ j ] = tempValue;
        }
    }
}
