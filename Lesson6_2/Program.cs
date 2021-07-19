using System;
using System.IO;

namespace Lesson6_2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Work with files
            {
                //string path = "File_1.txt";
                //string content = "Hello world";

                //File.WriteAllText(path, content);


                //File.Copy(path, @"..\File_2.txt", true);
                //File.Delete(path);

                string[] files = Directory.GetFiles(@"C:\Windows");
                //foreach (var item in files)
                //{
                //    FileAttributes atr = File.GetAttributes(item);
                //    Console.WriteLine(item + atr);
                //}

                string name;
                string surname;
                int age;
                int weight;
                string personText = File.ReadAllText(@"C:\test\person.txt");
                string[] personLines = File.ReadAllLines(@"C:\test\person.txt");
                name = personLines[0];
                surname = personLines[1];
                age = int.Parse(personLines[2]);

                //Console.WriteLine($"Name: {name}, surname: {surname}, age: {age}");

                Console.WriteLine("Population = " + Person.Pupulation);

                Person pers1 = new Person(); // creation of class instace
                pers1.Name = name;
                //pers1.Surname = surname;
                pers1.Age = age;
                pers1.Weight = double.Parse(personLines[3]);

                Console.WriteLine("Person: " + pers1);
                Console.WriteLine("Population = " + Person.Pupulation);
                Console.WriteLine($"Was born in {pers1.GetYearOfBirth}");

                Person pers2 = new Person("James", "Karter", 25, 75.5);
                Console.WriteLine("Person 2: " + pers2);
                Console.WriteLine("Population = " + Person.Pupulation);

                Person pers3 = new Person() { 
                    Name = "dsasd", 
                    //Surname = "asdasd", 
                    Age = 54, 
                    Weight = 78.6 
                };
                Console.WriteLine("Population = " + Person.Pupulation);
                Console.WriteLine("Person 3: " + pers3);
                Console.WriteLine("Person 3 proffesion: " + pers3.Profession);

                Console.WriteLine(pers3.Age);
                pers3.Age = 54;

            }
        }
    }
}
