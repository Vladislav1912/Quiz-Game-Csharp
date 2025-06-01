namespace Quiz_Project_for_Uni
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            Username = new TextBox();
            Email = new TextBox();
            Password = new TextBox();
            ConfirmPassword = new TextBox();
            RegisterBtn = new Button();
            label6 = new Label();
            linkLabel1 = new LinkLabel();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 25F, FontStyle.Bold);
            label1.Location = new Point(204, 63);
            label1.Name = "label1";
            label1.Size = new Size(150, 46);
            label1.TabIndex = 0;
            label1.Text = "Register";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label2.Location = new Point(75, 144);
            label2.Name = "label2";
            label2.Size = new Size(87, 21);
            label2.TabIndex = 1;
            label2.Text = "Username";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label3.Location = new Point(109, 184);
            label3.Name = "label3";
            label3.Size = new Size(53, 21);
            label3.TabIndex = 2;
            label3.Text = "Email";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label4.Location = new Point(80, 221);
            label4.Name = "label4";
            label4.Size = new Size(82, 21);
            label4.TabIndex = 3;
            label4.Text = "Password";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label5.Location = new Point(14, 255);
            label5.Name = "label5";
            label5.Size = new Size(148, 21);
            label5.TabIndex = 4;
            label5.Text = "Confirm Password";
            // 
            // Username
            // 
            Username.Location = new Point(168, 146);
            Username.Name = "Username";
            Username.Size = new Size(229, 23);
            Username.TabIndex = 5;
            // 
            // Email
            // 
            Email.Location = new Point(168, 182);
            Email.Name = "Email";
            Email.Size = new Size(229, 23);
            Email.TabIndex = 6;
            // 
            // Password
            // 
            Password.Location = new Point(168, 219);
            Password.Name = "Password";
            Password.Size = new Size(229, 23);
            Password.TabIndex = 7;
            // 
            // ConfirmPassword
            // 
            ConfirmPassword.Location = new Point(168, 257);
            ConfirmPassword.Name = "ConfirmPassword";
            ConfirmPassword.Size = new Size(229, 23);
            ConfirmPassword.TabIndex = 8;
            // 
            // RegisterBtn
            // 
            RegisterBtn.BackColor = SystemColors.ActiveCaption;
            RegisterBtn.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            RegisterBtn.Location = new Point(185, 298);
            RegisterBtn.Name = "RegisterBtn";
            RegisterBtn.Size = new Size(190, 44);
            RegisterBtn.TabIndex = 9;
            RegisterBtn.Text = "Register";
            RegisterBtn.UseVisualStyleBackColor = false;
            RegisterBtn.Click += RegisterBtn_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(168, 366);
            label6.Name = "label6";
            label6.Size = new Size(147, 15);
            label6.TabIndex = 10;
            label6.Text = "You already have account?";
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Location = new Point(313, 366);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(62, 15);
            linkLabel1.TabIndex = 11;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Click here!";
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(557, 450);
            Controls.Add(linkLabel1);
            Controls.Add(label6);
            Controls.Add(RegisterBtn);
            Controls.Add(ConfirmPassword);
            Controls.Add(Password);
            Controls.Add(Email);
            Controls.Add(Username);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox Username;
        private TextBox Email;
        private TextBox Password;
        private TextBox ConfirmPassword;
        private Button RegisterBtn;
        private Label label6;
        private LinkLabel linkLabel1;
    }
}
