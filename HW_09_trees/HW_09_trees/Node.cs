using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_09_trees
{
    class Node
    {
        
        public Employees Value { get; set; }

        public Node Left { get; set; }
        public Node Right { get; set; }

        public override string ToString()
        {
            return Value.ToString();
        }

  
    }


}
