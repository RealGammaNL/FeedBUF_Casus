using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DOMAIN
{
    public class Feedback
    {
        //Which feedback it is.
        public int FeedbackID;

        //Who it's for and who gave it.
        public int StudentID;

        //What its for and what activities are linked to that.
        public int LearngoalID;
        public int ActivityID;

        //Type of feedback
        public string Title;
        public string Description;

        //When was it given/by who
        public string Teacher;

        //Information about feedback
        public string Question;
        public string Note;

        // Feedback on an activity paired with a learngoal.
        public Feedback(int studentid, int learngoalid, int activityid, string teacher, string title, string description)
        {
            StudentID = studentid;
            LearngoalID = learngoalid;
            ActivityID = activityid;
            Teacher = teacher;
            Title = title;
            Description = description;
        }

        public Feedback(int feedbackid, string teacher, string title, string description)
        {
            FeedbackID = feedbackid;
            Teacher = teacher;
            Title = title;
            Description = description;
        }

        public static List<Feedback> GetFeedback(Student student, int weeknumber, string subject)
        {
            return DAL.FeedbackDAL.GetFeedback(student, weeknumber, subject);
        }

        public static void AddFeedback(Feedback feedback)
        {
            DAL.FeedbackDAL.AddFeedback(feedback);
        }
        public static string GetFeedbackNote(int feedbackid)
        {
            return DAL.FeedforwardDAL.GetFeedbackNote(feedbackid);
        }
        public static void UpdateFeedbackNote(int feedbackid, string note)
        {
            DAL.FeedforwardDAL.UpdateFeedbackNote(feedbackid, note);
        }
        public static void DeleteFeedbackNote(int feedbackid, string note)
        {
            DAL.FeedforwardDAL.DeleteFeedbackNote(feedbackid, note);
        }

        public static void AddQuestion(int feedbackID, string question)
        {
            DAL.FeedbackDAL.AddQuestion(feedbackID, question);
        }

        public static Feedback GetFeedBackByID(int FeedbackID)
        {
            return DAL.FeedbackDAL.GetFeedBackByID(FeedbackID);
        }

        public static void DeleteFeedback(int FeedbackID)
        {
            DAL.FeedbackDAL.DeleteFeedback(FeedbackID);
        }

        public static void UpdateFeedback(Feedback feedback)
        {
            DAL.FeedbackDAL.UpdateFeedback(feedback);
        }

        public static string GetFeedbackQuestion(int feedbackID)
        {
            return DAL.FeedbackDAL.GetFeedbackQuestion(feedbackID);
        }
    }
}
