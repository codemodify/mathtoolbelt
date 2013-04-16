using System.Collections.Generic;

namespace MathToolBelt.Searching.Contracts
{
    public class TreeNode
    {
        public Payload          Payload             { get; set; }

        public List<TreeNode>   Children            { get; set; }

        // Helpers for visualization
        public bool             IsCompareSource     { get; set; }
        public bool             IsCompareTarget     { get; set; }
    }
}
