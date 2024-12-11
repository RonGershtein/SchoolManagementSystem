using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalProjectC_.Resources
{
    [Serializable]
    internal class Student : Person
    {
        public double gradesAverage { get; set; }
        public string stringGradesAverage { get; set; }
        public int disturbance { get; set; } // The number of times a student interrupted the lesson
        public int absence { get; set; } // The number of times a student didn't come to class
        private int[] mathGrades = new int[10] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
        private int mathgradescounter { get; set; }
        private int[] hebrewGrades = new int[10] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
        private int hebrewgradescounter { get; set; }
        private int[] englishGrades = new int[10] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
        private int englishgradescounter { get; set; }


        public double AVGmath { get; set; }
        public double AVGeng { get; set; }
        public double AVGheb { get; set; }

        public Student()
        {
            gradesAverage = 0;
            disturbance = 0;
            absence = 0;
            mathgradescounter = 0;
            hebrewgradescounter = 0;
            englishgradescounter = 0;
            AVGeng = 0;
            AVGheb = 0;
            AVGmath = 0;
        }

        // Get functions
        public double getGradesAverage()
        {
            double sum = AVGeng + AVGheb + AVGmath;
            int counter = 0;
            if (AVGeng != 0) counter++;
            if (AVGmath != 0) counter++;
            if (AVGheb != 0) counter++;
            gradesAverage = sum / counter;
            stringGradesAverage = gradesAverage.ToString("0.00");

            return gradesAverage;
        }
        public int getDisturbance() {  return disturbance; }
        public int getAbsence() {  return absence; }
        
        // Set functions
        public void setmathgrade(int grade)
        {
            if(mathgradescounter < 10) 
            { 
            mathGrades[mathgradescounter] = grade;
            mathgradescounter++;
            double sum = 0;

            for(int i = 0;i < mathgradescounter;i++)
                sum += mathGrades[i];

                this.AVGmath = sum/mathgradescounter;
            }
            else
            {
                MessageBox.Show("All grades have already been submitted.", "", MessageBoxButtons.OK);
            }
            getGradesAverage();
        }
        public void sethebrewgrade(int grade)
        {
            if (hebrewgradescounter < 10) 
            { 
            hebrewGrades[hebrewgradescounter] = grade;
            hebrewgradescounter++;

                double sum = 0;

                for (int i = 0; i < hebrewgradescounter; i++)
                    sum += hebrewGrades[i];

                this.AVGheb = sum / hebrewgradescounter;
            }
            else
            {
                MessageBox.Show("All grades have already been submitted.", "", MessageBoxButtons.OK);
            }
            getGradesAverage();

        }
        public void setenglishgrade(int grade)
        {
            if (englishgradescounter < 10)
            {
                englishGrades[englishgradescounter] = grade;
                englishgradescounter++;

                double sum = 0;

                for (int i = 0; i < englishgradescounter; i++)
                    sum += englishGrades[i];

                this.AVGeng = sum / englishgradescounter;
            }
            else
            {
                MessageBox.Show("All grades have already been submitted.", "", MessageBoxButtons.OK);
            }
            getGradesAverage();

        }
        public void setdisturbance() { disturbance++; }
        public void setabsence() { absence++; }

    }
}
