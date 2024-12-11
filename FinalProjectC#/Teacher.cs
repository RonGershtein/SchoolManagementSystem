using Microsoft.Office.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProjectC_.Resources
{
    [Serializable]
    internal class Teacher : Person
    {
        public double salary { get; set; }
        public string education { get; set; }
        public int seniority { get; set; }
        public string username { get; set; }
        public string password { get; set; }
        public string salaryString { get; set; }

        public double BaseSalary = 7000;
        public string TeacherType
        {
            get { return GetTeacherType(); }
        }
        public Teacher()
        {
            salary = BaseSalary;
            education = string.Empty;
            seniority = 0;
            username = string.Empty;
            password = string.Empty;
        }

        // Get functions

        public double getSalary() { return salary; }
        public string getEducation() {  return education; }
        public int getSeniority() {  return seniority; }
        public string getUsername() { return username; }
        public string getPassword() { return password; }   
        public virtual string GetTeacherType()
        {
            return "Teacher";
        }


        // Set functions

        public virtual void setSalary()
        {
            salary = BaseSalary + (getSeniority() * 250.5);
            if (getEducation().Equals("BA"))
                salary += 500;
            else if (getEducation().Equals("Master Degree"))
                salary += 1000;

            salaryString = salary.ToString("N0");
        }

        public void setEducation(string education) { this.education = education; }
        public void setSeniority(int seniority)
        {
            this.seniority = seniority;
            setSalary(); //update the salary of the teacher.
        }

        public virtual void setusername() { this.username = name;} //default username for teachers
        public virtual void setPassword() { this.password = id; } //default password for teachers

        public virtual string WhoAmI()
        {
            return string.Format("Hello, {0}\nRole: {1}\nSalary: {2}",
                Program.myschool.Teacherlist[FormLoginScreen.instance.loginIndex].getName(),
                Program.myschool.Teacherlist[FormLoginScreen.instance.loginIndex].GetTeacherType(),
                Program.myschool.Teacherlist[FormLoginScreen.instance.loginIndex].getSalary());
        }


    }
}
