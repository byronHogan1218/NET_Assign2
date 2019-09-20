namespace BigBadBolts_Assign2
{
    partial class RedditForm
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
            this.subredditListBox = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.userListBox = new System.Windows.Forms.ListBox();
            this.loginBtn = new System.Windows.Forms.Button();
            this.systemOutListBox = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.postListBox = new System.Windows.Forms.ListBox();
            this.label5 = new System.Windows.Forms.Label();
            this.addReplyTextBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.addReplyBtn = new System.Windows.Forms.Button();
            this.commentListBox = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // subredditListBox
            // 
            this.subredditListBox.FormattingEnabled = true;
            this.subredditListBox.Location = new System.Drawing.Point(141, 25);
            this.subredditListBox.Name = "subredditListBox";
            this.subredditListBox.Size = new System.Drawing.Size(117, 95);
            this.subredditListBox.TabIndex = 0;
            this.subredditListBox.SelectedIndexChanged += new System.EventHandler(this.SubredditListBox_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(141, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Subreddits";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Users";
            // 
            // userListBox
            // 
            this.userListBox.FormattingEnabled = true;
            this.userListBox.Location = new System.Drawing.Point(15, 25);
            this.userListBox.Name = "userListBox";
            this.userListBox.Size = new System.Drawing.Size(120, 95);
            this.userListBox.TabIndex = 3;
            // 
            // loginBtn
            // 
            this.loginBtn.Location = new System.Drawing.Point(60, 126);
            this.loginBtn.Name = "loginBtn";
            this.loginBtn.Size = new System.Drawing.Size(75, 23);
            this.loginBtn.TabIndex = 4;
            this.loginBtn.Text = "Login";
            this.loginBtn.UseVisualStyleBackColor = true;
            this.loginBtn.Click += new System.EventHandler(this.LoginBtn_Click);
            // 
            // systemOutListBox
            // 
            this.systemOutListBox.FormattingEnabled = true;
            this.systemOutListBox.Location = new System.Drawing.Point(40, 309);
            this.systemOutListBox.Name = "systemOutListBox";
            this.systemOutListBox.Size = new System.Drawing.Size(629, 108);
            this.systemOutListBox.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(48, 293);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "System Output";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(265, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Posts";
            // 
            // postListBox
            // 
            this.postListBox.FormattingEnabled = true;
            this.postListBox.Location = new System.Drawing.Point(264, 25);
            this.postListBox.Name = "postListBox";
            this.postListBox.Size = new System.Drawing.Size(451, 95);
            this.postListBox.TabIndex = 8;
            this.postListBox.SelectedIndexChanged += new System.EventHandler(this.PostListBox_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 162);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Comments";
            // 
            // addReplyTextBox
            // 
            this.addReplyTextBox.Enabled = false;
            this.addReplyTextBox.Location = new System.Drawing.Point(449, 178);
            this.addReplyTextBox.Multiline = true;
            this.addReplyTextBox.Name = "addReplyTextBox";
            this.addReplyTextBox.Size = new System.Drawing.Size(209, 93);
            this.addReplyTextBox.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(446, 162);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Add Reply";
            // 
            // addReplyBtn
            // 
            this.addReplyBtn.Location = new System.Drawing.Point(583, 277);
            this.addReplyBtn.Name = "addReplyBtn";
            this.addReplyBtn.Size = new System.Drawing.Size(75, 23);
            this.addReplyBtn.TabIndex = 14;
            this.addReplyBtn.Text = "Add Reply";
            this.addReplyBtn.UseVisualStyleBackColor = true;
            this.addReplyBtn.Click += new System.EventHandler(this.AddReplyBtn_Click);
            // 
            // commentListBox
            // 
            this.commentListBox.FormattingEnabled = true;
            this.commentListBox.Location = new System.Drawing.Point(12, 178);
            this.commentListBox.Name = "commentListBox";
            this.commentListBox.Size = new System.Drawing.Size(431, 108);
            this.commentListBox.TabIndex = 15;
            // 
            // RedditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.commentListBox);
            this.Controls.Add(this.addReplyBtn);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.addReplyTextBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.postListBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.systemOutListBox);
            this.Controls.Add(this.loginBtn);
            this.Controls.Add(this.userListBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.subredditListBox);
            this.Name = "RedditForm";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox subredditListBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox userListBox;
        private System.Windows.Forms.Button loginBtn;
        private System.Windows.Forms.ListBox systemOutListBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox postListBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox addReplyTextBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button addReplyBtn;
        private System.Windows.Forms.ListBox commentListBox;
    }
}

