using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student_Performance_Management
{
    internal class StudentService
    {
        string connectionString = @"Data Source=WAIANGDESK11;Initial Catalog=StudentPManagement;Integrated Security=True";
        public void AddStudent(Student s)
        {
          
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                SqlCommand command = new SqlCommand("student.sp_add_Student", connection);
                command.CommandType = System.Data.CommandType.StoredProcedure;

                command.Parameters.Add(new SqlParameter("@roll_no", s.Roll_no));
                command.Parameters.Add(new SqlParameter("@studentName", s.Student_Name));
                command.Parameters.Add(new SqlParameter("@studentEmail", s.Student_Email));
                command.Parameters.Add(new SqlParameter("@studentAddress", s.Student_Address));
                command.Parameters.Add(new SqlParameter("@courseid", s.Course_id));

                int row = command.ExecuteNonQuery();
                Console.WriteLine(row);

            }
        }

        public void EditStudentData(Student s)
        {

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                SqlCommand command = new SqlCommand("student.sp_Update_Student", connection);
                command.CommandType = System.Data.CommandType.StoredProcedure;

                command.Parameters.Add(new SqlParameter("@roll_no", s.Roll_no));
                command.Parameters.Add(new SqlParameter("@studentName", s.Student_Name));
                command.Parameters.Add(new SqlParameter("@studentEmail", s.Student_Email));
                command.Parameters.Add(new SqlParameter("@studentAddress", s.Student_Address));
                command.Parameters.Add(new SqlParameter("@courseid", s.Course_id));

                int row = command.ExecuteNonQuery();
                Console.WriteLine("RECORD UPDATED....");

            }

        }




        public Student findRecordStudent(int rollno)
        {

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                SqlCommand command = new SqlCommand("student.sp_Find_perticular_Student", connection);
                command.CommandType = System.Data.CommandType.StoredProcedure;
                command.Parameters.Add(new SqlParameter("@roll_no", rollno));

                using (SqlDataReader reader = command.ExecuteReader())
                {
                    reader.Read();

                    Console.WriteLine(reader[1] + " " + reader[2].ToString() + " " + reader[3].ToString() + " " + reader[4].ToString() + " " + reader[5]);

                    Student s = new Student(int.Parse(reader[1].ToString()),reader[2].ToString(),reader[3].ToString(),reader[4].ToString(),int.Parse(reader[5].ToString()));
                    return s;
                }

            }
        }

        public void DeleteStudent()
        {
            Console.WriteLine("Enter Roll no to delete");
            int Rollnno = int.Parse(Console.ReadLine());


            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                SqlCommand command = new SqlCommand("student.sp_Delete_Student", connection);
                command.CommandType = System.Data.CommandType.StoredProcedure;

                command.Parameters.Add(new SqlParameter("@roll_no",Rollnno));

                int row = command.ExecuteNonQuery();
                Console.WriteLine("DELETED..");

            }


        }
        public void DisplayStudent()
        {
            string connectionString = @"Data Source=WAIANGDESK11;Initial Catalog=StudentPManagement;Integrated Security=True";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                SqlCommand command = new SqlCommand("student.sp_Display_Student", connection);
                command.CommandType = System.Data.CommandType.StoredProcedure;

                //command.Parameters.Add(new SqlParameter("@brand_name", "Trek"));

                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Console.WriteLine(reader[1] + " " + reader[2].ToString() + " " + reader[3].ToString() + " " + reader[4].ToString() + " " + reader[5]);
                    }
                }
            }


        }




    }
}
