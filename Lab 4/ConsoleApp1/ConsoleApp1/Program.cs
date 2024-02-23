using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            string nameOfCourse;
            double mark;
            string instructorName;

            bool check = true;
            do
            {
                Console.WriteLine("Enter name of Course");
                nameOfCourse = Console.ReadLine();
                Console.WriteLine();

                if (nameOfCourse == "" || nameOfCourse == " ")
                {
                    Console.WriteLine("ERROR Course Name cannot be not Empty. Re-enter Course Name");
                }
                else
                {
                    check = false;
                }

            } while (check == true);


            check = true;
            do
            {
                Console.WriteLine("Enter the relevant grade for that course");
                mark = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine();

                if (mark > 100 || mark < 0)
                {
                    Console.WriteLine("ERROR Grade should be with 1 - 100. Re-enter Grade");
                }
                else
                {
                    check = false;
                }

            } while (check == true);


            check = true;
            do
            {
                Console.WriteLine("Enter relavant instructor name");
                instructorName = Console.ReadLine();
                Console.WriteLine();

                if (instructorName == "" || instructorName == " ")
                {
                    Console.WriteLine("ERROR Instructor Name cannot be empty. Re-enter Instructor Name");
                }
                else
                {
                    check = false;
                }

            } while (check == true);


            Course course = new Course(nameOfCourse, mark, instructorName);

            Console.WriteLine();
            course.PrintCourseInfo();
        }
    }

    class Course
    {
        private string courseName;
        private string instructorName;
        private double grade;
        
        public Course(string courseName, double grade, string teacherName)
        {
            this.CourseName = courseName;
            this.Grade = grade;
            SetInstructorName(teacherName);
        }

        public string CourseName
        {
            get { return courseName; }
            
            private set
            {
                courseName = value;
            }
        }

        public double Grade
        {
            get { return grade; }
            
            private set
            {
                grade = value;
            }
        }

        public void SetInstructorName(string teacherName)
        {
                instructorName = teacherName;
        }

        private string CalculateLetterGrade()
        {
            if (grade >= 90)
            {
                return "A";
            }
            else if (grade >= 80)
            {
                return "B";
            }
            else if (grade >= 70)
            {
                return "C";
            }
            else if (grade >= 60)
            {
                return "D";
            }
            else if (grade >= 50)
            {
                return "E";
            }
            else
            {
                return "F";
            }
        }

        public void PrintCourseInfo()
        {
                Console.WriteLine($"Course Name: {courseName}");
                Console.WriteLine($"instructor Name : {instructorName}");
                Console.WriteLine($"Course Grade: {CalculateLetterGrade()}");
        }

    }
}
