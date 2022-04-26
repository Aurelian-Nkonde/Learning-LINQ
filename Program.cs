using System;

namespace learning.linq
{
    public class Program
    {
        /*
        static void Main(string[] args)
        {
            //The simplest query comprises one input sequence and one operator
            string[] girls = {"anna", "maidei", "ruwa"};
            IEnumerable<string> LongerNames = girls.Where(n => n.Length > 4);
            var shortName = girls.Where(n => n.Length <= 4);
            // foreach(string name in shortName)
            // {
            //     Console.WriteLine(name);
            // }

            // y extracts all names that contain the letter “a”
            IEnumerable<string> namesThatContainsA = girls.Where(a => a.Contains("a"));
            // foreach(string a in namesThatContainsA){ Console.WriteLine(a);}

            string[] boysNames = {"james", "boi", "olla", "joe"};
            IEnumerable<string> namesContainsA = boysNames
                                                .Where(n => n.Contains("a"))
                                                .OrderBy(n => n.Length)
                                                .Select(n => n.ToUpper());
            // Where, OrderBy, and Select are standard query operators
            foreach(string a in namesContainsA)
            {
                // Console.WriteLine(a);
            }


            List<string> colors = new List<string>()
            {
                "red",
                "blue",
                "orange",
                "black"
            };
            // ling query syntaxt
            var result = from col in colors
                        where col.Contains("a")
                        select col;
            // foreach(string n in result){ Console.WriteLine(n); };


            IList<Student> allStudents = new List<Student>()
            {
                new Student(){Id = 1, Name ="john", Age=23},
                new Student(){Id = 5, Name ="anna", Age=20},
                new Student(){Id = 3, Name ="ashy", Age=17},
                new Student(){Id = 7, Name ="bet", Age=16},
                new Student(){Id = 8, Name ="joe", Age=13},
                new Student(){Id = 4, Name ="annie", Age=25},
                new Student(){Id = 9, Name ="rudo", Age=33},
            };
            var studentsOlderThan20 = from student in allStudents
                                    where student.Age >= 20
                                    select student;
            foreach(var a in studentsOlderThan20)
            {
                // Console.WriteLine(a);
            }


            // LINQ method syntax query that returns a collection of strings which contains a letter "a"
            List<string> languages = new List<string>()
            {
                "java",
                "perl",
                "python",
                "javascript"
            };
            var codingContainsA = languages
                                .Where(n => n.Contains("a"))
                                .OrderBy(n => n.Length);
            // foreach(var a in codingContainsA){ Console.WriteLine(a); }
            var studentsOlderThan18 = allStudents
                                    .Where(n => n.Age >= 18);
            // foreach(var a in studentsOlderThan18){ Console.WriteLine(a); }

            // orderBy
            var studentsByNames = allStudents
                                .OrderBy(n => n.Name);
            // foreach(var n in studentsByNames){ Console.WriteLine(n); }

        }
    }

    public class Student
    {
        public int Id { get;set; }
        public string? Name { get;set; }
        public int Age { get;set; }

        public override string ToString()
        {
            return $"Student: {this.Name} is {this.Age} years!";
        }

        */
    }
}
