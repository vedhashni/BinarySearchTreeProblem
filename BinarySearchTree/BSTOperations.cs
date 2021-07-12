using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchTree
{
    /// <summary>
    /// UC1 - Insertion Operation
    /// UC2 - Adding elements using size
    /// </summary>
    /// <typeparam name="T"></typeparam>
    class BSTOperations<T> where T : IComparable<T>
    {
        public T nodedata { get; set; }
        public BSTOperations<T> leftsubtree { get; set; }

        public BSTOperations<T> rightsubtree { get; set; }

        public BSTOperations(T data)
        {
            this.nodedata = data;
            this.leftsubtree = null;
            this.rightsubtree = null;
        }
        int leftsubtreecount = 0, rightsubtreecount = 0;

        public void Insert(T item)
        {
            T CurrNodeVal = this.nodedata;
            if ((CurrNodeVal.CompareTo(item)) > 0)
            {
                if (this.leftsubtree == null)
                {
                    this.leftsubtree = new BSTOperations<T>(item);
                }
                else
                {
                    this.leftsubtree.Insert(item);
                    leftsubtreecount++;
                }
            }
            else
            {
                if (this.rightsubtree == null)
                {
                    this.rightsubtree = new BSTOperations<T>(item);
                }
                else
                {
                    this.rightsubtree.Insert(item);
                    rightsubtreecount++;
                }
            }
        }
        public void Size()
        {
            Console.WriteLine("Size " + " " + (1 + this.leftsubtreecount + this.rightsubtreecount));
        }

        public void Display()
        {
            if (this.leftsubtree != null)
            {
                this.leftsubtreecount++;
                this.leftsubtree.Display();
            }
            Console.WriteLine(this.nodedata.ToString());
            if (this.rightsubtree != null)
            {
                this.rightsubtreecount++;
                this.rightsubtree.Display();
            }
        }

    }
}
