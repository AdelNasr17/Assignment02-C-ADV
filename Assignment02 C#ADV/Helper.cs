using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace Assignment02C_Adv
{
    internal static class Helper
    {
        public static int[] Array { get; set; }

        // Create a function to get the array from the user
        public static void GetArray(int size)
        {
            if (size <= 0)
                Console.WriteLine(" The Array Size Can Not Be Less Than Or Equal to 0");
            else
            {

                Helper.Array = new int[size];
                Console.WriteLine("Please Enter The Array Elements : ");
                for (int i = 0; i < Array.Length; i++)
                {
                    Console.Write($"Element{i + 1} : ");
                    bool flag = true;
                    do
                    {
                        flag = int.TryParse(Console.ReadLine(), out Array[i]);
                        if (flag == false)
                            Console.WriteLine("Please Enter A Valid Number ");
                    } while (!flag);
                }
            }
        }




        #region Q01 : You are given an ArrayList containing a sequence of elements. try to reverse the order of elements in the ArrayList in-place(in the same arrayList) without using the built-in Reverse. Implement a function that takes the ArrayList as input and modifies it to have the reversed order of elements.

        public static void ReversedArrayList<T>(ArrayList arrayList)
        {
            if (arrayList == null) return;
            int n = arrayList.Count;
            for (int i = 0; i < (n / 2); i++)
            {

                T? temp = (T)arrayList[i];
                arrayList[i] = arrayList[n - 1 - i];
                arrayList[n - 1 - i] = temp;
            }
        }


        #endregion


        #region Q02:You are given a list of integers. Your task is to find and return a new list containing only the even numbers from the given list.


        public static void EvenNumbersList( List<int> list )
        {
            List<int> EvenNumberList = new List<int>();
            if (list == null) return;
     
            for(int i = 0; i < list.Count ; i++)
            {
                if( list[i] % 2 == 0 )
                {
                    EvenNumberList.Add(list[i]);
                }
            }

            foreach (int i in EvenNumberList )
            {
                Console.WriteLine(i);
            }

        }


        #endregion


        #region  Q04 : Given a string, find the first non-repeated character in it and return its index. If there is no such character, return 
        public static int First_Non_Repeated_Character(string str)
        {
            Dictionary<char, int> CharCount = new Dictionary<char, int>();

            foreach (char c in str)
            {
                if (CharCount.ContainsKey(c))
                { CharCount[c]++; }
                else
                {
                    CharCount[c] = 1;
                }
            }


            for (int i = 0; i < str.Length; i++)
            {
                if (CharCount[str[i]] == 1)
                    return i;
            }

            return -1; 
            
          

            
        
            
        }
        #endregion


        #region Q05 : Given an array  consists of  numbers with size N and number of queries, in each query you will be given an integer X, and you should print how many numbers in array that is greater than  X.
        public static void CountGreaterThan(int size, int numberOfQuaries)
        {
            //get the array from the user
            GetArray(size);


            //Get the query from the user and give him the answer for each query
            Console.WriteLine("Please Emter The Inquiries You Want : ");
            for (int i = 0; i < numberOfQuaries; i++)
            {
                Console.Write($"The Query {i + 1} is : ");
                bool flag;
                int quary;
                do
                {
                    flag = int.TryParse(Console.ReadLine(), out quary);

                } while (!flag);


                int count = 0;
                for (int J = 0; J < Array.Length; J++)
                    if (Array[J] > quary)
                        count++;



                Console.WriteLine($"Number Of Didits Greeater than {quary} = {count} ");

            }
        }

        #endregion



        #region  Q06 : Given a number N and an array of N numbers. Determine if it's palindrome or not.
        public static bool IsPalindrome(int[] arr, int N)
        {
            for (int i = 0; i < (N / 2); i++)
            {
                if (arr[i] != arr[N - i - 1])
                    return false;
            }
            return true;
        }
        #endregion



        #region  Q07 : Given an array, implement a function to remove duplicate elements from an array.
        public static T[] RemoveDuplicates<T>(T[] arr)
        {
            List<T> Result = new List<T>();
           for (int i = 0;i < arr.Length;i++)
            {
                if (!Result.Contains(arr[i]))
                    Result.Add(arr[i]);
            }
                
          
            return Result.ToArray();

        }
        #endregion


        #region Q08 :  Given an array list , implement a function to remove all odd numbers from it.
        public static void RemoveOddNumbers(List<int> list)
        {
            List<int> Result = new List<int>();
            foreach (int i in list)
            {
                if (i % 2 == 0)
                    Result.Add(i);
            }
            list.Clear();
            list.AddRange(Result);

        }

        #endregion

    }
}
