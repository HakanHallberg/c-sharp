using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamLib
{
    public class Exam
    {
        private string coursename;
        //private object namn;
        private Dictionary<Student, string> StudentGradeDictionary =
            new Dictionary<Student, string>();

        public Exam(string coursename)
        {
            this.coursename = coursename;
        }

        public void Assign(Student student)
        {
            StudentGradeDictionary.Add(student, "");
        }

        public void Grade(Student student, string grade)
        {
            if (!StudentGradeDictionary.ContainsKey(student))
            throw new UnassignedStudentException();
            StudentGradeDictionary[student] = grade;
            

            
        }

        public Dictionary<string, int> GenerateStatistics()
        {
            var gradeCountDicitionary = new Dictionary<string, int>();
            gradeCountDicitionary.Add("IG", 0);
            gradeCountDicitionary.Add("G", 0);
            gradeCountDicitionary.Add("VG", 0);
            foreach (var StudentGradeEntry in StudentGradeDictionary)
            {
                gradeCountDicitionary[StudentGradeEntry.Value]++;
            }
            return gradeCountDicitionary;
        }
    }

}