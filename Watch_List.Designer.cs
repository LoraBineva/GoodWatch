namespace Final_Eda
{
    partial class Watch_List
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
            Watched_list_lbl = new Label();
            label3 = new Label();
            go_watched = new Button();
            go_search = new Button();
            add_watchlist = new Button();
            label1 = new Label();
            movieID1 = new TextBox();
            data = new DataGridView();
            button1 = new Button();
            label2 = new Label();
            movieID2 = new TextBox();
            label4 = new Label();
            username_lbl = new Label();
            GenreCbox = new ComboBox();
            azCBox = new ComboBox();
            viewall_btn = new Button();
            ((System.ComponentModel.ISupportInitialize)data).BeginInit();
            SuspendLayout();
            // 
            // Watched_list_lbl
            // 
            Watched_list_lbl.AutoSize = true;
            Watched_list_lbl.BackColor = Color.Transparent;
            Watched_list_lbl.Font = new Font("Gadugi", 24F, FontStyle.Bold, GraphicsUnit.Point);
            Watched_list_lbl.ForeColor = Color.FromArgb(116, 167, 215);
            Watched_list_lbl.Location = new Point(104, 68);
            Watched_list_lbl.Name = "Watched_list_lbl";
            Watched_list_lbl.Size = new Size(156, 38);
            Watched_list_lbl.TabIndex = 4;
            Watched_list_lbl.Text = "Watchlist";
            Watched_list_lbl.TextAlign = ContentAlignment.TopCenter;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Gadugi", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = SystemColors.ButtonHighlight;
            label3.Location = new Point(148, 681);
            label3.Name = "label3";
            label3.Size = new Size(64, 22);
            label3.TabIndex = 26;
            label3.Text = "Go To:";
            // 
            // go_watched
            // 
            go_watched.BackColor = Color.FromArgb(67, 137, 207);
            go_watched.FlatAppearance.BorderColor = Color.FromArgb(67, 137, 207);
            go_watched.FlatStyle = FlatStyle.Flat;
            go_watched.Font = new Font("Gadugi", 12F, FontStyle.Regular, GraphicsUnit.Point);
            go_watched.ForeColor = SystemColors.ButtonHighlight;
            go_watched.Location = new Point(192, 715);
            go_watched.Name = "go_watched";
            go_watched.Size = new Size(147, 37);
            go_watched.TabIndex = 25;
            go_watched.Text = "Watched";
            go_watched.UseVisualStyleBackColor = false;
            go_watched.Click += go_watched_Click;
            // 
            // go_search
            // 
            go_search.BackColor = Color.FromArgb(67, 137, 207);
            go_search.FlatAppearance.BorderColor = Color.FromArgb(67, 137, 207);
            go_search.FlatStyle = FlatStyle.Flat;
            go_search.Font = new Font("Gadugi", 12F, FontStyle.Regular, GraphicsUnit.Point);
            go_search.ForeColor = SystemColors.ButtonHighlight;
            go_search.Location = new Point(23, 715);
            go_search.Name = "go_search";
            go_search.Size = new Size(147, 37);
            go_search.TabIndex = 24;
            go_search.Text = "Search";
            go_search.UseVisualStyleBackColor = false;
            go_search.Click += go_search_Click;
            // 
            // add_watchlist
            // 
            add_watchlist.BackColor = Color.FromArgb(62, 137, 207);
            add_watchlist.FlatAppearance.BorderColor = Color.FromArgb(62, 137, 207);
            add_watchlist.FlatStyle = FlatStyle.Flat;
            add_watchlist.ForeColor = SystemColors.ButtonHighlight;
            add_watchlist.Location = new Point(23, 645);
            add_watchlist.Name = "add_watchlist";
            add_watchlist.Size = new Size(147, 23);
            add_watchlist.TabIndex = 22;
            add_watchlist.Text = "Move to Watched List";
            add_watchlist.UseVisualStyleBackColor = false;
            add_watchlist.Click += add_watchlist_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Gadugi", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(23, 597);
            label1.Name = "label1";
            label1.RightToLeft = RightToLeft.No;
            label1.Size = new Size(147, 16);
            label1.TabIndex = 19;
            label1.Text = "Already Watched a Movie?";
            // 
            // movieID1
            // 
            movieID1.Location = new Point(23, 615);
            movieID1.Name = "movieID1";
            movieID1.PlaceholderText = "Movie ID...";
            movieID1.Size = new Size(147, 23);
            movieID1.TabIndex = 18;
            // 
            // data
            // 
            data.BackgroundColor = Color.White;
            data.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            data.GridColor = Color.FromArgb(52, 71, 105);
            data.Location = new Point(26, 189);
            data.Name = "data";
            data.RowTemplate.Height = 25;
            data.Size = new Size(306, 374);
            data.TabIndex = 17;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(62, 137, 207);
            button1.FlatAppearance.BorderColor = Color.FromArgb(62, 137, 207);
            button1.FlatStyle = FlatStyle.Flat;
            button1.ForeColor = SystemColors.ButtonHighlight;
            button1.Location = new Point(192, 645);
            button1.Name = "button1";
            button1.Size = new Size(147, 23);
            button1.TabIndex = 29;
            button1.Text = "Remove Movie from List";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Gadugi", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.ButtonHighlight;
            label2.Location = new Point(205, 596);
            label2.Name = "label2";
            label2.RightToLeft = RightToLeft.No;
            label2.Size = new Size(118, 16);
            label2.TabIndex = 28;
            label2.Text = "Don't Wanna Watch?";
            // 
            // movieID2
            // 
            movieID2.Location = new Point(192, 615);
            movieID2.Name = "movieID2";
            movieID2.PlaceholderText = "Movie ID...";
            movieID2.Size = new Size(147, 23);
            movieID2.TabIndex = 27;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Gadugi", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = Color.FromArgb(116, 167, 215);
            label4.Location = new Point(199, 120);
            label4.Name = "label4";
            label4.Size = new Size(129, 22);
            label4.TabIndex = 33;
            label4.Text = "Sort by Genre:";
            // 
            // username_lbl
            // 
            username_lbl.AutoSize = true;
            username_lbl.BackColor = Color.Transparent;
            username_lbl.Font = new Font("Gadugi", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            username_lbl.ForeColor = Color.FromArgb(116, 167, 215);
            username_lbl.Location = new Point(26, 120);
            username_lbl.Name = "username_lbl";
            username_lbl.Size = new Size(114, 22);
            username_lbl.TabIndex = 32;
            username_lbl.Text = "Sort By Title:";
            // 
            // GenreCbox
            // 
            GenreCbox.Font = new Font("Gadugi", 12F, FontStyle.Regular, GraphicsUnit.Point);
            GenreCbox.FormattingEnabled = true;
            GenreCbox.Location = new Point(199, 145);
            GenreCbox.Name = "GenreCbox";
            GenreCbox.Size = new Size(133, 27);
            GenreCbox.TabIndex = 31;
            GenreCbox.SelectedIndexChanged += GenreCbox_SelectedIndexChanged;
            // 
            // azCBox
            // 
            azCBox.Font = new Font("Gadugi", 12F, FontStyle.Regular, GraphicsUnit.Point);
            azCBox.FormattingEnabled = true;
            azCBox.Items.AddRange(new object[] { "A-Z", "Z-A" });
            azCBox.Location = new Point(26, 145);
            azCBox.Name = "azCBox";
            azCBox.Size = new Size(135, 27);
            azCBox.TabIndex = 30;
            azCBox.SelectedIndexChanged += azCBox_SelectedIndexChanged;
            // 
            // viewall_btn
            // 
            viewall_btn.BackColor = Color.FromArgb(67, 137, 207);
            viewall_btn.FlatAppearance.BorderColor = Color.FromArgb(67, 137, 207);
            viewall_btn.FlatStyle = FlatStyle.Flat;
            viewall_btn.Font = new Font("Gadugi", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            viewall_btn.ForeColor = SystemColors.ButtonHighlight;
            viewall_btn.Location = new Point(248, 565);
            viewall_btn.Name = "viewall_btn";
            viewall_btn.Size = new Size(84, 25);
            viewall_btn.TabIndex = 34;
            viewall_btn.Text = "View All";
            viewall_btn.UseVisualStyleBackColor = false;
            viewall_btn.Click += viewall_btn_Click;
            // 
            // Watch_List
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.background_app;
            ClientSize = new Size(357, 776);
            Controls.Add(viewall_btn);
            Controls.Add(label4);
            Controls.Add(username_lbl);
            Controls.Add(GenreCbox);
            Controls.Add(azCBox);
            Controls.Add(button1);
            Controls.Add(label2);
            Controls.Add(movieID2);
            Controls.Add(label3);
            Controls.Add(go_watched);
            Controls.Add(go_search);
            Controls.Add(add_watchlist);
            Controls.Add(label1);
            Controls.Add(movieID1);
            Controls.Add(data);
            Controls.Add(Watched_list_lbl);
            Name = "Watch_List";
            Text = "Watched_List";
            Load += Watch_List_Load;
            ((System.ComponentModel.ISupportInitialize)data).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label Watched_list_lbl;
        private Label label3;
        private Button go_watched;
        private Button go_search;
        private Button add_watchlist;
        private Label label1;
        private TextBox movieID1;
        private DataGridView data;
        private Button button1;
        private Label label2;
        private TextBox movieID2;
        private Label label4;
        private Label username_lbl;
        private ComboBox GenreCbox;
        private ComboBox azCBox;
        private Button viewall_btn;
    }
}