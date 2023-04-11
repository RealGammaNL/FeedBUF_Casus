using DOMAIN;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class FeedforwardDAL : MAINDAL
    {
        private static string ConnectionString = "Data Source=tcp:max.brosky.net\\GIGASOFTDB, 1433;Initial Catalog = FeedBUF_DB; Persist Security Info=True;User ID = sa; Password=Gigasoft123";
        public static void AddLearngoalNote(LearnGoal learngoal)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(ConnectionString))
                {
                    string sql = "INSERT INTO LEARNGOAL(Note) VALUES (@Note) WHERE LearnGoalID = @LearnGoalID";
                    connection.Open();
                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        command.Parameters.AddWithValue("@Note", learngoal.Note);
                        command.Parameters.AddWithValue("@LearnGoalID", learngoal.LearnGoalID);
                        command.ExecuteNonQuery();
                    }
                }
            }
            catch (SqlException ex) { throw ex; }
        }

        public static void AddActivityNote(Activity activity)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(ConnectionString))
                {
                    string sql = "INSERT INTO ACTIVITY(Note) VALUES (@Note) WHERE AcitivyID = @AcitivyID";
                    connection.Open();
                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        command.Parameters.AddWithValue("@Note", activity.Note);
                        command.Parameters.AddWithValue("ActivityID", activity.ActivityID);

                        command.ExecuteNonQuery();
                    }
                }
            }
            catch (SqlException ex) { throw ex; }
        }

        public static void UpdateNote()
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(ConnectionString))
                {
                    connection.Open();
                }
            }
            catch (SqlException ex) { throw ex; }
        }
        public static void DeleteNote()
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(ConnectionString))
                {
                    connection.Open();
                }
            }
            catch (SqlException ex) { throw ex; }
        }
        public static void GetLearngoalNote()
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(ConnectionString))
                {
                    connection.Open();
                }
            }
            catch (SqlException ex) { throw ex; }
        }
        public static void GetActivityNote()
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(ConnectionString))
                {
                    connection.Open();
                }
            }
            catch (SqlException ex) { throw ex; }
        }
    }
}
