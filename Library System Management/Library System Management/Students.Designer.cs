namespace Library_System_Management
{
    partial class Students
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Students));
            panel2 = new Panel();
            button5 = new Button();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            panel1 = new Panel();
            label2 = new Label();
            pictureBox2 = new PictureBox();
            button1 = new Button();
            button2 = new Button();
            button6 = new Button();
            pictureBox3 = new PictureBox();
            dataGridView1 = new DataGridView();
            studentID = new DataGridViewTextBoxColumn();
            studentFName = new DataGridViewTextBoxColumn();
            studentLName = new DataGridViewTextBoxColumn();
            studentAddress = new DataGridViewTextBoxColumn();
            studentCourse = new DataGridViewTextBoxColumn();
            studentYear = new DataGridViewTextBoxColumn();
            studentEmail = new DataGridViewTextBoxColumn();
            textBox1 = new TextBox();
            button4 = new Button();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.BackColor = Color.AntiqueWhite;
            panel2.Controls.Add(button5);
            panel2.Controls.Add(pictureBox1);
            panel2.Controls.Add(label1);
            panel2.Location = new Point(-1, 40);
            panel2.Name = "panel2";
            panel2.Size = new Size(242, 412);
            panel2.TabIndex = 5;
            // 
            // button5
            // 
            button5.Image = (Image)resources.GetObject("button5.Image");
            button5.ImageAlign = ContentAlignment.MiddleLeft;
            button5.Location = new Point(12, 350);
            button5.Name = "button5";
            button5.Size = new Size(217, 48);
            button5.TabIndex = 3;
            button5.Text = "Sign-out";
            button5.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(89, 48);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(66, 71);
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(103, 122);
            label1.Name = "label1";
            label1.Size = new Size(38, 20);
            label1.TabIndex = 2;
            label1.Text = "User";
            // 
            // panel1
            // 
            panel1.BackColor = Color.DarkOliveGreen;
            panel1.Controls.Add(label2);
            panel1.Controls.Add(pictureBox2);
            panel1.Location = new Point(-1, -1);
            panel1.Name = "panel1";
            panel1.Size = new Size(803, 43);
            panel1.TabIndex = 6;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Roboto", 19.8F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(3, 2);
            label2.Name = "label2";
            label2.Size = new Size(158, 39);
            label2.TabIndex = 7;
            label2.Text = "Students:";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(756, 0);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(41, 38);
            pictureBox2.TabIndex = 0;
            pictureBox2.TabStop = false;
            // 
            // button1
            // 
            button1.Image = (Image)resources.GetObject("button1.Image");
            button1.Location = new Point(297, 294);
            button1.Name = "button1";
            button1.Size = new Size(125, 125);
            button1.TabIndex = 7;
            button1.Text = "Add Student";
            button1.TextAlign = ContentAlignment.BottomCenter;
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Image = (Image)resources.GetObject("button2.Image");
            button2.Location = new Point(461, 294);
            button2.Name = "button2";
            button2.Size = new Size(125, 125);
            button2.TabIndex = 8;
            button2.Text = "Update Student";
            button2.TextAlign = ContentAlignment.BottomCenter;
            button2.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            button6.Image = (Image)resources.GetObject("button6.Image");
            button6.Location = new Point(623, 294);
            button6.Name = "button6";
            button6.Size = new Size(125, 125);
            button6.TabIndex = 11;
            button6.Text = "Delete Student";
            button6.TextAlign = ContentAlignment.BottomCenter;
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(247, 48);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(37, 40);
            pictureBox3.TabIndex = 12;
            pictureBox3.TabStop = false;
            pictureBox3.Click += pictureBox3_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { studentID, studentFName, studentLName, studentAddress, studentCourse, studentYear, studentEmail });
            dataGridView1.Location = new Point(297, 57);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(451, 160);
            dataGridView1.TabIndex = 13;
            // 
            // studentID
            // 
            studentID.HeaderText = "ID";
            studentID.MinimumWidth = 6;
            studentID.Name = "studentID";
            studentID.Width = 125;
            // 
            // studentFName
            // 
            studentFName.HeaderText = "First Name";
            studentFName.MinimumWidth = 6;
            studentFName.Name = "studentFName";
            studentFName.Width = 125;
            // 
            // studentLName
            // 
            studentLName.HeaderText = "Last Name";
            studentLName.MinimumWidth = 6;
            studentLName.Name = "studentLName";
            studentLName.Width = 125;
            // 
            // studentAddress
            // 
            studentAddress.HeaderText = "Address";
            studentAddress.MinimumWidth = 6;
            studentAddress.Name = "studentAddress";
            studentAddress.Width = 125;
            // 
            // studentCourse
            // 
            studentCourse.HeaderText = "Course";
            studentCourse.MinimumWidth = 6;
            studentCourse.Name = "studentCourse";
            studentCourse.Width = 125;
            // 
            // studentYear
            // 
            studentYear.HeaderText = "Year";
            studentYear.MinimumWidth = 6;
            studentYear.Name = "studentYear";
            studentYear.Width = 125;
            // 
            // studentEmail
            // 
            studentEmail.HeaderText = "Email";
            studentEmail.MinimumWidth = 6;
            studentEmail.Name = "studentEmail";
            studentEmail.Width = 125;
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBox1.Location = new Point(299, 227);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(414, 34);
            textBox1.TabIndex = 14;
            textBox1.Text = "Search";
            // 
            // button4
            // 
            button4.Image = (Image)resources.GetObject("button4.Image");
            button4.Location = new Point(713, 227);
            button4.Name = "button4";
            button4.Size = new Size(35, 34);
            button4.TabIndex = 16;
            button4.UseVisualStyleBackColor = true;
            // 
            // Students
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button4);
            Controls.Add(textBox1);
            Controls.Add(dataGridView1);
            Controls.Add(pictureBox3);
            Controls.Add(button6);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(panel1);
            Controls.Add(panel2);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Students";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Students";
            Load += Students_Load;
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel2;
        private Button button5;
        private PictureBox pictureBox1;
        private Label label1;
        private Panel panel1;
        private PictureBox pictureBox2;
        private Label label2;
        private Button button1;
        private Button button2;
        private Button button6;
        private PictureBox pictureBox3;
        private DataGridView dataGridView1;
        private TextBox textBox1;
        private Button button4;
        private DataGridViewTextBoxColumn studentID;
        private DataGridViewTextBoxColumn studentFName;
        private DataGridViewTextBoxColumn studentLName;
        private DataGridViewTextBoxColumn studentAddress;
        private DataGridViewTextBoxColumn studentCourse;
        private DataGridViewTextBoxColumn studentYear;
        private DataGridViewTextBoxColumn studentEmail;
    }
}