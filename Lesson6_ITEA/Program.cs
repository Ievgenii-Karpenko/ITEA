using DogFromAnimals = Lesson6_ITEA.Animals.Dog;
using System;
using System.IO;
using System.Text;

namespace Lesson6_ITEA
{
    class Program
    {
        static void Main(string[] args)
        {
            //Work with files
            { 
                string path = "C:\\test\\File_1.txt";
                string content = "Hello world";
                File.WriteAllText(path, content);
                File.Copy(path, "C:\\test\\File_2.txt", true);
                File.Delete(path);

                var files = Directory.GetFiles(@"C:\Windows");
                foreach (var item in files)
                {
                    Console.WriteLine(item);
                }

                string name;
                string surname;
                int age;
                int weight;
                string[] personLines = File.ReadAllLines(@"C:\test\person.txt");
                name = personLines[0];
                surname = personLines[1];
                age = int.Parse(personLines[2]);

                Console.WriteLine($"Name: {name}, surname: {surname}, age: {age}");
            }

            //Classes
            {
                //Person myPerson = new Person("John", 32, 50);
                //{
                //    Name = "John",
                //    Age = 32,
                //    Weight = 50.0,
                //};
                //myPerson.Name = "John";
                //myPerson.Age = 32;
                //myPerson.Weight = 50.0;
                //myPerson.ShowInfo();
                //Person another = new Person("Jessica");
                //another.Age = 33;
                ////another.Name ="Jessica";
                //another.ShowInfo();

                //string name = another.Name;
                //Console.WriteLine(name);

                //int age = another.Age;
                //Console.WriteLine(age);

                //Console.WriteLine(another.BirthYear);

                //another.ShowInfo2();

                //Person.StaticMethod();

                //DogFromAnimals rex = new DogFromAnimals();
                //rex.Say();

                //Dog rex2 = new Dog();
                //rex2.Say();

                var s = new Person("dfs");

                Console.WriteLine("What type of person do you want");
                Person mPers;
                if (Console.ReadLine() == "M")
                {
                    mPers = new MovigPerson("Dan", 54, 84, new Position() { positionX = 2, positionY = 5 });
                }
                else
                {
                    mPers = new StaticPerson("John", 54, 84, new Position() { positionX = 2, positionY = 5 });
                }

                mPers.ShowInfo();

                if (mPers as MovigPerson != null)
                {
                    (mPers as MovigPerson).MovingMethod();
                }

                if (mPers is MovigPerson)
                {
                    MovigPerson moving2 = mPers as MovigPerson;
                    moving2.MovingMethod();
                }

                if (mPers is MovigPerson moving)
                {
                    moving.MovingMethod();
                }

                MovigPerson m2 = new MovigPerson("asd", 50, 50, new Position() { positionX = 2, positionY = 5 });
                Person p2 = new Person("QQQ", 150, 150);
                m2 = (MovigPerson)p2;
            }
            
        }

        static string RandomString(int stringLength)
        {
            // Набор символов из которого будет случайным образом формироваться строка заданной длинны
            // Длинна возвращаемой строки передается как входной параметр в метод
            var chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz";
            StringBuilder stringChars = new StringBuilder();
            var random = new Random();
            for (int i = 0; i < stringLength; i++)
            {
                stringChars.Append(chars[random.Next(chars.Length)]);
            }
            return stringChars.ToString();
        }
    }
}
