using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BigBadBolts_Assign2
{


    public partial class RedditForm : Form
    {
        static public Nullable<uint> currentUserID;
        static public bool authenticated = false;
        static public SortedSet<Post> myPosts = new SortedSet<Post>();
         public SortedSet<Comment> myComments = new SortedSet<Comment>();
        static public SortedSet<Comment> myCommentsReplies = new SortedSet<Comment>();
        static public SortedSet<Subreddit> mySubReddits = new SortedSet<Subreddit>();
        static public SortedSet<User> myUsers = new SortedSet<User>();


        public RedditForm()
        {
            //Read the input files here to build the objects
            HelperFunctions.getFileInput(myPosts, myComments, mySubReddits, myUsers);
            InitializeComponent(); //This needs to be towards the top of the program!!!

            LoadTables();
        }

        private void LoadTables()
        {
            foreach (User user in myUsers) //populate the user listBox
            {
                userListBox.Items.Add(user.ToString());
            }
            foreach (Subreddit sub in mySubReddits) //populate the subreddit listBox
            {
                subredditListBox.Items.Add(sub.ToString());
            }
        }

        private void LoginBtn_Click(object sender, EventArgs e)
        {
            //Need to do password stuff here

            if (userListBox.SelectedIndex == -1)//check to make sure an option was selected
            {
                systemOutListBox.Items.Add("Please select a user to login as.");
                return;
            }

            Button login = sender as Button;

            if (login.Text == "Login") //this is to login
            {
                authenticated = true;
                foreach (User user in myUsers)
                {
                    if ((string)userListBox.SelectedItem == user.Name)
                    {
                        currentUserID = user.Id;
                        break;
                    }
                }
                systemOutListBox.Items.Add("We are logged in as user: " + userListBox.SelectedItem);
                login.Text = "Logout";
                userListBox.Enabled = false;

            }
            else //This is to log out
            {
                currentUserID = null;
                authenticated = false;
                userListBox.Enabled = true;
                login.Text = "Login";
            }
        }

        private void SubredditListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            postListBox.Items.Clear();//clear out anything that might have been in it before
            uint subIDToView = 0;
            if ((string)subredditListBox.SelectedItem == "all") //determines if all the posts should be displayed
            {
                foreach (Post post in myPosts)//display all the posts
                {
                    postListBox.Items.Add(post.ToString());
                }
                systemOutListBox.Items.Add("We are getting all the posts");
            }
            else //only a single subbreddits post should be displayed
            {
                foreach (Subreddit sub in mySubReddits) //Find the id of the subbreddit selected
                {
                    if ((string)subredditListBox.SelectedItem == sub.Name) //Found the subbreddit
                    {
                        subIDToView = sub.Id;
                        break;
                    }
                }
                systemOutListBox.Items.Add("We are getting the posts for subbreddit '" + subIDToView + "'");

                foreach (Post subPost in myPosts) // Display all the posts that have the subReddit as its parent
                {
                    if (subIDToView == subPost.SubHome)
                    {
                        postListBox.Items.Add(subPost.ToString());
                    }
                }
            }
        }

        private void PostListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            addReplyTextBox.Enabled = true;
            commentListBox.Items.Clear();//clear out anything that might have been in it before
            uint postIDToView = UInt32.Parse(HelperFunctions.getBetween((string)postListBox.SelectedItem, "<", ">"));

            foreach (Comment comment in myComments) //Find the comments to the post
            {
                if (postIDToView == comment.ParentID) //Found a comment to the post
                {
                    commentListBox.Items.Add(comment.ToString());
                    foreach (Comment reply in myComments)
                    {
                        if (reply.ParentID == comment.CommentID)
                        {
                            commentListBox.Items.Add('\t' + reply.ToString());
                            foreach (Comment AnotherReply in myComments)
                            {
                                if (AnotherReply.ParentID == reply.CommentID)
                                {
                                    commentListBox.Items.Add("\t\t" + AnotherReply.ToString());
                                }
                            }
                        }
                    }

                }
            }
            systemOutListBox.Items.Add("We are getting the comment for post '" + postIDToView + "'");
        }

        private void AddReplyBtn_Click(object sender, EventArgs e)
        {
            if (currentUserID != null)//Make sure user logged in
            {
                if (addReplyTextBox.TextLength > 0) //make sure words are present
                {
                    if (true)//make sure the comment has something listed
                    { 
                        uint commentToReplyID;
                        try { 
                        commentToReplyID = UInt32.Parse(HelperFunctions.getBetween(commentListBox.SelectedItem.ToString(), "<", ">"));
                        }
                        catch (Exception ex)
                        {
                            commentToReplyID = UInt32.Parse(HelperFunctions.getBetween(postListBox.SelectedItem.ToString(), "<", ">"));

                        }
                        systemOutListBox.Items.Add(commentToReplyID.ToString());
                        string content = "";
                        uint ID = 0;
                        foreach (Comment commentToReply in myComments) //Search for the comment to reply to
                        {
                            if (commentToReply.CommentID == commentToReplyID)//Found the comment to reply to
                            {
                                string commentContent = commentListBox.SelectedItem.ToString();
                                try
                                {
                                    if (HelperFunctions.vulgarityChecker(commentContent))
                                    {
                                        throw new HelperFunctions.FoulLanguageException();
                                    }
                                }
                                catch (HelperFunctions.FoulLanguageException fle)
                                {

                                    MessageBox.Show(fle.ToString(), "BAD WORD DETECTED");
                                    return;
                                }
                                content = commentContent;
                                ID = commentToReply.CommentID;
                                //Comment replyToAdd = new Comment(
                                //    commentContent, //content
                                //    (uint)currentUserID, //authorID //THIS IS ROGNESS USER
                                //    commentToReply.CommentID //parentID
                                //    );
                                systemOutListBox.Items.Add("MAKE IT HERE?");
                                //myComments.Add(replyToAdd);
                                //commentListBox.Items.Add(replyToAdd.ToString());
                                addReplyTextBox.Text = "";
                            }
                        }
                        Comment replyToAdd = new Comment(
                                content, //content
                                (uint)currentUserID, //authorID //THIS IS ROGNESS USER
                                ID //parentID
                            );
                        myComments.Add(replyToAdd);
                        commentListBox.Items.Add(replyToAdd.ToString());
                    }

                }
            }
            else//user not logged in
            {
                return;
            }
        }
    }
}
