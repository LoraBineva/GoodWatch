namespace FinalEda
{
    partial class Search
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
            search_box = new TextBox();
            category = new ComboBox();
            search_button = new PictureBox();
            hi_user = new Label();
            dataGridView1 = new DataGridView();
            movieID1 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            movieID2 = new TextBox();
            add_watchlist = new Button();
            add_watched = new Button();
            go_watchlist = new Button();
            go_watched = new Button();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)search_button).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // search_box
            // 
            search_box.Location = new Point(26, 92);
            search_box.Name = "search_box";
            search_box.PlaceholderText = "Search...";
            search_box.Size = new Size(194, 23);
            search_box.TabIndex = 0;
            // 
            // category
            // 
            category.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            category.ForeColor = Color.FromArgb(64, 64, 64);
            category.FormattingEnabled = true;
            category.Items.AddRange(new object[] { "Title", "Genre", "Director", "Language" });
            category.Location = new Point(217, 92);
            category.Name = "category";
            category.Size = new Size(92, 23);
            category.TabIndex = 1;
            category.Text = "Category";
            // 
            // search_button
            // 
            search_button.BackColor = Color.FromArgb(62, 137, 207);
            search_button.BackgroundImage = Final_Eda.Properties.Resources._1965ab7ef7de87fe748b3c66efbfc73a_removebg_preview__1_;
            search_button.Location = new Point(308, 92);
            search_button.Name = "search_button";
            search_button.Size = new Size(24, 23);
            search_button.TabIndex = 2;
            search_button.TabStop = false;
            search_button.Click += search_button_Click;
            // 
            // hi_user
            // 
            hi_user.AutoSize = true;
            hi_user.BackColor = Color.Transparent;
            hi_user.Font = new Font("Gadugi", 12F, FontStyle.Italic, GraphicsUnit.Point);
            hi_user.ForeColor = SystemColors.ButtonHighlight;
            hi_user.Location = new Point(186, 53);
            hi_user.Name = "hi_user";
            hi_user.Size = new Size(0, 19);
            hi_user.TabIndex = 3;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = Color.White;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.GridColor = Color.FromArgb(52, 71, 105);
            dataGridView1.Location = new Point(26, 131);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(306, 374);
            dataGridView1.TabIndex = 4;
            // 
            // movieID1
            // 
            movieID1.Location = new Point(26, 542);
            movieID1.Name = "movieID1";
            movieID1.PlaceholderText = "Movie ID...";
            movieID1.Size = new Size(136, 23);
            movieID1.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Gadugi", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(26, 524);
            label1.Name = "label1";
            label1.RightToLeft = RightToLeft.No;
            label1.Size = new Size(136, 16);
            label1.TabIndex = 6;
            label1.Text = "Add movie to Watchlist?";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Gadugi", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.ButtonHighlight;
            label2.Location = new Point(197, 524);
            label2.Name = "label2";
            label2.RightToLeft = RightToLeft.No;
            label2.Size = new Size(134, 16);
            label2.TabIndex = 8;
            label2.Text = "Add movie to Watched?";
            // 
            // movieID2
            // 
            movieID2.Location = new Point(196, 542);
            movieID2.Name = "movieID2";
            movieID2.PlaceholderText = "Movie ID...";
            movieID2.Size = new Size(136, 23);
            movieID2.TabIndex = 7;
            // 
            // add_watchlist
            // 
            add_watchlist.BackColor = Color.FromArgb(62, 137, 207);
            add_watchlist.FlatAppearance.BorderColor = Color.FromArgb(62, 137, 207);
            add_watchlist.FlatStyle = FlatStyle.Flat;
            add_watchlist.ForeColor = SystemColors.ButtonHighlight;
            add_watchlist.Location = new Point(26, 572);
            add_watchlist.Name = "add_watchlist";
            add_watchlist.Size = new Size(136, 23);
            add_watchlist.TabIndex = 9;
            add_watchlist.Text = "Add";
            add_watchlist.UseVisualStyleBackColor = false;
            add_watchlist.Click += add_watchlist_Click;
            // 
            // add_watched
            // 
            add_watched.BackColor = Color.FromArgb(62, 137, 207);
            add_watched.FlatAppearance.BorderColor = Color.FromArgb(62, 137, 207);
            add_watched.FlatStyle = FlatStyle.Flat;
            add_watched.ForeColor = SystemColors.ButtonHighlight;
            add_watched.Location = new Point(196, 571);
            add_watched.Name = "add_watched";
            add_watched.Size = new Size(136, 23);
            add_watched.TabIndex = 10;
            add_watched.Text = "Add";
            add_watched.UseVisualStyleBackColor = false;
            add_watched.Click += add_watched_Click;
            // 
            // go_watchlist
            // 
            go_watchlist.BackColor = Color.FromArgb(67, 137, 207);
            go_watchlist.FlatAppearance.BorderColor = Color.FromArgb(67, 137, 207);
            go_watchlist.FlatStyle = FlatStyle.Flat;
            go_watchlist.Font = new Font("Gadugi", 12F, FontStyle.Regular, GraphicsUnit.Point);
            go_watchlist.ForeColor = SystemColors.ButtonHighlight;
            go_watchlist.Location = new Point(26, 656);
            go_watchlist.Name = "go_watchlist";
            go_watchlist.Size = new Size(306, 37);
            go_watchlist.TabIndex = 11;
            go_watchlist.Text = "Watchlist";
            go_watchlist.UseVisualStyleBackColor = false;
            go_watchlist.Click += go_watchlist_Click;
            // 
            // go_watched
            // 
            go_watched.BackColor = Color.FromArgb(67, 137, 207);
            go_watched.FlatAppearance.BorderColor = Color.FromArgb(67, 137, 207);
            go_watched.FlatStyle = FlatStyle.Flat;
            go_watched.Font = new Font("Gadugi", 12F, FontStyle.Regular, GraphicsUnit.Point);
            go_watched.ForeColor = SystemColors.ButtonHighlight;
            go_watched.Location = new Point(26, 711);
            go_watched.Name = "go_watched";
            go_watched.Size = new Size(306, 37);
            go_watched.TabIndex = 12;
            go_watched.Text = "Watched";
            go_watched.UseVisualStyleBackColor = false;
            go_watched.Click += go_watched_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Gadugi", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = SystemColors.ButtonHighlight;
            label3.Location = new Point(23, 630);
            label3.Name = "label3";
            label3.Size = new Size(101, 22);
            label3.TabIndex = 13;
            label3.Text = "Check Out:";
            // 
            // Search
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Final_Eda.Properties.Resources.background_app;
            ClientSize = new Size(357, 776);
            Controls.Add(label3);
            Controls.Add(go_watched);
            Controls.Add(go_watchlist);
            Controls.Add(add_watched);
            Controls.Add(add_watchlist);
            Controls.Add(label2);
            Controls.Add(movieID2);
            Controls.Add(label1);
            Controls.Add(movieID1);
            Controls.Add(dataGridView1);
            Controls.Add(hi_user);
            Controls.Add(search_button);
            Controls.Add(category);
            Controls.Add(search_box);
            Name = "Search";
            Text = "Search";
            Load += Search_Load;
            ((System.ComponentModel.ISupportInitialize)search_button).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox search_box;
        private ComboBox category;
        private PictureBox search_button;
        private Label hi_user;
        private DataGridView dataGridView1;
        private TextBox movieID1;
        private Label label1;
        private Label label2;
        private TextBox movieID2;
        private Button add_watchlist;
        private Button add_watched;
        private Button go_watchlist;
        private Button go_watched;
        private Label label3;
    }
}