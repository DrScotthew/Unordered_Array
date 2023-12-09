using System;
using System.Collections.Generic;
using System.Linq;

namespace UnorderedArrayListNamespace

{
    public class UnorderedArrayList

    {
        protected int[] list;

        protected int next;

        public UnorderedArrayList()
        {
            list = new int[100];
            next = 0;
        }

        public void insert(ref int item)  //inserts an int into the list in no certain order

        {
            list[next] = item;
            next++;
        }

        

        public void remove(ref int item)  //removes one instance of a number (5 in this example) from the list... doesnt repeat since only removing one
        {
            int i;

            if (next == 0)
            {
                Console.WriteLine("Empty List");
            }

            if (item.Equals(list[0]))
            {
                list[0] = list[--next];
            }


            else
            {
                for (i = 0; i < next - 1; i++)
                {
                    if (item.Equals(list[i]))
                    {
                        for (int j = i; j < next; j++)
                            list[j] = list[j + 1];
                        next--;

                        break;
                    }
                }

                if (item.Equals(list[next - 1]) && i == next - 1)
                { 
                    next--; 
                }
            }
        }

        public void removeAll(ref int item)  //removes all integers that equal a certain value (7 in this example) from list
        {
            int i;
            int p = item;

            if (next == 0)
            {
                Console.WriteLine("Empty List");
            }

            if (item.Equals(list[0]))
            {
                list[0] = list[--next];
            }


            else
            {
                foreach (int x in list) //this looks at each individual int in list... repeats for each int
                {

                    //looks for whether or not int = value of 7 and removes it from list
                    for (i = 0; i < next - 1; i++)
                    {
                        if (item.Equals(list[i]))
                        {
                            for (int j = i; j < next; j++)
                                list[j] = list[j + 1];
                            next--;

                            break;
                        }

                    }

                    if (item.Equals(list[next - 1]) && i == next - 1)
                    {
                        next--;
                    }
                }
            }

        }

        public int min()  //gets value of minimum int in list
        {
            int m = list[0];

            for (int i = 1; i < next; i++)
            {
                if (m > list[i])
                    m = list[i];
            }

            return m;

        }

        public int max()  //gets value of maximum int in list
        {

            int m = list[0];
            for (int i = 1; i < next; i++)
            {
                if (m < list[i])
                    m = list[i];
            }

            return m;
        }

        public void insertionSort()  //performs an insertion sort to sort list from min to max
        {
            for (int i = 0; i < next - 1; i++)

            {
                for (int j = i + 1; j > 0; j--)
                {

                    if (list[j - 1] > list[j])
                    {

                        int temp = list[j - 1];
                        list[j - 1] = list[j];
                        list[j] = temp;
                    }
                }
            }
        }

        public void print()
        {
            for (int i = 0; i < next; i++)
            {
                Console.WriteLine(list[i]);
            }

            Console.WriteLine();
        }
    }
}