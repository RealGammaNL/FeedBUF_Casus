using DOMAIN;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class StudentDAL : MAINDAL
    {
        private static string ConnectionString = "Data Source= tcp:max.brosky.net\\GIGASOFTDB, 1433;Initial Catalog = GIGASOFTDB; Persist Security Info=True;User ID = sa; Password=Gigasoft123";
        public static void AddStudent(Student student)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(ConnectionString))
                {
                    string sql = "INSERT INTO STUDENT (StudentID, GroupID, Fullname, Email, Password) VALUES (@StudentID, @GroupID, @Fullname, @Email, @Password)";
                    connection.Open();
                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        command.Parameters.AddWithValue("@StudentID", student.ID);
                        command.Parameters.AddWithValue("@GroupID", student.GroupID);
                        command.Parameters.AddWithValue("@Fullname", student.Fullname);
                        command.Parameters.AddWithValue("@Email", student.Email);
                        command.Parameters.AddWithValue("@Password", student.Password);
                        command.ExecuteNonQuery();
                    }
                }
            }
            catch (SqlException ex) { throw ex; }
        }

        public static void DeleteStudent(Student student)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(ConnectionString))
                {
                    string sql = "DELETE STUDENT WHERE StudentID = @StudentID";
                    connection.Open();
                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        command.Parameters.AddWithValue("@StudentID", student.ID);
                        command.ExecuteNonQuery();
                    }
                }
            }
            catch (SqlException ex) { throw ex; }
        }

        public static void UpdateStudent(Student student)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(ConnectionString))
                {
                    string sql = "UPDATE STUDENT SET (StudentID = @StudentID, GroupID = @GroupID, Fullname = @Fullname, Email = @Email, Password = @Password) WHERE StudentID = @StudentID";
                    connection.Open();
                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        command.Parameters.AddWithValue("@StudentID", student.ID);
                        command.Parameters.AddWithValue("@GroupID", student.GroupID);
                        command.Parameters.AddWithValue("@Fullname", student.Fullname);
                        command.Parameters.AddWithValue("@Email", student.Email);
                        command.Parameters.AddWithValue("@Password", student.Password);
                        command.ExecuteNonQuery();
                    }
                }
            }
            catch (SqlException ex) { throw ex; }
        }

        public static List<Student> GetStudents()
        {
            List<Student> students = new List<Student>();

            try
            {
                using (SqlConnection connection = new SqlConnection(ConnectionString))
                {
                    string sql = "SELECT * FROM STUDENT";
                    connection.Open();
                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                students.Add(new Student((int)reader["StudentID"]
                                                    , reader["GroupID"].ToString()
                                                    , reader["Fullname"].ToString()
                                                    , reader["Email"].ToString()
                                                    , reader["Password"].ToString()
                                                    ));
                            }
                        }
                    }
                }
                return students;
            }
            catch (SqlException ex) { throw ex; }
        }
    }
}
