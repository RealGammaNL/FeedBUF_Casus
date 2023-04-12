using DAL;
using DOMAIN;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DAL
{
    public class FeedupDAL : MAINDAL
    {
        private static string ConnectionString = "Data Source=tcp:max.brosky.net\\GIGASOFTDB, 1433;Initial Catalog = FeedBUF_DB; Persist Security Info=True;User ID = sa; Password=Gigasoft123";

        public static void AddLearngoal(LearnGoal learngoal)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(ConnectionString))
                {
                    string sql = "INSERT INTO LEARNGOAL (StudentID, SubjectName, WeekNr, Learngoal) VALUES (@StudentID, @SubjectName, @WeekNr, @Learngoal)";
                    connection.Open();
                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        command.Parameters.AddWithValue("@StudentID", learngoal.StudentID);
                        command.Parameters.AddWithValue("@SubjectName", learngoal.SubjectName);
                        command.Parameters.AddWithValue("@WeekNr", learngoal.WeekNr);
                        command.Parameters.AddWithValue("@Learngoal", learngoal.Goal);
                        command.ExecuteNonQuery();
                    }
                }
            }
            catch (SqlException ex) { throw ex; }
        }
        public static List<LearnGoal> GetLearnGoals(Student student, int Weeknumber, string Subjectname)
        {
            List<LearnGoal> learngoals = new List<LearnGoal>();

            try
            {
                using (SqlConnection connection = new SqlConnection(ConnectionString))
                {
                    string sql = "SELECT * FROM LEARNGOAL WHERE StudentID = @StudentID AND WeekNr = @WeekNr AND SubjectName = @SubjectName";
                    
                    connection.Open();
                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        command.Parameters.AddWithValue("StudentID", student.ID);
                        command.Parameters.AddWithValue("WeekNr", Weeknumber);
                        command.Parameters.AddWithValue("SubjectName", Subjectname);
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                learngoals.Add(new LearnGoal((int)reader["LearnGoalID"]
                                                    , (int)(int)reader["StudentID"]
                                                    , reader["SubjectName"].ToString()
                                                    , (int)reader["WeekNr"]
                                                    , reader["Learngoal"].ToString()
                                                    , reader["Note"].ToString()
                                                    ));
                            }
                        }
                    }
                }
                return learngoals;
            }
            catch (SqlException ex) { throw ex; }
        }
        public static void AddActivity(Activity activity)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(ConnectionString))
                {
                    string sql = "INSERT INTO ACTIVITY (LearnGoalID, Activity, TimeEstimate) VALUES (@LearnGoalID, @Activity, @TimeEstimate)";
                    connection.Open();
                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        command.Parameters.AddWithValue("@LearnGoalID", activity.LearnGoalID);
                        command.Parameters.AddWithValue("@Activity", activity.ActivityText);
                        command.Parameters.AddWithValue("@TimeEstimate", activity.TimeEstimate);
                        command.ExecuteNonQuery();
                    }
                }
            }
            catch (SqlException ex) { throw ex; }
        }
        public static List<Activity> GetActivity(int learngoal)
        {
            List<Activity> activities = new List<Activity>();

            try
            {
                using (SqlConnection connection = new SqlConnection(ConnectionString))
                {
                    string sql = "SELECT * FROM ACTIVITY WHERE LearnGoalID = @LearnGoalID";

                    connection.Open();
                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        command.Parameters.AddWithValue("LearnGoalID", learngoal);
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                activities.Add(new Activity((int)reader["ActivityID"]
                                                    , (int)(int)reader["LearnGoalID"]
                                                    , reader["Activity"].ToString()
                                                    , reader["TimeEstimate"].ToString()
                                                    , reader["TimeSpent"].ToString()
                                                    , reader["Note"].ToString()
                                                    ));
                            }
                        }
                    }
                }
                return activities;
            }
            catch (SqlException ex) { throw ex; }
        }
        public static void TimeSpent(int activity, string timeSpent)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(ConnectionString))
                {
                    string sql = "UPDATE ACTIVITY SET TimeSpent = @TimeSpent WHERE ActivityID = @ActivityID";

                    connection.Open();
                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        command.Parameters.AddWithValue("ActivityID", activity);
                        command.Parameters.AddWithValue("TimeSpent", timeSpent);
                        command.ExecuteNonQuery();
                    }
                }
            }
            catch (SqlException ex) { throw ex; }
        }
        public static void DeleteActivity(int activity)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(ConnectionString))
                {
                    string sql = "DELETE FROM ACTIVITY WHERE ActivityID = @ActivityID";

                    connection.Open();
                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        command.Parameters.AddWithValue("ActivityID", activity);
                        command.ExecuteNonQuery();
                    }
                }
            }
            catch (SqlException ex) { throw ex; }
        }
        public static void UpdateActivity(int activityID, string activity)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(ConnectionString))
                {
                    string sql = "UPDATE ACTIVITY SET Activity=@Activity WHERE ActivityID = @ActivityID";

                    connection.Open();
                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        command.Parameters.AddWithValue("ActivityID", activityID);
                        command.Parameters.AddWithValue("Activity", activity);
                        command.ExecuteNonQuery();
                    }
                }
            }
            catch (SqlException ex) { throw ex; }
        }
        public static void UpdateLearngoal(int learngoalID, string learngoal)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(ConnectionString))
                {
                    string sql = "UPDATE LEARNGOAL SET Learngoal=@Learngoal WHERE LearngoalID = @LearngoalID";

                    connection.Open();
                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        command.Parameters.AddWithValue("LearngoalID", learngoalID);
                        command.Parameters.AddWithValue("Learngoal", learngoal);
                        command.ExecuteNonQuery();
                    }
                }
            }
            catch (SqlException ex) { throw ex; }
        }
        public static void DeleteLearngoal(int learngoal)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(ConnectionString))
                {
                    string sql = "DELETE FROM ACTIVITY WHERE LearngoalID = @LearngoalID;" +
                                 "DELETE FROM LEARNGOAL WHERE LearngoalID = @LearngoalID;";
                    connection.Open();
                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        command.Parameters.AddWithValue("LearngoalID", learngoal);
                        command.ExecuteNonQuery();
                    }
                }
            }
            catch (SqlException ex) { throw ex; }
        }
    }
}
