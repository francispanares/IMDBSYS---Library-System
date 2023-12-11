namespace Library_System_Management
{
    partial class updateAuthorUI
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
            panel1 = new Panel();
            label1 = new Label();
            txtEmail = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            txtNationality = new TextBox();
            txtLName = new TextBox();
            txtFName = new TextBox();
            panel2 = new Panel();
            bttnClear = new Button();
            bttnUpdate = new Button();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.DarkOliveGreen;
            panel1.Location = new Point(3, 1);
            panel1.Name = "panel1";
            panel1.Size = new Size(451, 41);
            panel1.TabIndex = 24;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Location = new Point(66, 329);
            label1.Name = "label1";
            label1.Size = new Size(53, 20);
            label1.TabIndex = 23;
            label1.Text = "Email: ";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(135, 326);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(255, 27);
            txtEmail.TabIndex = 22;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Location = new Point(46, 266);
            label4.Name = "label4";
            label4.Size = new Size(85, 20);
            label4.TabIndex = 21;
            label4.Text = "Nationality:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Location = new Point(42, 159);
            label3.Name = "label3";
            label3.Size = new Size(86, 20);
            label3.TabIndex = 20;
            label3.Text = "Last Name: ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Location = new Point(45, 93);
            label2.Name = "label2";
            label2.Size = new Size(83, 20);
            label2.TabIndex = 19;
            label2.Text = "First Name:";
            // 
            // txtNationality
            // 
            txtNationality.Location = new Point(137, 263);
            txtNationality.Name = "txtNationality";
            txtNationality.Size = new Size(255, 27);
            txtNationality.TabIndex = 18;
            // 
            // txtLName
            // 
            txtLName.Location = new Point(137, 201);
            txtLName.Name = "txtLName";
            txtLName.Size = new Size(255, 27);
            txtLName.TabIndex = 17;
            // 
            // txtFName
            // 
            txtFName.Location = new Point(134, 86);
            txtFName.Name = "txtFName";
            txtFName.Size = new Size(257, 27);
            txtFName.TabIndex = 15;
            // 
            // panel2
            // 
            panel2.BackColor = Color.AntiqueWhite;
            panel2.Controls.Add(bttnClear);
            panel2.Controls.Add(bttnUpdate);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(txtFName);
            panel2.Controls.Add(label2);
            panel2.Location = new Point(3, 42);
            panel2.Name = "panel2";
            panel2.Size = new Size(451, 452);
            panel2.TabIndex = 25;
            // 
            // bttnClear
            // 
            bttnClear.Location = new Point(269, 368);
            bttnClear.Name = "bttnClear";
            bttnClear.Size = new Size(94, 29);
            bttnClear.TabIndex = 1;
            bttnClear.Text = "Clear";
            bttnClear.UseVisualStyleBackColor = true;
            bttnClear.Click += bttnClear_Click;
            // 
            // bttnUpdate
            // 
            bttnUpdate.Location = new Point(89, 368);
            bttnUpdate.Name = "bttnUpdate";
            bttnUpdate.Size = new Size(94, 29);
            bttnUpdate.TabIndex = 0;
            bttnUpdate.Text = "Update";
            bttnUpdate.UseVisualStyleBackColor = true;
            bttnUpdate.Click += bttnUpdate_Click;
            // 
            // updateAuthorUI
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(453, 494);
            Controls.Add(panel1);
            Controls.Add(label1);
            Controls.Add(txtEmail);
            Controls.Add(label4);
            Controls.Add(txtNationality);
            Controls.Add(txtLName);
            Controls.Add(panel2);
            Name = "updateAuthorUI";
            Text = "updateAuthorUI";
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label1;
        public TextBox txtEmail;
        private Label label4;
        private Label label3;
        private Label label2;
        public TextBox txtNationality;
        public TextBox txtLName;
        private Label IDlabel;
        public TextBox txtFName;
        public TextBox txtID;
        private Panel panel2;
        private Button bttnClear;
        private Button bttnUpdate;
    }
}