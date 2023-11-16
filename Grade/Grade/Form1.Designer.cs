namespace Grade
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.exitButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.calculateButton = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.courseLetterLabel = new System.Windows.Forms.Label();
            this.courseLabel = new System.Windows.Forms.Label();
            this.finalExamLabel = new System.Windows.Forms.Label();
            this.testLabel = new System.Windows.Forms.Label();
            this.projectLabel = new System.Windows.Forms.Label();
            this.labLabel = new System.Windows.Forms.Label();
            this.projectTextBox = new System.Windows.Forms.TextBox();
            this.testTextBox = new System.Windows.Forms.TextBox();
            this.finalExamTextBox = new System.Windows.Forms.TextBox();
            this.labTextBox = new System.Windows.Forms.TextBox();
            this.labelCourseGrade = new System.Windows.Forms.Label();
            this.labelCourseLetter = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(679, 739);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(123, 109);
            this.exitButton.TabIndex = 7;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(361, 739);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(123, 109);
            this.clearButton.TabIndex = 6;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // calculateButton
            // 
            this.calculateButton.Location = new System.Drawing.Point(100, 739);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(123, 109);
            this.calculateButton.TabIndex = 5;
            this.calculateButton.Text = "Calculate";
            this.calculateButton.UseVisualStyleBackColor = true;
            this.calculateButton.Click += new System.EventHandler(this.calculateButton_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 22);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(273, 330);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // courseLetterLabel
            // 
            this.courseLetterLabel.AutoSize = true;
            this.courseLetterLabel.Location = new System.Drawing.Point(354, 484);
            this.courseLetterLabel.Name = "courseLetterLabel";
            this.courseLetterLabel.Size = new System.Drawing.Size(189, 25);
            this.courseLetterLabel.TabIndex = 16;
            this.courseLetterLabel.Text = "Course Letter Grade";
            this.courseLetterLabel.Visible = false;
            // 
            // courseLabel
            // 
            this.courseLabel.AutoSize = true;
            this.courseLabel.Location = new System.Drawing.Point(354, 413);
            this.courseLabel.Name = "courseLabel";
            this.courseLabel.Size = new System.Drawing.Size(135, 25);
            this.courseLabel.TabIndex = 15;
            this.courseLabel.Text = "Course Grade";
            this.courseLabel.Visible = false;
            // 
            // finalExamLabel
            // 
            this.finalExamLabel.AutoSize = true;
            this.finalExamLabel.Location = new System.Drawing.Point(354, 339);
            this.finalExamLabel.Name = "finalExamLabel";
            this.finalExamLabel.Size = new System.Drawing.Size(168, 25);
            this.finalExamLabel.TabIndex = 14;
            this.finalExamLabel.Text = "Final Exam Grade";
            // 
            // testLabel
            // 
            this.testLabel.AutoSize = true;
            this.testLabel.Location = new System.Drawing.Point(354, 249);
            this.testLabel.Name = "testLabel";
            this.testLabel.Size = new System.Drawing.Size(130, 25);
            this.testLabel.TabIndex = 13;
            this.testLabel.Text = "Test Average";
            // 
            // projectLabel
            // 
            this.projectLabel.AutoSize = true;
            this.projectLabel.Location = new System.Drawing.Point(358, 170);
            this.projectLabel.Name = "projectLabel";
            this.projectLabel.Size = new System.Drawing.Size(151, 25);
            this.projectLabel.TabIndex = 12;
            this.projectLabel.Text = "Project Average";
            // 
            // labLabel
            // 
            this.labLabel.AutoSize = true;
            this.labLabel.Location = new System.Drawing.Point(360, 91);
            this.labLabel.Name = "labLabel";
            this.labLabel.Size = new System.Drawing.Size(124, 25);
            this.labLabel.TabIndex = 11;
            this.labLabel.Text = "Lab Average";
            // 
            // projectTextBox
            // 
            this.projectTextBox.Location = new System.Drawing.Point(562, 166);
            this.projectTextBox.Name = "projectTextBox";
            this.projectTextBox.Size = new System.Drawing.Size(327, 29);
            this.projectTextBox.TabIndex = 20;
            // 
            // testTextBox
            // 
            this.testTextBox.Location = new System.Drawing.Point(562, 245);
            this.testTextBox.Name = "testTextBox";
            this.testTextBox.Size = new System.Drawing.Size(327, 29);
            this.testTextBox.TabIndex = 19;
            // 
            // finalExamTextBox
            // 
            this.finalExamTextBox.Location = new System.Drawing.Point(562, 339);
            this.finalExamTextBox.Name = "finalExamTextBox";
            this.finalExamTextBox.Size = new System.Drawing.Size(327, 29);
            this.finalExamTextBox.TabIndex = 18;
            // 
            // labTextBox
            // 
            this.labTextBox.Location = new System.Drawing.Point(562, 87);
            this.labTextBox.Name = "labTextBox";
            this.labTextBox.Size = new System.Drawing.Size(327, 29);
            this.labTextBox.TabIndex = 17;
            // 
            // labelCourseGrade
            // 
            this.labelCourseGrade.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelCourseGrade.Location = new System.Drawing.Point(562, 413);
            this.labelCourseGrade.Name = "labelCourseGrade";
            this.labelCourseGrade.Size = new System.Drawing.Size(100, 23);
            this.labelCourseGrade.TabIndex = 21;
            this.labelCourseGrade.Visible = false;
            // 
            // labelCourseLetter
            // 
            this.labelCourseLetter.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelCourseLetter.Location = new System.Drawing.Point(567, 484);
            this.labelCourseLetter.Name = "labelCourseLetter";
            this.labelCourseLetter.Size = new System.Drawing.Size(100, 23);
            this.labelCourseLetter.TabIndex = 22;
            this.labelCourseLetter.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(925, 876);
            this.Controls.Add(this.labelCourseLetter);
            this.Controls.Add(this.labelCourseGrade);
            this.Controls.Add(this.projectTextBox);
            this.Controls.Add(this.testTextBox);
            this.Controls.Add(this.finalExamTextBox);
            this.Controls.Add(this.labTextBox);
            this.Controls.Add(this.courseLetterLabel);
            this.Controls.Add(this.courseLabel);
            this.Controls.Add(this.finalExamLabel);
            this.Controls.Add(this.testLabel);
            this.Controls.Add(this.projectLabel);
            this.Controls.Add(this.labLabel);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.calculateButton);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Button calculateButton;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label courseLetterLabel;
        private System.Windows.Forms.Label courseLabel;
        private System.Windows.Forms.Label finalExamLabel;
        private System.Windows.Forms.Label testLabel;
        private System.Windows.Forms.Label projectLabel;
        private System.Windows.Forms.Label labLabel;
        private System.Windows.Forms.TextBox projectTextBox;
        private System.Windows.Forms.TextBox testTextBox;
        private System.Windows.Forms.TextBox finalExamTextBox;
        private System.Windows.Forms.TextBox labTextBox;
        private System.Windows.Forms.Label labelCourseGrade;
        private System.Windows.Forms.Label labelCourseLetter;
    }
}

