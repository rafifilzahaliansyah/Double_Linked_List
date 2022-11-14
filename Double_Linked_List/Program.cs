﻿using System;
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

        public void addnode()
        {
            int nim;
            string nm;
            Console.WriteLine("\n Enter the roll number of the student : ");
            nim = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\n Enter the name of the student : ");
            nm = Console.ReadLine();
            node NewNode = new node();
            NewNode.noMhs = nim;
            NewNode.name = nm;

            //cheack if the list empty
            if ((START != null) && (nim == START.noMhs))
            {
                Console.WriteLine("\nDuplicate number not allowed");
                return;
            }
            /*if the node is to inserted at between two node
             */
            node previous, current;
            for (current = previous= START;
                current != null && nim == current.noMhs;
                previous = current,current=current.next)
            {
                if(nim == current.noMhs)
                {
                    Console.WriteLine("\nDuplicate roll numbers not allowed");
                    return;
                }

            }
            /*
             * on the exucition of the above for loop,prev and
             * current will point to those nodes
             * between wich the node is to be inserted
             */

            NewNode.next = current;
            NewNode.prev = previous;

            //if the node is to be inserted at the end of the list
            if(current==null)
            {
                NewNode.next = null;
                NewNode.next = NewNode;
                return;
            }
            current.prev = NewNode;
            previous.next = NewNode;
        }
        public bool Search(int rollno,ref node previous, ref node current
        {
            for(previous = current = START;current != null && rollno != current.noMhs;previous=current,current = current.next) { }
            return (current != null);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
