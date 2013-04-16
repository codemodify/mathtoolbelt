using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Shapes;
using MathToolBelt.Searching.Contracts;

namespace MathToolBelt.Searching.Ui.TreeVisualizer
{
    public class SimpleTreeVisualizer
    {
        Canvas DrawingArea { get; set; }

        public void DrawTree( Canvas canvas, TreeNode tree ) 
        {
            DrawingArea = canvas;

            var annotatedTree = Helpers.ToAnnotatedTree( tree );

            PrepareNode( annotatedTree );
            PerformLayout(annotatedTree);

            DrawNode( annotatedTree );
            DrawLines( annotatedTree );

            int treeHeight = Helpers.TreeMaxHeight( annotatedTree );
            int treeWidth = Helpers.TreeMaxWidth( annotatedTree );
            DrawingArea.Width = treeWidth * 50;
            DrawingArea.Height = treeHeight * 80;
        }

        public void DrawTree( Canvas canvas, BinaryNode tree )
        {
            DrawingArea = canvas;

            var annotatedTree = Helpers.ToAnnotatedBinaryTree( tree );

            PrepareNode( annotatedTree );
            PerformLayout( annotatedTree );

            DrawNode( annotatedTree );
            DrawLines( annotatedTree );

            int treeHeight = Helpers.TreeMaxHeight( annotatedTree );
            int treeWidth = Helpers.TreeMaxWidth( annotatedTree );
            DrawingArea.Width = treeWidth * 50;
            DrawingArea.Height = treeHeight * 80;
        }

        #region 1

        private void PrepareNode
        (
            AnnotatedTreeNode node,
            int level = 0,
            AnnotatedTreeNode parentNode = null,
            AnnotatedTreeNode LeftSibling = null,
            Dictionary<int, AnnotatedTreeNode> rightLimits = null
        )
        {
            if( rightLimits == null )
                rightLimits = new Dictionary<int, AnnotatedTreeNode>();

            node.Level = level;
            node.Parent = parentNode;
            node.LeftSibling = LeftSibling;

            if( node.HasChildren )
            {
                for( var i = 0; i < node.Children.Count; i++ )
                {
                    AnnotatedTreeNode left = null;

                    if( i == 0 && rightLimits.ContainsKey( level ) )
                        left = rightLimits[ level ];

                    if( i > 0 )
                        left = node.Children[ i - 1 ];

                    if( i == ( node.Children.Count - 1 ) )
                    {
                        if( rightLimits.ContainsKey( level ) )
                            rightLimits.Remove( level );
                        rightLimits.Add( level, node.Children[ i ] );
                    }

                    PrepareNode( node.Children[ i ], level + 1, node, left, rightLimits );
                }
            }
        }

        private void PerformLayout( AnnotatedTreeNode node )
        {
            double nodeHeight = 40;
            double nodeWidth = 40;
            double nodeMarginLeft = 10;
            double nodeMarginTop = 20;

            double nodeLeft = 0; // defaultValue 

            // Before Layout this Node, Layout its children
            if( node.HasChildren )
            {
                for (var i = 0; i < node.Children.Count; i++)
                {
                    PerformLayout(node.Children[i]);
                }
            }

            if( node.HasChildren ) // If Has Children and Is Expanded
            {

                // My left is in the center of my children
                var childrenWidth = (node.Children[node.Children.Count-1].Left + node.Children[node.Children.Count-1].Width) - node.Children[0].Left;
                nodeLeft = (node.Children[0].Left + (childrenWidth / 2)) - (nodeWidth / 2);

                // Is my left over my left node?
                // Move it to the right
                if(node.LeftSibling != null &&((node.LeftSibling.Left+node.LeftSibling.Width+nodeMarginLeft)>nodeLeft))
                {
                    double newLeft = node.LeftSibling.Left + node.LeftSibling.Width + nodeMarginLeft;
                    double diff = newLeft - nodeLeft;
                    /// Move also my children
                    MoveRigth(node.Children, diff);
                    nodeLeft = newLeft;
                }
            }
            else
            {
                // My left is next to my left sibling
                if (node.LeftSibling != null ) 
                    nodeLeft = node.LeftSibling.Left + node.LeftSibling.Width + nodeMarginLeft;
            }

            node.Left = nodeLeft;

            // The top depends only on the level
            node.Top = (nodeMarginTop * (node.Level + 1)) + (nodeHeight * (node.Level + 1));
            // Size is constant
            node.Height = nodeHeight;
            node.Width = nodeWidth;

            // Calculate Connector Points
            // Child: Where the lines get out from to connect this node with its children
            var pointX = nodeLeft + (nodeWidth / 2);
            var pointY = node.Top + nodeHeight;
            node.ChildrenConnectorPoint = new Point{ X= pointX, Y= pointY };
            // Parent: Where the line that connect this node with its parent end
            pointX = nodeLeft + (nodeWidth / 2);
            pointY = node.Top;
            node.ParentConnectorPoint = new Point { X = pointX, Y = pointY };
        }
        
