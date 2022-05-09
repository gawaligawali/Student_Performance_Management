using Student_Performance_Management.Model;
using Student_Performance_Management.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student_Performance_Management
{
    internal class Manager
    {
        Course course = new Course();
        Student student = new Student();
        CourseService courseservice = new CourseService();
        StudentService studentservice = new StudentService();
        Subject subject = new Subject();
        SubjectService subjectservice = new SubjectService();   



        public void Start()
        {
            do
            {

                Console.WriteLine("Menu: ");
                Console.WriteLine("1.AddCourse");
                Console.WriteLine("2.Display Course");
                Console.WriteLine("3.Edit Course");
                Console.WriteLine("4.Delete Course");


                Console.WriteLine("5.Add Student");
                Console.WriteLine("6.Display Student");
                Console.WriteLine("7.Edit Student");
                Console.WriteLine("8.Delete Student");

                Console.WriteLine("9.Add Subject");
                Console.WriteLine("10.Display Subject");
                Console.WriteLine("11.Edit Subject");
                Console.WriteLine("12.Delete Subject");

                Console.WriteLine("13.Add Marks");
                Console.WriteLine("14.Display Marks");
                Console.WriteLine("15.Edit Marks");
                Console.WriteLine("16.Delete Marks\n");


                Console.WriteLine("Select a Choice:");
                var keyInfo = Console.ReadKey();
                Console.WriteLine("\n");

                switch (keyInfo.KeyChar)
                {
                    case '1':
                        course.AddCourseManager();
                        break;
                    case '2':
                        courseservice.DisplayCourse();
                        break;
                    case '3':
                        course.EditCoursseDataManager();
                        break;
                    case '4':
                        course.DeleteCourseManager();
                        break;
                    case '5':
                        student.AddStudentManager();
                        break;
                    case '6':
                        studentservice.DisplayStudent();
                        break;
                    case '7':
                        student.EditStudentDataManager();
                        break;
                    case '8':
                        studentservice.DeleteStudent();
                        break;
                    case '9':
                        subject.AddSubjectManager();
                        break;


                }



            } while (true);

        }






    }
}
