using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;
using MathToolBelt.Sorting.Contracts;
using System.Threading.Tasks;
using MathToolBelt.Sorting.Ui.App.ZedGraph;
using System.Numerics;

namespace MathToolBelt.Sorting.Ui.App
{
    public partial class SortingAlgorithmVisualizer : UserControl
    {
        #region House keeping

        double[] _values;

        int _compares;
        int _swaps;
        int _copies;

        Thread _task;
        int _delay;
        bool _autoBlockAfterOneOperation;
        bool _isPause;
        ManualResetEvent _manualResetEvent;

        AlgoConfig _algoConfig;

        #endregion

        public SortingAlgorithmVisualizer()
        {
            InitializeComponent();

            this.Speed.Value = _delay = 1;

            _manualResetEvent = new ManualResetEvent( true );

            this.BarChart.GraphPane.Title.Text = string.Empty;
            this.BarChart.GraphPane.XAxis.Title.Text = string.Empty;
            this.BarChart.GraphPane.YAxis.Title.Text = string.Empty;

            this.BarChart.GraphPane.Margin.All = 0;
            this.BarChart.GraphPane.Legend.IsVisible = false;
            this.BarChart.GraphPane.Title.IsVisible = false;
            this.BarChart.GraphPane.Legend.IsVisible = false;
            this.BarChart.GraphPane.BarSettings.MinBarGap = 1;

            this.BarChart.GraphPane.X2Axis.IsVisible = false;
            this.BarChart.GraphPane.Y2Axis.IsVisible = false;
            this.BarChart.GraphPane.XAxis.IsVisible = false;
            this.BarChart.GraphPane.YAxis.IsVisible = false;
        }

        ~SortingAlgorithmVisualizer()
        {
            if( _task != null )
                _task.Abort();
        }

        public void Visualize( AlgoConfig algoConfig )
        {
            _algoConfig = algoConfig;

            algoConfig.SortingAlgorithm.ItemsCompared += SortingAlgorithm_ItemsCompared;
            algoConfig.SortingAlgorithm.ItemsSwaped += SortingAlgorythm_ItemsSwaped;
            algoConfig.SortingAlgorithm.ItemCopied += SortingAlgorythm_ItemCopied;
            algoConfig.SortingAlgorithm.Finished += SortingAlgorithm_Finished;

            // Update the Ui
            this.Parent.Text = algoConfig.SortingAlgorithm.Name;
            this.HowItWorksTextBox.Text = algoConfig.SortingAlgorithm.HowItWorks;
            this.LabelN.Text = string.Format( "{0}", algoConfig.Array.Length );

            // Show the initial array
            _values = algoConfig.Array;
            _compares = 0;
            _swaps = 0;
            _copies = 0;

            LabelCompares.Text = string.Empty;
            LabelSwaps.Text = string.Empty;
            LabelCopies.Text = string.Empty;
            LabelBigO.Text = string.Empty;
            LabelTotalOperations.Text = string.Empty;

            _isPause = false;
            _autoBlockAfterOneOperation = false;
            _manualResetEvent.Set();
            if( _task != null )
            {
                _task.Abort();
            }

            this.BarChart.GraphPane.CurveList.Clear();
            this.BarChart.GraphPane.GraphObjList.Clear();

            PointPairList list = new PointPairList();
            Random rand = new Random();

            for( int i = 0; i < _values.Length; i++ )
            {
                list.Add( i, _values[ i ], 0 );
            }

            BarItem 
                myCurve = this.BarChart.GraphPane.AddBar( string.Empty, list, Color.Black );
                //                                               0            1          2             3           4
                myCurve.Bar.Fill = new Fill( new Color[] { Color.Black, Color.Red, Color.Yellow, Color.Blue } );// , Color.Green
                myCurve.Bar.Fill.Type = FillType.GradientByZ;

                myCurve.Bar.Fill.RangeMin = 0;
                myCurve.Bar.Fill.RangeMax = 3;

            this.BarChart.GraphPane.AxisChange();
            this.BarChart.Refresh();

            // Start sorting
            _task = new Thread( () => algoConfig.SortingAlgorithm.Sort( algoConfig.Array ) );
            _task.Start();
        }

        void ResetColors()
        {
            var points = this.BarChart.GraphPane.CurveList[ 0 ].Points;
            for( int i=0; i < points.Count; i++ )
            {
                points[ i ].Z = 0;
            }
        }

        void SortingAlgorithm_ItemsCompared( object sender, ItemsEventArgs e )
        {
            #region Simulate Debug

            if( _isPause || _autoBlockAfterOneOperation )
                _manualResetEvent.WaitOne();

            #endregion

            _compares++;
            this.LabelCompares.Invoke( (MethodInvoker) ( () => this.LabelCompares.Text = string.Format( "{0}", _compares ) ) );

            this.BarChart.Invoke
            (
                (MethodInvoker)
                (
                    () =>
                    {
                        ResetColors();

                        this.BarChart.GraphPane.CurveList[ 0 ].Points[ e.I ].Z = 1;
                        this.BarChart.GraphPane.CurveList[ 0 ].Points[ e.J ].Z = 2;

                        this.BarChart.GraphPane.AxisChange();
                        this.BarChart.Refresh();
                    }
                )
            );

            Thread.Sleep( _delay );

            #region Simulate Debug

            if( _autoBlockAfterOneOperation )
                _manualResetEvent.Reset();

            #endregion
        }

