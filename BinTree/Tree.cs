using System;

namespace BinTree
{
    public static class Tree
    {
        public static void WalkTree(Leaf leaf)
        {
            Console.WriteLine(leaf.Value);
            if (leaf.Right != null) WalkTree(leaf.Right);
            if (leaf.Left != null) WalkTree(leaf.Left);
        }

        public static void BuildTree(Leaf leaf, int depth)
        {
            if (depth == 0) return;

            leaf.Right = new Leaf($"{leaf.Value}:{depth}:Left");
            leaf.Left = new Leaf($"{leaf.Value}:{depth}:Right");

            BuildTree(leaf.Right, depth - 1);
            BuildTree(leaf.Left, depth - 1);
        }
    }
}
