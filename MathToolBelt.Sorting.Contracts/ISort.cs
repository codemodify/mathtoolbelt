using System;
using System.Collections.Generic;

namespace MathToolBelt.Sorting.Contracts
{
    public interface ISort
    {
        string Name { get; }
        string HowItWorks { get; }
        string BigO { get; }

        void Sort( double[] array );

        event EventHandler<ItemsEventArgs> ItemsSwaped;
        event EventHandler<ItemsEventArgs> ItemsCompared;
        event EventHandler<ItemsEventArgs> ItemCopied;
        event EventHandler<EventArgs> Finished;
    }
}
