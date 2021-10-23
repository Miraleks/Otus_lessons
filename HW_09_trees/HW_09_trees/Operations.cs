using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_09_trees
{
    class Operations
    {
        public static void Traverse(Node node)
        {
            if (node.Left != null)
            {
                Traverse(node.Left);
            }

            Console.WriteLine($"Name: {node.Value.name}, salary: {node.Value.salary}");

            if (node.Right != null)
            {
                Traverse(node.Right);
            };
        }
        public static void Add(Node current, Node toAdd)
        {
            var currentValue = current.Value;

            if (toAdd.Value.salary < current.Value.salary)
            {
                if (current.Left != null)
                {
                    Add(current.Left, toAdd);
                }
                else
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

        public static Node Search(Node current, int value)
        {
            if (value < current.Value.salary)
            {
                if (current.Left != null)
                {
                    return Search(current.Left, value);
                }
                else
                {
                    return null;
                }
            }
            else if ((value > current.Value.salary))
            {
                if (current.Right != null)
                {
                    return Search(current.Right, value);
                }
                else
                {
                    return null;
                }
            }
            else
            {
                return (current);
            }
        }


    }
}
