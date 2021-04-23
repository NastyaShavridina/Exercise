using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ConsoleApp9
{
   public class Student
    { 
       [Key]
       public string StudentId { get; set; }

       public string FirstName { get; set; }

       public string LastName { get; set; }

       public ICollection<Subject> Subjects { get; set; }

        public Student()
        {
            Subjects = new List<Subject>();        
        }
    }
}
