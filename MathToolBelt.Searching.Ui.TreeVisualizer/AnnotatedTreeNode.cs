
using System.Collections.Generic;
using System.Windows;

namespace MathToolBelt.Searching.Contracts
{
    public class AnnotatedTreeNode
    {
        public Payload Payload { get; set; }
        public List<AnnotatedTreeNode> Children { get; set; }

        // Helpers
        public bool HasChildren
        {
            get
            {
                return ( Children != null ) && ( Children.Count > 0 );
            }
        }

        // Helpers for visualization
        public bool IsCompareSource { get; set; }
        public bool IsCompareTarget { get; set; }

        // Helpers for drawing
        public AnnotatedTreeNode Parent { get; set; }
        public AnnotatedTreeNode LeftSibling { get; set; }
        public int Level { get; set; }

        public double Top { get; set; }
        public double Left { get; set; }
        public double Width { get; set; }
        public double Height { get; set; }

        public Point ChildrenConnectorPoint { get; set; }
        public Point ParentConnectorPoint { get; set; }

        public bool IsInvisibleNode { get; set; }
    }
}
