using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Double_Linked_List
{
    class node
    {
        /*node class represents the node of doubly linked list.
         * it consists of the information part and linked to.
         * its succeeding and preceeding.
         * it terms of next and proveious*/
        public int noMhs;
        public string name;
        //point to the succeding node
        public node next;
        //point to the precceeding node
        public node prev;

    }

    class doublelinkedlist
    {
        node START;

        //Construktor
        public doublelinkedlist()
        {
            START = null;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
