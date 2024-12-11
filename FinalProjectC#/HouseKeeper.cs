using FinalProjectC_.Resources;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalProjectC_
{
    [Serializable]
    internal class HouseKeeper : Teacher
    {


        public HouseKeeper(string name)
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


        public override void setusername() { this.username = "housekeeper"; }
        public override void setPassword() { this.password = "housekeeper"; }
        public override string GetTeacherType()
        {
            return "House Keeper";
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
            if (this.seniority == 0)
                salary = BaseSalary;
            else 
                salary = BaseSalary * (Math.Pow(this.seniority,0.25));

            salaryString = salary.ToString("N2");
        }
    }
}
