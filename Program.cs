using System;
using System.Collections.Generic;
using System.Linq;

namespace CnLINQ_Projection
{
  class Student
  {
		public string Neptun { get; set; }
		public string Name { get; set; }
		public string Email { get; set; }
		public double Average { get; set; }

		public Student(string neptun, string name, string email,
     double average)
    {
      Neptun = neptun;
      Name = name;
      Email = email;
      Average = average;
    }
  }
  class ProjectionProgram
  {
    static List<Student> Students = new List<Student>();
    static void Seed()
    {
      Students.Add(new Student("ACRESC", "Anne Boer", "x@net.net", 2.25));
      Students.Add(new Student("ZHU234", "Cecil Button", "y@net.net", 4.25));
      Students.Add(new Student("DBGTRZ", "Debra Coelho", "z@net.net", 3.45));
      Students.Add(new Student("RFCMJW", "Emil Zoone", "t@net.net", 3.55));
    }
    static void Main(string[] args)
    {
      Seed();
     
      var H = from x in Students
              where x.Average > 3.5
              orderby x.Name ascending
              select new { x.Name, x.Neptun };
    
      Console.WriteLine("Students with an average greater than 3.5:\n");
      foreach (var y in H)
      {
        Console.WriteLine(y.Neptun + "\t" + y.Name);
      }
      Console.ReadLine();
    }
  }

}
