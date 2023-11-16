namespace Quiz
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
            System.Windows.Forms.RadioButton radioButton2Quiz2;
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.labelSelectaQuiz = new System.Windows.Forms.Label();
            this.listBoxQuiz = new System.Windows.Forms.ListBox();
            this.buttonSelectQuiz = new System.Windows.Forms.Button();
            this.buttonSubmit = new System.Windows.Forms.Button();
            this.buttonClear = new System.Windows.Forms.Button();
            this.buttonExit = new System.Windows.Forms.Button();
            this.groupBoxQuiz1Questions1 = new System.Windows.Forms.GroupBox();
            this.labelQuiz1Question1 = new System.Windows.Forms.Label();
            this.radioButton1Quiz1 = new System.Windows.Forms.RadioButton();
            this.radioButto2Quiz1 = new System.Windows.Forms.RadioButton();
            this.radioButton3Quiz1 = new System.Windows.Forms.RadioButton();
            this.radioButton4Quiz1 = new System.Windows.Forms.RadioButton();
            this.groupBoxQuiz1Questions2 = new System.Windows.Forms.GroupBox();
            this.radioButton8Quiz1 = new System.Windows.Forms.RadioButton();
            this.radioButton7Quiz1 = new System.Windows.Forms.RadioButton();
            this.radioButton6Quiz1 = new System.Windows.Forms.RadioButton();
            this.radioButton5Quiz1 = new System.Windows.Forms.RadioButton();
            this.labelQuiz1Question2 = new System.Windows.Forms.Label();
            this.groupBoxQuiz2Questions1 = new System.Windows.Forms.GroupBox();
            this.radioButton4Quiz2 = new System.Windows.Forms.RadioButton();
            this.radioButton3Quiz2 = new System.Windows.Forms.RadioButton();
            this.radioButton1Quiz2 = new System.Windows.Forms.RadioButton();
            this.labelQuiz2Question1 = new System.Windows.Forms.Label();
            this.groupBoxQuiz2Questions2 = new System.Windows.Forms.GroupBox();
            this.radioButton8Quiz2 = new System.Windows.Forms.RadioButton();
            this.radioButton7Quiz2 = new System.Windows.Forms.RadioButton();
            this.radioButton6Quiz2 = new System.Windows.Forms.RadioButton();
            this.radioButton5Quiz2 = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.labelQuiz1Answer1 = new System.Windows.Forms.Label();
            this.labelQuiz1Answer2 = new System.Windows.Forms.Label();
            this.labelQuiz2Answer1 = new System.Windows.Forms.Label();
            this.labelQuiz2Answer2 = new System.Windows.Forms.Label();
            radioButton2Quiz2 = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBoxQuiz1Questions1.SuspendLayout();
            this.groupBoxQuiz1Questions2.SuspendLayout();
            this.groupBoxQuiz2Questions1.SuspendLayout();
            this.groupBoxQuiz2Questions2.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(250, 227);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // labelSelectaQuiz
            // 
            this.labelSelectaQuiz.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSelectaQuiz.Location = new System.Drawing.Point(268, 21);
            this.labelSelectaQuiz.Name = "labelSelectaQuiz";
            this.labelSelectaQuiz.Size = new System.Drawing.Size(372, 48);
            this.labelSelectaQuiz.TabIndex = 4;
            this.labelSelectaQuiz.Text = "Select a Quiz";
            this.labelSelectaQuiz.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // listBoxQuiz
            // 
            this.listBoxQuiz.FormattingEnabled = true;
            this.listBoxQuiz.ItemHeight = 24;
            this.listBoxQuiz.Items.AddRange(new object[] {
            "Quiz 1",
            "Quiz 2",
            "Quiz 3",
            "Quiz 4"});
            this.listBoxQuiz.Location = new System.Drawing.Point(343, 63);
            this.listBoxQuiz.Name = "listBoxQuiz";
            this.listBoxQuiz.Size = new System.Drawing.Size(297, 172);
            this.listBoxQuiz.TabIndex = 5;
            // 
            // buttonSelectQuiz
            // 
            this.buttonSelectQuiz.Location = new System.Drawing.Point(108, 1031);
            this.buttonSelectQuiz.Name = "buttonSelectQuiz";
            this.buttonSelectQuiz.Size = new System.Drawing.Size(116, 80);
            this.buttonSelectQuiz.TabIndex = 6;
            this.buttonSelectQuiz.Text = "Select Quiz";
            this.buttonSelectQuiz.UseVisualStyleBackColor = true;
            this.buttonSelectQuiz.Click += new System.EventHandler(this.buttonSelectQuiz_Click);
            // 
            // buttonSubmit
            // 
            this.buttonSubmit.Location = new System.Drawing.Point(329, 1031);
            this.buttonSubmit.Name = "buttonSubmit";
            this.buttonSubmit.Size = new System.Drawing.Size(116, 80);
            this.buttonSubmit.TabIndex = 7;
            this.buttonSubmit.Text = "Submit";
            this.buttonSubmit.UseVisualStyleBackColor = true;
            this.buttonSubmit.Click += new System.EventHandler(this.buttonSubmit_Click);
            // 
            // buttonClear
            // 
            this.buttonClear.Location = new System.Drawing.Point(513, 1031);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(116, 80);
            this.buttonClear.TabIndex = 8;
            this.buttonClear.Text = "Clear";
            this.buttonClear.UseVisualStyleBackColor = true;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // buttonExit
            // 
            this.buttonExit.Location = new System.Drawing.Point(700, 1031);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(116, 80);
            this.buttonExit.TabIndex = 9;
            this.buttonExit.Text = "Exit";
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // groupBoxQuiz1Questions1
            // 
            this.groupBoxQuiz1Questions1.Controls.Add(this.labelQuiz1Answer1);
            this.groupBoxQuiz1Questions1.Controls.Add(this.radioButton4Quiz1);
            this.groupBoxQuiz1Questions1.Controls.Add(this.radioButton3Quiz1);
            this.groupBoxQuiz1Questions1.Controls.Add(this.radioButto2Quiz1);
            this.groupBoxQuiz1Questions1.Controls.Add(this.radioButton1Quiz1);
            this.groupBoxQuiz1Questions1.Controls.Add(this.labelQuiz1Question1);
            this.groupBoxQuiz1Questions1.Location = new System.Drawing.Point(12, 259);
            this.groupBoxQuiz1Questions1.Name = "groupBoxQuiz1Questions1";
            this.groupBoxQuiz1Questions1.Size = new System.Drawing.Size(507, 377);
            this.groupBoxQuiz1Questions1.TabIndex = 10;
            this.groupBoxQuiz1Questions1.TabStop = false;
            this.groupBoxQuiz1Questions1.Text = "Quiz 1 Questions";
            this.groupBoxQuiz1Questions1.Visible = false;
            this.groupBoxQuiz1Questions1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // labelQuiz1Question1
            // 
            this.labelQuiz1Question1.Location = new System.Drawing.Point(27, 37);
            this.labelQuiz1Question1.Name = "labelQuiz1Question1";
            this.labelQuiz1Question1.Size = new System.Drawing.Size(392, 62);
            this.labelQuiz1Question1.TabIndex = 0;
            this.labelQuiz1Question1.Text = "A piece of data that is passed into a method is known as a(n) ________.";
            this.labelQuiz1Question1.Click += new System.EventHandler(this.label1_Click);
            // 
            // radioButton1Quiz1
            // 
            this.radioButton1Quiz1.AutoSize = true;
            this.radioButton1Quiz1.Location = new System.Drawing.Point(32, 107);
            this.radioButton1Quiz1.Name = "radioButton1Quiz1";
            this.radioButton1Quiz1.Size = new System.Drawing.Size(119, 29);
            this.radioButton1Quiz1.TabIndex = 1;
            this.radioButton1Quiz1.TabStop = true;
            this.radioButton1Quiz1.Text = "argument";
            this.radioButton1Quiz1.UseVisualStyleBackColor = true;
            // 
            // radioButto2Quiz1
            // 
            this.radioButto2Quiz1.AutoSize = true;
            this.radioButto2Quiz1.Location = new System.Drawing.Point(32, 167);
            this.radioButto2Quiz1.Name = "radioButto2Quiz1";
            this.radioButto2Quiz1.Size = new System.Drawing.Size(109, 29);
            this.radioButto2Quiz1.TabIndex = 2;
            this.radioButto2Quiz1.TabStop = true;
            this.radioButto2Quiz1.Text = "delimiter";
            this.radioButto2Quiz1.UseVisualStyleBackColor = true;
            this.radioButto2Quiz1.CheckedChanged += new System.EventHandler(this.radioButto2Quiz1_CheckedChanged);
            // 
            // radioButton3Quiz1
            // 
            this.radioButton3Quiz1.AutoSize = true;
            this.radioButton3Quiz1.Location = new System.Drawing.Point(32, 228);
            this.radioButton3Quiz1.Name = "radioButton3Quiz1";
            this.radioButton3Quiz1.Size = new System.Drawing.Size(104, 29);
            this.radioButton3Quiz1.TabIndex = 3;
            this.radioButton3Quiz1.TabStop = true;
            this.radioButton3Quiz1.Text = "decimal";
            this.radioButton3Quiz1.UseVisualStyleBackColor = true;
            // 
            // radioButton4Quiz1
            // 
            this.radioButton4Quiz1.AutoSize = true;
            this.radioButton4Quiz1.Location = new System.Drawing.Point(32, 289);
            this.radioButton4Quiz1.Name = "radioButton4Quiz1";
            this.radioButton4Quiz1.Size = new System.Drawing.Size(122, 29);
            this.radioButton4Quiz1.TabIndex = 4;
            this.radioButton4Quiz1.TabStop = true;
            this.radioButton4Quiz1.Text = "descriptor";
            this.radioButton4Quiz1.UseVisualStyleBackColor = true;
            // 
            // groupBoxQuiz1Questions2
            // 
            this.groupBoxQuiz1Questions2.Controls.Add(this.labelQuiz1Answer2);
            this.groupBoxQuiz1Questions2.Controls.Add(this.radioButton8Quiz1);
            this.groupBoxQuiz1Questions2.Controls.Add(this.radioButton7Quiz1);
            this.groupBoxQuiz1Questions2.Controls.Add(this.radioButton6Quiz1);
            this.groupBoxQuiz1Questions2.Controls.Add(this.radioButton5Quiz1);
            this.groupBoxQuiz1Questions2.Controls.Add(this.labelQuiz1Question2);
            this.groupBoxQuiz1Questions2.Location = new System.Drawing.Point(12, 648);
            this.groupBoxQuiz1Questions2.Name = "groupBoxQuiz1Questions2";
            this.groupBoxQuiz1Questions2.Size = new System.Drawing.Size(513, 377);
            this.groupBoxQuiz1Questions2.TabIndex = 12;
            this.groupBoxQuiz1Questions2.TabStop = false;
            this.groupBoxQuiz1Questions2.Text = "Quiz 1 Questions";
            this.groupBoxQuiz1Questions2.Visible = false;
            // 
            // radioButton8Quiz1
            // 
            this.radioButton8Quiz1.AutoSize = true;
            this.radioButton8Quiz1.Location = new System.Drawing.Point(32, 289);
            this.radioButton8Quiz1.Name = "radioButton8Quiz1";
            this.radioButton8Quiz1.Size = new System.Drawing.Size(101, 29);
            this.radioButton8Quiz1.TabIndex = 4;
            this.radioButton8Quiz1.TabStop = true;
            this.radioButton8Quiz1.Text = "Square";
            this.radioButton8Quiz1.UseVisualStyleBackColor = true;
            // 
            // radioButton7Quiz1
            // 
            this.radioButton7Quiz1.AutoSize = true;
            this.radioButton7Quiz1.Location = new System.Drawing.Point(32, 228);
            this.radioButton7Quiz1.Name = "radioButton7Quiz1";
            this.radioButton7Quiz1.Size = new System.Drawing.Size(76, 29);
            this.radioButton7Quiz1.TabIndex = 3;
            this.radioButton7Quiz1.TabStop = true;
            this.radioButton7Quiz1.Text = "Size";
            this.radioButton7Quiz1.UseVisualStyleBackColor = true;
            this.radioButton7Quiz1.CheckedChanged += new System.EventHandler(this.radioButton6_CheckedChanged);
            // 
            // radioButton6Quiz1
            // 
            this.radioButton6Quiz1.AutoSize = true;
            this.radioButton6Quiz1.Location = new System.Drawing.Point(32, 167);
            this.radioButton6Quiz1.Name = "radioButton6Quiz1";
            this.radioButton6Quiz1.Size = new System.Drawing.Size(128, 29);
            this.radioButton6Quiz1.TabIndex = 2;
            this.radioButton6Quiz1.TabStop = true;
            this.radioButton6Quiz1.Text = "Resolution";
            this.radioButton6Quiz1.UseVisualStyleBackColor = true;
            // 
            // radioButton5Quiz1
            // 
            this.radioButton5Quiz1.AutoSize = true;
            this.radioButton5Quiz1.Location = new System.Drawing.Point(32, 107);
            this.radioButton5Quiz1.Name = "radioButton5Quiz1";
            this.radioButton5Quiz1.Size = new System.Drawing.Size(79, 29);
            this.radioButton5Quiz1.TabIndex = 1;
            this.radioButton5Quiz1.TabStop = true;
            this.radioButton5Quiz1.Text = "Area";
            this.radioButton5Quiz1.UseVisualStyleBackColor = true;
            // 
            // labelQuiz1Question2
            // 
            this.labelQuiz1Question2.Location = new System.Drawing.Point(27, 40);
            this.labelQuiz1Question2.Name = "labelQuiz1Question2";
            this.labelQuiz1Question2.Size = new System.Drawing.Size(421, 53);
            this.labelQuiz1Question2.TabIndex = 0;
            this.labelQuiz1Question2.Text = "The ________ property can be used to change the form\'s width and height in pixels" +
    ".";
            // 
            // groupBoxQuiz2Questions1
            // 
            this.groupBoxQuiz2Questions1.Controls.Add(this.labelQuiz2Answer1);
            this.groupBoxQuiz2Questions1.Controls.Add(this.radioButton4Quiz2);
            this.groupBoxQuiz2Questions1.Controls.Add(this.radioButton3Quiz2);
            this.groupBoxQuiz2Questions1.Controls.Add(radioButton2Quiz2);
            this.groupBoxQuiz2Questions1.Controls.Add(this.radioButton1Quiz2);
            this.groupBoxQuiz2Questions1.Controls.Add(this.labelQuiz2Question1);
            this.groupBoxQuiz2Questions1.Location = new System.Drawing.Point(594, 259);
            this.groupBoxQuiz2Questions1.Name = "groupBoxQuiz2Questions1";
            this.groupBoxQuiz2Questions1.Size = new System.Drawing.Size(468, 377);
            this.groupBoxQuiz2Questions1.TabIndex = 13;
            this.groupBoxQuiz2Questions1.TabStop = false;
            this.groupBoxQuiz2Questions1.Text = "Quiz 2 Questions";
            this.groupBoxQuiz2Questions1.Visible = false;
            this.groupBoxQuiz2Questions1.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // radioButton4Quiz2
            // 
            this.radioButton4Quiz2.AutoSize = true;
            this.radioButton4Quiz2.Location = new System.Drawing.Point(32, 289);
            this.radioButton4Quiz2.Name = "radioButton4Quiz2";
            this.radioButton4Quiz2.Size = new System.Drawing.Size(139, 29);
            this.radioButton4Quiz2.TabIndex = 4;
            this.radioButton4Quiz2.TabStop = true;
            this.radioButton4Quiz2.Text = "BorderStyle";
            this.radioButton4Quiz2.UseVisualStyleBackColor = true;
            // 
            // radioButton3Quiz2
            // 
            this.radioButton3Quiz2.AutoSize = true;
            this.radioButton3Quiz2.Location = new System.Drawing.Point(32, 228);
            this.radioButton3Quiz2.Name = "radioButton3Quiz2";
            this.radioButton3Quiz2.Size = new System.Drawing.Size(93, 29);
            this.radioButton3Quiz2.TabIndex = 3;
            this.radioButton3Quiz2.TabStop = true;
            this.radioButton3Quiz2.Text = "Frame";
            this.radioButton3Quiz2.UseVisualStyleBackColor = true;
            // 
            // radioButton2Quiz2
            // 
            radioButton2Quiz2.AutoSize = true;
            radioButton2Quiz2.Location = new System.Drawing.Point(32, 167);
            radioButton2Quiz2.Name = "radioButton2Quiz2";
            radioButton2Quiz2.Size = new System.Drawing.Size(137, 29);
            radioButton2Quiz2.TabIndex = 2;
            radioButton2Quiz2.TabStop = true;
            radioButton2Quiz2.Text = "FrameStyle";
            radioButton2Quiz2.UseVisualStyleBackColor = true;
            // 
            // radioButton1Quiz2
            // 
            this.radioButton1Quiz2.AutoSize = true;
            this.radioButton1Quiz2.Location = new System.Drawing.Point(32, 107);
            this.radioButton1Quiz2.Name = "radioButton1Quiz2";
            this.radioButton1Quiz2.Size = new System.Drawing.Size(95, 29);
            this.radioButton1Quiz2.TabIndex = 1;
            this.radioButton1Quiz2.TabStop = true;
            this.radioButton1Quiz2.Text = "Border";
            this.radioButton1Quiz2.UseVisualStyleBackColor = true;
            // 
            // labelQuiz2Question1
            // 
            this.labelQuiz2Question1.Location = new System.Drawing.Point(27, 28);
            this.labelQuiz2Question1.Name = "labelQuiz2Question1";
            this.labelQuiz2Question1.Size = new System.Drawing.Size(415, 76);
            this.labelQuiz2Question1.TabIndex = 0;
            this.labelQuiz2Question1.Text = "Label controls have a ________ property that allows you to display a border aroun" +
    "d the control\'s text.";
            // 
            // groupBoxQuiz2Questions2
            // 
            this.groupBoxQuiz2Questions2.Controls.Add(this.labelQuiz2Answer2);
            this.groupBoxQuiz2Questions2.Controls.Add(this.radioButton8Quiz2);
            this.groupBoxQuiz2Questions2.Controls.Add(this.radioButton7Quiz2);
            this.groupBoxQuiz2Questions2.Controls.Add(this.radioButton6Quiz2);
            this.groupBoxQuiz2Questions2.Controls.Add(this.radioButton5Quiz2);
            this.groupBoxQuiz2Questions2.Controls.Add(this.label4);
            this.groupBoxQuiz2Questions2.Location = new System.Drawing.Point(594, 663);
            this.groupBoxQuiz2Questions2.Name = "groupBoxQuiz2Questions2";
            this.groupBoxQuiz2Questions2.Size = new System.Drawing.Size(468, 362);
            this.groupBoxQuiz2Questions2.TabIndex = 14;
            this.groupBoxQuiz2Questions2.TabStop = false;
            this.groupBoxQuiz2Questions2.Text = "Quiz 2 Questions";
            this.groupBoxQuiz2Questions2.Visible = false;
            // 
            // radioButton8Quiz2
            // 
            this.radioButton8Quiz2.AutoSize = true;
            this.radioButton8Quiz2.Location = new System.Drawing.Point(32, 289);
            this.radioButton8Quiz2.Name = "radioButton8Quiz2";
            this.radioButton8Quiz2.Size = new System.Drawing.Size(84, 29);
            this.radioButton8Quiz2.TabIndex = 4;
            this.radioButton8Quiz2.TabStop = true;
            this.radioButton8Quiz2.Text = "string";
            this.radioButton8Quiz2.UseVisualStyleBackColor = true;
            // 
            // radioButton7Quiz2
            // 
            this.radioButton7Quiz2.AutoSize = true;
            this.radioButton7Quiz2.Location = new System.Drawing.Point(32, 228);
            this.radioButton7Quiz2.Name = "radioButton7Quiz2";
            this.radioButton7Quiz2.Size = new System.Drawing.Size(79, 29);
            this.radioButton7Quiz2.TabIndex = 3;
            this.radioButton7Quiz2.TabStop = true;
            this.radioButton7Quiz2.Text = "word";
            this.radioButton7Quiz2.UseVisualStyleBackColor = true;
            // 
            // radioButton6Quiz2
            // 
            this.radioButton6Quiz2.AutoSize = true;
            this.radioButton6Quiz2.Location = new System.Drawing.Point(32, 167);
            this.radioButton6Quiz2.Name = "radioButton6Quiz2";
            this.radioButton6Quiz2.Size = new System.Drawing.Size(92, 29);
            this.radioButton6Quiz2.TabIndex = 2;
            this.radioButton6Quiz2.TabStop = true;
            this.radioButton6Quiz2.Text = "thread";
            this.radioButton6Quiz2.UseVisualStyleBackColor = true;
            // 
            // radioButton5Quiz2
            // 
            this.radioButton5Quiz2.AutoSize = true;
            this.radioButton5Quiz2.Location = new System.Drawing.Point(32, 107);
            this.radioButton5Quiz2.Name = "radioButton5Quiz2";
            this.radioButton5Quiz2.Size = new System.Drawing.Size(122, 29);
            this.radioButton5Quiz2.TabIndex = 1;
            this.radioButton5Quiz2.TabStop = true;
            this.radioButton5Quiz2.Text = "statement";
            this.radioButton5Quiz2.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(27, 38);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(348, 53);
            this.label4.TabIndex = 0;
            this.label4.Text = "In programming we use the term ________ to mean string of characters.";
            // 
            // labelQuiz1Answer1
            // 
            this.labelQuiz1Answer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelQuiz1Answer1.Location = new System.Drawing.Point(32, 337);
            this.labelQuiz1Answer1.Name = "labelQuiz1Answer1";
            this.labelQuiz1Answer1.Size = new System.Drawing.Size(245, 37);
            this.labelQuiz1Answer1.TabIndex = 5;
            this.labelQuiz1Answer1.Visible = false;
            // 
            // labelQuiz1Answer2
            // 
            this.labelQuiz1Answer2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelQuiz1Answer2.Location = new System.Drawing.Point(32, 336);
            this.labelQuiz1Answer2.Name = "labelQuiz1Answer2";
            this.labelQuiz1Answer2.Size = new System.Drawing.Size(245, 38);
            this.labelQuiz1Answer2.TabIndex = 6;
            this.labelQuiz1Answer2.Visible = false;
            this.labelQuiz1Answer2.Click += new System.EventHandler(this.label2_Click);
            // 
            // labelQuiz2Answer1
            // 
            this.labelQuiz2Answer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelQuiz2Answer1.Location = new System.Drawing.Point(27, 337);
            this.labelQuiz2Answer1.Name = "labelQuiz2Answer1";
            this.labelQuiz2Answer1.Size = new System.Drawing.Size(265, 37);
            this.labelQuiz2Answer1.TabIndex = 6;
            this.labelQuiz2Answer1.Visible = false;
            // 
            // labelQuiz2Answer2
            // 
            this.labelQuiz2Answer2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelQuiz2Answer2.Location = new System.Drawing.Point(27, 321);
            this.labelQuiz2Answer2.Name = "labelQuiz2Answer2";
            this.labelQuiz2Answer2.Size = new System.Drawing.Size(265, 38);
            this.labelQuiz2Answer2.TabIndex = 6;
            this.labelQuiz2Answer2.Visible = false;
            this.labelQuiz2Answer2.Click += new System.EventHandler(this.label5_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1093, 1380);
            this.Controls.Add(this.groupBoxQuiz2Questions2);
            this.Controls.Add(this.groupBoxQuiz2Questions1);
            this.Controls.Add(this.groupBoxQuiz1Questions2);
            this.Controls.Add(this.groupBoxQuiz1Questions1);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.buttonClear);
            this.Controls.Add(this.buttonSubmit);
            this.Controls.Add(this.buttonSelectQuiz);
            this.Controls.Add(this.listBoxQuiz);
            this.Controls.Add(this.labelSelectaQuiz);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Quiz";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBoxQuiz1Questions1.ResumeLayout(false);
            this.groupBoxQuiz1Questions1.PerformLayout();
            this.groupBoxQuiz1Questions2.ResumeLayout(false);
            this.groupBoxQuiz1Questions2.PerformLayout();
            this.groupBoxQuiz2Questions1.ResumeLayout(false);
            this.groupBoxQuiz2Questions1.PerformLayout();
            this.groupBoxQuiz2Questions2.ResumeLayout(false);
            this.groupBoxQuiz2Questions2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label labelSelectaQuiz;
        private System.Windows.Forms.ListBox listBoxQuiz;
        private System.Windows.Forms.Button buttonSelectQuiz;
        private System.Windows.Forms.Button buttonSubmit;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.GroupBox groupBoxQuiz1Questions1;
        private System.Windows.Forms.RadioButton radioButton4Quiz1;
        private System.Windows.Forms.RadioButton radioButton3Quiz1;
        private System.Windows.Forms.RadioButton radioButto2Quiz1;
        private System.Windows.Forms.RadioButton radioButton1Quiz1;
        private System.Windows.Forms.Label labelQuiz1Question1;
        private System.Windows.Forms.GroupBox groupBoxQuiz1Questions2;
        private System.Windows.Forms.RadioButton radioButton8Quiz1;
        private System.Windows.Forms.RadioButton radioButton7Quiz1;
        private System.Windows.Forms.RadioButton radioButton6Quiz1;
        private System.Windows.Forms.RadioButton radioButton5Quiz1;
        private System.Windows.Forms.Label labelQuiz1Question2;
        private System.Windows.Forms.GroupBox groupBoxQuiz2Questions1;
        private System.Windows.Forms.RadioButton radioButton4Quiz2;
        private System.Windows.Forms.RadioButton radioButton3Quiz2;
        private System.Windows.Forms.RadioButton radioButton1Quiz2;
        private System.Windows.Forms.Label labelQuiz2Question1;
        private System.Windows.Forms.GroupBox groupBoxQuiz2Questions2;
        private System.Windows.Forms.RadioButton radioButton8Quiz2;
        private System.Windows.Forms.RadioButton radioButton7Quiz2;
        private System.Windows.Forms.RadioButton radioButton6Quiz2;
        private System.Windows.Forms.RadioButton radioButton5Quiz2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label labelQuiz1Answer1;
        private System.Windows.Forms.Label labelQuiz1Answer2;
        private System.Windows.Forms.Label labelQuiz2Answer1;
        private System.Windows.Forms.Label labelQuiz2Answer2;
    }
}

