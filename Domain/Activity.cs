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
        public string TimeEstimate;
        public string TimeSpent;

        public Activity(int learngoalid, string activitytext, string timeEstimate)
        {
            LearnGoalID = learngoalid;
            ActivityText = activitytext;
            TimeEstimate = timeEstimate;
        }

        public Activity(int activityid, int learngoalid, string activitytext, string timeEstimate, string note) 
        { 
            ActivityID = activityid;
            LearnGoalID = learngoalid;  
            ActivityText = activitytext;
            TimeEstimate = timeEstimate;
            Note = note;
        }
        public Activity(int activityid, int learngoalid, string activitytext, string timeEstimate, string timeSpent, string note)
        {
            ActivityID = activityid;
            LearnGoalID = learngoalid;
            ActivityText = activitytext;
            TimeEstimate = timeEstimate;
            TimeSpent = timeSpent;
            Note = note;
        }
        public static List<Activity> GetActivity(int learngoal)
        {
            return DAL.FeedupDAL.GetActivity(learngoal);
        }

        public static void InsertTimeSpent(int activityid, string TimeSpent)
        {
            DAL.FeedupDAL.TimeSpent(activityid, TimeSpent);
        }

        public static void AddActivity(Activity activity)
        {
            DAL.FeedupDAL.AddActivity(activity);
        }

        //public static Activity GetActivityByName(LearnGoal learngoal)
        //{
        //    return DAL.FeedupDAL.GetActivity(learngoal)
        //}

        public static Activity GetActivityByID(int activityID)
        {
            return DAL.FeedbackDAL.GetActivityByID(activityID);
        }
    }
}
