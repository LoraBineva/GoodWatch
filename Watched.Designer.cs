namespace Final_Eda
{
    partial class Watched
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
            dataGridView1 = new DataGridView();
            azCBox = new ComboBox();
            GenreCbox = new ComboBox();
            username_lbl = new Label();
            label1 = new Label();
            label3 = new Label();
            go_watchlist = new Button();
            go_search = new Button();
            viewall_btn = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // Watched_list_lbl
            // 
            Watched_list_lbl.AutoSize = true;
            Watched_list_lbl.BackColor = Color.Transparent;
            Watched_list_lbl.Font = new Font("Gadugi", 24F, FontStyle.Bold, GraphicsUnit.Point);
            Watched_list_lbl.ForeColor = Color.FromArgb(116, 167, 215);
            Watched_list_lbl.Location = new Point(47, 102);
            Watched_list_lbl.Name = "Watched_list_lbl";
            Watched_list_lbl.Size = new Size(266, 38);
            Watched_list_lbl.TabIndex = 6;
            Watched_list_lbl.Text = "Watched Movies";
            Watched_list_lbl.TextAlign = ContentAlignment.TopCenter;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = Color.White;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.GridColor = Color.FromArgb(52, 71, 105);
            dataGridView1.Location = new Point(27, 270);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(306, 374);
            dataGridView1.TabIndex = 18;
            // 
            // azCBox
            // 
            azCBox.Font = new Font("Gadugi", 12F, FontStyle.Regular, GraphicsUnit.Point);
            azCBox.FormattingEnabled = true;
            azCBox.Items.AddRange(new object[] { "A-Z", "Z-A" });
            azCBox.Location = new Point(27, 206);
            azCBox.Name = "azCBox";
            azCBox.Size = new Size(135, 27);
            azCBox.TabIndex = 19;
            azCBox.SelectedIndexChanged += azCBox_SelectedIndexChanged;
            // 
            // GenreCbox
            // 
            GenreCbox.Font = new Font("Gadugi", 12F, FontStyle.Regular, GraphicsUnit.Point);
            GenreCbox.FormattingEnabled = true;
            GenreCbox.Location = new Point(200, 206);
            GenreCbox.Name = "GenreCbox";
            GenreCbox.Size = new Size(133, 27);
            GenreCbox.TabIndex = 20;
            GenreCbox.SelectedIndexChanged += GenreCbox_SelectedIndexChanged;
            // 
            // username_lbl
            // 
            username_lbl.AutoSize = true;
            username_lbl.BackColor = Color.Transparent;
            username_lbl.Font = new Font("Gadugi", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            username_lbl.ForeColor = Color.FromArgb(116, 167, 215);
            username_lbl.Location = new Point(27, 181);
            username_lbl.Name = "username_lbl";
            username_lbl.Size = new Size(114, 22);
            username_lbl.TabIndex = 21;
            username_lbl.Text = "Sort By Title:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Gadugi", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(116, 167, 215);
            label1.Location = new Point(200, 181);
            label1.Name = "label1";
            label1.Size = new Size(129, 22);
            label1.TabIndex = 22;
            label1.Text = "Sort By Genre:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Gadugi", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = SystemColors.ButtonHighlight;
            label3.Location = new Point(142, 673);
            label3.Name = "label3";
            label3.Size = new Size(64, 22);
            label3.TabIndex = 29;
            label3.Text = "Go To:";
            // 
            // go_watchlist
            // 
            go_watchlist.BackColor = Color.FromArgb(67, 137, 207);
            go_watchlist.FlatAppearance.BorderColor = Color.FromArgb(67, 137, 207);
            go_watchlist.FlatStyle = FlatStyle.Flat;
            go_watchlist.Font = new Font("Gadugi", 12F, FontStyle.Regular, GraphicsUnit.Point);
            go_watchlist.ForeColor = SystemColors.ButtonHighlight;
            go_watchlist.Location = new Point(186, 707);
            go_watchlist.Name = "go_watchlist";
            go_watchlist.Size = new Size(147, 37);
            go_watchlist.TabIndex = 28;
            go_watchlist.Text = "Watch List";
            go_watchlist.UseVisualStyleBackColor = false;
            go_watchlist.Click += go_watchlist_Click;
            // 
            // go_search
            // 
            go_search.BackColor = Color.FromArgb(67, 137, 207);
            go_search.FlatAppearance.BorderColor = Color.FromArgb(67, 137, 207);
            go_search.FlatStyle = FlatStyle.Flat;
            go_search.Font = new Font("Gadugi", 12F, FontStyle.Regular, GraphicsUnit.Point);
            go_search.ForeColor = SystemColors.ButtonHighlight;
            go_search.Location = new Point(17, 707);
            go_search.Name = "go_search";
            go_search.Size = new Size(147, 37);
            go_search.TabIndex = 27;
            go_search.Text = "Search";
            go_search.UseVisualStyleBackColor = false;
            go_search.Click += go_search_Click;
            // 
            // viewall_btn
            // 
            viewall_btn.BackColor = Color.FromArgb(67, 137, 207);
            viewall_btn.FlatAppearance.BorderColor = Color.FromArgb(67, 137, 207);
            viewall_btn.FlatStyle = FlatStyle.Flat;
            viewall_btn.Font = new Font("Gadugi", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            viewall_btn.ForeColor = SystemColors.ButtonHighlight;
            viewall_btn.Location = new Point(249, 650);
            viewall_btn.Name = "viewall_btn";
            viewall_btn.Size = new Size(84, 25);
            viewall_btn.TabIndex = 30;
            viewall_btn.Text = "View All";
            viewall_btn.UseVisualStyleBackColor = false;
            viewall_btn.Click += viewall_btn_Click;
            // 
            // Watched
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.background_app;
            ClientSize = new Size(357, 776);
            Controls.Add(viewall_btn);
            Controls.Add(label3);
            Controls.Add(go_watchlist);
            Controls.Add(go_search);
            Controls.Add(label1);
            Controls.Add(username_lbl);
            Controls.Add(GenreCbox);
            Controls.Add(azCBox);
            Controls.Add(dataGridView1);
            Controls.Add(Watched_list_lbl);
            Name = "Watched";
            Text = "Watched_Listcs";
            Load += Watched_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label Watched_list_lbl;
        private DataGridView dataGridView1;
        private ComboBox azCBox;
        private ComboBox GenreCbox;
        private Label username_lbl;
        private Label label1;
        private Label label3;
        private Button go_watchlist;
        private Button go_search;
        private Button viewall_btn;
    }
}