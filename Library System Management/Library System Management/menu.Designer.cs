namespace Library_System_Management
{
    partial class menu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(menu));
            panel1 = new Panel();
            label2 = new Label();
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            panel2 = new Panel();
            button5 = new Button();
            button_author = new Button();
            button_books = new Button();
            button_students = new Button();
            button_borrowBooks = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.DarkOliveGreen;
            panel1.Controls.Add(label2);
            panel1.Controls.Add(pictureBox2);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1109, 41);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Roboto", 19.8F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(0, 2);
            label2.Name = "label2";
            label2.Size = new Size(109, 39);
            label2.TabIndex = 8;
            label2.Text = "Menu:";
            label2.Click += label2_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(1068, 2);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(41, 38);
            pictureBox2.TabIndex = 0;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
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
            label1.Click += label1_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.AntiqueWhite;
            panel2.Controls.Add(button5);
            panel2.Controls.Add(pictureBox1);
            panel2.Controls.Add(label1);
            panel2.Location = new Point(0, 40);
            panel2.Name = "panel2";
            panel2.Size = new Size(242, 544);
            panel2.TabIndex = 3;
            // 
            // button5
            // 
            button5.Image = (Image)resources.GetObject("button5.Image");
            button5.ImageAlign = ContentAlignment.MiddleLeft;
            button5.Location = new Point(12, 482);
            button5.Name = "button5";
            button5.Size = new Size(217, 48);
            button5.TabIndex = 3;
            button5.Text = "Sign-out";
            button5.UseVisualStyleBackColor = true;
            // 
            // button_author
            // 
            button_author.BackColor = Color.Transparent;
            button_author.Image = (Image)resources.GetObject("button_author.Image");
            button_author.Location = new Point(439, 129);
            button_author.Name = "button_author";
            button_author.Size = new Size(133, 133);
            button_author.TabIndex = 4;
            button_author.Text = "Author";
            button_author.TextAlign = ContentAlignment.BottomCenter;
            button_author.UseVisualStyleBackColor = false;
            button_author.Click += button1_Click;
            // 
            // button_books
            // 
            button_books.Image = (Image)resources.GetObject("button_books.Image");
            button_books.Location = new Point(784, 129);
            button_books.Name = "button_books";
            button_books.Size = new Size(133, 133);
            button_books.TabIndex = 5;
            button_books.Text = "Books";
            button_books.TextAlign = ContentAlignment.BottomCenter;
            button_books.UseVisualStyleBackColor = true;
            button_books.Click += button_books_Click;
            // 
            // button_students
            // 
            button_students.Image = (Image)resources.GetObject("button_students.Image");
            button_students.Location = new Point(439, 377);
            button_students.Name = "button_students";
            button_students.Size = new Size(133, 133);
            button_students.TabIndex = 6;
            button_students.Text = "Students";
            button_students.TextAlign = ContentAlignment.BottomCenter;
            button_students.UseVisualStyleBackColor = true;
            button_students.Click += button3_Click;
            // 
            // button_borrowBooks
            // 
            button_borrowBooks.Image = (Image)resources.GetObject("button_borrowBooks.Image");
            button_borrowBooks.Location = new Point(784, 377);
            button_borrowBooks.Name = "button_borrowBooks";
            button_borrowBooks.Size = new Size(133, 133);
            button_borrowBooks.TabIndex = 7;
            button_borrowBooks.Text = "Borrow Books";
            button_borrowBooks.TextAlign = ContentAlignment.BottomCenter;
            button_borrowBooks.UseVisualStyleBackColor = true;
            button_borrowBooks.Click += button_borrowBooks_Click;
            // 
            // menu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1109, 582);
            Controls.Add(button_borrowBooks);
            Controls.Add(button_students);
            Controls.Add(button_books);
            Controls.Add(button_author);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "menu";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "menu";
            Load += menu_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private PictureBox pictureBox1;
        private Label label1;
        private Panel panel2;
        private Button button_author;
        private Button button_books;
        private Button button_students;
        private Button button_borrowBooks;
        private Button button5;
        private PictureBox pictureBox2;
        private Label label2;
    }
}