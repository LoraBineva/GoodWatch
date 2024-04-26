namespace Register_page
{
    partial class Register
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
            uTXTbox = new TextBox();
            eTXTbox = new TextBox();
            pTXTbox = new TextBox();
            last_nameTXTbox = new TextBox();
            first_nameTXTbox = new TextBox();
            yearCbox = new ComboBox();
            dayCbox = new ComboBox();
            button1 = new Button();
            log_in_lbl = new Label();
            username_lbl = new Label();
            email_lbl = new Label();
            password_lbl = new Label();
            first_name_lbl = new Label();
            label1 = new Label();
            label2 = new Label();
            monthCbox = new ComboBox();
            SuspendLayout();
            // 
            // uTXTbox
            // 
            uTXTbox.Font = new Font("Gadugi", 12F, FontStyle.Regular, GraphicsUnit.Point);
            uTXTbox.Location = new Point(74, 247);
            uTXTbox.Name = "uTXTbox";
            uTXTbox.PlaceholderText = "Username:";
            uTXTbox.Size = new Size(231, 29);
            uTXTbox.TabIndex = 0;
            // 
            // eTXTbox
            // 
            eTXTbox.Font = new Font("Gadugi", 12F, FontStyle.Regular, GraphicsUnit.Point);
            eTXTbox.Location = new Point(74, 326);
            eTXTbox.Name = "eTXTbox";
            eTXTbox.PlaceholderText = "Email:";
            eTXTbox.Size = new Size(231, 29);
            eTXTbox.TabIndex = 1;
            // 
            // pTXTbox
            // 
            pTXTbox.Font = new Font("Gadugi", 12F, FontStyle.Regular, GraphicsUnit.Point);
            pTXTbox.Location = new Point(73, 407);
            pTXTbox.Name = "pTXTbox";
            pTXTbox.PasswordChar = '*';
            pTXTbox.PlaceholderText = "Password:";
            pTXTbox.Size = new Size(231, 29);
            pTXTbox.TabIndex = 2;
            // 
            // last_nameTXTbox
            // 
            last_nameTXTbox.Font = new Font("Gadugi", 12F, FontStyle.Regular, GraphicsUnit.Point);
            last_nameTXTbox.Location = new Point(210, 510);
            last_nameTXTbox.Name = "last_nameTXTbox";
            last_nameTXTbox.PlaceholderText = "Last Name:";
            last_nameTXTbox.Size = new Size(137, 29);
            last_nameTXTbox.TabIndex = 3;
            // 
            // first_nameTXTbox
            // 
            first_nameTXTbox.Font = new Font("Gadugi", 12F, FontStyle.Regular, GraphicsUnit.Point);
            first_nameTXTbox.Location = new Point(32, 510);
            first_nameTXTbox.Name = "first_nameTXTbox";
            first_nameTXTbox.PlaceholderText = "First Name:";
            first_nameTXTbox.Size = new Size(134, 29);
            first_nameTXTbox.TabIndex = 4;
            // 
            // yearCbox
            // 
            yearCbox.Font = new Font("Gadugi", 12F, FontStyle.Regular, GraphicsUnit.Point);
            yearCbox.FormattingEnabled = true;
            yearCbox.Items.AddRange(new object[] { "1950", "1951", "1952", "1953", "1954", "1955", "1956", "1957", "1958", "1959", "1960", "1961", "1962", "1963", "1964", "1965", "1966", "1967", "1968", "1969", "1970", "1971", "1972", "1973", "1974", "1975", "1976", "1977", "1978", "1979", "1980", "1981", "1982", "1983", "1984", "1985", "1986", "1987", "1988", "1989", "1990", "1991", "1992", "1993", "1994", "1995", "1996", "1997", "1998", "1999", "2000", "2001", "2002", "2003", "2004", "2005", "2006", "2007", "2008", "2009", "2010", "2011", "2012", "2013", "2014", "2015", "2016", "2017", "2018", "2019", "2020" });
            yearCbox.Location = new Point(251, 613);
            yearCbox.Name = "yearCbox";
            yearCbox.Size = new Size(75, 27);
            yearCbox.TabIndex = 5;
            yearCbox.Text = "Year";
            // 
            // dayCbox
            // 
            dayCbox.Font = new Font("Gadugi", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dayCbox.FormattingEnabled = true;
            dayCbox.Items.AddRange(new object[] { "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20", "21", "22", "23", "24", "25", "26", "27", "28", "29", "30", "31" });
            dayCbox.Location = new Point(56, 613);
            dayCbox.Name = "dayCbox";
            dayCbox.Size = new Size(52, 27);
            dayCbox.TabIndex = 7;
            dayCbox.Text = "Day";
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(62, 84, 126);
            button1.FlatAppearance.BorderColor = Color.FromArgb(62, 84, 126);
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Gadugi", 15F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = Color.FromArgb(202, 212, 242);
            button1.Location = new Point(57, 685);
            button1.Margin = new Padding(4);
            button1.Name = "button1";
            button1.Size = new Size(269, 45);
            button1.TabIndex = 24;
            button1.Text = "Create Account";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // log_in_lbl
            // 
            log_in_lbl.AutoSize = true;
            log_in_lbl.BackColor = Color.Transparent;
            log_in_lbl.Font = new Font("Gadugi", 27.75F, FontStyle.Bold, GraphicsUnit.Point);
            log_in_lbl.ForeColor = Color.FromArgb(203, 212, 242);
            log_in_lbl.Location = new Point(46, 134);
            log_in_lbl.Name = "log_in_lbl";
            log_in_lbl.Size = new Size(284, 44);
            log_in_lbl.TabIndex = 17;
            log_in_lbl.Text = "Create Account";
            // 
            // username_lbl
            // 
            username_lbl.AutoSize = true;
            username_lbl.BackColor = Color.Transparent;
            username_lbl.Font = new Font("Gadugi", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            username_lbl.ForeColor = Color.FromArgb(203, 212, 242);
            username_lbl.Location = new Point(69, 219);
            username_lbl.Name = "username_lbl";
            username_lbl.Size = new Size(110, 25);
            username_lbl.TabIndex = 18;
            username_lbl.Text = "Username:";
            // 
            // email_lbl
            // 
            email_lbl.AutoSize = true;
            email_lbl.BackColor = Color.Transparent;
            email_lbl.Font = new Font("Gadugi", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            email_lbl.ForeColor = Color.FromArgb(203, 212, 242);
            email_lbl.Location = new Point(68, 298);
            email_lbl.Name = "email_lbl";
            email_lbl.Size = new Size(67, 25);
            email_lbl.TabIndex = 19;
            email_lbl.Text = "Email:";
            // 
            // password_lbl
            // 
            password_lbl.AutoSize = true;
            password_lbl.BackColor = Color.Transparent;
            password_lbl.Font = new Font("Gadugi", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            password_lbl.ForeColor = Color.FromArgb(203, 212, 242);
            password_lbl.Location = new Point(69, 379);
            password_lbl.Name = "password_lbl";
            password_lbl.Size = new Size(104, 25);
            password_lbl.TabIndex = 20;
            password_lbl.Text = "Password:";
            // 
            // first_name_lbl
            // 
            first_name_lbl.AutoSize = true;
            first_name_lbl.BackColor = Color.Transparent;
            first_name_lbl.Font = new Font("Gadugi", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            first_name_lbl.ForeColor = Color.FromArgb(203, 212, 242);
            first_name_lbl.Location = new Point(32, 482);
            first_name_lbl.Name = "first_name_lbl";
            first_name_lbl.Size = new Size(117, 25);
            first_name_lbl.TabIndex = 21;
            first_name_lbl.Text = "First Name:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Gadugi", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(203, 212, 242);
            label1.Location = new Point(210, 482);
            label1.Name = "label1";
            label1.Size = new Size(116, 25);
            label1.TabIndex = 22;
            label1.Text = "Last Name:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Gadugi", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.FromArgb(203, 212, 242);
            label2.Location = new Point(121, 575);
            label2.Name = "label2";
            label2.Size = new Size(135, 25);
            label2.TabIndex = 23;
            label2.Text = "Date of Birth:";
            // 
            // monthCbox
            // 
            monthCbox.Font = new Font("Gadugi", 12F, FontStyle.Regular, GraphicsUnit.Point);
            monthCbox.FormattingEnabled = true;
            monthCbox.Items.AddRange(new object[] { "January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December" });
            monthCbox.Location = new Point(144, 613);
            monthCbox.Name = "monthCbox";
            monthCbox.Size = new Size(73, 27);
            monthCbox.TabIndex = 6;
            monthCbox.Text = "Month";
            monthCbox.SelectedIndexChanged += monthCbox_SelectedIndexChanged;
            // 
            // Register
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Final_Eda.Properties.Resources.background_app;
            ClientSize = new Size(376, 770);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(first_name_lbl);
            Controls.Add(password_lbl);
            Controls.Add(email_lbl);
            Controls.Add(username_lbl);
            Controls.Add(log_in_lbl);
            Controls.Add(button1);
            Controls.Add(dayCbox);
            Controls.Add(monthCbox);
            Controls.Add(yearCbox);
            Controls.Add(first_nameTXTbox);
            Controls.Add(last_nameTXTbox);
            Controls.Add(pTXTbox);
            Controls.Add(eTXTbox);
            Controls.Add(uTXTbox);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "Register";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox uTXTbox;
        private TextBox eTXTbox;
        private TextBox pTXTbox;
        private TextBox last_nameTXTbox;
        private TextBox first_nameTXTbox;
        private ComboBox yearCbox;
        private ComboBox dayCbox;
        private Button button1;
        private Label log_in_lbl;
        private Label username_lbl;
        private Label email_lbl;
        private Label password_lbl;
        private Label first_name_lbl;
        private Label label1;
        private Label label2;
        private ComboBox monthCbox;
    }
}