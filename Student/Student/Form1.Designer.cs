namespace Student
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButtonFinancialAid = new System.Windows.Forms.RadioButton();
            this.radioButtonCredit = new System.Windows.Forms.RadioButton();
            this.radioButtonCheck = new System.Windows.Forms.RadioButton();
            this.radioButtonCash = new System.Windows.Forms.RadioButton();
            this.labelAmountOwed = new System.Windows.Forms.Label();
            this.textBoxCreditHours = new System.Windows.Forms.TextBox();
            this.exitButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.addButton = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.textBoxCreditCardNumber = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBoxCreditCardNumber);
            this.groupBox1.Controls.Add(this.radioButtonFinancialAid);
            this.groupBox1.Controls.Add(this.radioButtonCredit);
            this.groupBox1.Controls.Add(this.radioButtonCheck);
            this.groupBox1.Controls.Add(this.radioButtonCash);
            this.groupBox1.Location = new System.Drawing.Point(286, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(507, 321);
            this.groupBox1.TabIndex = 24;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Payment Options";
            // 
            // radioButtonFinancialAid
            // 
            this.radioButtonFinancialAid.AutoSize = true;
            this.radioButtonFinancialAid.Location = new System.Drawing.Point(30, 218);
            this.radioButtonFinancialAid.Name = "radioButtonFinancialAid";
            this.radioButtonFinancialAid.Size = new System.Drawing.Size(146, 29);
            this.radioButtonFinancialAid.TabIndex = 3;
            this.radioButtonFinancialAid.TabStop = true;
            this.radioButtonFinancialAid.Text = "Financial aid";
            this.radioButtonFinancialAid.UseVisualStyleBackColor = true;
            // 
            // radioButtonCredit
            // 
            this.radioButtonCredit.AutoSize = true;
            this.radioButtonCredit.Location = new System.Drawing.Point(30, 167);
            this.radioButtonCredit.Name = "radioButtonCredit";
            this.radioButtonCredit.Size = new System.Drawing.Size(89, 29);
            this.radioButtonCredit.TabIndex = 2;
            this.radioButtonCredit.TabStop = true;
            this.radioButtonCredit.Text = "Credit";
            this.radioButtonCredit.UseVisualStyleBackColor = true;
            // 
            // radioButtonCheck
            // 
            this.radioButtonCheck.AutoSize = true;
            this.radioButtonCheck.Location = new System.Drawing.Point(30, 115);
            this.radioButtonCheck.Name = "radioButtonCheck";
            this.radioButtonCheck.Size = new System.Drawing.Size(94, 29);
            this.radioButtonCheck.TabIndex = 1;
            this.radioButtonCheck.TabStop = true;
            this.radioButtonCheck.Text = "Check";
            this.radioButtonCheck.UseVisualStyleBackColor = true;
            // 
            // radioButtonCash
            // 
            this.radioButtonCash.AutoSize = true;
            this.radioButtonCash.Location = new System.Drawing.Point(30, 57);
            this.radioButtonCash.Name = "radioButtonCash";
            this.radioButtonCash.Size = new System.Drawing.Size(84, 29);
            this.radioButtonCash.TabIndex = 0;
            this.radioButtonCash.TabStop = true;
            this.radioButtonCash.Text = "Cash";
            this.radioButtonCash.UseVisualStyleBackColor = true;
            // 
            // labelAmountOwed
            // 
            this.labelAmountOwed.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelAmountOwed.Location = new System.Drawing.Point(325, 420);
            this.labelAmountOwed.Name = "labelAmountOwed";
            this.labelAmountOwed.Size = new System.Drawing.Size(264, 97);
            this.labelAmountOwed.TabIndex = 23;
            this.labelAmountOwed.Click += new System.EventHandler(this.labelAmountOwed_Click);
            // 
            // textBoxCreditHours
            // 
            this.textBoxCreditHours.Location = new System.Drawing.Point(39, 476);
            this.textBoxCreditHours.Name = "textBoxCreditHours";
            this.textBoxCreditHours.Size = new System.Drawing.Size(216, 29);
            this.textBoxCreditHours.TabIndex = 22;
            this.textBoxCreditHours.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(574, 586);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(138, 87);
            this.exitButton.TabIndex = 21;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(343, 586);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(138, 87);
            this.clearButton.TabIndex = 20;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(147, 586);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(138, 87);
            this.addButton.TabIndex = 19;
            this.addButton.Text = "Add";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(243, 235);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 18;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // textBoxCreditCardNumber
            // 
            this.textBoxCreditCardNumber.Location = new System.Drawing.Point(145, 167);
            this.textBoxCreditCardNumber.Name = "textBoxCreditCardNumber";
            this.textBoxCreditCardNumber.Size = new System.Drawing.Size(356, 29);
            this.textBoxCreditCardNumber.TabIndex = 25;
            this.textBoxCreditCardNumber.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 421);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(262, 25);
            this.label1.TabIndex = 25;
            this.label1.Text = "Enter number of credit hours:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(825, 702);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.labelAmountOwed);
            this.Controls.Add(this.textBoxCreditHours);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Student";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioButtonFinancialAid;
        private System.Windows.Forms.RadioButton radioButtonCredit;
        private System.Windows.Forms.RadioButton radioButtonCheck;
        private System.Windows.Forms.RadioButton radioButtonCash;
        private System.Windows.Forms.Label labelAmountOwed;
        private System.Windows.Forms.TextBox textBoxCreditHours;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox textBoxCreditCardNumber;
        private System.Windows.Forms.Label label1;
    }
}

