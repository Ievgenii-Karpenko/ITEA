using System;
using System.Text;

namespace Lesson2_ITEA
{
    class Program
    {
        private readonly int V;

        static void Main(string[] args)
        {
            int myInt = 23;
            myInt *= 10; // myInt = myInt + 10;

            Console.WriteLine($"myInt = {myInt}");

            {
                sbyte myByte = 127;
                myByte++;
                Console.WriteLine($"myByte = {myByte}");
            }
            {
                sbyte myByte = 127;
                Console.WriteLine(myByte);
            }

            int a = 0;
            Console.WriteLine(++a + a++);

            Console.WriteLine(string.Format("myByte = {0} {1}", myByte, myByte));

            Console.WriteLine("My name is \t \"Yevgenii\"");
            string pathToFile = @"C:\MyFolder\blfdf\file.txt \t {myByte}";
            Console.WriteLine(pathToFile);

            string myString = "sdfsd";
            Console.WriteLine($"{myString}");
            myString = myString + "1";

            Console.WriteLine($"{myString}");

            var sb = new StringBuilder();
            sb.Append(myString);
            sb.Append("adfdsf");
            sb.Append("sfrfr");

            string result = sb.ToString();

            bool varname = 5 < 2;
            bool varname2 = 5 > 2;

            Console.WriteLine($" 5 < 2 ? {varname}");
            Console.WriteLine($" 5 > 2 ? {varname2}");

            object universal = 5;
            Console.WriteLine($"{universal}");
            universal = "dfsdf";
            Console.WriteLine($"{universal}");
            universal = 5.2;
            Console.WriteLine($"{universal}");
            universal = true;
            Console.WriteLine($"{universal}");

            var age = 32;
            var weight = 56.5f;
            var height = 166.8;
            var name = "Yevgenii";

            string mfmm = Console.ReadLine(); 
            age = 35;

            const double PI = 3.14;

            bool isAlive = false;

            if (isAlive)
            {
                Console.WriteLine("Player is alive");
            }
            else
            {
                Console.WriteLine("Player is dead :(");
            }

            bool fullAmmo = false, fullHP = false;

            // == перевірка на рівність значень
            // != перевірка на нерівність значень
            // && логічне "і"
            // || логічне "або"
            // ! оператор заперечення або інверсії

            if (fullAmmo && fullHP)
            {
                Console.WriteLine("Player has fullHP and fullAmmo");
            }
            else if (fullAmmo || fullHP)
            {
                Console.WriteLine("Player has fullHP or fullAmmo");
            }

            bool debugMode = false;

            Console.WriteLine("For debug write Y");
            string debugAnswer = Console.ReadLine();

            // result = [condition] ? [positive case] : [negative case];
            debugMode = debugAnswer != "Y" ? false : true;
            //debugMode = debugAnswer == "Y" || debugAnswer == "y";

            Console.WriteLine("Please choose the door from 1 to 5");
            string choiceString = Console.ReadLine();

            // "dver 24"
            string cutDigit = "";
            foreach (char character in choiceString)
            {
                if (Char.IsDigit(character))
                {
                    cutDigit += character;
                    if (debugMode)
                    {
                        Console.WriteLine($"INFO: found {character} digit");
                    }
                }
            }

            int choice = int.Parse(cutDigit);
            switch (choice)
            {
                case 1: //if(choice == 1)
                    Console.WriteLine("There is an enemy. You loose!");
                    break;
                case 2:
                    Console.WriteLine("There is a treasure. You win!");
                    break;
                case 3:
                case 4:
                case 5:
                    Console.WriteLine("This door is empty");
                    break;
                default: // else
                    Console.WriteLine($"There is no such door: {choice}");
                    break;
            }

            //bool isAlive, fullAmmo, fullHP;
            int bigCondition = 0;

            int isAliveInt = 1;
            int isFullAmmoInt = 1 << 1;
            int isFullHPInt = 1 << 2;

            if ((bigCondition & isAliveInt) != 0)
            {
                isAlive = true;
            }

        }
    }
}
