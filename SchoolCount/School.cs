using System.Collections.Generic;
using System.Linq;

namespace SchoolCount
{
    public class School
    {
     
        private string nameOfSchool;



        public School(string nameOfSchool)
        {
            this.nameOfSchool = nameOfSchool;
        }

        public List<Class> Classes { get; internal set; }
             = new List<Class>();


        public int NumberOfStudents
            {
             get
            {
                return this.Classes.Sum(Class=>Class.students);
            }
            }
    }
}