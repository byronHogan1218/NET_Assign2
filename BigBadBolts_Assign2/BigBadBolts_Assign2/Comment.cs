using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BigBadBolts_Assign2
{
    /**
         * This is the definition for the Comment class
         * Created by Byron Hogan
         */
    public class Comment : IComparable
    {
        private readonly uint commentID;
        private readonly uint authorID;
        private string content;
        private readonly uint parentID;
        private uint upVotes;
        private uint downVotes;
        private readonly DateTime timeStamp;
        private SortedSet<Comment> commentReplies;
        private uint indentLevel;

        public uint CommentID
        {
            get { return commentID; }
        }
        public uint ParentID
        {
            get { return parentID; }
        }
        public string Content
        {
            get { return this.content; }
        }

        public uint Score
        {
            get { return upVotes - downVotes; }
        }

        /////////CONSTRUCTOR ZONE////////////////////////////////////////////////////////
        public Comment() //DEFAULT CONSTRUCTOR....may need some tweaks
        {
            commentID = (uint)RedditForm.myComments.Count + 1;
            authorID = 0;
            content = "";
            parentID = 0;
            upVotes = 0;
            downVotes = 0;
            timeStamp = DateTime.Now;
            commentReplies = RedditForm.myComments;
            indentLevel = 0;
            foreach (Comment tabs in RedditForm.myComments)
            {
                if (tabs.CommentID == this.parentID)
                {
                    indentLevel = tabs.indentLevel + 1;
                }
            }
        }
        //This is used to create a new post from file.
        public Comment(uint _commentID, uint _authorID, string _content, uint _parentID, uint _upVotes, uint _downVotes, DateTime _timeStamp)
        {
            commentID = _commentID;
            content = _content;
            authorID = _authorID;
            parentID = _parentID;
            upVotes = _upVotes;
            downVotes = _downVotes;
            timeStamp = _timeStamp;
            commentReplies = RedditForm.myComments;
            indentLevel = 0;
            foreach (Comment tabs in RedditForm.myComments)
            {
                if (tabs.CommentID == this.parentID)
                {
                    indentLevel = tabs.indentLevel + 1;
                }
            }

        }
        public Comment(string _content, uint _authorID, uint _parentID)
        {
            commentID = (uint)RedditForm.myComments.Count + 1;
            content = _content;
            authorID = _authorID;
            parentID = _parentID;
            upVotes = 1;
            downVotes = 0;
            commentReplies = RedditForm.myComments;
            indentLevel = 0;
            foreach (Comment tabs in RedditForm.myComments)
            {
                if (tabs.CommentID == this.parentID)
                {
                    indentLevel = tabs.indentLevel + 1;
                }
            }
        }
        ////////////////END CONSTREUCTOR ZONE///////////////////////////////////////////




        public int CompareTo(Object aplha)
        {
            if (aplha == null)
                throw new ArgumentNullException();

            Comment rightOp = aplha as Comment;

            if (rightOp != null)
            {
                return Score.CompareTo(rightOp.Score); //This might have to be switched around
            }
            else
            {
                throw new ArgumentException("[Comment]:CompareTo argument is not a Comment Object.");
            }
        }

        public override string ToString()
        {
            string authorName = "";
            foreach (User item in RedditForm.myUsers)
            {
                if (item.Id == this.authorID)
                    authorName = item.Name;
            }
            if (authorName.Length == 0)
                authorName = this.authorID.ToString();
            string replies = "\n";
            string replyAuthorName = "";
            foreach (Comment reply in this.commentReplies)
            {
                for (int i = 0; i < this.indentLevel; ++i)
                {
                    replies = replies + '\t';
                }
                foreach (User item in RedditForm.myUsers)
                {
                    if (item.Id == reply.authorID)
                        replyAuthorName = item.Name;
                }
                if (replyAuthorName.Length == 0)
                    replyAuthorName = reply.authorID.ToString();
                replies = replies + "\t<" + reply.CommentID + "> (" + reply.Score + ") " + reply.content + " - " + replyAuthorName + "|" + reply.timeStamp.ToString() + "|";
                replies = replies + '\n';
            }
            replies = ""; //NOT WORKING
            return "\t<" + this.CommentID + "> (" + this.Score + ") " + this.content + " - " + authorName + "|" + this.timeStamp.ToString() + "|" + replies;
        }

    }//End comment class

    /** Collection of Comment objects. This class
     * implements IEnumerable so that it can be used
     * with ForEach syntax. 
     */
    public class Comments : IEnumerable
    {
        private Comment[] _comment;
        public Comments(Comment[] cArray)
        {
            _comment = new Comment[cArray.Length];

            for (int i = 0; i < cArray.Length; i++)
            {
                _comment[i] = cArray[i];
            }
        }

        // Implementation for the GetEnumerator method.
        IEnumerator IEnumerable.GetEnumerator()
        {
            return (IEnumerator)GetEnumerator();
        }

        public CommentEnum GetEnumerator()
        {
            return new CommentEnum(_comment);
        }
    }

    // When you implement IEnumerable, you must also implement IEnumerator.
    public class CommentEnum : IEnumerator
    {
        public Comment[] _comment;

        // Enumerators are positioned before the first element
        // until the first MoveNext() call.
        int position = -1;

        public CommentEnum(Comment[] list)
        {
            _comment = list;
        }

        public bool MoveNext()
        {
            position++;
            return (position < _comment.Length);
        }

        public void Reset()
        {
            position = -1;
        }

        object IEnumerator.Current
        {
            get
            {
                return Current;
            }
        }

        public Comment Current
        {
            get
            {
                try
                {
                    return _comment[position];
                }
                catch (IndexOutOfRangeException)
                {
                    throw new InvalidOperationException();
                }
            }
        }
    }


}
