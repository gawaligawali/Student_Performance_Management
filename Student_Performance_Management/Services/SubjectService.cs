using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student_Performance_Management.Services
{
    internal class SubjectService
    {
        string connectionString = @"Data Source = WAIANGDESK11; Initial Catalog = SampleStore; Integrated Security = True";
        public void AddSubject()
        {

        }

        public void EditSubjectData()
        {

        }

        public void DeleteSubject()
        {
            Console.WriteLine("Enter Subject code to delete");
            int scode = int.Parse(Console.ReadLine());


            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                SqlCommand command = new SqlCommand("course.sp_Delete_Subject", connection);
                command.CommandType = System.Data.CommandType.StoredProcedure;

                command.Parameters.Add(new SqlParameter("@sub_code", scode));

                int row = command.ExecuteNonQuery();
                Console.WriteLine("DELETED..");

            }



        }
        public void DisplaySubject()
        {
            string connectionString = @"Data Source = WAIANGDESK11; Initial Catalog = SampleStore; Integrated Security = True";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                SqlCommand command = new SqlCommand("dbo.sp_ass2ParaVari", connection);
                command.CommandType = System.Data.CommandType.StoredProcedure;

                command.Parameters.Add(new SqlParameter("@brand_name", "Trek"));

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
