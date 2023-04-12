﻿using DOMAIN;
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
        public static void AddFeedbackNote(Feedback feedback)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(ConnectionString))
                {
                    string sql = "INSERT INTO FEEDBACK(Note) VALUES (@Note) WHERE FeedbackID = @FeedbackID";
                    connection.Open();
                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        command.Parameters.AddWithValue("@Note", feedback.Note);
                        command.Parameters.AddWithValue("@FeedbackID", feedback.FeedbackID);
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

        public static void UpdateFeedbackNote(Feedback feedback)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(ConnectionString))
                {
                    string sql = "UPDATE FEEDBACK SET (Note = @Note) WHERE FeedbackID = @FeedbackID";
                    connection.Open();
                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        command.Parameters.AddWithValue("@Note", feedback.Note);
                        command.Parameters.AddWithValue("@FeedbackID", feedback.FeedbackID);
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
        public static void DeleteFeedbackNote(Feedback feedback)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(ConnectionString))
                {
                    string sql = "DELETE FROM FEEDBACK WHERE FeedbackID = @FeedbackID";
                    connection.Open();
                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        command.Parameters.AddWithValue("@Note", feedback.Note);
                        command.Parameters.AddWithValue("@FeedbackID", feedback.FeedbackID);
                        command.ExecuteNonQuery();
                    }
                }
            }
            catch (SqlException ex) { throw ex; }
        }

        public static void DeleteActivityNote(Activity activity)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(ConnectionString))
                {
                    string sql = "DELETE FROM ACTIVITY WHERE ActivityID = @ActivityID";
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
        public static void AddLearnGoalNote(LearnGoal learngoal)
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

        public static void UpdateLearnGoalNote(LearnGoal learngoal)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(ConnectionString))
                {
                    string sql = "UPDATE LEARNGOAL SET (Note = @Note) WHERE LearnGoalID = @LearnGoalID";
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
        public static void DeleteLearnGoalNote(LearnGoal learngoal)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(ConnectionString))
                {
                    string sql = "DELETE FROM LEARNGOAL WHERE ActivityID = @ActivityID";
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
