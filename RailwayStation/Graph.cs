
namespace RailwayStation
{
    /// <summary>
    /// Class implements graph to store railway switches as nodes and railway routes as edges
    /// </summary>
    class Graph<T>
    {
        private NodeList<T> nodeSet;
        private string name;

        public Graph() : this(null, null) { }
        public Graph(string name) : this(name, null) { }
        public Graph(NodeList<T> nodeSet) : this(null, nodeSet) { }
        public Graph(string name, NodeList<T> nodeSet)
        {
            if (name == null)
                this.name = "";
            else
                this.name = name;

            if (nodeSet == null)
                this.nodeSet = new NodeList<T>();
            else
                this.nodeSet = nodeSet;
        }

        public void AddNode(Node<T> node)
        {
            nodeSet.Add(node);
        }

        public void AddNode(T value)
        {
            nodeSet.Add(new Node<T>(value));
        }

        public void AddDirectedEdge(Node<T> from, Node<T> to, int cost)
        {
            from.Neighbors.Add(to);
            to.Neighbors.Add(from);
        }

        public bool Contains(T value)
        {
            return nodeSet.FindByValue(value) != null;
        }

        public bool Remove(T value)
        {
            Node<T> nodeToRemove = (Node<T>)nodeSet.FindByValue(value);
            if (nodeToRemove == null)
                return false;

            nodeSet.Remove(nodeToRemove);

            foreach (Node<T> gnode in nodeSet)
            {
                int index = gnode.Neighbors.IndexOf(nodeToRemove);
                if (index != -1)
                    gnode.Neighbors.RemoveAt(index);
            }

            return true;
        }

        public NodeList<T> Nodes
        {
            get
            {
                return nodeSet;
            }
        }

        public int Count
        {
            get
            {
                return nodeSet.Count;
            }
        }

        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }


    }
}
