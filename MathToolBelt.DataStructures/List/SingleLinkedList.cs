
namespace MathToolBelt.DataStructures
{
    public class SingleLinkedListNode
    {
        public double Value{ get; set; }
        public SingleLinkedListNode Next { get; set; }

        public void Add( double value )
        {
            SingleLinkedListNode nextNode = this;

            // Seek to end
            while( nextNode.Next != null )
            {
                nextNode = nextNode.Next;
            }

            // Allocate a new node
            nextNode.Next = new SingleLinkedListNode() { Value = value };
        }

        public void Insert( double value, int index )
        {
            SingleLinkedListNode nextNode = this;

            // Seek to specified index
            while( nextNode.Next != null && index-- > 0 )
            {
                nextNode = nextNode.Next;
            }

            //Backup the current value for Next
            SingleLinkedListNode backup = nextNode.Next;

            // Allocate a new node & fix the links
            nextNode.Next = new SingleLinkedListNode() { Value = value };
            nextNode.Next.Next = backup;
        }

        public void Delete( double value )
        {
            SingleLinkedListNode nextNode = this;

            // Seek to specified index
            while( nextNode.Next != null && nextNode.Next.Value != value )
            {
                nextNode = nextNode.Next;
            }

            // Delete the node & fix the links, in C/C++ we may have to call "delete" in C# the GC does it
            nextNode.Next = nextNode.Next.Next;
        }
    }
}
