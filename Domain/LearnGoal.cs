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
        public string SubjectCode;
        public int WeekNr;
        public string Goal;

        public LearnGoal(int learngoalid, int studentid, string subjectcode, int weeknr, string goal)
        {
            LearnGoalID = learngoalid;
            StudentID = studentid;
            SubjectCode = subjectcode;
            WeekNr = weeknr;
            Goal = goal;
        }
    }
    
}
