// Project 2 2/ 3
//Filename: Quiz
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

namespace Quiz
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonSelectQuiz_Click(object sender, EventArgs e)
        {
            string quizSelected = listBoxQuiz.SelectedItem.ToString();

            if (quizSelected == "Quiz 1")
            {
                MessageBox.Show("Quiz #1, Chapters 1 & 2");
                groupBoxQuiz1Questions1.Visible = true;
                groupBoxQuiz1Questions2.Visible = true;
            }
            else if (quizSelected == "Quiz 2")
            {
                groupBoxQuiz1Questions1.Visible = false;
                groupBoxQuiz1Questions2.Visible = false;
                MessageBox.Show("Quiz #2, Chapters 3 & 4");
                groupBoxQuiz2Questions1.Visible = true;
                groupBoxQuiz2Questions2.Visible = true;
            }
            else if( quizSelected == "Quiz 3" || quizSelected == "Quiz 4")
            {
                MessageBox.Show("Quiz not available at this time");
            } 
            
        }

        private void buttonSubmit_Click(object sender, EventArgs e)
        {
            if (listBoxQuiz.SelectedItem.ToString() == "Quiz 1")
            {
                if (radioButton1Quiz1.Checked)
                {
                    labelQuiz1Answer1.Visible = true;
                    labelQuiz1Answer1.Text = "Question 1: Correct";
                }
                else
                {
                    labelQuiz1Answer1.Visible = true;
                    labelQuiz1Answer1.Text = "Question 1: Incorrect";
                }

                if (radioButton7Quiz1.Checked)
                {
                    labelQuiz1Answer2.Visible = true;
                    labelQuiz1Answer2.Text = "Question 2: Correct";
                }
                else
                {
                    labelQuiz1Answer2.Visible = true;
                    labelQuiz1Answer2.Text = "Question 2: Incorrect";
                }
            }
            if (listBoxQuiz.SelectedItem.ToString() == "Quiz 2")
            {
                if (radioButton4Quiz2.Checked)
                {
                    labelQuiz2Answer1.Visible = true;
                    labelQuiz2Answer1.Text = "Question 1: Correct";
                }
                else
                {
                    labelQuiz2Answer1.Visible = true;
                    labelQuiz2Answer1.Text = "Question 1: Incorrect";
                }

                if (radioButton8Quiz2.Checked)
                {
                    labelQuiz2Answer2.Visible = true;
                    labelQuiz2Answer2.Text = "Question 2: Correct";
                }
                else
                {
                    labelQuiz2Answer2.Visible = true;
                    labelQuiz2Answer2.Text = "Question 2: Incorrect";
                }
            }



        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            groupBoxQuiz1Questions1.Visible = false;
            groupBoxQuiz1Questions2.Visible = false;
            groupBoxQuiz2Questions1.Visible = false;
            groupBoxQuiz2Questions2.Visible = false;

            listBoxQuiz.Focus();

        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void radioButto2Quiz1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton6_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
