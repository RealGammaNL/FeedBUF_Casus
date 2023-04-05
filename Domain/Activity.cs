using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DOMAIN
{
    public class Activity
    {
        public int ActivityID;
        public int LearnGoalID;
        public string ActivityText;
        public string Note;

        public Activity(int activityid, int learngoalid, string activitytext)
        {
            ActivityID = activityid;
            LearnGoalID = learngoalid;
            ActivityText = activitytext;
        }

        public Activity(int activityid, int learngoalid, string activitytext, string note) 
        { 
            ActivityID = activityid;
            LearnGoalID = learngoalid;  
            ActivityText = activitytext;
            Note = note;
        }
    }
}
