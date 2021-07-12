using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchTree
{
    class Program
    {
        private static object binarySearchTree;

        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Binary Search Tree Problem");
            Console.WriteLine("1.Insertion\n 2.Adding the Elements\n 3.Searching");
            int option = Convert.ToInt32(Console.ReadLine());
            BSTOperations<int> bst = new BSTOperations<int>(56);
            switch (option)
            {
                case 1:
                    bst.Insert(30);
                    bst.Insert(70);
                    bst.Display();
                    break;

                case 2:
                    bst.Insert(30);
                    bst.Insert(70);
                    bst.Insert(22);
                    bst.Insert(40);
                    bst.Insert(11);
                    bst.Insert(3);
                    bst.Insert(16);
                    bst.Insert(60);
                    bst.Insert(95);
                    bst.Insert(65);
                    bst.Insert(63);
                    bst.Insert(67);
                    bst.Display();
                    bst.Size();
                    break;

                case 3:

                    bst.Insert(30);
                    bst.Insert(70);
                    bst.Insert(22);
                    bst.Insert(40);
                    bst.Insert(11);
                    bst.Insert(3);
                    bst.Insert(16);
                    bst.Insert(60);
                    bst.Insert(95);
                    bst.Insert(65);
                    bst.Insert(63);
                    bst.Insert(67);
                    bst.Display();
                    bst.Search(63,bst);
                    break;

                default:
                    
                    break;
            }
            Console.ReadLine();
        }
    }
}
