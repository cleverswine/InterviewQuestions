using System;

namespace BinTree
{
    class Program
    {
        static void Main(string[] args)
        {
            var node = new Leaf("root");
            Tree.BuildTree(node, 10);
            Tree.WalkTree(node);
            Console.Read();
        }
    }
}
