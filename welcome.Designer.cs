namespace FinalEda
{
    partial class welcome
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
            create_acc = new Button();
            log_in = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Gadugi", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(69, 519);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(233, 19);
            label1.TabIndex = 0;
            label1.Text = "Want to join our community?";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Gadugi", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(166, 610);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(31, 19);
            label2.TabIndex = 1;
            label2.Text = "OR";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Gadugi", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.White;
            label3.Location = new Point(81, 646);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(204, 19);
            label3.TabIndex = 2;
            label3.Text = "Already have an account?";
            // 
            // create_acc
            // 
            create_acc.BackColor = Color.FromArgb(62, 84, 126);
            create_acc.FlatAppearance.BorderSize = 0;
            create_acc.FlatStyle = FlatStyle.Flat;
            create_acc.Font = new Font("Gadugi", 15F, FontStyle.Bold, GraphicsUnit.Point);
            create_acc.ForeColor = Color.FromArgb(202, 212, 242);
            create_acc.Location = new Point(49, 549);
            create_acc.Margin = new Padding(4);
            create_acc.Name = "create_acc";
            create_acc.Size = new Size(269, 45);
            create_acc.TabIndex = 3;
            create_acc.Text = "Create Account";
            create_acc.UseVisualStyleBackColor = false;
            create_acc.Click += create_acc_Click;
            // 
            // log_in
            // 
            log_in.BackColor = Color.FromArgb(62, 84, 126);
            log_in.FlatAppearance.BorderColor = Color.FromArgb(62, 84, 126);
            log_in.FlatAppearance.BorderSize = 0;
            log_in.FlatStyle = FlatStyle.Flat;
            log_in.Font = new Font("Gadugi", 15F, FontStyle.Bold, GraphicsUnit.Point);
            log_in.ForeColor = Color.FromArgb(202, 212, 242);
            log_in.Location = new Point(49, 675);
            log_in.Margin = new Padding(4);
            log_in.Name = "log_in";
            log_in.Size = new Size(269, 45);
            log_in.TabIndex = 4;
            log_in.Text = "Log In";
            log_in.UseVisualStyleBackColor = false;
            log_in.Click += log_in_Click;
            // 
            // welcome
            // 
            AutoScaleDimensions = new SizeF(10F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(62, 84, 126);
            BackgroundImage = Final_Eda.Properties.Resources.IMG_7407;
            ClientSize = new Size(375, 777);
            Controls.Add(log_in);
            Controls.Add(create_acc);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Gadugi", 12F, FontStyle.Bold, GraphicsUnit.Point);
            ForeColor = Color.FromArgb(202, 212, 242);
            Margin = new Padding(4);
            Name = "welcome";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Button create_acc;
        private Button log_in;
    }
}