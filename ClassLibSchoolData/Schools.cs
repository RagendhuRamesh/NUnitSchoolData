using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibSchoolData
{
    public class Schools
    {
        static List<Students> students = new List<Students>()
        {
            new Students(){RollNumber=1,FirstName="Suresh",LastName="Reddy",DOB=new DateTime(day:06,month:2,year:2001)},
            new Students(){RollNumber=2,FirstName="Naresh",LastName="Kumar",DOB=new DateTime(day:1,month:8,year:1999)},
            new Students(){RollNumber=3,FirstName="Ramesh",LastName="Babu",DOB=new DateTime(day:12,month:6,year:2000)}
        };
        static List<Teachers> teachList = new List<Teachers>()
        {
            new Teachers(){Tid=1,TeacherName="Prakasham"},
            new Teachers(){Tid=2,TeacherName="Sundharacharya"},
            new Teachers(){Tid=3,TeacherName="Suchi"},
            new Teachers(){Tid=4,TeacherName="Ragendhu"}
        };
        static List<Subjects> SubList = new List<Subjects>()
        {
            new Subjects(){SubjectId=1,SubjectName="Biology"},
            new Subjects(){SubjectId=2,SubjectName="Maths"},
            new Subjects(){SubjectId=3,SubjectName="Arts"}
        };
        public static List<Students> AllStudents()
        {
            return students;
        }
        public static List<Students> EmpById(int id)
        {
            List<Students> emp = students.FindAll(e => e.RollNumber == id);
            return emp;
        }
        public static List<Teachers> allTeacher()
        {
            return teachList;
        }
        public static List<Subjects> AllSubs()
        {
            return SubList;
        }
    }
}
