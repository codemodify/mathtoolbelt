using System.Collections.Generic;
using System.Windows;

using MathToolBelt.Searching.Contracts;
using MathToolBelt.Searching.Ui.TreeVisualizer;

namespace MathToolBelt.Searching.Ui.App
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            this.Loaded += MainWindow_Loaded;
        }

        void MainWindow_Loaded( object sender, RoutedEventArgs e )
        {
            #region Fancy Tree - 3 000 000 nodes
/*
            const int COUNT = 25;

            var randomTree = new TreeNode();
                randomTree.Children = new List<TreeNode>();
            
            for( int i=0; i < COUNT; i++ )
            {
                var childI = new TreeNode();
                    childI.Children = new List<TreeNode>();
                for( int j=0; j < COUNT; j++ )
                {
                    var childJ = new TreeNode();
                        childJ.Children = new List<TreeNode>();
                    for( int k=0; k < COUNT; k++ )
                    {
                        var childK = new TreeNode();
                        //    childK.Children = new List<TreeNode>();
                        //for( int l=0; l < COUNT; l++ )
                        //{
                        //    var childL = new TreeNode();
                        //        childL.Children = new List<TreeNode>();
                        //    for( int m=0; m < COUNT; m++ )
                        //    {
                        //        var childM = new TreeNode();
                        //            childM.Children = new List<TreeNode>();
                        //        for( int o=0; o < COUNT; o++ )
                        //        {
                        //            var childO = new TreeNode();

                        //            childM.Children.Add( childO );
                        //        }
                        //        childL.Children.Add( childM );
                        //    }
                        //    childK.Children.Add( childL );
                        //}
                        childJ.Children.Add( childK );
                    }
                    childI.Children.Add( childJ );
                }
                randomTree.Children.Add( childI );
            }

            var treeViewer = new SimpleTreeVisualizer();
                treeViewer.DrawTree( TreeViewer, randomTree );
            */
            #endregion;

            #region Arbitrary Binary Tree
/*
            var rootBinaryNode = new BinaryNode() { Payload = new Payload() { Value1 = 1 }, IsCompareSource = true, IsCompareTarget = false };

                // First Level
                rootBinaryNode.LeftNode = new BinaryNode() { Payload = new Payload() { Value1 = 2 }, IsCompareSource = false, IsCompareTarget = true };
                rootBinaryNode.RightNode = new BinaryNode() { Payload = new Payload() { Value1 = 3 }, IsCompareSource = false, IsCompareTarget = false };

                // Second Level
                rootBinaryNode.LeftNode.LeftNode = new BinaryNode() { Payload = new Payload() { Value1 = 4 }, IsCompareSource = false, IsCompareTarget = false };

                rootBinaryNode.RightNode.LeftNode = new BinaryNode() { Payload = new Payload() { Value1 = 5 }, IsCompareSource = false, IsCompareTarget = false };
                rootBinaryNode.RightNode.RightNode = new BinaryNode() { Payload = new Payload() { Value1 = 6 }, IsCompareSource = false, IsCompareTarget = false };

                // Third Level
                rootBinaryNode.LeftNode.LeftNode.LeftNode = new BinaryNode() { Payload = new Payload() { Value1 = 7 }, IsCompareSource = false, IsCompareTarget = false };
                rootBinaryNode.LeftNode.LeftNode.RightNode = new BinaryNode() { Payload = new Payload() { Value1 = 8 }, IsCompareSource = false, IsCompareTarget = false };

            var binaryTreeViewer = new SimpleTreeVisualizer();
                binaryTreeViewer.DrawTree( TreeViewer, rootBinaryNode );
            */
            #endregion

            #region Arbitrary Tree

            var rootTreeNode = new TreeNode();

                // First Level
                rootTreeNode.Children = new List<TreeNode>();
                rootTreeNode.Children.Add( new TreeNode() );
                rootTreeNode.Children.Add( new TreeNode() );
                rootTreeNode.Children.Add( new TreeNode() );
                rootTreeNode.Children.Add( new TreeNode() );
                rootTreeNode.Children.Add( new TreeNode() );
                rootTreeNode.Children.Add( new TreeNode() );
                rootTreeNode.Children.Add( new TreeNode() );
                rootTreeNode.Children.Add( new TreeNode() );
                rootTreeNode.Children.Add( new TreeNode() );

                // Second Level
                rootTreeNode.Children[ 1 ].Children = new List<TreeNode>();
                rootTreeNode.Children[ 1 ].Children.Add( new TreeNode() );
                rootTreeNode.Children[ 1 ].Children.Add( new TreeNode() );
                rootTreeNode.Children[ 1 ].Children.Add( new TreeNode() );
                rootTreeNode.Children[ 1 ].Children.Add( new TreeNode() );
                rootTreeNode.Children[ 1 ].Children.Add( new TreeNode() );

                rootTreeNode.Children[ 2 ].Children = new List<TreeNode>();
                rootTreeNode.Children[ 2 ].Children.Add( new TreeNode() );
                rootTreeNode.Children[ 2 ].Children.Add( new TreeNode() );


                // Third Level
                rootTreeNode.Children[ 1 ].Children[ 0 ].Children = new List<TreeNode>();
                rootTreeNode.Children[ 1 ].Children[ 0 ].Children.Add( new TreeNode() );

                rootTreeNode.Children[ 1 ].Children[ 3 ].Children = new List<TreeNode>();
                rootTreeNode.Children[ 1 ].Children[ 3 ].Children.Add( new TreeNode() );
                rootTreeNode.Children[ 1 ].Children[ 3 ].Children.Add( new TreeNode() );
                rootTreeNode.Children[ 1 ].Children[ 3 ].Children.Add( new TreeNode() );
                rootTreeNode.Children[ 1 ].Children[ 3 ].Children.Add( new TreeNode() );

                rootTreeNode.Children[ 1 ].Children[ 3 ].Children[ 3 ].Children = new List<TreeNode>();
                rootTreeNode.Children[ 1 ].Children[ 3 ].Children[ 3 ].Children.Add( new TreeNode() );
                rootTreeNode.Children[ 1 ].Children[ 3 ].Children[ 3 ].Children.Add( new TreeNode() );
                rootTreeNode.Children[ 1 ].Children[ 3 ].Children[ 3 ].Children.Add( new TreeNode() );

                var treeViewer = new SimpleTreeVisualizer();
                    treeViewer.DrawTree( TreeViewer, rootTreeNode );

            #endregion
        }
    }
}
