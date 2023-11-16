// Project 2 3/ 3
//Filename: Grades
//Name: Tiffany Ledbetter
//Date: 10/23/2023

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Grade
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            if (double.TryParse(labTextBox.Text, out double labAvg) &&
            double.TryParse(projectTextBox.Text, out double projectAvg) &&
            double.TryParse(testTextBox.Text, out double testAvg) &&
            double.TryParse(finalExamTextBox.Text, out double finalExamGrade))
            {
                double weightedAverage = (labAvg * 0.30) + (projectAvg * 0.30) + (testAvg * 0.30) + (finalExamGrade * 0.10);


                labelCourseGrade.Text = weightedAverage.ToString();
                courseLabel.Visible = true;
                labelCourseLetter.Visible = true;
                courseLetterLabel.Visible = true;
                labelCourseGrade.Visible = true;

                string letterGrade;
                if (weightedAverage >= 90)
                    letterGrade = "A";
                else if (weightedAverage >= 80)
                    letterGrade = "B";
                else if (weightedAverage >= 70)
                    letterGrade = "C";
                else if (weightedAverage >= 60)
                    letterGrade = "D";
                else
                    letterGrade = "Failing";

                labelCourseLetter.Text = letterGrade.ToString();

            }
        }
        private void clearButton_Click(object sender, EventArgs e)
        {
            labTextBox.Clear();
            projectTextBox.Clear();
            testTextBox.Clear();
            finalExamTextBox.Clear();
            labelCourseGrade.Text="";
            labelCourseLetter.Text ="";

            labTextBox.Focus();
        }

        private void exitButton_Click(object sender, EventArgs e)
        { 
            this.Close();
        }
    }
}
