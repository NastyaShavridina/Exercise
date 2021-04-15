using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ConsoleApp9
{
   public class Subject
    {
       [Key]
       public string SubjectId { get; set; }

       public string Name { get; set; }

       public ICollection<Student> Students { get; set; }

       public Subject()
       {
            Students = new List<Student>();
       }
    }
}
