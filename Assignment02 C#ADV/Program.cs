using System.Collections;
using System.Runtime.Intrinsics.X86;

namespace Assignment02C_Adv
{
    
    internal class Program
    {    

        static void Main(string[] args)
        {

            #region Q01 : You are given an ArrayList containing a sequence of elements. try to reverse the order of elements in the ArrayList in-place(in the same arrayList) without using the built-in Reverse. Implement a function that takes the ArrayList as input and modifies it to have the reversed order of elements.

            //ArrayList arrayList = new ArrayList() { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            //Console.WriteLine("------Befor--------");
            //foreach (int i in arrayList)
            //    Console.WriteLine(i);

            //Helper.ReversedArrayList<int>(arrayList);
            //Console.WriteLine("--------After-------");
            //foreach (int i in arrayList)
            //    Console.WriteLine(i); 
            #endregion


            #region  Q02:You are given a list of integers. Your task is to find and return a new list containing only the even numbers from the given list.

            //List<int> list = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            //Console.WriteLine("----Before---");
            //foreach (int i in list) 
            //    Console.WriteLine(i);

            //Console.WriteLine("-----After----");
            //Helper.EvenNumbersList(list);

            #endregion


            #region Q03: mplement a custom list called FixedSizeList<T> with a predetermined capacity. This list should not allow more elements than its capacity and should provide clear messages if one tries to exceed it or access invalid indices.

            ////Requirements:
            ////Create a generic class named FixedSizeList<T>.
            ////Implement a constructor that takes the fixed capacity of the list as a
            ////parameter.
            ////Implement an Add method that adds an element to the list, but throws an exception if the list is already full.
            ////Implement a Get method that retrieves an element at a specific index in the list but throws an exception for invalid indices.




            // FixedSizeList<int> list = new FixedSizeList<int>(2);
            // list.AddElement(1); // Valid
            // list.AddElement(2); // valid 
            ////list.AddElement(3); // InValid : System.Exception: This Element Can Not Be Added Becouse The List Is Full

            // list.RetrievesElement(0); // 1
            // list.RetrievesElement(1); // 2
            // list.RetrievesElement(3 ); //  System.Exception: Invalid Index. Please Enter A Valid Index.


            #endregion


            #region Q04 : Given a string, find the first non-repeated character in it and return its index. If there is no such character, return 
            //Hint: you can use dictionary







            #endregion


            #region Q05 : Given an array  consists of  numbers with size N and number of queries, in each query you will be given an integer X, and you should print how many numbers in array that is greater than  X.

            //Helper.CountGreaterThan(3, 3);
            ////Ex:
            //// Input                            
            ////15 10 5           //Array 
            ////4                 //Query1
            ////10                //Query2
            ////5                 //Query 3
            ////Output
            ////3                    //15 10 5
            ////1                    //15
            ////2                    //15 10

            #endregion

            #region Q06 : Given a number N and an array of N numbers. Determine if it's palindrome or not.

            //int N;
            //bool Flag;
            //do
            //{
            //    Console.Write("Please Enter Number Of Element : ");
            //   Flag= int.TryParse(Console.ReadLine(), out N);
            //}while(!Flag);
            //Helper.GetArray(N);
            //bool Result = Helper.IsPalindrome(Helper.Array, N);
            //Console.WriteLine(Result);

            #endregion


            #region Q07 : Given an array, implement a function to remove duplicate elements from an array.
            //int N;
            //bool Flag;
            //do
            //{
            //    Console.Write("Please Enter Number Of Element : ");
            //    Flag = int.TryParse(Console.ReadLine(), out N);
            //} while (!Flag);
            //Helper.GetArray(N);

            //int[] NewArray = Helper.RemoveDuplicates(Helper.Array);


            //Console.WriteLine("\n---------Before RemoveDuplicates -----------\n");
            //foreach (int i in Helper.Array)
            //    Console.Write($"{i}  ");


            //Console.WriteLine("\n----------After RemoveDuplicates ----------\n");
            //foreach (int i in NewArray)
            //    Console.Write($"{i}  ");

            #endregion



            #region  Q08 : Given an array list , implement a function to remove all odd numbers from it.
            //List<int> lest = new List<int>() { 1, 2, 3, 4, 5, 5, 6, 7, 8, 9, 10 };

            // Helper.RemoveOddNumbers(lest);
            //foreach (int i in lest)
            //    Console.WriteLine(i); 
            #endregion




        }
    }


}
