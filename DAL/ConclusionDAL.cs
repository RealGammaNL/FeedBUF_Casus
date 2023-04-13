using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;

public class FeedbackData
{
    public int LearnGoalID { get; set; }
    public string LearnGoal { get; set; }
    public string Activity { get; set; }
    public string Title { get; set; }
    public string Question { get; set; }
    public string Note { get; set; }
    public string TimeEstimate { get; set; }
    public string TimeSpent { get; set; }
}

public class ConclusieDAL
{
    // Connection string voor de database
    private static string ConnectionString = "Data Source=tcp:max.brosky.net\\GIGASOFTDB, 1433;Initial Catalog = FeedBUF_DB; Persist Security Info=True;User ID = sa; Password=Gigasoft123";

    // Methode voor het ophalen van feedbackgegevens
    public List<FeedbackData> GetFeedbackData()
    {
        List<FeedbackData> feedbackDataList = new List<FeedbackData>();

        // Query om de gewenste gegevens uit de database te halen
        string query = "SELECT ROW_NUMBER() OVER (ORDER BY lg.LearnGoalID ASC) AS LearnGoalID, " +
                       "lg.LearnGoal, " +
                       "a.Activity, " +
                       "f.Description, " +
                       "f.Question, " +
                       "f.Note, " +
                       "a.TimeEstimate, " +
                       "a.TimeSpent " +
                       "FROM LearnGoal lg " +
                       "JOIN Activity a ON a.LearnGoalID = lg.LearnGoalID " +
                       "LEFT JOIN Feedback f ON f.ActivityID = a.ActivityID " +
                       "ORDER BY LearnGoalID ASC;";

        // Open een verbinding met de database
        using (SqlConnection connection = new SqlConnection(ConnectionString))
        {
            // Maak een commando-object aan en voer de query uit
            SqlCommand command = new SqlCommand(query, connection);
            connection.Open();

            using (SqlDataReader reader = command.ExecuteReader())
            {
                // Lees de resultaten van de query en voeg deze toe aan de lijst van FeedbackData-objecten
                while (reader.Read())
                {
                    FeedbackData feedbackData = new FeedbackData();
                    feedbackData.LearnGoalID = Convert.ToInt32(reader["LearnGoalID"]);
                    feedbackData.LearnGoal = reader["LearnGoal"].ToString();
                    feedbackData.Activity = reader["Activity"].ToString();
                    feedbackData.Title = reader["Title"].ToString();
                    feedbackData.Question = reader["Question"].ToString();
                    feedbackData.Note = reader["Note"].ToString();
                    feedbackData.TimeEstimate = reader["TimeEstimate"].ToString();
                    feedbackData.TimeSpent = reader["TimeSpent"].ToString();
                    feedbackDataList.Add(feedbackData);
                }
            }// Geef de lijst van FeedbackData-objecten terug
            return feedbackDataList;
        }

    }

    public List<FeedbackData> GetFeedbackData(int selectedWeek, string selectedVak)
    {
        List<FeedbackData> feedbackDataList = new List<FeedbackData>();

        // Verbinding maken met de database
        string connectionString = "Data Source=tcp:max.brosky.net\\GIGASOFTDB, 1433;Initial Catalog = FeedBUF_DB; Persist Security Info=True;User ID = sa; Password=Gigasoft123";
        using (SqlConnection connection = new SqlConnection(connectionString))
        {
            connection.Open();

            // Query uitvoeren om de juiste gegevens te verkrijgen
            string query = @"SELECT ROW_NUMBER() OVER (ORDER BY lg.LearnGoalID ASC) AS ID, 
                                lg.LearnGoalID,
                                lg.LearnGoal, 
                                a.Activity, 
                                f.Title, 
                                f.Question, 
                                f.Note, 
                                a.TimeEstimate, 
                                a.TimeSpent 
                         FROM LearnGoal lg 
                         JOIN Activity a ON a.LearnGoalID = lg.LearnGoalID 
                         LEFT JOIN Feedback f ON f.ActivityID = a.ActivityID 
                         WHERE lg.WeekNr = @selectedWeek AND lg.SubjectName = @selectedVak 
                         ORDER BY lg.LearnGoalID ASC, ID ASC";
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@selectedWeek", selectedWeek);
                command.Parameters.AddWithValue("@selectedVak", selectedVak);
                

                using (SqlDataReader reader = command.ExecuteReader())
                {
                    // Lees de resultaten van de query en voeg deze toe aan de lijst van FeedbackData-objecten
                    while (reader.Read())
                    {
                        FeedbackData feedbackData = new FeedbackData();
                        feedbackData.LearnGoalID = Convert.ToInt32(reader["LearnGoalID"]);
                        feedbackData.LearnGoal = reader["LearnGoal"].ToString();
                        feedbackData.Activity = reader["Activity"].ToString();
                        feedbackData.Title = reader["Title"].ToString();
                        feedbackData.Question = reader["Question"].ToString();
                        feedbackData.Note = reader["Note"].ToString();
                        feedbackData.TimeEstimate = reader["TimeEstimate"].ToString();
                        feedbackData.TimeSpent = reader["TimeSpent"].ToString();
                        feedbackDataList.Add(feedbackData);
                    }
                }// Geef de lijst van FeedbackData-objecten terug
                return feedbackDataList;
            }

        }
    }
}

