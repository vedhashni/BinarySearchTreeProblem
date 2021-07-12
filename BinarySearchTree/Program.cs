using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchTree
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Binary Search Tree Problem");
            Console.WriteLine("1.Insertion.");
            int option = Convert.ToInt32(Console.ReadLine());
            BSTOperations<int> bst = new BSTOperations<int>(56);
            switch (option)
            {
                case 1:
                    bst.Insert(30);
                    bst.Insert(70);
                    bst.Display();
                    break;
                default:
                    
                    break;
            }
            Console.ReadLine();
        }
    }
}
