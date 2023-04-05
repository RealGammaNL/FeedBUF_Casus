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
        public string Auteur;

        //Information about feedback
        public string Question;
        public string Note;


        public Feedback()
        {

        }

        public Feedback(int feedbackid, string auteur, string title, string description) 
        {
            FeedbackID = feedbackid;
            Auteur = auteur;
            Title = title;
            Description= description;
        }

        public Feedback(int feedbackid, string auteur, string title, string description, string question)
        {
            FeedbackID = feedbackid;
            Auteur = auteur;
            Title = title;
            Description = description;
            Question = question;
        }

        public Feedback(int feedbackid, string auteur, string title, string description, string question, string note)
        {
            FeedbackID = feedbackid;
            Auteur = auteur;
            Title = title;
            Description = description;
            Question = question;
            Note = note;
        }

        public static List<Feedback> GetFeedback()
        {
            return DAL.FeedbackDAL.GetFeedback();
        }
    }
}
