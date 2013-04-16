using System.Collections.Generic;
using MathToolBelt.Searching.Contracts;

namespace MathToolBelt.Searching.Ui.TreeVisualizer
{
    public class Helpers
    {
        public static AnnotatedTreeNode ToAnnotatedBinaryTree( BinaryNode node )
        {
            var annotatedNode = new AnnotatedTreeNode()
            {
                Payload = node.Payload,
                IsCompareSource = node.IsCompareSource,
                IsCompareTarget = node.IsCompareTarget
            };

            if( node.LeftNode != null || node.RightNode != null )
            {
                annotatedNode.Children = new List<AnnotatedTreeNode>();

                if( node.LeftNode != null )
                {
                    var leftNode = ToAnnotatedBinaryTree( node.LeftNode );

                    annotatedNode.Children.Add( leftNode );
                }

                if( node.RightNode != null )
                {
                    var rightNode = ToAnnotatedBinaryTree( node.RightNode );

                    annotatedNode.Children.Add( rightNode );
                }

                // Push an invisible node
                if( node.LeftNode != null && node.RightNode == null )
                {
                    annotatedNode.Children.Add( new AnnotatedTreeNode(){ IsInvisibleNode = true } );
                }
                else if( node.LeftNode == null && node.RightNode != null )
                {
                    annotatedNode.Children.Insert( 0, new AnnotatedTreeNode() { IsInvisibleNode = true } );
                }
            }

            return annotatedNode;
        }

        public static AnnotatedTreeNode ToAnnotatedTree( TreeNode node )
        {
            var annotatedNode = new AnnotatedTreeNode()
            {
                Payload = node.Payload,
                IsCompareSource = node.IsCompareSource,
                IsCompareTarget = node.IsCompareTarget
            };

            if( node.Children != null )
            {
                annotatedNode.Children = new List<AnnotatedTreeNode>();

                for( int i=0; i < node.Children.Count; i++ )
                {
                    var child = ToAnnotatedTree( node.Children[ i ] );

                    annotatedNode.Children.Add( child );
                }
            }

            return annotatedNode;
        }

        public static int TreeMaxHeight( BinaryNode node )
        {
            if( node == null ) return 0;
            int left_height = TreeMaxHeight( node.LeftNode );
            int right_height = TreeMaxHeight( node.RightNode );
            return ( left_height > right_height ) ? left_height + 1 : right_height + 1;
        }

        public static int TreeMaxHeight( AnnotatedTreeNode node )
        {
            if( node == null ) 
                return 0;

            int maxHeight = 0;
            if( node.Children != null )
            {
                for( int i=0; i < node.Children.Count; i++ )
                {
                    int branchHeight = TreeMaxHeight( node.Children[i] );

                    if( maxHeight < branchHeight )
                        maxHeight = branchHeight;
                }
            }

            return maxHeight + 1;
        }

        public static int TreeMaxWidth( AnnotatedTreeNode node )
        {
            if( node.Children == null )
                return 1;

            int branchWidth = 0;
            for( int i=0; i < node.Children.Count; i++ )
            {
                branchWidth += TreeMaxWidth( node.Children[ i ] );
            }

            return branchWidth;
        }
    }
}
