using System;
using System.Text;

namespace Lesson2_ITEA
{
    class Program
    {
        private readonly int V;
        private readonly DateTime V1 = DateTime.Now;

        public static void Main(string[] args)
        {
            ////Init variable
            {
                int var1;
                int myInt = 23;
                myInt = myInt + 10;
                myInt -= 10;
                myInt--; // myInt = myInt + 1;

                var1 = myInt;
                Console.WriteLine($"myInt = {myInt}");
            }

            //sbyte myByte;
            // Scope
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
            //Console.WriteLine(++a);
            //1  +  1 = 2
            Console.WriteLine(++a + a++);
            //1) ++a // a = 1
            //2) 1 + 1
            //3) a++  // a = 2

            //Console.WriteLine(string.Format("myByte = {0} {1}", myByte, myByte));

            // Console.WriteLine("My name is \t \"Yevgenii\"");
            string pathToFile = @$"C:\\MyFolder\\blfdf\\file.txt "" {{a}} = {a}";
            Console.WriteLine(pathToFile);

            // Strings are immutable
            {
                string myString = "sdfsd";
                Console.WriteLine($"{myString}");
                myString = myString + "1";

                Console.WriteLine($"{myString}");

                var sb = new StringBuilder();
                sb.Append(myString);
                sb.Append("adfdsf");
                sb.Append("sfrfr");

                string result = sb.ToString();
            }

            //bool variable
            {
                bool varname = 5 < 2; // 1 або 0
                bool varname2 = 5 > 2;

                bool myBool = true;

                Console.WriteLine($" 5 < 2 ? {varname}");
                Console.WriteLine($" 5 > 2 ? {varname2}");
                Console.WriteLine($"sizeof(bool) = {sizeof(bool)}");
            }

            //base object
            {
                object universal = 5; // boxing
                int fromObject = (int)universal; // unboxing

                Console.WriteLine($"{universal}");
                universal = "dfsdf";
                Console.WriteLine($"{universal}");
                universal = 5.2;

                universal = (double)universal + 2;

                Console.WriteLine($"{universal}");
                universal = true;
                Console.WriteLine($"{universal}");
            }

            int age2;
            //var age3;

            //using of var
            {
                age2 = 12;
                //age3 = 12;
                var age = 32;
                var weight = 56.5f;
                var height = 166.8;
                var name = "Yevgenii";

                string readed = Console.ReadLine();
                age = 35;
            }

            const double PI = 3.14;
            //const DateTime ind = new DateTime(1991, 8, 24);
            //var aa = sizeof(DateTime);

            double price = 100.5;
            int quantity = 5;

            var res = price * quantity;

            int n1 = 2;
            int n2 = 3;
            double res1 = 2 / 3; //0.66666

            int a1 = Convert.ToInt32("afa");
            //int a2 = (int)"afa";

            // Conditions

            bool isAlive = false;
            if (isAlive)
            {
                Console.WriteLine("Player is alive");
            }
            else
            {
                Console.WriteLine("Player is dead :(");
            }

            bool fullAmmo = true, fullHP = true;

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

            int a = 5;

            if (!fullAmmo)
            {
                Console.WriteLine("It is true");
            }

            bool debugMode = false;

            Console.WriteLine("For debug write Y");
            string debugAnswer = Console.ReadLine();

            // result = [condition] ? [positive case] : [negative case];
            debugMode = debugAnswer != "Y" ? false : true;

            if (debugAnswer != "Y")
            {
                debugMode = false;
            }
            else
            {
                debugMode = true;
            }

            object o = 5;

            object o1 = o;
            object o2 = o;

            string a1 = "abc";
            string a2 = "a" + "b";
            string a3 = a2 + "c";

            if(a1 == a2)
            {
                Console.WriteLine("a1 == a2");
            }
            else
            {
                Console.WriteLine("a1 != a2");
            }

            //debugMode = debugAnswer == "Y" || debugAnswer == "y";

            Console.WriteLine("Please choose the door from 1 to 5");
            string choiceString = Console.ReadLine();

            // "dver 24"
            //string cutDigit = "";
            //foreach (char character in choiceString)
            //{
            //    if (Char.IsDigit(character))
            //    {
            //        cutDigit += character;
            //        if (debugMode)
            //        {
            //            Console.WriteLine($"INFO: found {character} digit");
            //        }
            //    }
            //}

            Random rnd = new Random();

            

            int choice = 5;

            if (choice == rnd.Next(1, 10))
            {
                //
            }

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
            int isFullAmmoInt = 7 << 1;
            int isFullHPInt = 1 >> 2;

            if ((bigCondition & isAliveInt) != 0)
            {
                isAlive = true;
            }

            int a = 0;
            int b = 1;

            a = a | (b << 4);



        }
    }
}
