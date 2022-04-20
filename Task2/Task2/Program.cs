using System;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Student student = new Student("Shahrom", "Rajabov", 324, 77, false);

            Console.WriteLine(student.getInfo());
        }

    }

    class Student
    {
        public string Name;
        public string Surname;
        public int Group;
        public byte Point;
        public bool IsGraduated;


        public  Student(string name,string  surname,int group,byte point,bool isGraduated)
        {
            Name = name;
            Surname = surname;
            Group = group;
            Point = point;

        }

        public string getInfo()
        {
            if (IsGraduated==true)
            {
                Console.WriteLine("Telebe mezun olub");
            }

            else if (Point>80)
            {
                Console.WriteLine("Ikinci imtahana buraxilir");
            }

            else
            {
                Console.WriteLine("Telebe mezun olmayib");
                Console.WriteLine("Ikinc imtahana buraxilmir");
            }

            return $"Name: {Name}  Surname:{Surname} Group:{Group} Point:{Point} isGrduate:{IsGraduated}";

        }
    }
}
