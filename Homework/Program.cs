using System;
using System.Globalization;


namespace HomeWork4
{
    class Homework4
    {
        static void Main(string[] args)
        {
            // Д/З до 5-го уроку
            //Зробити програму яка:
            //0️. Запитує у користувача назви N комп’ютерних ігор і записує їх у масив.
            //1. Зробити метод який буде сортувати масив цих ігор у зворотньому порядку (від Z до А).
            //2. Виводить з масиву тільки ті імена, які починаються на якусь букву X. 
            //3. Всі ці інструкції здійснюються в циклі.
            //P.S. Значення для N та X мають передаватися програмі, як command line параметер.


            //char letter;
            //int parsedInt;
            //Tuple<int, char> parsedParams = ValifateParams(args);

            //Console.WriteLine("Parsed int = " + parsedParams.Item1);
            //Console.WriteLine("Parsed letter = " + parsedParams.Item2);

            (int parsedInt, char letter) parsedParams2 = ValifateParams(args);

            Console.WriteLine("Parsed int = " + parsedParams2.parsedInt);
            Console.WriteLine("Parsed letter = " + parsedParams2.letter);



            (string name, int, double, string, int) person = ("Tom", 25, 81.23, "");

            Console.WriteLine(person.name);
            Tuple<string, int, double, string> myTup = new Tuple<string, int, double, string>("Tom", 25, 81.23, "");
            Console.WriteLine(myTup.Item1);

            Console.WriteLine("Starting input to array. To exit, plz type in \"Q\", or hit any key to continue");
            string Choice = Console.ReadLine();
            while (Choice != "Q")
            {
                Console.WriteLine("Plz enter qty of games you`d like to add to array (or type in \"Q\" to exit):");
                string ChoiceString = Console.ReadLine();
                if (ChoiceString == "Q")
                    break;

                string Digit = "";
                foreach (char character in ChoiceString)
                {
                    if (char.IsDigit(character))
                        Digit += character;
                }
                int N = int.Parse(Digit);

                string[] arr = new string[N];

                Console.WriteLine(" ____ ");

                Console.WriteLine("Plz enter name of game:");
                for (int i = 0; i < arr.Length; i++)
                {
                    arr[i] = Console.ReadLine();
                }

                Console.WriteLine(" ____ ");


                static string ReverseArr(string[] arr)
                {

                    for (int i = 0; i < arr.Length; i++)
                    {
                        Console.WriteLine(arr[arr.Length - i - 1]);
                    }
                    return null;
                }

                Console.WriteLine("Array sorted from Z to A:");
                Console.WriteLine(ReverseArr(arr));
                Console.WriteLine(" ____ ");

                Console.WriteLine("Plz enter first letter of game`s name:");
                char X = char.Parse(Console.ReadLine());

                static string SearchArr(string[] arr, char X)
                {
                    for (int i = 0; i < arr.Length; ++i)
                    {
                        if (arr[i][0] == X)
                            Console.WriteLine(arr[i]);
                    }
                    return null;
                }
                Console.WriteLine(SearchArr(arr, X));
            }


        }

        private static (int, char) ValifateParams(string[] args)
        {
            bool parsed = int.TryParse(args[0], out int parsedInt);
            if (!parsed)
            {
                Console.WriteLine("Not able to parse 0-th parameter");
                parsedInt = 10;
            }

            char letter;
            if (args[1].Length != 1)
            {
                Console.WriteLine("Not able to parse 1-th parameter");
                letter = 'a';
            }
            else
            {
                letter = args[1][0];
            }

            return (parsedInt, letter);
        }
    }
}