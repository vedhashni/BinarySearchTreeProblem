using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchTree
{
    /// <summary>
    /// UC1 - Insertion Operation
    /// </summary>
    /// <typeparam name="T"></typeparam>
    class BSTOperations<T> where T : IComparable<T>
    {
        public T nodedata { get; set; }
        public BSTOperations<T> leftnode { get; set; }

        public BSTOperations<T> rightnode { get; set; }

        public BSTOperations(T data)
        {
            this.nodedata = data;
            this.leftnode = null;
            this.rightnode = null;
        }
        int leftnodecount = 0, rightnodecount = 0;

        public void Insert(T item)
        {
            T CurrNodeVal = this.nodedata;
            if ((CurrNodeVal.CompareTo(item)) > 0)
            {
                if (this.leftnode == null)
                {
                    this.leftnode = new BSTOperations<T>(item);
                }
                else
                {
                    this.leftnode.Insert(item);
                }
            }
            else
            {
                if (this.rightnode == null)
                {
                    this.rightnode = new BSTOperations<T>(item);
                }
                else
                {
                    this.rightnode.Insert(item);
                }
            }
        }

        public void Display()
        {
            if (this.leftnode != null)
            {
                this.leftnodecount++;
                this.leftnode.Display();
            }
            Console.WriteLine(this.nodedata.ToString());
            if (this.rightnode != null)
            {
                this.rightnodecount++;
                this.rightnode.Display();
            }
        }

    }
}
