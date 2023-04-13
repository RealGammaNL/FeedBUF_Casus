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
        public static void UpdateFeedbackNote(int feedbackid, string note)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(ConnectionString))
                {
                    string sql = "UPDATE FEEDBACK SET Note = @Note WHERE FeedbackID = @FeedbackID";
                    connection.Open();
                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        command.Parameters.AddWithValue("@Note", note);
                        command.Parameters.AddWithValue("@FeedbackID", feedbackid);
                        command.ExecuteNonQuery();
                    }
                }
            }
            catch (SqlException ex) { throw ex; }
        }

        public static void UpdateActivityNote(int activityid, string note)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(ConnectionString))
                {
                    string sql = "UPDATE ACTIVITY SET Note = @Note WHERE ActivityID = @ActivityID";
                    connection.Open();
                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        command.Parameters.AddWithValue("@Note", note);
                        command.Parameters.AddWithValue("@ActivityID", activityid);
                        command.ExecuteNonQuery();
                    }
                }
            }
            catch (SqlException ex) { throw ex; }
        }
        public static void DeleteFeedbackNote(int feedbackid, string note)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(ConnectionString))
                {
                    string sql = "DELETE FROM FEEDBACK WHERE FeedbackID = @FeedbackID";
                    connection.Open();
                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        command.Parameters.AddWithValue("@Note", note);
                        command.Parameters.AddWithValue("@FeedbackID", feedbackid);
                        command.ExecuteNonQuery();
                    }
                }
            }
            catch (SqlException ex) { throw ex; }
        }

        public static void DeleteActivityNote(int activityid, string note)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(ConnectionString))
                {
                    string sql = "DELETE FROM ACTIVITY WHERE ActivityID = @ActivityID";
                    connection.Open();
                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        command.Parameters.AddWithValue("@Note", note);
                        command.Parameters.AddWithValue("@ActivityID", activityid);
                        command.ExecuteNonQuery();
                    }
                }
            }
            catch (SqlException ex) { throw ex; }
        }
        public static string GetFeedbackNote(int feedbackid)
        {
            string note = "";
            try
            {
                using (SqlConnection connection = new SqlConnection(ConnectionString))
                {
                    string sql = "SELECT Note FROM FEEDBACK WHERE FeedbackID = @FeedbackID";
                    connection.Open();
                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        command.Parameters.AddWithValue("@FeedbackID", feedbackid);
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.HasRows)
                            {
                                while (reader.Read())
                                {
                                    if (!reader.IsDBNull(0))
                                    {
                                        note = reader.GetString(0);
                                    }
                                }
                            }
                        }
                    }
                }
                return note;
            }
            catch (SqlException ex) { throw ex; }
        }
        public static string GetActivityNote(int activityid)
        {
            string note = "";
            try
            {
                using (SqlConnection connection = new SqlConnection(ConnectionString))
                {
                    string sql = "SELECT Note FROM ACTIVITY WHERE ActivityID = @ActivityID";
                    connection.Open();
                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        command.Parameters.AddWithValue("@ActivityID", activityid);
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.HasRows)
                            {
                                while (reader.Read())
                                {
                                    if (!reader.IsDBNull(0))
                                    {
                                        note = reader.GetString(0);
                                    }
                                }
                            }
                        }
                    }
                }
                return note;
            }
            catch (SqlException ex) { throw ex; }
        }

        public static void UpdateLearnGoalNote(int learngoalid, string note)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(ConnectionString))
                {
                    string sql = "UPDATE LEARNGOAL SET Note = @Note WHERE LearnGoalID = @LearnGoalID";
                    connection.Open();
                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        command.Parameters.AddWithValue("@Note", note);
                        command.Parameters.AddWithValue("@LearnGoalID", learngoalid);
                        command.ExecuteNonQuery();
                    }
                }
            }
            catch (SqlException ex) { throw ex; }
        }
        public static void DeleteLearnGoalNote(int learngoalid, string note)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(ConnectionString))
                {
                    string sql = "DELETE FROM LEARNGOAL WHERE ActivityID = @ActivityID";
                    connection.Open();
                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        command.Parameters.AddWithValue("@Note", note);
                        command.Parameters.AddWithValue("@LearnGoalID", learngoalid);
                        command.ExecuteNonQuery();
                    }
                }
            }
            catch (SqlException ex) { throw ex; }
        }
        public static string GetLearnGoalNote(int learngoalid)
        {
            string note = "";
            try
            {
                using (SqlConnection connection = new SqlConnection(ConnectionString))
                {
                    string sql = "SELECT Note FROM LEARNGOAL WHERE LearnGoalID = @LearnGoalID";
                    connection.Open();
                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        command.Parameters.AddWithValue("@LearnGoalID", learngoalid);
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.HasRows)
                            {
                                while (reader.Read())
                                {
                                    if (!reader.IsDBNull(0)) 
                                    {
                                        note = reader.GetString(0);
                                    }
                                }
                            }
                        }
                    }
                }
                return note;
            }
            catch (SqlException ex) { throw ex; }
        }
    }
}
