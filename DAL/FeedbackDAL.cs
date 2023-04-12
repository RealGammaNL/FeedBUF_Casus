using DOMAIN;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

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
                            command.Parameters.AddWithValue("@ActivityID", DBNull.Value);
                        }
                        if (feedback.ActivityID != 0)
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
                    string sql = "UPDATE FEEDBACK SET Teacher = @Teacher, Title = @Title, Description = @Description " +
                        "WHERE FeedbackID = @FeedbackID";
                    connection.Open();
                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        command.Parameters.AddWithValue("@FeedbackID", feedback.FeedbackID);
                        command.Parameters.AddWithValue("@Teacher", feedback.Teacher);
                        command.Parameters.AddWithValue("@Title", feedback.Title);
                        command.Parameters.AddWithValue("@Description", feedback.Description);
                        command.ExecuteNonQuery();
                    }
                }
            }
            catch (SqlException ex) { throw ex; }
        }

        public static void DeleteFeedback(int FeedbackID)
        {
            try
            {
                using(SqlConnection connection = new SqlConnection(ConnectionString))
                {
                    string sql = "DELETE FEEDBACK WHERE FeedbackID = @FeedbackID";
                    connection.Open();
                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        command.Parameters.AddWithValue("@FeedbackID", FeedbackID);
                        command.ExecuteNonQuery();
                    }
                }
            }
            catch (SqlException ex) { throw ex; }
        }

        public static List<Feedback> GetFeedback(Student student, int weeknumber, string subject)
        {
            List<Feedback> feedbacks = new List<Feedback>();

            try
            {
                using (SqlConnection connection = new SqlConnection(ConnectionString))
                {
                    string sql = "SELECT FEEDBACK.FeedbackID, FEEDBACK.Title, FEEDBACK.Description, FEEDBACK.Teacher " +
                                "FROM FEEDBACK, LEARNGOAL " +
                                "WHERE FEEDBACK.StudentID = @StudentID " +
                                "AND FEEDBACK.LearnGoalID = LEARNGOAL.LearnGoalID " +
                                "AND LEARNGOAL.WeekNr = @WeekNr " +
                                "AND LEARNGOAL.SubjectName = @Subject";

                    connection.Open();
                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        command.Parameters.AddWithValue("@StudentID", student.ID);
                        command.Parameters.AddWithValue("@WeekNr", weeknumber);
                        command.Parameters.AddWithValue("@Subject", subject);

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

        public static void AddQuestion(int feedbackID, string question)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(ConnectionString))
                {
                    string sql = "UPDATE FEEDBACK SET Question = @Question WHERE FeedbackID = @FeedbackID";

                    connection.Open();
                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        command.Parameters.AddWithValue("@FeedbackID", feedbackID);
                        if (question != "") { command.Parameters.AddWithValue("@Question", question); }
                        else { command.Parameters.AddWithValue("@Question", DBNull.Value); }
                        command.ExecuteNonQuery();
                    }
                }
            }
            catch (SqlException ex) { throw ex; }
        }

        public static LearnGoal GetLearnGoalByID(int LearnGoalID)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(ConnectionString))
                {
                    string sql = "SELECT * FROM LEARNGOAL WHERE LearnGoalID = @LearnGoalID";

                    connection.Open();
                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        command.Parameters.AddWithValue("@LearnGoalID", LearnGoalID);
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                LearnGoal learnGoal = new LearnGoal((int)reader["LearnGoalID"]
                                                    , (int)reader["StudentID"]
                                                    , reader["SubjectName"].ToString()
                                                    , (int)reader["WeekNr"]
                                                    , reader["Learngoal"].ToString()
                                                    , reader["Note"].ToString()
                                                    );
                                return learnGoal;
                            }
                        }
                    }
                }
                return null;
            }
            catch (SqlException ex) { throw ex; }
        }

        public static Feedback GetFeedBackByID(int feedbackID)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(ConnectionString))
                {
                    string sql = "SELECT * FROM FEEDBACK WHERE FeedbackID = @FeedbackID";

                    connection.Open();
                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        command.Parameters.AddWithValue("@FeedbackID", feedbackID);
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                Feedback feedback = new Feedback((int)reader["StudentID"]
                                                    , (int)reader["LearnGoalID"]
                                                    // Inline if statement
                                                    , reader["ActivityID"] != DBNull.Value ? (int)reader["ActivityID"] : -1
                                                    , reader["Teacher"].ToString()
                                                    , reader["Title"].ToString()
                                                    , reader["Description"].ToString()
                                                    );
                                return feedback;
                            }
                        }
                    }
                }
                return null;
            }
            catch (SqlException ex) { throw ex; }
        }

        public static Activity GetActivityByID(int activityID)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(ConnectionString))
                {
                    string sql = "SELECT * FROM ACTIVITY WHERE ActivityID = @ActivityID";

                    connection.Open();
                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        command.Parameters.AddWithValue("@ActivityID", activityID);
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                Activity activity = new Activity((int)reader["ActivityID"]
                                                    , (int)reader["LearnGoalID"]
                                                    , reader["Activity"].ToString()
                                                    , reader["TimeEstimate"].ToString()
                                                    , reader["TimeSpent"].ToString()
                                                    , reader["Note"].ToString()
                                                    );
                                return activity;
                            }
                        }
                    }
                }
                return null;
            }
            catch (SqlException ex) { throw ex; }
        }

        public static string GetFeedbackQuestion(int feedbackID)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(ConnectionString))
                {
                    string sql = "SELECT Question FROM FEEDBACK WHERE FeedbackID = @FeedbackID";

                    connection.Open();
                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        command.Parameters.AddWithValue("@FeedbackID", feedbackID);
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                string question = reader["Question"].ToString();
                                return question;
                            }
                        }
                    }
                }
                return null;
            }
            catch (SqlException ex) { throw ex; }
        }
    }
}
