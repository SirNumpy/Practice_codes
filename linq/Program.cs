using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace linq
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[] { 1, 2, 3, 4, 5, 6, 7 };
            IEnumerable<int> oddNumbers = from number in numbers where number % 2 != 0 select number;
            foreach( int i in oddNumbers){
                Console.WriteLine(i);
            }
            UniversityManager un=new UniversityManager();
            un.MaleStudents();
            Console.WriteLine("Sorted by their age students are as follows-:");
            un.SortedAge();
            Console.WriteLine("students which belong to----------------------- ");
            un.MichegenStudents();
            un.universityStudentsCollection();
        }
    }
    class UniversityManager
    {
        public List<Student> students;
        public List<University> university;
        public UniversityManager()
        {
            students = new List<Student>();
            university = new List<University>();

            students.Add(new Student() { Age = 22, Id = 123, Gender = "male", Name = "sam",UniversityId=2 });
            students.Add(new Student() { Age = 15, Id = 123, Gender = "female", Name = "lisa",UniversityId=1 }); 
            students.Add(new Student() { Age = 18, Id = 123, Gender = "male", Name = "ben",UniversityId=1 });
            students.Add(new Student() { Age = 21, Id = 123, Gender = "transgender", Name = "karen",UniversityId=1 });
            students.Add(new Student() { Age = 16, Id = 123, Gender = "female", Name = "angilina",UniversityId=2 });

            university.Add(new University() { Id = 1, Name = "michegan" });
            university.Add(new University() { Id = 2, Name = "calafornia" });

            

        }
        public void MaleStudents()
        {
            IEnumerable<Student> malestudents = from student in students where student.Gender == "male" select student;
            foreach (Student i in malestudents)
            {
                i.print();
            }
        }
        public void SortedAge()
        {
            IEnumerable<Student> sortage = from student in students orderby student.Age select student;
            foreach(Student i in sortage)
            {
                i.print();
            }
        } 
        public void MichegenStudents()
        {
            IEnumerable<Student> MiStudent = from student in students 
                                             join uni in university on student.UniversityId 
                                             equals uni.Id where uni.Name=="michegan" select student;
            foreach ( Student i in MiStudent)
            {
                i.print();
            }
        }
        public void universityStudentsCollection()
        {
            var uniStuCollection = from student in students
                                   join uni in university on student.UniversityId equals uni.Id
                                 orderby student.Name select new { name = student.Name, universityName = uni.Name };
            Console.WriteLine("new student university collection is ");
            foreach (var item in uniStuCollection)
            {
                Console.WriteLine("name of student is {0} name of university is {1}",item.name,item.universityName);

            }
        }
        
    }
    class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public string Gender { get; set; }

        //forign key
        public int UniversityId { get; set; }
        public void print()
        {
            Console.WriteLine("student {0} of id {1}, age{2},gender{3} university id {4}",Name,Id,Age,Gender,UniversityId);
        }
    }
    class University
    {
        public string Name  { get; set; }
        public int Id { get; set; }
        public void Print()
        {
            Console.WriteLine("university {0} has an id{1}",Name,Id);
        }
    }
}
