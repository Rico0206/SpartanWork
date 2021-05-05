using System;
using System.Collections.Generic;
using System.Linq;

namespace QueryWalkthrough
{
    class Program
    {

        static List<Student> students = new List<Student>
        {
            new Student {First="Svetlana", Last="Omelchenko", ID=111, Scores= new List<int> {97, 92, 81, 60}},
            new Student {First="Claire", Last="O'Donnell", ID=112, Scores= new List<int> {75, 84, 91, 39}},
            new Student {First="Sven", Last="Mortensen", ID=113, Scores= new List<int> {88, 94, 65, 91}},
            new Student {First="Cesar", Last="Garcia", ID=114, Scores= new List<int> {97, 89, 85, 82}},
            new Student {First="Debra", Last="Garcia", ID=115, Scores= new List<int> {35, 72, 91, 70}},
            new Student {First="Fadi", Last="Fakhouri", ID=116, Scores= new List<int> {99, 86, 90, 94}},
            new Student {First="Hanying", Last="Feng", ID=117, Scores= new List<int> {93, 92, 80, 87}},
            new Student {First="Hugo", Last="Garcia", ID=118, Scores= new List<int> {92, 90, 83, 78}},
            new Student {First="Lance", Last="Tucker", ID=119, Scores= new List<int> {68, 79, 88, 92}},
            new Student {First="Terry", Last="Adams", ID=120, Scores= new List<int> {99, 82, 81, 79}},
            new Student {First="Eugene", Last="Zabokritski", ID=121, Scores= new List<int> {96, 85, 91, 60}},
            new Student {First="Michael", Last="Tucker", ID=122, Scores= new List<int> {94, 92, 91, 91}},
            new Student {First="Christiano", Last="Ronaldo", ID=123, Scores= new List<int> {99, 95, 94, 93}},
            new Student {First= "Lionel", Last="Messi", ID=124, Scores= new List<int> {94, 95, 96, 96}},
            new Student {First= "Alexandre", Last="Lacazette", ID=125, Scores= new List<int> {78, 56, 76, 67}}
        };
        static void Main(string[] args)
        {
            //IEnumerable<Student> studentQuery =
            //    from student in students
            //    where student.Scores[0] > 90 
            //    orderby student.Scores[0] ascending
            //    select student;

            //foreach (var student in studentQuery)
            //{
            //    Console.WriteLine($"First Name = {student.First} \nLast Name = {student.Last} \nScore = {student.Scores[0]}\n");
            //}

            //var studentQuery2 =
            //    from student in students
            //    group student by student.Last[0];

            //foreach (var studentGroup in studentQuery2)
            //{
            //    Console.WriteLine(studentGroup.Key);

            //    foreach (var student in studentGroup)
            //    {
            //        Console.WriteLine($"First Name = {student.First}\nLast Name = {student.Last}\n");
            //    }
            //}

            //var studentQuery3 =
            //    from student in students
            //    group student by student.Last[0] into studentGroup
            //    orderby studentGroup.Key
            //    select studentGroup;

            //foreach (var groupStudent in studentQuery3)
            //{
            //    Console.WriteLine(groupStudent.Key);

            //    foreach (var student in groupStudent)
            //    {
            //        Console.WriteLine($"First Name = {student.First}\nLast Name = {student.Last}\n");
            //    }
            //}

            //var studentQuery4 =
            //    from student in students
            //    let totalScore = student.Scores[0] + student.Scores[1] + student.Scores[2] + student.Scores[3]
            //    where totalScore / student.Scores.Count < student.Scores[0]
            //    orderby student.Last ascending
            //    select student.First + " " + student.Last;

            //foreach (var student in studentQuery4)
            //{
            //    Console.WriteLine(student);
            //}

            var studentQuery5 =
                from student in students
                let totalScore = student.Scores[0] + student.Scores[1] + student.Scores[2] + student.Scores[3]
                select totalScore;

            double averageScore = studentQuery5.Average();

            //Console.WriteLine($"Average Score = {averageScore}");

            //var studentQuery6 =
            //    from student in students
            //    where student.Last == "Garcia"
            //    select student.First;

            //Console.WriteLine("Garcia's In The Class Are: ");

            //foreach (var student in studentQuery6)
            //{
            //    Console.WriteLine(student);
            //}


            var studentQuery7 =
                from student in students
                let ts = student.Scores[0] + student.Scores[1] + student.Scores[2] + student.Scores[3]
                where ts > averageScore
                select new { Id = student.ID, Score = ts };

            Console.WriteLine($"Average Score = {(int)averageScore}");
            foreach (var student in studentQuery7)
            {
                Console.WriteLine($"Id = {student.Id} Score = {student.Score}");
            }
        }
    }
}
