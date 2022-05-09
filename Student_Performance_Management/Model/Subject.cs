using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student_Performance_Management.Model
{
    internal class Subject
    {
        public string subject_code;
        public string subject_name;
        public string subject_discription;
        public int course_id;

        public Subject()
        {
        }

        public Subject(string subject_code, string subject_name, string subject_discription, int course_id)
        {
            this.subject_code = subject_code;
            this.subject_name = subject_name;
            this.subject_discription = subject_discription;
            this.course_id = course_id;
        }

        public void AddSubjectManager()
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

    }
}
