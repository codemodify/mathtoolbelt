using System;

namespace MathToolBelt.Sorting.Contracts
{
    public class ItemsEventArgs : EventArgs
    {
        public int I { get; set; }
        public int J { get; set; }

        public double Ivalue { get; set; }
        public double Jvalue { get; set; }
    }
}