        #endregion

        #region 2

        private void DrawNode( AnnotatedTreeNode node )
        {
            if( node.IsInvisibleNode )
                return;

            var ellipse = new Ellipse();
                ellipse.Fill = node.IsCompareSource ? Brushes.Green : ( node.IsCompareTarget ? Brushes.Yellow : Brushes.White );
                ellipse.StrokeThickness = 2;
                ellipse.Stroke = Brushes.Black;
                ellipse.Width = node.Width;
                ellipse.Height = node.Height;

            var text = new TextBlock();
                text.Text = string.Format( "{0}", node.Payload.Value1 );
                text.TextAlignment = TextAlignment.Center;
                text.VerticalAlignment = VerticalAlignment.Center;

            var grid = new Grid();
                grid.Width = node.Width;
                grid.Height = node.Height;
                grid.Children.Add( ellipse );
                grid.Children.Add( text );
                Canvas.SetTop( grid, node.Top );
                Canvas.SetLeft( grid, node.Left );

            DrawingArea.Children.Add( grid );

            // Draw children
            if( node.HasChildren ) // Has Children and is Expanded
            {
                for (var i = 0; i < node.Children.Count; i++)
                {
                    DrawNode( node.Children[i] );
                }
            }
        }

        private void DrawLines( AnnotatedTreeNode node ) 
        {
            if( node.IsInvisibleNode )
                return;

            if( node.HasChildren )
            { // Has children and Is Expanded
                for (var j = 0; j < node.Children.Count; j++)
                {
                    if( !node.Children[ j ].IsInvisibleNode )
                    DrawLine( node.ChildrenConnectorPoint, node.Children[j].ParentConnectorPoint);

                    // Children
                    DrawLines( node.Children[j] );
                }
            }
        }

        #endregion

        #region 3

        private void DrawLine( Point startPoint, Point endPoint ) 
        {
            var midY = (startPoint.Y + ((endPoint.Y - startPoint.Y) / 2)); // Half path between start en end Y point

            // Start segment
            DrawLineSegment( startPoint.X, startPoint.Y, startPoint.X, midY, 1);

            // Intermidiate segment
            var imsStartX = startPoint.X < endPoint.X ? startPoint.X : endPoint.X; // The lower value will be the starting point
            var imsEndX = startPoint.X > endPoint.X ? startPoint.X : endPoint.X; // The higher value will be the ending point
            DrawLineSegment( imsStartX, midY, imsEndX, midY, 1);

            // End segment
            DrawLineSegment( endPoint.X, midY, endPoint.X, endPoint.Y, 1);
        }

        private void DrawLineSegment( double startX, double startY, double endX, double endY, double lineWidth )
        {
            var line = new Line();
                line.Stroke = System.Windows.Media.Brushes.Black;
                line.X1 = startX;
                line.X2 = endX;
                line.Y1 = startY;
                line.Y2 = endY;
                line.StrokeThickness = lineWidth;
                line.SnapsToDevicePixels = true;
                line.SetValue( RenderOptions.EdgeModeProperty, EdgeMode.Aliased );

            DrawingArea.Children.Add( line );
        }

        private void MoveRigth( IList<AnnotatedTreeNode> nodes, double distance )
        {
            for (var i = 0; i < nodes.Count; i++) 
            {
                nodes[i].Left += distance;
                if (nodes[i].ParentConnectorPoint != null ) nodes[i].ParentConnectorPoint = new Point( nodes[i].ParentConnectorPoint.X + distance, nodes[i].ParentConnectorPoint.Y );
                if( nodes[ i ].ChildrenConnectorPoint != null ) nodes[ i ].ChildrenConnectorPoint = new Point( nodes[ i ].ChildrenConnectorPoint.X + distance, nodes[ i ].ChildrenConnectorPoint.Y );
                if( nodes[ i ].Children != null )
                {
                    MoveRigth( nodes[ i ].Children, distance );
                }
            }
        }

        private void MoveBottom( IList<AnnotatedTreeNode> nodes, double distance )
        {
            for( var i = 0; i < nodes.Count; i++ )
            {
                nodes[i].Top += distance;
                if( nodes[ i ].ParentConnectorPoint != null ) nodes[ i ].ParentConnectorPoint = new Point( nodes[ i ].ParentConnectorPoint.X, nodes[ i ].ParentConnectorPoint.Y + distance );
                if( nodes[ i ].ChildrenConnectorPoint != null ) nodes[ i ].ChildrenConnectorPoint = new Point( nodes[ i ].ChildrenConnectorPoint.X, nodes[ i ].ChildrenConnectorPoint.Y + distance );
                if( nodes[ i ].Children != null )
                {
                    MoveBottom( nodes[ i ].Children, distance );
                }   
            }
        }

        #endregion
    }
}
