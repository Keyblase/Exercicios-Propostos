using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metodos
{
    class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student();
            student.Init("Nicolas", 18);
            Console.WriteLine("Matriculando Nicolas em CC H-106");
            student.Enroll("CC H-106");
            Console.WriteLine("Resuldado do registro do estudante");
            student.DisplayCourse();
            Console.ReadKey();

        }

        public class Student
        {
            public string name;
            public int id;
            CourseInstance coursInst;

            public void Init(string name, int id)
            {
                this.name = name;
                this.id = id;
                coursInst = null;
            }

            public void Enroll(string courseID)
            {
                coursInst = new CourseInstance();
                coursInst.Init(this, courseID);
            }

            public void DisplayCourse()
            {
                Console.WriteLine(name);
                coursInst.Display();
            }

            public class CourseInstance
            {
                public Student student;
                public string courseId;

                public void Init(Student student, string couseId)
                {
                    this.student = student;
                    this.courseId = courseId;
                }
                
                public void Display()
                {
                    Console.WriteLine(courseId);
                }
            }
        }
    }
}
