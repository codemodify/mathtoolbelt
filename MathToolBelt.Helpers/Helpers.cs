using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathToolBelt
{
    public class Helpers
    {
        public static double[] GenerateValues( int n )
        {
            var random = new Random();

            var list = new List<double>();
            for( int i=0; i < n; i++ )
                list.Add( random.Next( 100 ) );

            return list.ToArray();
        }

        public static void PrintArray( double[] array )
        {
            Console.WriteLine( string.Empty );

            foreach( int i in array )
                Console.Write( string.Format( "{0} ", i ) );
        }
    }
}
