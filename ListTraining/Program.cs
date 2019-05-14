using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListTraining
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> nameList = new List<string>();
            List<int> intList = new List<int>();
            List<Student> studentList = new List<Student>();

            Student student1 = new Student("Nicolas");
            Student student2 = new Student("Natanael");
            studentList.Add(student1);
            studentList.Add(student2);

            Student[] students = { new Student("Ana"), new Student("Mario") };
            studentList.AddRange(students);//add um banco de dados a lista
            studentList.AddRange(students);
            Console.WriteLine("Numero de estudantes :" + studentList.Count);

            //Student[] students = studentList.ToArray();//transforma para array

            //Busca indexOf()
            Console.WriteLine("Student2 no " + studentList.IndexOf(student2));
            string name = studentList[3].ToString();
            if (studentList.Contains(student1))
            {
                Console.WriteLine(student1.ToString());//contem algo na lista

            }

            studentList.Sort();
            studentList.Insert(3, new Student("Ross"));
            studentList.RemoveAt(3);
            Console.WriteLine("Removido " + name);

            nameList.Add("one");
            intList.Add(3);
            intList.Add(4);

            /*foreach( string j in nameList)
            {
                Console.WriteLine("string j = " + j);
            }

            foreach(int i in intList)
            {
                Console.WriteLine(" int i =" + i);
            } 
           */
            Console.ReadKey();
        }

        public class Student
        {
            private string v;

            public Student(string v)
            {
                this.v = v;
            }
        }
    }
}
