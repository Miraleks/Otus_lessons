using System;
using System.Collections.Generic;

namespace trees
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите числаю Для окончания ввода введите \"0\"");
            Node root = null;

            while (true)
            {
                var i = int.Parse(Console.ReadLine());
                if (i == 0)
                {
                    break;
                }
                if (root == null)
                {
                    root = new Node
                    {
                        Value = i
                    };
                }
                else
                {
                    Add(root, new Node
                    {
                        Value = i
                    });
                }

            }
            Console.WriteLine();
            Console.WriteLine("Отсортированные значения: ");
            Traverse(root);

            while (true)
            {
                Console.WriteLine();
                Console.WriteLine("Какое число ищем? (-100 для выхода)");
                var goal = int.Parse(Console.ReadLine());
                if (goal == -100)
                {
                    break;
                }

                var foundNode = Search(root, goal, 0);
                if (foundNode.Item1 == null)
                {
                    Console.WriteLine("Такое число не нашли.");
                }
                else
                {
                    Console.WriteLine("Число найдено: " + foundNode.Item1);
                    Console.WriteLine("на уровне: "+ foundNode.Item2);
                }
            }
            //Console.ReadKey();

        }

        static void Traverse(Node node)
        {
            if (node.Left != null)
            {
                Traverse(node.Left);
            }

            Console.WriteLine(node);

            if (node.Right != null)
            {
                Traverse(node.Right);
            }
        }

        static (Node, int) Search(Node current, int value, int level)
        {
            if (value < current.Value)
            {
                if(current.Left != null)
                {
                    return Search(current.Left, value, level + 1);
                }
                else
                {
                    return (null, 0);
                }
            }
            else if ((value > current.Value))
            {
                if (current.Right != null)
                {
                    return Search(current.Right, value, level + 1);
                }
                else
                {
                    return (null, 0);
                }
            }
            else{
                return (current, level);
            }
        }

        static void Add(Node current, Node toAdd)
        {
            if (toAdd.Value < current.Value)
            {
                if (current.Left != null)
                {
                    Add(current.Left, toAdd);
                } else
                {
                    current.Left = toAdd;
                }
            }
            else
            {
                if (current.Right != null)
                {
                    Add(current.Right, toAdd);
                }
                else
                {
                    current.Right = toAdd;
                }
            }
        }

    }

    class Node
    {
        private readonly List<Node> _children = new List<Node>();
        public int Value { get; set; }

        public Node Left { get; set; }
        public Node Right { get; set; }

        public override string ToString()
        {
            return Value.ToString(); 
        }





    }
}