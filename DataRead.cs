using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp9
{
   public class DataRead
    {
        public string SubjectName { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string ReadSubjectName()
        {
            Console.WriteLine($"Введите название предмета: ");

            SubjectName = Console.ReadLine();

            return SubjectName;
        }

        public string ReadStudentFirstName()
        {
            Console.WriteLine($"Ваше имя: ");

            FirstName = Console.ReadLine();

            return FirstName;
        }

        public string ReadStudentLastName()
        {
            Console.WriteLine($"Ваша фамилия: ");

            LastName = Console.ReadLine();

            return LastName;
        }

    }
}
