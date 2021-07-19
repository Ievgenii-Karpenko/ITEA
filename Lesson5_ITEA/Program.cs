using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace Lesson5_ITEA
{
    class User
    {

    }

    class Program
    {
        static void SetUsers(out List<string> users)
        {
            users = new List<string>();
            users.Add("");
        }

        static void Main(string[] args)
        {
            int[] a1 = new int[2];

            for (int i = 0; i < a1.Length; i++)
            {
                Console.WriteLine(a1[i]);
            }

            a1 = new int[4];


            List<string> users;
            SetUsers(out users);

            foreach (var item in args)
            {

                if (item == "debug")
                {
                    Console.WriteLine("DEBUG is present");
                }
            }
            Console.ReadKey();

            int count = 5;
            int[] array1 = new int[count];
            array1[2] = 3;
            array1[3] = 75;
            array1[4] = 3;
            array1[0] = 2;
            array1[1] = 5;

            Console.WriteLine(array1.Length * sizeof(int));


            //array1 = new int[6];
            //array1[5] = 3;

            foreach (var item in array1)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("-----------------------");

            var arr2 = new string[] { "Sunday", "Monday", "..." };
            for (int i = 0; i < arr2.Length; i++)
            {
                Console.WriteLine(arr2[i]);
                foreach (var item in arr2[i])
                {
                    Console.WriteLine(item);
                }
            }

            Console.WriteLine("-----------------------");
            int[] arr3 = { 55, 22, 45, 75 };
            User[] users = new User[2];
            // int[] != int
            //var arr3 = { 55, 22, 45, 75 }; // couldn't use var here
            foreach (var item in array1)
            {
                Console.WriteLine(item);
            }

            //Console.WriteLine("-----------------------");
            //// 1  2  3  4
            //// 11 22 33 44
            int[,] arr2d = { {1,2,3,4 }, {11,22,33,44 } };
            arr2d[0, 1] = 2;
            //int[,] arr2d2 = new int[2,4];

            for (int i = 0; i < arr2d.Rank; i++)
            {
                for (int k = 0; k < arr2d.GetUpperBound(1) +1; k++)
                {
                    Console.Write(arr2d[i, k] + "\t");
                }
                Console.WriteLine();
            }

            foreach (var item in arr2d)
            {
                Console.Write(item + "\t");
            }

            Console.WriteLine("-----------------------");
            // 1  2  3
            // 11 22 33 44 55
            int[][] jArr = new int[2][];
            jArr[0] = new int[] { 1, 2, 3 };
            jArr[1] = new int[] { 11, 22, 33, 44, 55 };

            for (int i = 0; i < jArr.Length; i++)
            {
                for (int k = 0; k < jArr[i].Length; k++)
                {
                    Console.Write(jArr[i][k]);
                    Console.Write("\t");
                }
                Console.WriteLine();
            }

            Console.WriteLine("-----------------------");
            Console.WriteLine("Foreach:");
            foreach (var item in jArr)
            {
                foreach (var innerItem in item)
                {
                    Console.Write(innerItem);
                    Console.Write("\t");
                }
                Console.WriteLine();
            }

            Console.WriteLine("-----------------------");
            //Console.WriteLine("3-Dimension array");

            //string[][][] arr3d = new string[2][][];
            //arr3d[0][0] = new string[2];
            //arr3d[0][1] = new string[2];

            //arr3d[1][0] = new string[3];
            //arr3d[1][1] = new string[3];

            //for (int i = 0; i < arr3d.Rank; i++)
            //{
            //    for (int j = 0; j < arr3d[].Rank; j++)
            //    {
            //        for (int л = 0; j < arr3d.Length / arr3d.Rank; j++)
            //        {

            //        }
            //    }
            //}

            //foreach (var item in arr3d)
            //{
            //    int rnd = new Random().Next(0, 100);
            //    //item = ((char)rnd).ToString();
            //}


            string input = "Hello world!"; // -> World! Hello

            char[] charArr = input.ToCharArray();
            charArr[2] = 'T';
            input = new string(charArr);


            int[] intArr = { 541, 11, -6, 23, 0 };

            //Console.WriteLine(ReverseString(input));
            //Console.WriteLine(ReverseWords(input));

            Array.Sort(intArr);  // in-place
            Array.Reverse(intArr);
            Array.Fill(intArr, 5);

            string[] arrS = Array.CreateInstance(typeof(string), 10) as string[]; // null
            Array.Fill(arrS, "fasdf");

            Array.ForEach(arrS, item => Console.WriteLine(item));
            Array.ForEach(arrS, PrintElement);

            bool isAllff = Array.TrueForAll(arrS, item => item == "fff");
            if (isAllff)
                Console.WriteLine("all elements is \"fff\"");


            foreach (var item in arrS)
            {
                Console.WriteLine(item);
            }


            Console.WriteLine("Enter numbers. For exit type 'q'");
            //string input = string.Empty;
            List<List<int>> list = new List<List<int>>(8);
            List<int> list2 = new List<int>(8);

            for (int i = 0; i < 2; i++)
            {
                list.Add(new List<int>());
                for (int j = 0; j < 3; j++)
                {
                    list[i].Add(j * 4);
                }
            }

            while (input != "q")
            {
                input = Console.ReadLine();
                if (input == "q")
                    break;

                int convertedInput = Convert.ToInt32(input);
                //list.Add(convertedInput);
            }

            Console.WriteLine("Items inside list:");
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }

            ArrayList arrList = new ArrayList();
            //List<int> arrList = new List<int>();

            while (input != "q")
            {
                input = Console.ReadLine();
                if (input == "q")
                    break;

                int convertedInput = Convert.ToInt32(input);
                arrList.Add(convertedInput);
                arrList.Add("Hello");
            }

            int sum = (int)arrList[0] + (int)arrList[1];

            Console.WriteLine("Items inside list:");
            foreach (var item in arrList)
            {
                Console.WriteLine(item);
            }

        }

        static void PrintElement(string elemement)
        {
            Console.WriteLine(elemement);
        }


        // Hello world!
        static string ReverseWords(string input)
        {
            string[] splitted = input.Split(new char[]{' '});
            StringBuilder result = new StringBuilder();

            for (int i = splitted.Length - 1; i >= 0; i--)
            {
                result.Append(splitted[i]);
                if (i != 0)
                    result.Append(" ");
            }
            return result.ToString();
        }


        static string ReverseString(string input)
        {
            // Hello world!
            // !
            // !d
            // !dl
            // ...
            string res = "";

            if(input[0] == 'G')
            {

            }

            char[] inputCharArr = input.ToCharArray();
            //for (int i = input.Length - 1; i >= 0; i--)
            //{
            //    res = res + input[i];
            //}

            //Array.Reverse(inputCharArr);

            for (int i = 0; i < inputCharArr.Length / 2; i++)
            {
                char temp = inputCharArr[i];
                inputCharArr[i] = inputCharArr[inputCharArr.Length - 1 - i];
                inputCharArr[inputCharArr.Length - 1 - i] = temp;
            }
            return new string(inputCharArr);
        }
    }
}
