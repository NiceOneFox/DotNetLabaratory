namespace AlgorithmsAndCollections.Collections
{
    public class Node<U>
    {
        public Node<U> Next { get; set; }
        public U Value { get; set; }
        public Node(U value)
        {
            Value = value;
        }
    }
}
