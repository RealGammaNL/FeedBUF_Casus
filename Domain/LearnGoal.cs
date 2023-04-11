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
        public static List<LearnGoal> GetLearnGoals(Student student, int weeknumber, string Subjectname)
        {
            return DAL.FeedupDAL.GetLearnGoals(student, weeknumber, Subjectname);
        }

        //public static LearnGoal GetLearnGoalByName(Student student, int weeknumber, string Subjectname, string learngoaltext)
        //{
        //    return DAL.FeedupDAL.GetLearnGoalByName(student, weeknumber, Subjectname, learngoaltext);
        //}

        public static LearnGoal GetLearnGoalByName(Student student, int weeknumber, string subject, string learngoaltext)
        {
            foreach (LearnGoal learngoal in DAL.FeedupDAL.GetLearnGoals(student, weeknumber, subject))
            {
                if (learngoaltext == learngoal.Goal)
                {
                    return learngoal;
                }
            }
            return null;
        }

    }
}
