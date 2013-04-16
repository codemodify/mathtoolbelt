
namespace MathToolBelt.DataStructures.Queue
{
    public class Queue // FIFO
    {
        private SingleLinkedListNode _data;

        public void Enque( double value )
        {
            if( _data == null )
                _data = new SingleLinkedListNode() { Value = value };
            else
                _data.Add( value );
        }

        public double Dequeue()
        {
            double value = _data.Value;
            _data.Delete( value );

            return value;
        }
    }
}
