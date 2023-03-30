namespace HashTable
{
    /*    class Node
        {
            protected internal string Key { get; set; }
            protected internal object Value { get; set; }
            protected internal Node Next { get; set; }
        }*/

    internal class Node
    {
        internal int Key { get; set; }
        internal string Value { get; set; }
        internal Node Next { get; set; }

        internal Node(int key, string value)
        {
            Key = key;
            Value = value;
            Next = null;
        }
    }
}
