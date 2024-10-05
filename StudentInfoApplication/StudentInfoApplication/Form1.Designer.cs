namespace StudentInfoApplication
{
    partial class frmStudentInfo
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            StudentIDList = new ListBox();
            FirstnameList = new ListBox();
            LastnameList = new ListBox();
            button1 = new Button();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Times New Roman", 12.75F);
            textBox1.Location = new Point(12, 32);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(236, 32);
            textBox1.TabIndex = 0;
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Times New Roman", 12.75F);
            textBox2.Location = new Point(282, 32);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(237, 32);
            textBox2.TabIndex = 1;
            // 
            // textBox3
            // 
            textBox3.Font = new Font("Times New Roman", 12.75F);
            textBox3.Location = new Point(553, 32);
            textBox3.Multiline = true;
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(235, 32);
            textBox3.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 14.25F);
            label1.Location = new Point(11, 8);
            label1.Name = "label1";
            label1.Size = new Size(100, 21);
            label1.TabIndex = 3;
            label1.Text = "Student ID*";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 14.25F);
            label2.Location = new Point(282, 8);
            label2.Name = "label2";
            label2.Size = new Size(95, 21);
            label2.TabIndex = 4;
            label2.Text = "Last name*";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 14.25F);
            label3.Location = new Point(553, 8);
            label3.Name = "label3";
            label3.Size = new Size(97, 21);
            label3.TabIndex = 5;
            label3.Text = "First name*";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Times New Roman", 14.25F);
            label4.Location = new Point(11, 151);
            label4.Name = "label4";
            label4.Size = new Size(124, 21);
            label4.TabIndex = 6;
            label4.Text = "Student ID List";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Times New Roman", 14.25F);
            label5.Location = new Point(282, 151);
            label5.Name = "label5";
            label5.Size = new Size(121, 21);
            label5.TabIndex = 7;
            label5.Text = "First name List";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Times New Roman", 14.25F);
            label6.Location = new Point(551, 151);
            label6.Name = "label6";
            label6.Size = new Size(119, 21);
            label6.TabIndex = 8;
            label6.Text = "Last name List";
            // 
            // StudentIDList
            // 
            StudentIDList.Font = new Font("Times New Roman", 12.75F);
            StudentIDList.FormattingEnabled = true;
            StudentIDList.ItemHeight = 19;
            StudentIDList.Location = new Point(11, 171);
            StudentIDList.Name = "StudentIDList";
            StudentIDList.Size = new Size(237, 213);
            StudentIDList.TabIndex = 9;
            StudentIDList.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // FirstnameList
            // 
            FirstnameList.Font = new Font("Times New Roman", 12.75F);
            FirstnameList.FormattingEnabled = true;
            FirstnameList.ItemHeight = 19;
            FirstnameList.Location = new Point(282, 171);
            FirstnameList.Name = "FirstnameList";
            FirstnameList.Size = new Size(237, 213);
            FirstnameList.TabIndex = 10;
            FirstnameList.SelectedIndexChanged += listBox2_SelectedIndexChanged;
            // 
            // LastnameList
            // 
            LastnameList.Font = new Font("Times New Roman", 12.75F);
            LastnameList.FormattingEnabled = true;
            LastnameList.ItemHeight = 19;
            LastnameList.Location = new Point(551, 171);
            LastnameList.Name = "LastnameList";
            LastnameList.Size = new Size(237, 213);
            LastnameList.TabIndex = 11;
            LastnameList.SelectedIndexChanged += listBox3_SelectedIndexChanged;
            // 
            // button1
            // 
            button1.Location = new Point(697, 82);
            button1.Name = "button1";
            button1.Size = new Size(91, 41);
            button1.TabIndex = 12;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // frmStudentInfo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(800, 436);
            Controls.Add(button1);
            Controls.Add(LastnameList);
            Controls.Add(FirstnameList);
            Controls.Add(StudentIDList);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Name = "frmStudentInfo";
            Text = "frmStudentinfo";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private ListBox StudentIDList;
        private ListBox FirstnameList;
        private ListBox LastnameList;
        private Button button1;
    }
}
