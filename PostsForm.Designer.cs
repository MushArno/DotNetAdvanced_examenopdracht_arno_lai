namespace DotNetAdvanced_examenopdracht_arno_lai
{
    partial class PostsForm
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
            this.lb_title = new System.Windows.Forms.Label();
            this.numeric_select_post = new System.Windows.Forms.NumericUpDown();
            this.btn_search_post = new System.Windows.Forms.Button();
            this.lb_post_id = new System.Windows.Forms.Label();
            this.lb_category = new System.Windows.Forms.Label();
            this.lb_date = new System.Windows.Forms.Label();
            this.PostsDataGridView = new System.Windows.Forms.DataGridView();
            this.btn_previous = new System.Windows.Forms.Button();
            this.btn_next = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numeric_select_post)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PostsDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // lb_title
            // 
            this.lb_title.AutoSize = true;
            this.lb_title.Location = new System.Drawing.Point(12, 12);
            this.lb_title.Name = "lb_title";
            this.lb_title.Size = new System.Drawing.Size(27, 15);
            this.lb_title.TabIndex = 1;
            this.lb_title.Text = "title";
            // 
            // numeric_select_post
            // 
            this.numeric_select_post.Location = new System.Drawing.Point(428, 41);
            this.numeric_select_post.Name = "numeric_select_post";
            this.numeric_select_post.Size = new System.Drawing.Size(75, 23);
            this.numeric_select_post.TabIndex = 2;
            // 
            // btn_search_post
            // 
            this.btn_search_post.Location = new System.Drawing.Point(428, 12);
            this.btn_search_post.Name = "btn_search_post";
            this.btn_search_post.Size = new System.Drawing.Size(75, 23);
            this.btn_search_post.TabIndex = 3;
            this.btn_search_post.Text = "Search";
            this.btn_search_post.UseVisualStyleBackColor = true;
            this.btn_search_post.Click += new System.EventHandler(this.btn_search_post_Click);
            // 
            // lb_post_id
            // 
            this.lb_post_id.AutoSize = true;
            this.lb_post_id.Location = new System.Drawing.Point(378, 43);
            this.lb_post_id.Name = "lb_post_id";
            this.lb_post_id.Size = new System.Drawing.Size(44, 15);
            this.lb_post_id.TabIndex = 4;
            this.lb_post_id.Text = "Post ID";
            // 
            // lb_category
            // 
            this.lb_category.AutoSize = true;
            this.lb_category.Location = new System.Drawing.Point(12, 41);
            this.lb_category.Name = "lb_category";
            this.lb_category.Size = new System.Drawing.Size(53, 15);
            this.lb_category.TabIndex = 5;
            this.lb_category.Text = "category";
            // 
            // lb_date
            // 
            this.lb_date.AutoSize = true;
            this.lb_date.Location = new System.Drawing.Point(12, 67);
            this.lb_date.Name = "lb_date";
            this.lb_date.Size = new System.Drawing.Size(30, 15);
            this.lb_date.TabIndex = 6;
            this.lb_date.Text = "date";
            // 
            // PostsDataGridView
            // 
            this.PostsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.PostsDataGridView.Location = new System.Drawing.Point(12, 146);
            this.PostsDataGridView.Name = "PostsDataGridView";
            this.PostsDataGridView.RowTemplate.Height = 25;
            this.PostsDataGridView.Size = new System.Drawing.Size(553, 174);
            this.PostsDataGridView.TabIndex = 0;
            // 
            // btn_previous
            // 
            this.btn_previous.Location = new System.Drawing.Point(12, 337);
            this.btn_previous.Name = "btn_previous";
            this.btn_previous.Size = new System.Drawing.Size(75, 23);
            this.btn_previous.TabIndex = 7;
            this.btn_previous.Text = "Previous";
            this.btn_previous.UseVisualStyleBackColor = true;
            this.btn_previous.Click += new System.EventHandler(this.btn_previous_Click);
            // 
            // btn_next
            // 
            this.btn_next.Location = new System.Drawing.Point(490, 337);
            this.btn_next.Name = "btn_next";
            this.btn_next.Size = new System.Drawing.Size(75, 23);
            this.btn_next.TabIndex = 8;
            this.btn_next.Text = "Next";
            this.btn_next.UseVisualStyleBackColor = true;
            this.btn_next.Click += new System.EventHandler(this.btn_next_Click);
            // 
            // PostsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(577, 370);
            this.Controls.Add(this.btn_next);
            this.Controls.Add(this.btn_previous);
            this.Controls.Add(this.lb_date);
            this.Controls.Add(this.lb_category);
            this.Controls.Add(this.lb_post_id);
            this.Controls.Add(this.btn_search_post);
            this.Controls.Add(this.numeric_select_post);
            this.Controls.Add(this.lb_title);
            this.Controls.Add(this.PostsDataGridView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "PostsForm";
            this.Text = "Posts";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.PostsForm_FormClosed);
            this.Load += new System.EventHandler(this.PostsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numeric_select_post)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PostsDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Label lb_title;
        private NumericUpDown numeric_select_post;
        private Button btn_search_post;
        private Label lb_post_id;
        private Label lb_category;
        private Label lb_date;
        private DataGridView PostsDataGridView;
        private Button btn_previous;
        private Button btn_next;
    }
}