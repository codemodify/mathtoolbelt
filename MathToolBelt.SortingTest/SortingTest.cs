using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MathToolBelt.Sorting;
using System.Collections.Generic;

namespace MathToolBelt.SortingTest
{
    [TestClass]
    public class SortingTest
    {
        [TestMethod]
        public void Insertion()
        {
            double[] array = Helpers.GenerateValues( 6 );
            Helpers.PrintArray( array );

            var insertionSort = new InsertionSort();
                insertionSort.Sort( array );

            Helpers.PrintArray( array );
        }
    }
}
