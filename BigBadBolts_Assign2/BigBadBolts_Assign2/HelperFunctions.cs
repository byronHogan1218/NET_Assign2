using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


namespace BigBadBolts_Assign2
{
    class HelperFunctions
    {
       

        static public List<string> BANNED_WORDS = new List<string>()
        {
            "fudge","shoot","baddie","butthead"
        };

        /**
   * This is the definition of the foul language exception
   * 
   * returns:  A string indicationg that a FLE occured
   */
        public class FoulLanguageException : Exception
        {
            public override string ToString()
            {
                return "You seem to have included a bad word in your message. Please avoid doing this in the future";
            }
        }

        /**
         * This is a helper function that can be called to check for profanity.
         * Parameters: This takes a string and will check the entire thing for profanity somewhere in it
         * Returns:   This will return true if profanity has been found.
         */
        static public bool vulgarityChecker(string s)
        {
            foreach (string badWord in BANNED_WORDS) // Check each word in the bad words if they appear in the passed string
            {
                if (s.ToLower().Contains(badWord))
                { //Found a bad word!
                    return true;
                }
            }
            // The string is clean of bad words,return false
            return false;
        }

        /**
         * This function gets and reads input from files provided to us. 
         * Parameters: myPosts- a SortedSet of post objects to fill with post info
         *             myComments - a SortedSet of Comment objects to fill with comment info
         *             mySubreddits - Sorted set of Subreddit objects
         *             myUsers - Sorted set of user objects
         */
        static public void getFileInput(SortedSet<Post> myPosts, SortedSet<Comment> myComments, SortedSet<Subreddit> mySubreddits, SortedSet<User> myUsers)
        {
            string currentLine;
            string[] tokens;

            //This will read the post file and build the objects from there
            using (StreamReader inFile = new StreamReader("..//..//..//posts.txt"))
            {
                currentLine = inFile.ReadLine(); //prime the read
                while (currentLine != null)
                {
                    tokens = currentLine.Split('\t');

                    string dateString = tokens[8] + '-' + tokens[9] + '-' + tokens[10] + ' ' + tokens[11] + ':' + tokens[12] + ':' + tokens[13];
                    DateTime temp;
                    if (DateTime.TryParse(dateString, out temp))//Makes sure the date converted successfully
                    {
                        Post postToAdd = new Post(//build the post to add
                            UInt32.Parse(tokens[0]),//postId
                            UInt32.Parse(tokens[1]),//authorID
                            tokens[2],//title
                            tokens[3],//postContent
                            UInt32.Parse(tokens[4]),//subHome
                            UInt32.Parse(tokens[5]),//upvotes
                            UInt32.Parse(tokens[6]),//downVotes
                            UInt32.Parse(tokens[7]),//weight
                            temp//dateTime
                            );

                        myPosts.Add(postToAdd);
                    }
                    else //We failed to conver the date
                    {
                        Console.WriteLine("We didn't conver the date properly! QUIT (Handle this better)");
                        return;
                    }
                    currentLine = inFile.ReadLine(); //get the next line
                }
            }

            //This will read the comment file and build the objects from there
            using (StreamReader inFile = new StreamReader("..//..//..//comments.txt"))
            {
                currentLine = inFile.ReadLine(); //prime the read
                while (currentLine != null)
                {
                    tokens = currentLine.Split('\t');

                    string dateString = tokens[6] + '-' + tokens[7] + '-' + tokens[8] + ' ' + tokens[9] + ':' + tokens[10] + ':' + tokens[11];
                    DateTime temp;
                    if (DateTime.TryParse(dateString, out temp))//Make sure the date converted successfully
                    {
                        Comment commentToAdd = new Comment(//build the comment to add
                            UInt32.Parse(tokens[0]),//commentId
                            UInt32.Parse(tokens[1]),//authorID
                            tokens[2],//content
                            UInt32.Parse(tokens[3]),//parentID
                            UInt32.Parse(tokens[4]),//upvotes
                            UInt32.Parse(tokens[5]),//downVotes
                            temp//dateTime
                            );

                        myComments.Add(commentToAdd);
                    }
                    else
                    {
                        Console.WriteLine("We didn't convert the date properly! QUIT (Handle this better)");
                        return;
                    }
                    currentLine = inFile.ReadLine(); //get the next line
                }
            }

            //This will read the the subreddit file and build the objects from them
            using (StreamReader inFile = new StreamReader("..//..//..//subreddits.txt"))
            {
                currentLine = inFile.ReadLine(); //prime the read
                while (currentLine != null)
                {
                    tokens = currentLine.Split('\t');

                    Subreddit newSub = new Subreddit(//build the subreddit
                      UInt32.Parse(tokens[0]),//id
                      tokens[1],//name
                      UInt32.Parse(tokens[2]), //Members
                      UInt32.Parse(tokens[3]) //Active
                    );

                    RedditForm.mySubReddits.Add(newSub);

                    currentLine = inFile.ReadLine(); //get the next line
                }
            }

            //This will get the user information and store it in the user object
            using (StreamReader inFile = new StreamReader("..//..//..//users.txt"))
            {
                currentLine = inFile.ReadLine(); //prime the read
                while (currentLine != null)
                {
                    tokens = currentLine.Split('\t');

                    User newUser = new User(//build the user
                      UInt32.Parse(tokens[0]),//id
                      tokens[1],//name
                      Int32.Parse(tokens[2]), //postScore
                      Int32.Parse(tokens[3]) //commentScore
                    );

                    myUsers.Add(newUser);
                    currentLine = inFile.ReadLine(); //get the next line
                }
            }

        }

    }
}
