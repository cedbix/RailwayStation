
namespace RailwayStation
{
    /// <summary>
    /// Class implements graph to store railway turns or switches
    /// </summary>
    class Node<T>
    {
        private T data;
        private NodeList<T> neighbors = null;

        public Node() { }
        public Node(T data) : this(data, null) { }
        public Node(T data, NodeList<T> neighbors)
        {
            this.data = data;
            this.neighbors = neighbors;
        }

        public T Value
        {
            get
            {
                return data;
            }
            set
            {
                data = value;
            }
        }

        public NodeList<T> Neighbors
        {
            get
            {
                if (neighbors == null)
                    neighbors = new NodeList<T>();
                return neighbors;
            }
            set
            {
                neighbors = value;
            }
        }
    }
}
