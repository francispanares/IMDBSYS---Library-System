namespace Library_System_Management
{
    partial class addAuthorUI
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
            txtID = new TextBox();
            txtFName = new TextBox();
            IDlabel = new Label();
            txtLName = new TextBox();
            txtNationality = new TextBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            txtEmail = new TextBox();
            label1 = new Label();
            button1 = new Button();
            button2 = new Button();
            panel1 = new Panel();
            panel2 = new Panel();
            SuspendLayout();
            // 
            // txtID
            // 
            txtID.Location = new Point(132, 71);
            txtID.Name = "txtID";
            txtID.Size = new Size(255, 27);
            txtID.TabIndex = 0;
            // 
            // txtFName
            // 
            txtFName.Location = new Point(132, 135);
            txtFName.Name = "txtFName";
            txtFName.Size = new Size(257, 27);
            txtFName.TabIndex = 1;
            txtFName.TextChanged += textBox2_TextChanged;
            // 
            // IDlabel
            // 
            IDlabel.AutoSize = true;
            IDlabel.BackColor = Color.Transparent;
            IDlabel.ForeColor = Color.Black;
            IDlabel.Location = new Point(89, 78);
            IDlabel.Name = "IDlabel";
            IDlabel.Size = new Size(27, 20);
            IDlabel.TabIndex = 2;
            IDlabel.Text = "ID:";
            IDlabel.Click += label1_Click;
            // 
            // txtLName
            // 
            txtLName.Location = new Point(134, 201);
            txtLName.Name = "txtLName";
            txtLName.Size = new Size(255, 27);
            txtLName.TabIndex = 3;
            // 
            // txtNationality
            // 
            txtNationality.Location = new Point(134, 263);
            txtNationality.Name = "txtNationality";
            txtNationality.Size = new Size(255, 27);
            txtNationality.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Location = new Point(43, 142);
            label2.Name = "label2";
            label2.Size = new Size(83, 20);
            label2.TabIndex = 5;
            label2.Text = "First Name:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Location = new Point(40, 208);
            label3.Name = "label3";
            label3.Size = new Size(86, 20);
            label3.TabIndex = 6;
            label3.Text = "Last Name: ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Location = new Point(43, 266);
            label4.Name = "label4";
            label4.Size = new Size(85, 20);
            label4.TabIndex = 7;
            label4.Text = "Nationality:";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(132, 326);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(255, 27);
            txtEmail.TabIndex = 8;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Location = new Point(63, 329);
            label1.Name = "label1";
            label1.Size = new Size(53, 20);
            label1.TabIndex = 9;
            label1.Text = "Email: ";
            // 
            // button1
            // 
            button1.Location = new Point(117, 423);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 10;
            button1.Text = "Add";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(258, 423);
            button2.Name = "button2";
            button2.Size = new Size(94, 29);
            button2.TabIndex = 11;
            button2.Text = "Clear";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.DarkOliveGreen;
            panel1.Location = new Point(0, 1);
            panel1.Name = "panel1";
            panel1.Size = new Size(451, 41);
            panel1.TabIndex = 12;
            // 
            // panel2
            // 
            panel2.BackColor = Color.AntiqueWhite;
            panel2.Location = new Point(0, 42);
            panel2.Name = "panel2";
            panel2.Size = new Size(451, 452);
            panel2.TabIndex = 13;
            // 
            // addAuthorUI
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(451, 494);
            Controls.Add(panel1);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label1);
            Controls.Add(txtEmail);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(txtNationality);
            Controls.Add(txtLName);
            Controls.Add(IDlabel);
            Controls.Add(txtFName);
            Controls.Add(txtID);
            Controls.Add(panel2);
            Name = "addAuthorUI";
            Text = "addAuthorUI";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label IDlabel;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label1;
        private Button button1;
        private Button button2;
        private Panel panel1;
        private Panel panel2;
        public TextBox txtID;
        public TextBox txtFName;
        public TextBox txtLName;
        public TextBox txtNationality;
        public TextBox txtEmail;
    }
}