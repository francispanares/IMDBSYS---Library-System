namespace Library_System_Management
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            signInBttn = new Button();
            txt_user = new TextBox();
            txt_password = new TextBox();
            label1 = new Label();
            label2 = new Label();
            pictureBox1 = new PictureBox();
            closePicBox = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)closePicBox).BeginInit();
            SuspendLayout();
            // 
            // signInBttn
            // 
            signInBttn.BackColor = Color.Tan;
            signInBttn.Location = new Point(110, 350);
            signInBttn.Name = "signInBttn";
            signInBttn.Size = new Size(124, 29);
            signInBttn.TabIndex = 0;
            signInBttn.Text = "Sign-in";
            signInBttn.UseVisualStyleBackColor = false;
            signInBttn.Click += button1_Click;
            // 
            // txt_user
            // 
            txt_user.Location = new Point(74, 208);
            txt_user.Name = "txt_user";
            txt_user.Size = new Size(201, 27);
            txt_user.TabIndex = 2;
            txt_user.TextAlign = HorizontalAlignment.Center;
            txt_user.TextChanged += txt_user_TextChanged;
            // 
            // txt_password
            // 
            txt_password.Location = new Point(74, 280);
            txt_password.Name = "txt_password";
            txt_password.Size = new Size(201, 27);
            txt_password.TabIndex = 3;
            txt_password.TextAlign = HorizontalAlignment.Center;
            txt_password.TextChanged += passTxtbx_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = Color.White;
            label1.Location = new Point(134, 185);
            label1.Name = "label1";
            label1.Size = new Size(75, 20);
            label1.TabIndex = 4;
            label1.Text = "Username";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.White;
            label2.Location = new Point(139, 257);
            label2.Name = "label2";
            label2.Size = new Size(70, 20);
            label2.TabIndex = 5;
            label2.Text = "Password";
            label2.Click += label2_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.InitialImage = null;
            pictureBox1.Location = new Point(121, 84);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(97, 98);
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            // 
            // closePicBox
            // 
            closePicBox.Image = (Image)resources.GetObject("closePicBox.Image");
            closePicBox.Location = new Point(288, 12);
            closePicBox.Name = "closePicBox";
            closePicBox.Size = new Size(35, 37);
            closePicBox.TabIndex = 7;
            closePicBox.TabStop = false;
            closePicBox.Click += pictureBox2_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkOliveGreen;
            ClientSize = new Size(335, 504);
            Controls.Add(closePicBox);
            Controls.Add(pictureBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txt_password);
            Controls.Add(txt_user);
            Controls.Add(signInBttn);
            ForeColor = Color.Black;
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)closePicBox).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button signInBttn;
        private TextBox txt_user;
        private TextBox txt_password;
        private Label label1;
        private Label label2;
        private PictureBox pictureBox1;
        private PictureBox closePicBox;
    }
}