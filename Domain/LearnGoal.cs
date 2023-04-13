using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DOMAIN
{
    public class LearnGoal
    {
        public int LearnGoalID;
        public int StudentID;
        public string SubjectName;
        public int WeekNr;
        public string Goal;
        public string Note;

        public LearnGoal(int learngoalid, int studentid, string subjectname, int weeknr, string goal)
        {
            LearnGoalID = learngoalid;
            StudentID = studentid;
            SubjectName = subjectname;
            WeekNr = weeknr;
            Goal = goal;
        }

        public LearnGoal(int learngoalid, int studentid, string subjectname, int weeknr, string goal, string note)
        {
            LearnGoalID = learngoalid;
            StudentID = studentid;
            SubjectName = subjectname;
            WeekNr = weeknr;
            Goal = goal;
            Note = note;
        }
        public LearnGoal(int studentid, string subjectname, int weeknr, string goal)
        {
            StudentID = studentid;
            SubjectName = subjectname;
            WeekNr = weeknr;
            Goal = goal;
        }
        public static List<LearnGoal> GetLearnGoals(Student student, int Weeknumber, string Subjectname)
        {
            return DAL.FeedupDAL.GetLearnGoals(student, Weeknumber, Subjectname);
        }
        public static string GetLearnGoalNote(int learngoalid)
        {
            return DAL.FeedforwardDAL.GetLearnGoalNote(learngoalid);
        }
        public static void UpdateLearnGoalNote(int learngoalid, string note)
        {
            DAL.FeedforwardDAL.UpdateLearnGoalNote(learngoalid, note);  
        }
        public static void DeleteLearnGoalNote(int learngoalid, string note)
        {
            DAL.FeedforwardDAL.DeleteLearnGoalNote(learngoalid, note);
        }
    }
}
