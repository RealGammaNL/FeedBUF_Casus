using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace DOMAIN
{
    public class Subject
    {
        public string Name;
        public bool Following;

        public Subject(string name, bool following) 
        {
            Name = name;
            Following = following;
        }

        public void AddSubject(Student student, Subject subject)
        {
            DAL.StudentDAL.AddSubject(student, subject);
        }

        public static List<Subject> GetSubjects(Student student)
        {
            return DAL.StudentDAL.GetSubjects(student);
        }

        public static Subject findSubjectByName(Student student, string subjectName)
        {
            foreach(Subject subject in DAL.StudentDAL.GetSubjects(student))
            {
                if (subjectName == subject.Name)
                {
                    return subject;
                }
            }
            return null;
        }
        
        public static void UpdateSubjects(Student student, Subject subject)
        {
            DAL.StudentDAL.UpdateSubjectFollowing(student, subject);
        }

        public static void UpdateSubjectName(Student student, string oldsubject, string newsubject)
        {
            DAL.StudentDAL.UpdateSubjectName(student, oldsubject, newsubject);
        }

        public static void DeleteSubject(Student student, string subjectName)
        {
            DAL.StudentDAL.DeleteSubject(student, subjectName);
        }
    }
}
