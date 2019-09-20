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
        static public SortedSet<Comment> myComments = new SortedSet<Comment>();
        static public SortedSet<Comment> myCommentsReplies = new SortedSet<Comment>();
        static public SortedSet<Subreddit> mySubReddits = new SortedSet<Subreddit>();
        static public SortedSet<User> myUsers = new SortedSet<User>();


        public RedditForm()
        {
            //Read the input files here to build the objects
            HelperFunctions.getFileInput(myPosts, myComments, mySubReddits, myUsers);
            InitializeComponent(); //This needs to be towards the top of the program!!!



            foreach (User user in myUsers) //populate the user listBox
            {
                userListBox.Items.Add(user.ToString());
            }

     

        }

        private void LoggedInLoad()
        {
            if (authenticated)
            {
                foreach (Subreddit sub in mySubReddits) //populate the subreddit listBox
                {
                    subredditListBox.Items.Add(sub.ToString());
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

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
                LoggedInLoad();
            }
            else //This is to log out
            {
                currentUserID = null;
                userListBox.Enabled = true;
                authenticated = false;
                login.Text = "Login";
                ClearDataInListBoxes();
            }
        }
         
        private void ClearDataInListBoxes()
        {
            subredditListBox.Items.Clear();
        }
 
    }
}
