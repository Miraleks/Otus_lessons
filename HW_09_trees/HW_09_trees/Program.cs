using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_09_trees
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {

                List<Employees> employees = new();
                string name, inputSalary, inputEnd;
                Node root = null;
                
                while (true)
                {
                    Console.WriteLine("Please, enter Name and Salary of employee.");
                    Console.Write("Name: ");
                    name = Console.ReadLine();
                    if (name == "")
                        break;
                    do
                    {
                        Console.Write("Salary: ");
                        inputSalary = Console.ReadLine();
                        if (inputSalary == "")
                        {
                            Console.WriteLine("You don't enter salary");
                        }
                        else
                        {
                            foreach (char item in inputSalary)
                            {
                                if (!Char.IsDigit(item))
                                {
                                    Console.WriteLine("Please, enter correct salary");
                                    inputSalary = "";
                                }
                            }
                        }
                        

                    } while (inputSalary == "");
                    
                    
                    
                    var salary = int.Parse(inputSalary);

                    Employees person = new(name, salary);
                    if (root == null)
                    {
                        root = new Node
                        {
                            Value = person
                        };
                    }
                    else
                    {
                        Operations.Add(root, new Node
                        {
                            Value = person
                        });
                    }

                }

                Console.WriteLine();
                if(root == null)
                {
                    Console.WriteLine("You don't enter any employees");
                }
                else
                {
                    Operations.Traverse(root);
                }

                while (true)
                {
                    if (root != null)
                    {


                        Console.WriteLine("Please, what salary you are search?");
                        var salarySearch = int.Parse(Console.ReadLine());


                        var foundNode = Operations.Search(root, salarySearch);
                        if (foundNode == null)
                        {
                            Console.WriteLine("No employee with this salary.");
                        }
                        else
                        {
                            Console.WriteLine("Employee name: " + foundNode.Value.name);

                        }
                        //TODO исправить выход по "0" и "1"
                        do
                        {
                            Console.WriteLine("Do you want make another search? Please, enter \"1\"");
                            Console.WriteLine("Or if you want go to start, please, enter \"0\"");
                            inputEnd = Console.ReadLine();
                        } while (inputEnd != "0" & inputEnd !="1");

                        var choise = int.Parse(inputEnd);

                        if (choise == 0)
                        {
                            break;
                        }
                    }
                    else
                    {
                        break;
                    }
                }
            }

        }

              
    }
}
