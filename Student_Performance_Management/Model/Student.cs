namespace Student_Performance_Management
{
    public class Student
    {
        public int Roll_no;
        public string Student_Name;
        public string Student_Email;
        public string Student_Address;
        public int Course_id;
        StudentService studentService = new StudentService();


        public Student()
        {
        }

        public Student(int rollno, string student_Name, string student_Email, string student_Address, int course_id)
        {
            Roll_no = rollno;
            Student_Name = student_Name;
            Student_Email = student_Email;
            Student_Address = student_Address;
            Course_id = course_id;
        }

        public void AddStudentManager()
        {
            Console.WriteLine("Enter Student Roll_no");
            int stud_roll = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter Student Name");
            string stud_name = Console.ReadLine();

            Console.WriteLine("Enter Students Email");
            string stud_email = Console.ReadLine();

            Console.WriteLine("Enter Address\n");
            string stud_address = Console.ReadLine();


            Console.WriteLine("Enter Couse Id");
            int c_id = int.Parse(Console.ReadLine());

            Student stud = new Student(stud_roll, stud_name, stud_email, stud_address, c_id);
            studentService.AddStudent(stud);

        }



        public void EditStudentDataManager()
        {

            Console.WriteLine("Enter Rollno :");
            int c_Rollnno = int.Parse(Console.ReadLine());
            Student s = new Student();
            s = studentService.findRecordStudent(c_Rollnno);

            if (s == null)
            {
                Console.WriteLine("no data found");
            }
            else
            {
                Console.WriteLine("you want to delete proceed Y/N.\n");
                string ans = Console.ReadLine();
                if (ans == "Y")
                {

                    Console.WriteLine("Enter Name to update ");
                    string s_name = Console.ReadLine();

                    Console.WriteLine("Enter email to update\n");
                    string s_email = Console.ReadLine();

                    Console.WriteLine("Enter address update ");
                    string s_address = Console.ReadLine();

                    Console.WriteLine("Enter course id to update\n");
                    int c_id =int.Parse( Console.ReadLine());


                    Student stud = new Student(c_Rollnno, s_name,s_email,s_address,c_id);
                    studentService.EditStudentData(stud);
                }
                else
                {
                    Console.WriteLine("Cancel \n");
                }

            }



        }




    }
}