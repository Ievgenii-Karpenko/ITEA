using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_06_HW
{
    class Classroom
    {
        private List<Student> students = new List<Student>();

        // Генерирует ФИО студента из трех массивов. Составляются все возможные уникальные комбинации.
        // В данном случае 27 комбинаций. Результат записывается в файл, который после читается в List.
        public void WriteStudentToFile(string dir)
        {
            string filePath = $@"{dir}\Students.txt";
            string[] arrFirstName = new string[] { "Иван", "Петр", "Сидор" };
            string[] arrMiddleName = new string[] { "Иванович", "Петрович", "Сидорович" };
            string[] arrLastName = new string[] { "Иванов", "Петров", "Сидоров" };
            Random rnd = new Random();

            if (!File.Exists(filePath))
            {
                using (FileStream fs = File.Create(filePath))
                using (StreamWriter writer = new StreamWriter(fs))
                {
                    for (int i = 0; i < arrLastName.Length; i++)
                    {
                        for (int j = 0; j < arrFirstName.Length; j++)
                        {
                            for (int k = 0; k < arrMiddleName.Length; k++)
                            {
                                writer.WriteLine(arrLastName[i] + " " + arrFirstName[j] + " " + arrMiddleName[k] + "-" + rnd.Next(1, 6));
                            }
                        }
                    }
                    writer.Close();
                }
            }
        }

        // Ранее сгенерированный файл читается посточно. Результат ФИО и курс студента хаписывается в List.
        public void GetStudentsFromFile(string dir)
        {
            string filePath = $@"{dir}\Students.txt";
            int courseNum;
            string[] studentLine = new string[2];

            using (StreamReader sr = new StreamReader(filePath))
            {
                while (sr.Peek() >= 0)
                {
                    studentLine = sr.ReadLine().Split("-");
                    Student student = new Student();
                    student.Name = studentLine[0];

                    if (int.TryParse(studentLine[1], out courseNum))
                    {
                        student.CourseNum = courseNum;
                    }
                    else
                    {
                        student.CourseNum = 0;
                    }

                    students.Add(student);
                }
            }
        }

        public void WriteAllHomework(string dir)
        {
            foreach (var item in students)
            {
                item.WriteHomework(dir);
            }
        }
    }
}