﻿using System;
using System.Collections.Generic;

namespace BinaryTree.Data
{
    public class Node : IDisposable
    {
        public int ID { get; set; }
        public Node(int ID)
        {
            this.ID = ID;
        }
        public Node? LeftNode { get; set; }
        public Node? RightNode { get; set; }

        public void Dispose()
        {
            // implementierung der dispose-methode
            // wird in diesem context nicht benötigt
        }

        // erstellt einen binärbaum aus einer liste von zahlen
        public static Node CreateTree(List<int> numbers)
        {
            if (numbers == null || numbers.Count == 0)
                return null;

            Node root = new Node(numbers[0]);
            for (int i = 1; i < numbers.Count; i++)
                AddNode(root, numbers[i]);

            return root;
        }

        // fügt einen knoten zum baum hinzu (rekursiv)
        private static void AddNode(Node node, int number)
        {
            if (number < node.ID)
            {
                if (node.LeftNode == null)
                    node.LeftNode = new Node(number);
                else
                    AddNode(node.LeftNode, number);
            }
            else
            {
                if (node.RightNode == null)
                    node.RightNode = new Node(number);
                else
                    AddNode(node.RightNode, number);
            }
        }

        // findet den minimalwert im baum (rekursiv)
        public int FindMin()
        {
            if (this == null)
                return int.MaxValue;

            int min = this.ID;
            int leftMin = this.LeftNode?.FindMin() ?? int.MaxValue;
            int rightMin = this.RightNode?.FindMin() ?? int.MaxValue;

            if (leftMin < min)
                min = leftMin;
            if (rightMin < min)
                min = rightMin;

            return min;
        }

        // findet den maximalwert im baum (rekursiv)
        public int FindMax()
        {
            if (this == null)
                return int.MinValue;

            int max = this.ID;
            int leftMax = this.LeftNode?.FindMax() ?? int.MinValue;
            int rightMax = this.RightNode?.FindMax() ?? int.MinValue;

            if (leftMax > max)
                max = leftMax;
            if (rightMax > max)
                max = rightMax;

            return max;
        }

        // gibt die zahlen im baum in aufsteigender reihenfolge aus (rekursiv)
        public void PrintInOrder()
        {
            if (this == null)
                return;

            this.LeftNode?.PrintInOrder();
            Console.Write(this.ID + " ");
            this.RightNode?.PrintInOrder();
        }

        // gibt die zahlen im baum in absteigender reihenfolge aus (rekursiv)
        public void PrintInReverseOrder()
        {
            if (this == null)
                return;

            this.RightNode?.PrintInReverseOrder();
            Console.Write(this.ID + " ");
            this.LeftNode?.PrintInReverseOrder();
        }
    }
}
