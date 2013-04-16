

namespace MathToolBelt.Searching.Contracts
{
    public class BinaryNode
    {
        public Payload          Payload             { get; set; }

        public BinaryNode       LeftNode            { get; set; }
        public BinaryNode       RightNode           { get; set; }

        // Helpers for visualization
        public bool             IsCompareSource     { get; set; }
        public bool             IsCompareTarget     { get; set; }
    }
}
