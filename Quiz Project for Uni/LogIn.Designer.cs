namespace Quiz_Project_for_Uni
{
    partial class LogIn
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            linkLabel1 = new LinkLabel();
            label5 = new Label();
            LogInUsername = new TextBox();
            LogInEmail = new TextBox();
            LogInPassword = new TextBox();
            button1 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 25F, FontStyle.Bold);
            label1.Location = new Point(175, 51);
            label1.Name = "label1";
            label1.Size = new Size(120, 46);
            label1.TabIndex = 0;
            label1.Text = "Log In";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label2.Location = new Point(44, 119);
            label2.Name = "label2";
            label2.Size = new Size(87, 21);
            label2.TabIndex = 1;
            label2.Text = "Username";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label3.Location = new Point(78, 160);
            label3.Name = "label3";
            label3.Size = new Size(53, 21);
            label3.TabIndex = 2;
            label3.Text = "Email";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label4.Location = new Point(49, 199);
            label4.Name = "label4";
            label4.Size = new Size(82, 21);
            label4.TabIndex = 3;
            label4.Text = "Password";
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Location = new Point(259, 315);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(62, 15);
            linkLabel1.TabIndex = 4;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Click here!";
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(119, 315);
            label5.Name = "label5";
            label5.Size = new Size(134, 15);
            label5.TabIndex = 5;
            label5.Text = "You dont have account?";
            // 
            // LogInUsername
            // 
            LogInUsername.Location = new Point(137, 121);
            LogInUsername.Name = "LogInUsername";
            LogInUsername.Size = new Size(214, 23);
            LogInUsername.TabIndex = 6;
            // 
            // LogInEmail
            // 
            LogInEmail.Location = new Point(137, 162);
            LogInEmail.Name = "LogInEmail";
            LogInEmail.Size = new Size(214, 23);
            LogInEmail.TabIndex = 7;
            // 
            // LogInPassword
            // 
            LogInPassword.Location = new Point(137, 201);
            LogInPassword.Name = "LogInPassword";
            LogInPassword.Size = new Size(214, 23);
            LogInPassword.TabIndex = 8;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ActiveCaption;
            button1.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            button1.Location = new Point(163, 242);
            button1.Name = "button1";
            button1.Size = new Size(148, 50);
            button1.TabIndex = 9;
            button1.Text = "Sign in";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // LogIn
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(480, 401);
            Controls.Add(button1);
            Controls.Add(LogInPassword);
            Controls.Add(LogInEmail);
            Controls.Add(LogInUsername);
            Controls.Add(label5);
            Controls.Add(linkLabel1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "LogIn";
            Text = "LogIn";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private LinkLabel linkLabel1;
        private Label label5;
        private TextBox LogInUsername;
        private TextBox LogInEmail;
        private TextBox LogInPassword;
        private Button button1;
    }
}