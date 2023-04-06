using DOMAIN;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class FeedbackDAL : MAINDAL
    {
        private static string ConnectionString = "Data Source=tcp:max.brosky.net\\GIGASOFTDB, 1433;Initial Catalog = FeedBUF_DB; Persist Security Info=True;User ID = sa; Password=Gigasoft123";
        public static void AddFeedback(Feedback feedback)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(ConnectionString))
                {
                    string sql = "INSERT INTO FEEDBACK (StudentID, Teacher, ActivityID, LearnGoalID, Title, Description) VALUES (@StudentID, @Teacher, @ActivityID, @LearnGoalID, @Title, @Description)";
                    connection.Open();
                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        command.Parameters.AddWithValue("@StudentID", feedback.StudentID);
                        command.Parameters.AddWithValue("@Teacher", feedback.Teacher);
                        command.Parameters.AddWithValue("@LearngoalID", feedback.LearngoalID);

                        if (feedback.ActivityID == 0)
                        {
                            command.Parameters.AddWithValue("@ActivityID", null);
                        }
                        else
                        {
                            command.Parameters.AddWithValue("@ActivityID", feedback.ActivityID);
                        }

                        command.Parameters.AddWithValue("@Title", feedback.Title);
                        command.Parameters.AddWithValue("@Description", feedback.Description);
                        command.ExecuteNonQuery();
                    }
                }
            }
            catch (SqlException ex) { throw ex; }
        }

        public static void UpdateFeedback(Feedback feedback)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(ConnectionString))
                {
                    string sql = "UPDATE STUDENT SET (StudentID = @StudentID, TeacherID = @TeacherID, LearnGoalID = @LearnGoalID, Activity = @Activity, WeekNr = @WeekNr, Title = @Title, Description = @Description) " +
                        "WHERE FeedbackID = @FeedbackID";
                    connection.Open();
                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        command.Parameters.AddWithValue("@StudentID", feedback.FeedbackID);
                        command.Parameters.AddWithValue("@StudentID", feedback.StudentID);
                        command.Parameters.AddWithValue("@TeacherID", feedback.TeacherID);
                        command.Parameters.AddWithValue("@LearngoalID", feedback.LearngoalID);
                        command.Parameters.AddWithValue("@Activity", feedback.ActivityID);
                        command.Parameters.AddWithValue("@WeekNr", feedback.Weeknr);
                        command.Parameters.AddWithValue("@Title", feedback.Title);
                        command.Parameters.AddWithValue("@Description", feedback.Description);
                        command.ExecuteNonQuery();
                    }
                }
            }
            catch (SqlException ex) { throw ex; }
        }

        public static List<Feedback> GetFeedback()
        {
            List<Feedback> feedbacks = new List<Feedback>();

            try
            {
                using (SqlConnection connection = new SqlConnection(ConnectionString))
                {
                    string sql = "SELECT FeedbackID, Title, Description, Teacher " +
                                 "FROM FEEDBACK";

                    connection.Open();
                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                feedbacks.Add(new Feedback((int)reader["FeedbackID"]
                                                    , reader["Teacher"].ToString()
                                                    , reader["Title"].ToString()
                                                    , reader["Description"].ToString()
                                                    ));
                            }
                        }
                    }
                }
                return feedbacks;
            }
            catch (SqlException ex) { throw ex; }
        }




        public static List<LearnGoal> GetLearnGoals(Student student)
        {
            List<LearnGoal> learngoals = new List<LearnGoal>();

            try
            {
                using (SqlConnection connection = new SqlConnection(ConnectionString))
                {
                    string sql = "SELECT * FROM LEARNGOAL WHERE StudentID = @StudentID";

                    connection.Open();
                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                learngoals.Add(new LearnGoal((int)reader["LearnGoalID"]
                                                    , (int)(int)reader["StudentID"]
                                                    , reader["SubjectCode"].ToString()
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
    }
}
