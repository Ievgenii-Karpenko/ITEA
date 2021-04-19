using System;
using System.Collections;
using System.Collections.Generic;

namespace Lesson5_ITEA
{
    class Program
    {
        static void Main(string[] args)
        {
            var array1 = new int[5];
            array1[0] = 2;
            array1[1] = 5;
            array1[2] = 3;
            array1[2] = 75;
            array1[4] = 3;
            //array1[5] = 3;

            foreach (var item in array1)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("-----------------------");
            string[] arr2 = new string[] { "Sunday", "Monday", "..." };
            for (int i = 0; i < arr2.Length; i++)
            {
                Console.WriteLine(arr2[i]);
            }

            Console.WriteLine("-----------------------");
            int[] arr3 = { 55, 22, 45, 75 };
            // var arr3 = { 55, 22, 45, 75 }; // couldn't use var here
            foreach (var item in array1)
            {
                Console.WriteLine(item);
            }

            //Console.WriteLine("-----------------------");
            //// 1  2  3  4
            //// 11 22 33 44
            int[,] arr2d = { {1,2,3,4 }, {11,22,33,44 } };
            arr2d[0, 0] = 41;
            arr2d[0, 1] = 3;
            for (int i = 0; i < arr2d.Rank; i++)
            {
                for (int k = 0; k < arr2d.Length / arr2d.Rank; k++)
                {
                    Console.WriteLine(arr2d[i, k]);
                }
            }

            Console.WriteLine("-----------------------");
            //1  2  3
            // 11 22 33 44 55
            int[][] jArr = new int[2][];
            jArr[0] = new int[3] { 1, 2, 3 };
            jArr[1] = new int[5] { 11, 22, 33, 44, 55 };

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
                    Console.WriteLine(innerItem);
                }
            }

            Console.WriteLine("-----------------------");
            Console.WriteLine("3-Dimension array");

            string[][][] arr3d = new string[2][][];
            arr3d[0][0] = new string[2];
            arr3d[0][1] = new string[2];

            arr3d[1][0] = new string[3];
            arr3d[1][1] = new string[3];

            for (int i = 0; i < arr3d.Rank; i++)
            {
                for (int j = 0; j < arr3d[].Rank; j++)
                {
                    for (int л = 0; j < arr3d.Length / arr3d.Rank; j++)
                    {

                    }
                }
            }

            foreach (var item in arr3d)
            {
                int rnd = new Random().Next(0, 100);
                item = ((char)rnd).ToString();
            }


            string input = "Hello world!"; // -> World! Hello
            var charArr = input.ToCharArray();
            int[] intArr = { 541, 11, -6, 23, 0 };

            //Console.WriteLine(ReverseString(input));
            //Console.WriteLine(ReverseWords(input));

            Array.Sort(intArr);
            Array.Fill(intArr, 5);

            string[] arrS = Array.CreateInstance(typeof(string), 10) as string[]; // null
            Array.Fill(arrS, "fasdf");

            Array.ForEach(arrS, item => Console.WriteLine(item));
            bool isAllff = Array.TrueForAll(arrS, item => item == "fff");
            if (isAllff)
                Console.WriteLine("all elements is \"fff\"");


            foreach (var item in arrS)
            {
                Console.WriteLine(item);
            }


            Console.WriteLine("Enter numbers. For exit type 'q'");
            string input = string.Empty;
            List<int> list = new List<int>();

            while (input != "q")
            {
                input = Console.ReadLine();
                if (input == "q")
                    break;

                int convertedInput = Convert.ToInt32(input);
                list.Add(convertedInput);
            }

            Console.WriteLine("Items inside list:");
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }

            ArrayList arrList = new ArrayList();

            while (input != "q")
            {
                input = Console.ReadLine();
                if (input == "q")
                    break;

                int convertedInput = Convert.ToInt32(input);
                arrList.Add(convertedInput);
                arrList.Add("Hello");
            }

            Console.WriteLine("Items inside list:");
            foreach (var item in arrList)
            {
                Console.WriteLine(item);
            }

        }



        static string ReverseWords(string input)
        {
            string[] splitted = input.Split(new char[]{' '});
            string result = "";

            for (int i = splitted.Length - 1; i >= 0; i--)
            {
                result += splitted[i];
                if (i != 0)
                    result += " ";
            }
            return result;
        }


        static string ReverseString(string input)
        {
            // Hello world!
            // !
            // !d
            // !dl
            // ...

            char[] inputCharArr = input.ToCharArray();
            //for (int i = input.Length - 1; i >= 0; i--)
            //{
            //    res = res + input[i];
            //}

            Array.Reverse(inputCharArr);

            //for (int i = 0; i < inputCharArr.Length/2; i++)
            //{
            //    char temp = inputCharArr[i];
            //    inputCharArr[i] = inputCharArr[inputCharArr.Length - 1 - i];
            //    inputCharArr[inputCharArr.Length - 1 - i] = temp;
            //}
            return new string(inputCharArr);
        }
    }
}
