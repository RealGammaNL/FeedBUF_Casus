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
                    string sql = "INSERT INTO ACTIVITY(Note) VALUES (@Note) WHERE ActivityID = @ActivityID";
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

        public static void UpdateLearnGoalNote(LearnGoal learngoal)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(ConnectionString))
                {
                    string sql = "UPDATE LEARNGOAL SET (Note = @Note) WHERE LearngoalID = @LearnGoalID";
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

        public static void UpdateAvtivityNote(Activity activity)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(ConnectionString))
                {
                    string sql = "UPDATE ACTIVITY SET (Note = @Note) WHERE ActivityID = @ActivityID";
                    connection.Open();
                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        command.Parameters.AddWithValue("@Note", activity.Note);
                        command.Parameters.AddWithValue("@ActivityID", activity.ActivityID);
                        command.ExecuteNonQuery();
                    }
                }
            }
            catch (SqlException ex) { throw ex; }
        }
        public static void DeleteLearngoalNote()
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(ConnectionString))
                {
                    string sql = "DELETE";
                    connection.Open();
                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        command.ExecuteNonQuery();
                    }
                }
            }
            catch (SqlException ex) { throw ex; }
        }

        public static void DeleteActivityNote()
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(ConnectionString))
                {
                    string sql = "DELETE";
                    connection.Open();
                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        command.ExecuteNonQuery();
                    }
                }
            }
            catch (SqlException ex) { throw ex; }
        }
        public static List<LearnGoal> GetLearnGoalNote()
        {
            List <LearnGoal> learngoals = new List<LearnGoal>();
            try
            {
                using (SqlConnection connection = new SqlConnection(ConnectionString))
                {
                    string sql = "SELECT Note FROM ACTIVITY";
                    connection.Open();
                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                learngoals.Add(new LearnGoalt)reader["Note"]));
                            }
                        }
                    }
                }
                return learngoals;
            }
            catch (SqlException ex) { throw ex; }
        }
        public static List<Activity> GetActivityNote()
        {
            List <Activity> activities = new List<Activity>();    
            try
            {
                using (SqlConnection connection = new SqlConnection(ConnectionString))
                {
                    string sql = "SELECT Note FROM ACTIVITY";
                    connection.Open();
                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                activities.Add(new Activity((int)reader["Note"]));
                            }
                        }
                    }
                }
                return activities;
            }
            catch (SqlException ex) { throw ex; }
        }
    }
}
