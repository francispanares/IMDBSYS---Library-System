namespace Library_System_Management
{
    partial class Author
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Author));
            panel2 = new Panel();
            button5 = new Button();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            panel1 = new Panel();
            pictureBox2 = new PictureBox();
            label2 = new Label();
            button1 = new Button();
            pictureBox3 = new PictureBox();
            dataGridView1 = new DataGridView();
            txt_search = new TextBox();
            button3 = new Button();
            button6 = new Button();
            authorID = new DataGridViewTextBoxColumn();
            authorFName = new DataGridViewTextBoxColumn();
            authorLName = new DataGridViewTextBoxColumn();
            authorNationality = new DataGridViewTextBoxColumn();
            authorEmail = new DataGridViewTextBoxColumn();
            update = new DataGridViewImageColumn();
            delete = new DataGridViewImageColumn();
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
            panel2.Location = new Point(0, 42);
            panel2.Name = "panel2";
            panel2.Size = new Size(242, 484);
            panel2.TabIndex = 4;
            // 
            // button5
            // 
            button5.Image = (Image)resources.GetObject("button5.Image");
            button5.ImageAlign = ContentAlignment.MiddleLeft;
            button5.Location = new Point(12, 423);
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
            panel1.Controls.Add(pictureBox2);
            panel1.Controls.Add(label2);
            panel1.Location = new Point(0, -1);
            panel1.Name = "panel1";
            panel1.Size = new Size(1108, 43);
            panel1.TabIndex = 5;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(1064, 2);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(41, 38);
            pictureBox2.TabIndex = 0;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Roboto", 19.8F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(3, 2);
            label2.Name = "label2";
            label2.Size = new Size(330, 39);
            label2.TabIndex = 1;
            label2.Text = "Author Management:";
            // 
            // button1
            // 
            button1.BackColor = Color.Transparent;
            button1.Image = (Image)resources.GetObject("button1.Image");
            button1.Location = new Point(581, 403);
            button1.Name = "button1";
            button1.Size = new Size(217, 100);
            button1.TabIndex = 6;
            button1.Text = "Add";
            button1.TextAlign = ContentAlignment.BottomCenter;
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(248, 48);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(37, 37);
            pictureBox3.TabIndex = 11;
            pictureBox3.TabStop = false;
            pictureBox3.Click += pictureBox3_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { authorID, authorFName, authorLName, authorNationality, authorEmail, update, delete });
            dataGridView1.Location = new Point(297, 70);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(774, 263);
            dataGridView1.TabIndex = 12;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // txt_search
            // 
            txt_search.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txt_search.Location = new Point(297, 342);
            txt_search.Name = "txt_search";
            txt_search.Size = new Size(639, 34);
            txt_search.TabIndex = 13;
            txt_search.Text = "Search";
            txt_search.Click += txt_search_Click;
            txt_search.TextChanged += textBox1_TextChanged;
            // 
            // button3
            // 
            button3.BackColor = Color.Transparent;
            button3.ForeColor = Color.Transparent;
            button3.Image = (Image)resources.GetObject("button3.Image");
            button3.Location = new Point(942, 342);
            button3.Name = "button3";
            button3.Size = new Size(40, 34);
            button3.TabIndex = 14;
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click_1;
            // 
            // button6
            // 
            button6.BackColor = Color.Transparent;
            button6.Image = (Image)resources.GetObject("button6.Image");
            button6.ImageAlign = ContentAlignment.MiddleLeft;
            button6.Location = new Point(988, 344);
            button6.Name = "button6";
            button6.Size = new Size(83, 30);
            button6.TabIndex = 9;
            button6.Text = "Refresh";
            button6.TextAlign = ContentAlignment.MiddleRight;
            button6.UseVisualStyleBackColor = false;
            button6.Click += button4_Click;
            // 
            // authorID
            // 
            authorID.DataPropertyName = "authorID";
            authorID.HeaderText = "ID";
            authorID.MinimumWidth = 6;
            authorID.Name = "authorID";
            authorID.ReadOnly = true;
            authorID.Width = 53;
            // 
            // authorFName
            // 
            authorFName.DataPropertyName = "authorFName";
            authorFName.HeaderText = "First Name";
            authorFName.MinimumWidth = 6;
            authorFName.Name = "authorFName";
            authorFName.ReadOnly = true;
            authorFName.Width = 109;
            // 
            // authorLName
            // 
            authorLName.DataPropertyName = "authorLName";
            authorLName.HeaderText = "Last Name";
            authorLName.MinimumWidth = 6;
            authorLName.Name = "authorLName";
            authorLName.ReadOnly = true;
            authorLName.Width = 108;
            // 
            // authorNationality
            // 
            authorNationality.DataPropertyName = "authorNationality";
            authorNationality.HeaderText = "Nationality";
            authorNationality.MinimumWidth = 6;
            authorNationality.Name = "authorNationality";
            authorNationality.ReadOnly = true;
            authorNationality.Width = 111;
            // 
            // authorEmail
            // 
            authorEmail.DataPropertyName = "authorEmail";
            authorEmail.HeaderText = "Email";
            authorEmail.MinimumWidth = 6;
            authorEmail.Name = "authorEmail";
            authorEmail.ReadOnly = true;
            authorEmail.Width = 75;
            // 
            // update
            // 
            update.HeaderText = "";
            update.Image = (Image)resources.GetObject("update.Image");
            update.MinimumWidth = 6;
            update.Name = "update";
            update.ReadOnly = true;
            update.Width = 6;
            // 
            // delete
            // 
            delete.HeaderText = "";
            delete.Image = (Image)resources.GetObject("delete.Image");
            delete.MinimumWidth = 6;
            delete.Name = "delete";
            delete.ReadOnly = true;
            delete.Width = 6;
            // 
            // Author
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1109, 526);
            Controls.Add(button3);
            Controls.Add(txt_search);
            Controls.Add(dataGridView1);
            Controls.Add(pictureBox3);
            Controls.Add(button6);
            Controls.Add(button1);
            Controls.Add(panel1);
            Controls.Add(panel2);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Author";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Author";
            Load += Author_Load;
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
        private Button button1;
        private Label label2;
        private PictureBox pictureBox3;
        private DataGridView dataGridView1;
        private TextBox txt_search;
        private Button button3;
        private Button button6;
        private DataGridViewTextBoxColumn authorID;
        private DataGridViewTextBoxColumn authorFName;
        private DataGridViewTextBoxColumn authorLName;
        private DataGridViewTextBoxColumn authorNationality;
        private DataGridViewTextBoxColumn authorEmail;
        private DataGridViewImageColumn update;
        private DataGridViewImageColumn delete;
    }
}