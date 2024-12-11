using FinalProjectC_.Resources;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace FinalProjectC_
{
    [Serializable]
    internal class school
    {
        public BindingList<Teacher> Teacherlist { get; set; }
        public BindingList<Student> StudentList { get; set; }
        public BindingList<FaultsClass> faultsList { get; set; }
     

        public int teachercounter { get; set; }
        public int studentcounter { get; set; }
        private string schoolName { get; set; }

        public school(string name,string MengerName, string houserKeeperName) 
        {
            faultsList = new BindingList<FaultsClass>();
            Teacherlist = new BindingList<Teacher>();
            StudentList = new BindingList<Student>(); 
            schoolName = name;
            teachercounter = 1;
            studentcounter = 1;
            SchoolMenager schoolMenager = new SchoolMenager(MengerName);
            HouseKeeper houseKeeper = new HouseKeeper(houserKeeperName);
            Teacherlist.Add(schoolMenager);
            Teacherlist.Add(houseKeeper);
            
        }
        public void Addstudent(Student student)
        {
            this.StudentList.Add(student);
            studentcounter++;
        }
        public void Addteacher(Teacher teacher)
        {
            this.Teacherlist.Add(teacher);
            teachercounter++;
        }
        public void removestudent(int serialnum) //Remove studnt from the list and then update all the other student serial number.
        {
            this.StudentList.RemoveAt(serialnum);


            studentcounter--;
        }
        public void removeteacher(int serialnum) //Remove teacher from the list and then update all the other teacher serial number.
        {
            this.Teacherlist.RemoveAt(serialnum);
            teachercounter--;
        }

        public void SaveData()
        {
            SaveFileDialog saveFile = new SaveFileDialog();
            saveFile.InitialDirectory = Directory.GetCurrentDirectory();
            saveFile.Filter = "model files (*.mdl)|*.mdl|All files (*.*)|*.*";
            saveFile.FilterIndex = 1;
            saveFile.RestoreDirectory = true;

            if (saveFile.ShowDialog() == DialogResult.OK)
            {
                IFormatter formatter = new BinaryFormatter();
                using (Stream stream = new FileStream(saveFile.FileName, FileMode.Create, FileAccess.Write, FileShare.None))
                {
                    formatter.Serialize(stream, this); // Serialize the whole school instance
                }
            }
        }

        public void LoadData()
        {
            OpenFileDialog openFile = new OpenFileDialog();
            openFile.InitialDirectory = Directory.GetCurrentDirectory();
            openFile.Filter = "model files (*.mdl)|*.mdl|All files (*.*)|*.*";
            openFile.FilterIndex = 1;
            openFile.RestoreDirectory = true;

            if (openFile.ShowDialog() == DialogResult.OK)
            {
                IFormatter formatter = new BinaryFormatter();
                using (Stream stream = new FileStream(openFile.FileName, FileMode.Open, FileAccess.Read, FileShare.Read))
                {
                    school loadedSchool = (school)formatter.Deserialize(stream);

                    // Update the current instance with loaded data
                    this.StudentList = loadedSchool.StudentList;
                    this.Teacherlist = loadedSchool.Teacherlist;
                    this.faultsList = loadedSchool.faultsList;
                }
            }
        }
    }
}
