
using System.Collections.Generic;
using MathToolBelt.Sorting.Contracts;

namespace MathToolBelt.Sorting.Ui.App
{
    public class AlgoConfig
    {
        public ISort SortingAlgorithm { get; set; }
        public double[] Array { get; set; }
        public bool PlaySound { get; set; }
    }
}
