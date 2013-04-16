using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MathToolBelt.Sorting.Contracts;

namespace MathToolBelt.Sorting.Ui.App
{
    public partial class Main : Form
    {
        private double[] _values;

        public Main()
        {
            InitializeComponent();

            var algoList = new List<ISort>();
                algoList.Add( new BubleSort() );
                algoList.Add( new InsertionSort() );
                algoList.Add( new SelectionSort() );
                algoList.Add( new QuickSort() );
                algoList.Add( new MergeSort() );

            algoList.ForEach
            (
                a =>
                {
                    AlgosComboBox.Items.Add( a );
                }
            );
        }

        private void NewTabButton_Click( object sender, EventArgs e )
        {
            var tabPage = new TabPage();
                tabPage.Text = "Choose Amount & Algo";

            var sortingAlgorythmVisualizerUserControl = new SortingAlgorithmVisualizer();
                sortingAlgorythmVisualizerUserControl.Parent = tabPage;
                sortingAlgorythmVisualizerUserControl.Dock = DockStyle.Fill;

            AlgoVisTabControl.TabPages.Add( tabPage );
        }

        private void GenerateButton_Click( object sender, EventArgs e )
        {
            int amount = Convert.ToInt32( AmountTextBox.Text );

            _values = MathToolBelt.Helpers.GenerateValues( amount );
        }

        private void SortButton_Click( object sender, EventArgs e )
        {
            if( AlgoVisTabControl.TabPages.Count == 0 )
            {
                NewTabButton_Click( null, null );
            }

            if( string.IsNullOrEmpty( AmountTextBox.Text ) || AlgosComboBox.SelectedItem == null || _values == null )
                return;

            #region Prepare the algo config
            

            var algoConfig = new AlgoConfig()
            {
                SortingAlgorithm = AlgosComboBox.SelectedItem as ISort,
                Array = ( new List<double>( _values ) ).ToArray(),
                PlaySound = PlaySoundCheckBox.Checked
            };

            #endregion

            #region Visualize it

            var tabPage = AlgoVisTabControl.SelectedTab;
            var sortingAlgorythmVisualizerUserControl = tabPage.Controls[0] as SortingAlgorithmVisualizer;
                sortingAlgorythmVisualizerUserControl.Visualize( algoConfig );

            #endregion
        }
    }
}
