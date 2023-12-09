//5-2-22
//This program takes an unordered array list and performs different functions including finding max/min values, removing values, and sorting the array
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnorderedArrayListNamespace;

namespace test

{

    public class Program

    {

        public static void Main(string[] args)

        {

            UnorderedArrayList u = new UnorderedArrayList();

            u.print();

            int var = 5;

            u.insert(ref var);

            var = 12;

            u.insert(ref var);

            var = 2;

            u.insert(ref var);

            var = 29;

            u.insert(ref var);

            var = 7;

            u.insert(ref var);

            var = 33;

            u.insert(ref var);

            var = 49;

            u.insert(ref var);

            var = 7;

            u.insert(ref var);

            var = 3;

            u.insert(ref var);

            Console.WriteLine("Initial List");

            u.print();

            Console.WriteLine("Remove 5");

            var = 5; //Remove from head

            u.remove(ref var);

            u.print();

            Console.WriteLine("Remove 33");

            var = 33; //Remove from somewhere not head

            u.remove(ref var);

            u.print();

            Console.WriteLine("Remove all occurences of 7");

            var = 7; //Remove all occurences

            u.removeAll(ref var);

            u.print();

            Console.WriteLine("Max element is: " + u.max());

            Console.WriteLine("Min element is: " + u.min());

            u.insertionSort();

            Console.WriteLine("Sorted List");

            u.print();

        }

    }

}