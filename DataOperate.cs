using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using Microsoft.EntityFrameworkCore;

namespace ConsoleApp9
{
   public class DataOperate
    {
      async public void Operation(DbContextOptions<ApplicationContext> options, string subjectName, string firstName, string lastName)
        {
           using (ApplicationContext db = new ApplicationContext(options))
            {  
                Subject subject1 = new Subject() { SubjectId = Guid.NewGuid().ToString(), Name = subjectName };

                try
                {
                    if (!Equals(subject1, null))
                    {
                        db.Subjects.Add(subject1);
                    }

                    Student student1 = new Student() { StudentId = Guid.NewGuid().ToString(), FirstName = firstName, LastName = lastName, Subjects = new List<Subject>() { subject1 } };

                    db.Students.Add(student1);

                    db.SaveChanges();

                }
                catch (Exception ex)
                {
                    throw ex;
                }
              
            }
        }
    }
}