        void SortingAlgorythm_ItemsSwaped( object sender, ItemsEventArgs e )
        {
            #region Simulate Debug

            if( _isPause || _autoBlockAfterOneOperation )
                _manualResetEvent.WaitOne();

            #endregion

            _swaps++;
            this.LabelSwaps.Invoke( (MethodInvoker) ( () => this.LabelSwaps.Text = string.Format( "{0}", _swaps ) ) );

            this.BarChart.Invoke
            ( 
                (MethodInvoker) 
                (
                    () =>
                    {
                        ResetColors();

                        this.BarChart.GraphPane.CurveList[ 0 ].Points[ e.I ].Y = e.Ivalue;
                        this.BarChart.GraphPane.CurveList[ 0 ].Points[ e.J ].Y = e.Jvalue;

                        this.BarChart.GraphPane.CurveList[ 0 ].Points[ e.I ].Z = 3;
                        this.BarChart.GraphPane.CurveList[ 0 ].Points[ e.J ].Z = 1;

                        this.BarChart.GraphPane.AxisChange();
                        this.BarChart.Refresh();
                    }
                )
            );

            Thread.Sleep( _delay );

            #region Simulate Debug

            if( _autoBlockAfterOneOperation )
                _manualResetEvent.Reset();

            #endregion
        }

        void SortingAlgorythm_ItemCopied( object sender, ItemsEventArgs e )
        {
            #region Simulate Debug

            if( _isPause || _autoBlockAfterOneOperation )
                _manualResetEvent.WaitOne();

            #endregion

            _copies++;
            this.LabelCopies.Invoke( (MethodInvoker) ( () => this.LabelCopies.Text = string.Format( "{0}", _copies ) ) );

            this.BarChart.Invoke
            (
                (MethodInvoker)
                (
                    () =>
                    {
                        ResetColors();

                        this.BarChart.GraphPane.CurveList[ 0 ].Points[ e.I ].Y = e.Ivalue;
                        this.BarChart.GraphPane.CurveList[ 0 ].Points[ e.J ].Y = e.Jvalue;

                        this.BarChart.GraphPane.CurveList[ 0 ].Points[ e.I ].Z = 3;
                        this.BarChart.GraphPane.CurveList[ 0 ].Points[ e.J ].Z = 3;

                        this.BarChart.GraphPane.AxisChange();
                        this.BarChart.Refresh();
                    }
                )
            );

            Thread.Sleep( _delay );

            #region Simulate Debug

            if( _autoBlockAfterOneOperation )
                _manualResetEvent.Reset();

            #endregion
        }

        BigInteger Fact( int n )
        {
            BigInteger bigInt = 1;
            while( n > 1 )
            {
                bigInt = BigInteger.Multiply( n--, bigInt );
            }

            return bigInt;
        }

        void SortingAlgorithm_Finished( object sender, EventArgs e )
        {
            LabelTotalOperations.Invoke( (MethodInvoker) ( () => LabelTotalOperations.Text = string.Format( "{0}", _swaps + _compares + _copies ) ) );

            this.LabelBigO.Invoke( (MethodInvoker) ( () =>
            {
                #region Later Fix
      ////////////          int n = _values.Count;
      ////////////          int operations = _swaps + _compares;
      ////////////          //double delta = ( _values.Count * operations ) / 100;
      ////////////          string O = "?";

      /////////////* 1 */   if( false )                                     // O( 1 )
      ////////////          {
      ////////////              // FIXME
      ////////////          }
      /////////////* 2 */   else if( Math.Log( n ) == operations )          // O( log n )
      ////////////          {
      ////////////              O = "log n";
      ////////////          }
      /////////////* 3 */   else if( n == operations )                      // O( n )
      ////////////          {
      ////////////              O = "n";
      ////////////          }
      /////////////* 4 */   else if( n * Math.Log( n ) == operations )      // O( n log n )
      ////////////          {
      ////////////              O = "n log n";
      ////////////          }
      /////////////* 5 */   else if( Math.Pow( n, 2 ) == operations )       // O( n^2 )
      ////////////          {
      ////////////              O = "n²";
      ////////////          }
      /////////////* 6 */   else if( Math.Pow( n, 3 ) == operations )       // O( n^3 )
      ////////////          {
      ////////////              O = "n³";
      ////////////          }
      /////////////* 8 */   else if( Math.Pow( n, n ) == operations )       // O( c^n )
      ////////////          {
      ////////////              O = "c^n";
      ////////////          }
      /////////////* 9 */   else if( Fact( n ).CompareTo( new BigInteger( operations ) ) == 0 )          // O( n! )
      ////////////          {
      ////////////              O = "n!";
      ////////////          }
      /////////////* 7 */   else                                            // O( n^c )
      ////////////          {
      ////////////              O = "n^c";
      ////////////          }

                #endregion

                this.LabelBigO.Text = _algoConfig.SortingAlgorithm.BigO;
            } ) );
        }

        private void Speed_ValueChanged( object sender, EventArgs e )
        {
            _delay = this.Speed.Value;
        }

        private void Pause_Click( object sender, EventArgs e )
        {
            _isPause = _autoBlockAfterOneOperation ? false : !_isPause;
            _autoBlockAfterOneOperation = false;

            if( _isPause )
                _manualResetEvent.Reset();
            else
                _manualResetEvent.Set();
        }

        private void Step_Click( object sender, EventArgs e )
        {
            _autoBlockAfterOneOperation = true;
            _isPause = false;

            _manualResetEvent.Set();
        }
    }
}
