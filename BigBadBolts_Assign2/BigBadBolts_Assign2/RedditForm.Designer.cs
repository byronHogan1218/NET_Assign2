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
            this.label7 = new System.Windows.Forms.Label();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.passwordOutTest = new System.Windows.Forms.TextBox();
            this.hexTest = new System.Windows.Forms.TextBox();
            this.membersTileLabel = new System.Windows.Forms.Label();
            this.activeTitleLabel = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.membersNumberLabel = new System.Windows.Forms.Label();
            this.activeNumberLabel = new System.Windows.Forms.Label();
            this.deletePostBtn = new System.Windows.Forms.Button();
            this.deleteCommentBtn = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // subredditListBox
            // 
            this.subredditListBox.FormattingEnabled = true;
            this.subredditListBox.Location = new System.Drawing.Point(179, 25);
            this.subredditListBox.Name = "subredditListBox";
            this.subredditListBox.Size = new System.Drawing.Size(117, 134);
            this.subredditListBox.TabIndex = 0;
            this.subredditListBox.SelectedIndexChanged += new System.EventHandler(this.SubredditListBox_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(176, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Subreddits";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 1);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Users";
            // 
            // userListBox
            // 
            this.userListBox.FormattingEnabled = true;
            this.userListBox.Location = new System.Drawing.Point(6, 17);
            this.userListBox.Name = "userListBox";
            this.userListBox.Size = new System.Drawing.Size(137, 95);
            this.userListBox.TabIndex = 3;
            // 
            // loginBtn
            // 
            this.loginBtn.Location = new System.Drawing.Point(31, 154);
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
            this.systemOutListBox.Location = new System.Drawing.Point(40, 371);
            this.systemOutListBox.Name = "systemOutListBox";
            this.systemOutListBox.Size = new System.Drawing.Size(629, 108);
            this.systemOutListBox.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(37, 355);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "System Output";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(299, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Posts";
            // 
            // postListBox
            // 
            this.postListBox.FormattingEnabled = true;
            this.postListBox.Location = new System.Drawing.Point(302, 25);
            this.postListBox.Name = "postListBox";
            this.postListBox.Size = new System.Drawing.Size(470, 134);
            this.postListBox.TabIndex = 8;
            this.postListBox.SelectedIndexChanged += new System.EventHandler(this.PostListBox_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 215);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Comments";
            // 
            // addReplyTextBox
            // 
            this.addReplyTextBox.Enabled = false;
            this.addReplyTextBox.Location = new System.Drawing.Point(449, 230);
            this.addReplyTextBox.Multiline = true;
            this.addReplyTextBox.Name = "addReplyTextBox";
            this.addReplyTextBox.Size = new System.Drawing.Size(209, 93);
            this.addReplyTextBox.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(446, 214);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Add Reply";
            // 
            // addReplyBtn
            // 
            this.addReplyBtn.Enabled = false;
            this.addReplyBtn.Location = new System.Drawing.Point(594, 329);
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
            this.commentListBox.Location = new System.Drawing.Point(12, 231);
            this.commentListBox.Name = "commentListBox";
            this.commentListBox.Size = new System.Drawing.Size(431, 121);
            this.commentListBox.TabIndex = 15;
            this.commentListBox.SelectedIndexChanged += new System.EventHandler(this.CommentListBox_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(0, 114);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 13);
            this.label7.TabIndex = 17;
            this.label7.Text = "Password";
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.Location = new System.Drawing.Point(6, 129);
            this.passwordTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.Size = new System.Drawing.Size(137, 20);
            this.passwordTextBox.TabIndex = 18;
            this.passwordTextBox.TextChanged += new System.EventHandler(this.PasswordTextBox_TextChanged);
            // 
            // passwordOutTest
            // 
            this.passwordOutTest.Enabled = false;
            this.passwordOutTest.Location = new System.Drawing.Point(557, 215);
            this.passwordOutTest.Multiline = true;
            this.passwordOutTest.Name = "passwordOutTest";
            this.passwordOutTest.Size = new System.Drawing.Size(160, 40);
            this.passwordOutTest.TabIndex = 19;
            // 
            // hexTest
            // 
            this.hexTest.Enabled = false;
            this.hexTest.Location = new System.Drawing.Point(557, 269);
            this.hexTest.Multiline = true;
            this.hexTest.Name = "hexTest";
            this.hexTest.Size = new System.Drawing.Size(160, 40);
            this.hexTest.TabIndex = 20;
            // 
            // membersTileLabel
            // 
            this.membersTileLabel.AutoSize = true;
            this.membersTileLabel.Location = new System.Drawing.Point(176, 162);
            this.membersTileLabel.Name = "membersTileLabel";
            this.membersTileLabel.Size = new System.Drawing.Size(56, 13);
            this.membersTileLabel.TabIndex = 21;
            this.membersTileLabel.Text = "Members -";
            // 
            // activeTitleLabel
            // 
            this.activeTitleLabel.AutoSize = true;
            this.activeTitleLabel.Location = new System.Drawing.Point(285, 162);
            this.activeTitleLabel.Name = "activeTitleLabel";
            this.activeTitleLabel.Size = new System.Drawing.Size(43, 13);
            this.activeTitleLabel.TabIndex = 22;
            this.activeTitleLabel.Text = "Active -";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.passwordTextBox);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.loginBtn);
            this.groupBox1.Controls.Add(this.userListBox);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(9, 8);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(149, 185);
            this.groupBox1.TabIndex = 23;
            this.groupBox1.TabStop = false;
            // 
            // membersNumberLabel
            // 
            this.membersNumberLabel.AutoSize = true;
            this.membersNumberLabel.Location = new System.Drawing.Point(238, 162);
            this.membersNumberLabel.Name = "membersNumberLabel";
            this.membersNumberLabel.Size = new System.Drawing.Size(28, 13);
            this.membersNumberLabel.TabIndex = 24;
            this.membersNumberLabel.Text = "###";
            // 
            // activeNumberLabel
            // 
            this.activeNumberLabel.AutoSize = true;
            this.activeNumberLabel.Location = new System.Drawing.Point(328, 162);
            this.activeNumberLabel.Name = "activeNumberLabel";
            this.activeNumberLabel.Size = new System.Drawing.Size(28, 13);
            this.activeNumberLabel.TabIndex = 25;
            this.activeNumberLabel.Text = "###";
            // 
            // deletePostBtn
            // 
            this.deletePostBtn.Enabled = false;
            this.deletePostBtn.Location = new System.Drawing.Point(697, 162);
            this.deletePostBtn.Name = "deletePostBtn";
            this.deletePostBtn.Size = new System.Drawing.Size(75, 23);
            this.deletePostBtn.TabIndex = 26;
            this.deletePostBtn.Text = "Delete Post";
            this.deletePostBtn.UseVisualStyleBackColor = true;
            this.deletePostBtn.Click += new System.EventHandler(this.DeletePostBtn_Click);
            // 
            // deleteCommentBtn
            // 
            this.deleteCommentBtn.Enabled = false;
            this.deleteCommentBtn.Location = new System.Drawing.Point(449, 329);
            this.deleteCommentBtn.Name = "deleteCommentBtn";
            this.deleteCommentBtn.Size = new System.Drawing.Size(96, 23);
            this.deleteCommentBtn.TabIndex = 27;
            this.deleteCommentBtn.Text = "Delete Comment";
            this.deleteCommentBtn.UseVisualStyleBackColor = true;
            this.deleteCommentBtn.Click += new System.EventHandler(this.DeleteCommentBtn_Click);
            // 
            // RedditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 491);
            this.Controls.Add(this.deleteCommentBtn);
            this.Controls.Add(this.deletePostBtn);
            this.Controls.Add(this.activeNumberLabel);
            this.Controls.Add(this.membersNumberLabel);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.activeTitleLabel);
            this.Controls.Add(this.membersTileLabel);
            this.Controls.Add(this.hexTest);
            this.Controls.Add(this.passwordOutTest);
            this.Controls.Add(this.commentListBox);
            this.Controls.Add(this.addReplyBtn);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.addReplyTextBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.postListBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.systemOutListBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.subredditListBox);
            this.Name = "RedditForm";
            this.Text = "SubReddit";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
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
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox passwordTextBox;
        private System.Windows.Forms.TextBox passwordOutTest;
        private System.Windows.Forms.TextBox hexTest;
        private System.Windows.Forms.Label membersTileLabel;
        private System.Windows.Forms.Label activeTitleLabel;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label membersNumberLabel;
        private System.Windows.Forms.Label activeNumberLabel;
        private System.Windows.Forms.Button deletePostBtn;
        private System.Windows.Forms.Button deleteCommentBtn;
    }
}

