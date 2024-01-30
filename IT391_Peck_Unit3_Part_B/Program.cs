using System;
using System.Collections.Generic;
using System.Linq;


namespace IT391_Peck_Unit3_Part_B
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine();
            Console.WriteLine("**********Section 1 ***********");
            Console.WriteLine();

            String[] mammals = new string[] { "Bear", "Gorilla", "Tiger", "Polar Bear", "Lion", "Monkey" };
            HashSet<string> setMammals = new HashSet<string>();
            try
            {
                for (int i = 0; i <= mammals.GetUpperBound(0); i++)
                {
                    setMammals.Add(mammals[i]);
                }
                Console.WriteLine("Orginal List ");
                Console.Write("[");

                for (int i = 0; i <= mammals.GetUpperBound(0); i++)
                {
                    Console.Write(mammals[i]);
                    if (i == mammals.GetUpperBound(0))
                    {
                        Console.Write("]");
                    }
                    else
                    {
                        Console.Write(", ");
                    }
                }


                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine(" Sorted Lists: ");

                SortedSet<String> sortedMammals = new SortedSet<string>(setMammals);
                Console.WriteLine("[");

                int j = 0;

                foreach (string job in sortedMammals)
                {
                    Console.WriteLine(job);
                    if (j != sortedMammals.Count() - 1)
                        Console.Write(", ");
                    j++;
                }
                Console.Write("]");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message.ToString());
            }

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("**********Section 2 ***********");
            Console.WriteLine();

            List<String> myFriends = new List<String>();
            myFriends.Add("Fred 602-299-3300");
            myFriends.Add("Ann 602-555-4949");
            myFriends.Add("Grace 520-544-9898");
            myFriends.Add("Sam 602-343-8723");
            myFriends.Add("Dorothy 520-689-9745");
            myFriends.Add("Sussan 520-981-8745");
            myFriends.Add("Bill 520-456-9823");
            myFriends.Add("Mary 520-788-3457");
            Console.WriteLine();

            Console.WriteLine("The contents of my friends list ");
            DisplayList(myFriends);
            Console.WriteLine();

            myFriends.Sort();

            Console.WriteLine("Sorted Friend List: ");
            DisplayList(myFriends);
            Console.WriteLine();

            myFriends.RemoveAt(1); //removes bill
            myFriends.RemoveAt(0); // remove first item from list
            myFriends.RemoveAt(myFriends.Count() - 1); //remove last item from list

            Console.WriteLine("Friend List After Deletions: ");
            DisplayList(myFriends);
            Console.WriteLine();

            Console.WriteLine("The number of items in my friends list is: " + myFriends.Count + "\n");
            Console.WriteLine();

            //part B
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("***********Sections 3 ************");
            Console.WriteLine();

            //new binary tree object which will initialize itself and print contents
            new BinaryTree().create();

            Console.ReadKey();
        }
        static void DisplayList(List<String> lst)
        {
            Console.Write("[");
            for (int i = 0; i < lst.Count(); i++)
            {
                Console.Write(lst[i]);
                if (i != lst.Count() - 1)
                    Console.Write(", ");
            }
            Console.Write("]");
            Console.WriteLine();
        }
    }

    public class Node
    {
        public Node left;
        public Node right;
        public int value;

        public Node(int value)
        { this.value = value; }
    }
    public class BinaryTree
    {
        public void create()
        {
            Node rootnode = new Node(50);
            insert(rootnode, 30);
            insert(rootnode, 45);
            insert(rootnode, 12);
            insert(rootnode, 29);
            Console.WriteLine("The contents of the binary tree are: ");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            traverse(rootnode);
        } //
        public void traverse(Node rootnode)
        {
            Console.WriteLine("The traversal sequence of PreOrder is: ");
            printPreOrder(rootnode);
            Console.WriteLine("*************************************");
            Console.WriteLine();
            Console.WriteLine("The traversal sequence of InOrder is: ");
            printInOrder(rootnode);
            Console.WriteLine("*************************************");
            Console.WriteLine();
            Console.WriteLine("The travesal sequence of PostOrder is: ");
            printPostOrder(rootnode);
            Console.WriteLine("*************************************");
            Console.WriteLine();
        }
        public void insert(Node node, int value)
        {
            if (value < node.value)
            {
                if (node.left != null)
                {
                    insert(node.left, value);
                }
                else
                {
                    //Console.WriteLine(" Inserted" + value + " to left of node " + node.value);
                    node.left = new Node(value);
                }
            }
            else if (value > node.value)
            {
                if (node.right != null)
                {
                    insert(node.right, value);
                }
                else
                {
                    //Console.WriteLine(" Inserted" + value + " to right of node " + node.value);
                    node.right = new Node(value);
                }
            }

        }
        public void printInOrder(Node node)
        {
            if (node != null)
            {
                printInOrder(node.left);
                Console.WriteLine(" Traversed " + node.value);
                printInOrder(node.right);
            }
        }
        public void printPreOrder(Node node)
        {
            if (node != null)
            {
                Console.WriteLine(" Traversed " + node.value);
                printPreOrder(node.left);
                printPreOrder(node.right);
            }
        }
        public void printPostOrder(Node node)
        {
            if (node != null)
            {
                printPostOrder(node.left);
                printPostOrder(node.right);
                Console.WriteLine(" Traversed " + node.value);
            }
        }
    }
}
