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
        public int TeacherID;

        //What its for and what activities are linked to that.
        public int LearngoalID;
        public int ActivityID;

        //Type of feedback
        public string Title;
        public string Description;

        //When was it given/by who
        public int Weeknr;
        public string Teacher;

        //Information about feedback
        public string Question;
        public string Note;


        public Feedback()
        {

        }

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

        // Feedback on an learngoal, without a paired activity
        public Feedback(int studentid, int learngoalid, string teacher, string title, string description)
        {
            StudentID = studentid;
            LearngoalID = learngoalid;
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

        public Feedback(int feedbackid, string teacher, string title, string description, string question)
        {
            FeedbackID = feedbackid;
            Teacher = teacher;
            Title = title;
            Description = description;
            Question = question;
        }

        public Feedback(int feedbackid, string teacher, string title, string description, string question, string note)
        {
            FeedbackID = feedbackid;
            Teacher = teacher;
            Title = title;
            Description = description;
            Question = question;
            Note = note;
        }

        public static List<Feedback> GetFeedback()
        {
            return DAL.FeedbackDAL.GetFeedback();
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
    }
}
