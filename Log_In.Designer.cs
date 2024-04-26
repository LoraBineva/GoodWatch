namespace Final_Eda
{
    partial class Log_In
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
            username = new TextBox();
            log_in_lbl = new Label();
            username_lbl = new Label();
            password_lbl = new Label();
            password = new TextBox();
            log_in_btn = new Button();
            label1 = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // username
            // 
            username.BackColor = Color.White;
            username.Font = new Font("Gadugi", 12F, FontStyle.Regular, GraphicsUnit.Point);
            username.Location = new Point(68, 281);
            username.Name = "username";
            username.PlaceholderText = "Username";
            username.Size = new Size(231, 29);
            username.TabIndex = 1;
            // 
            // log_in_lbl
            // 
            log_in_lbl.AutoSize = true;
            log_in_lbl.BackColor = Color.Transparent;
            log_in_lbl.Font = new Font("Gadugi", 27.75F, FontStyle.Bold, GraphicsUnit.Point);
            log_in_lbl.ForeColor = Color.FromArgb(203, 212, 242);
            log_in_lbl.Location = new Point(112, 152);
            log_in_lbl.Name = "log_in_lbl";
            log_in_lbl.Size = new Size(128, 44);
            log_in_lbl.TabIndex = 3;
            log_in_lbl.Text = "Log In";
            // 
            // username_lbl
            // 
            username_lbl.AutoSize = true;
            username_lbl.BackColor = Color.Transparent;
            username_lbl.Font = new Font("Gadugi", 18F, FontStyle.Regular, GraphicsUnit.Point);
            username_lbl.ForeColor = Color.FromArgb(203, 212, 242);
            username_lbl.Location = new Point(60, 234);
            username_lbl.Name = "username_lbl";
            username_lbl.Size = new Size(124, 28);
            username_lbl.TabIndex = 4;
            username_lbl.Text = "Username:";
            // 
            // password_lbl
            // 
            password_lbl.AutoSize = true;
            password_lbl.BackColor = Color.Transparent;
            password_lbl.Font = new Font("Gadugi", 18F, FontStyle.Regular, GraphicsUnit.Point);
            password_lbl.ForeColor = Color.FromArgb(203, 212, 242);
            password_lbl.Location = new Point(60, 338);
            password_lbl.Name = "password_lbl";
            password_lbl.Size = new Size(115, 28);
            password_lbl.TabIndex = 6;
            password_lbl.Text = "Password:";
            // 
            // password
            // 
            password.BackColor = Color.White;
            password.Font = new Font("Gadugi", 12F, FontStyle.Regular, GraphicsUnit.Point);
            password.Location = new Point(68, 383);
            password.Name = "password";
            password.PasswordChar = '*';
            password.PlaceholderText = "Password";
            password.Size = new Size(231, 29);
            password.TabIndex = 5;
            // 
            // log_in_btn
            // 
            log_in_btn.BackColor = Color.FromArgb(62, 84, 126);
            log_in_btn.FlatAppearance.BorderColor = Color.FromArgb(62, 84, 126);
            log_in_btn.FlatAppearance.BorderSize = 0;
            log_in_btn.FlatStyle = FlatStyle.Flat;
            log_in_btn.Font = new Font("Gadugi", 15F, FontStyle.Bold, GraphicsUnit.Point);
            log_in_btn.ForeColor = Color.FromArgb(202, 212, 242);
            log_in_btn.Location = new Point(44, 478);
            log_in_btn.Margin = new Padding(4);
            log_in_btn.Name = "log_in_btn";
            log_in_btn.Size = new Size(269, 45);
            log_in_btn.TabIndex = 7;
            log_in_btn.Text = "Log In";
            log_in_btn.UseVisualStyleBackColor = false;
            log_in_btn.Click += log_in_btn_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Gadugi", 12F, FontStyle.Italic, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(94, 537);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(170, 19);
            label1.TabIndex = 8;
            label1.Text = "Don't have an account?";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Gadugi", 12F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(112, 556);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(133, 19);
            label2.TabIndex = 9;
            label2.Text = "Create one now!";
            label2.Click += label2_Click;
            // 
            // Log_In
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.background_app;
            ClientSize = new Size(357, 776);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(log_in_btn);
            Controls.Add(password_lbl);
            Controls.Add(password);
            Controls.Add(username_lbl);
            Controls.Add(log_in_lbl);
            Controls.Add(username);
            Name = "Log_In";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox username;
        private Label log_in_lbl;
        private Label username_lbl;
        private Label password_lbl;
        private TextBox password;
        private Button log_in_btn;
        private Label label1;
        private Label label2;
    }
}