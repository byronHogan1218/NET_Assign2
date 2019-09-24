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
            this.SuspendLayout();
            // 
            // subredditListBox
            // 
            this.subredditListBox.FormattingEnabled = true;
            this.subredditListBox.ItemHeight = 16;
            this.subredditListBox.Location = new System.Drawing.Point(188, 31);
            this.subredditListBox.Margin = new System.Windows.Forms.Padding(4);
            this.subredditListBox.Name = "subredditListBox";
            this.subredditListBox.Size = new System.Drawing.Size(155, 116);
            this.subredditListBox.TabIndex = 0;
            this.subredditListBox.SelectedIndexChanged += new System.EventHandler(this.SubredditListBox_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(188, 11);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Subreddits";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 11);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Users";
            // 
            // userListBox
            // 
            this.userListBox.FormattingEnabled = true;
            this.userListBox.ItemHeight = 16;
            this.userListBox.Location = new System.Drawing.Point(20, 31);
            this.userListBox.Margin = new System.Windows.Forms.Padding(4);
            this.userListBox.Name = "userListBox";
            this.userListBox.Size = new System.Drawing.Size(159, 116);
            this.userListBox.TabIndex = 3;
            // 
            // loginBtn
            // 
            this.loginBtn.Location = new System.Drawing.Point(80, 155);
            this.loginBtn.Margin = new System.Windows.Forms.Padding(4);
            this.loginBtn.Name = "loginBtn";
            this.loginBtn.Size = new System.Drawing.Size(100, 28);
            this.loginBtn.TabIndex = 4;
            this.loginBtn.Text = "Login";
            this.loginBtn.UseVisualStyleBackColor = true;
            this.loginBtn.Click += new System.EventHandler(this.LoginBtn_Click);
            // 
            // systemOutListBox
            // 
            this.systemOutListBox.FormattingEnabled = true;
            this.systemOutListBox.ItemHeight = 16;
            this.systemOutListBox.Location = new System.Drawing.Point(53, 380);
            this.systemOutListBox.Margin = new System.Windows.Forms.Padding(4);
            this.systemOutListBox.Name = "systemOutListBox";
            this.systemOutListBox.Size = new System.Drawing.Size(837, 132);
            this.systemOutListBox.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(64, 361);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "System Output";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(353, 11);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "Posts";
            // 
            // postListBox
            // 
            this.postListBox.FormattingEnabled = true;
            this.postListBox.ItemHeight = 16;
            this.postListBox.Location = new System.Drawing.Point(352, 31);
            this.postListBox.Margin = new System.Windows.Forms.Padding(4);
            this.postListBox.Name = "postListBox";
            this.postListBox.Size = new System.Drawing.Size(600, 116);
            this.postListBox.TabIndex = 8;
            this.postListBox.SelectedIndexChanged += new System.EventHandler(this.PostListBox_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 199);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 17);
            this.label5.TabIndex = 9;
            this.label5.Text = "Comments";
            // 
            // addReplyTextBox
            // 
            this.addReplyTextBox.Enabled = false;
            this.addReplyTextBox.Location = new System.Drawing.Point(599, 219);
            this.addReplyTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.addReplyTextBox.Multiline = true;
            this.addReplyTextBox.Name = "addReplyTextBox";
            this.addReplyTextBox.Size = new System.Drawing.Size(277, 114);
            this.addReplyTextBox.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(595, 199);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 17);
            this.label6.TabIndex = 13;
            this.label6.Text = "Add Reply";
            // 
            // addReplyBtn
            // 
            this.addReplyBtn.Location = new System.Drawing.Point(777, 341);
            this.addReplyBtn.Margin = new System.Windows.Forms.Padding(4);
            this.addReplyBtn.Name = "addReplyBtn";
            this.addReplyBtn.Size = new System.Drawing.Size(100, 28);
            this.addReplyBtn.TabIndex = 14;
            this.addReplyBtn.Text = "Add Reply";
            this.addReplyBtn.UseVisualStyleBackColor = true;
            this.addReplyBtn.Click += new System.EventHandler(this.AddReplyBtn_Click);
            // 
            // commentListBox
            // 
            this.commentListBox.FormattingEnabled = true;
            this.commentListBox.ItemHeight = 16;
            this.commentListBox.Location = new System.Drawing.Point(16, 219);
            this.commentListBox.Margin = new System.Windows.Forms.Padding(4);
            this.commentListBox.Name = "commentListBox";
            this.commentListBox.Size = new System.Drawing.Size(573, 132);
            this.commentListBox.TabIndex = 15;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(351, 155);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(69, 17);
            this.label7.TabIndex = 17;
            this.label7.Text = "Password";
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.Location = new System.Drawing.Point(187, 155);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.Size = new System.Drawing.Size(156, 22);
            this.passwordTextBox.TabIndex = 18;
            this.passwordTextBox.TextChanged += new System.EventHandler(this.PasswordTextBox_TextChanged);
            // 
            // passwordOutTest
            // 
            this.passwordOutTest.Enabled = false;
            this.passwordOutTest.Location = new System.Drawing.Point(637, 506);
            this.passwordOutTest.Margin = new System.Windows.Forms.Padding(4);
            this.passwordOutTest.Multiline = true;
            this.passwordOutTest.Name = "passwordOutTest";
            this.passwordOutTest.Size = new System.Drawing.Size(212, 48);
            this.passwordOutTest.TabIndex = 19;
            // 
            // hexTest
            // 
            this.hexTest.Enabled = false;
            this.hexTest.Location = new System.Drawing.Point(857, 506);
            this.hexTest.Margin = new System.Windows.Forms.Padding(4);
            this.hexTest.Multiline = true;
            this.hexTest.Name = "hexTest";
            this.hexTest.Size = new System.Drawing.Size(212, 48);
            this.hexTest.TabIndex = 20;
            // 
            // RedditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.hexTest);
            this.Controls.Add(this.passwordOutTest);
            this.Controls.Add(this.passwordTextBox);
            this.Controls.Add(this.label7);
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
            this.Margin = new System.Windows.Forms.Padding(4);
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
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox passwordTextBox;
        private System.Windows.Forms.TextBox passwordOutTest;
        private System.Windows.Forms.TextBox hexTest;
    }
}

