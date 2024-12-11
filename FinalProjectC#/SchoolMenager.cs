using FinalProjectC_.Resources;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace FinalProjectC_
{
    [Serializable]
    internal class SchoolMenager : Teacher
    {
        public int menagerBonus = 23000;
        public SchoolMenager(string name)
        {
            setName(name);
            setusername();
            setPassword();
            setAddrass("X");
            setAge(99);
            setEducation("X");
            setGender("X");
            setId("X");
            setPhoneNumber("X");
            setSeniority(0);
            setSalary();
        }


        public override void setusername() { this.username = "manager"; }
        public override void setPassword() { this.password = "manager"; }
        public override string GetTeacherType()
        {
            return "School Manager";
        }
        public override string WhoAmI()
        {
            return string.Format("Hello, {0}\nRole: {1}\nSalary: {2}",
                Program.myschool.Teacherlist[FormLoginScreen.instance.loginIndex].getName(),
                Program.myschool.Teacherlist[FormLoginScreen.instance.loginIndex].GetTeacherType(),
                Program.myschool.Teacherlist[FormLoginScreen.instance.loginIndex].getSalary());
        }

        public override void setSalary()
        {
            salary = BaseSalary + menagerBonus;

            if (getEducation().Equals("BA"))
                salary *= 1.02;
            else if (getEducation().Equals("Master Degree"))
                salary *= 1.05;

            salaryString = salary.ToString("N0");
        }
    }

}
