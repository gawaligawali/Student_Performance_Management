using Student_Performance_Management.Services;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student_Performance_Management.Model
{
    internal class Course
    {
       public string C_code;
       public string C_title;
       public string C_description;
       CourseService cs = new CourseService();

        public Course()
        {
        }

        public Course(string c_code)
        {
            C_code = c_code;
        }

        public Course(string c_code, string c_title, string c_description)
        {
            this.C_code = c_code;
            this.C_title = c_title;
            this.C_description = c_description;
        }


        public void AddCourseManager()
        {
            Console.WriteLine("Enter Course Code");
            string c_code = Console.ReadLine();

            Console.WriteLine("Enter Course name");
            string c_name = Console.ReadLine();

            Console.WriteLine("Enter Course discription\n");
            string c_discription = Console.ReadLine();

            Course c = new Course(c_code, c_name, c_discription);
            cs.AddCourse(c);

        }

        public void EditCoursseDataManager()
        {
            Console.WriteLine("Enter Course Code :");
            string c_code = Console.ReadLine();
            Course c = new Course();
            c = cs.findRecordCourse(c_code);

            if (c == null)
            {
                Console.WriteLine("no data found");
            }
            else
            {
                Console.WriteLine("you want to delete proceed Y/N.\n");
                string ans = Console.ReadLine();
                if (ans == "Y")
                {

                    Console.WriteLine("Enter Course name");
                    string c_name = Console.ReadLine();

                    Console.WriteLine("Enter Course discription\n");
                    string c_discription = Console.ReadLine();

                    Course cour = new Course(c_code, c_name, c_discription);
                    cs.EditCoursseData(cour);
                }
                else
                {
                    Console.WriteLine("Cancel \n");
                }

            }

        }

        public void DeleteCourseManager()
        {
            Console.WriteLine("Enter Course Code :");
            string c_code = Console.ReadLine();
            Course c = new Course();
            c = cs.findRecordCourse(c_code);

            if (c == null)
            {
                Console.WriteLine("no data found");
            }
            else
            {
                Console.WriteLine("you want to delete proceed Y/N.\n");
                string ans=Console.ReadLine();
                if (ans == "Y")
                {
                    cs.DeleteCourse(c);
                }
                else
                {
                    Console.WriteLine("Cancel \n");
                }
               
            }

        }

       

    }
}
