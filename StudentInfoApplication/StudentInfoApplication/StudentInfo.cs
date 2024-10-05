using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentInfoApplication
{
    public class StudentInfo
    {
        private String firstName;
        private String lastName;
        private String studentId;


        public StudentInfo()
        {

        }
        public StudentInfo(String Fname, String Lname, String SID)
        {
            firstName = Fname;
            lastName = Lname;
            studentId = SID;
        }
        public String FirstName
        {
            get { return firstName; }
            set { firstName = value; }
        }
        public String LastName
        {
            get { return lastName; }
            set { lastName = value; }
        }
        public String StudID
        {
            get { return studentId; }
            set { studentId = value; }
        }
    }
}
