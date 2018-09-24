namespace BinTree
{
    public class Leaf
    {
        public Leaf(string val)
        {
            Value = val;
        }

        public string Value { get; set; }
        public Leaf Left { get; set; }
        public Leaf Right { get; set; }
    }
}
