using Student_Performance_Management.Model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student_Performance_Management.Services
{
    internal class CourseService
    {
        string connectionString = @"Data Source=WAIANGDESK11;Initial Catalog=StudentPManagement;Integrated Security=True";

        public void AddCourse(Course c)
        {

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                SqlCommand command = new SqlCommand("course.sp_add_Course", connection);
                command.CommandType = System.Data.CommandType.StoredProcedure;

                command.Parameters.Add(new SqlParameter("@courseCode", c.C_code));
                command.Parameters.Add(new SqlParameter("@courseTitle", c.C_title));
                command.Parameters.Add(new SqlParameter("@courseDisc", c.C_description));

                int row = command.ExecuteNonQuery();
                Console.WriteLine(row);

            }

        }

        public void EditCoursseData(Course c)
        {


            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                SqlCommand command = new SqlCommand("course.sp_Update_Course", connection);
                command.CommandType = System.Data.CommandType.StoredProcedure;

                command.Parameters.Add(new SqlParameter("@corse_code", c.C_code));
                command.Parameters.Add(new SqlParameter("@course_title", c.C_title));
                command.Parameters.Add(new SqlParameter("@course_discription", c.C_description));

                int row = command.ExecuteNonQuery();
                Console.WriteLine("RECORD UPDATED....");

            }

        }

        public void DeleteCourse(Course course)
        {

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                SqlCommand command = new SqlCommand("course.sp_Delete_Course", connection);
                command.CommandType = System.Data.CommandType.StoredProcedure;

                command.Parameters.Add(new SqlParameter("@corse_code", course.C_code));

                int row = command.ExecuteNonQuery();
                Console.WriteLine("DELETED..");

            }

        }

        public Course findRecordCourse(string c_code)
        {

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                SqlCommand command = new SqlCommand("course.sp_Find_perticular_Course", connection);
                command.CommandType = System.Data.CommandType.StoredProcedure;
                command.Parameters.Add(new SqlParameter("@corse_code", c_code));

                using (SqlDataReader reader = command.ExecuteReader())
                {
                    reader.Read();

                    Console.WriteLine(reader[1] + " " + reader[2].ToString() + " " + reader[3].ToString());

                    Course c = new Course(reader[1].ToString(), reader[2].ToString(), reader[3].ToString());
                    return c;
                }

            }
        }



        public void DisplayCourse()
        {

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                SqlCommand command = new SqlCommand("course.sp_Diaplay_Course", connection);
                command.CommandType = System.Data.CommandType.StoredProcedure;


                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Console.WriteLine(reader[1] + " " + reader[2].ToString() + " " + reader[3].ToString());
                    }
                }
            }


        }
    }
}
