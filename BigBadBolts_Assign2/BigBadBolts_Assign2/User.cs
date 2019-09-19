using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BigBadBolts_Assign2
{
        /* The User class
            * By Margaret
        */
        public class User : IComparable
        {
            private readonly uint id;
            private readonly string name;
            private int postScore;
            private int commonScore;

            //public versions
            public uint Id
            {
                get { return id; }
            }

            public string Name
            {
                get { return name; }
                set
                {
                    if (value.Length >= 5 && value.Length <= 21) ; //Added a semicolon
                                                                   //name = value;//This isnt working properly
                }
            }

            public int PostScore
            {
                get { return postScore; }
                set { postScore = value; }
            }

            public int CommonScore
            {
                get { return commonScore; }
                set { commonScore = value; }
            }

            // default constructor for User
            public User()
            {
                id = (uint)RedditForm.myUsers.Count + 1;
                name = "";
                postScore = 0;
                commonScore = 0;
            }

            // constructor for User when all properties are set
            public User(uint conId, string conName, int conPost, int conCommon)
            {
                id = conId;
                name = conName;
                postScore = conPost;
                commonScore = conCommon;
            }

            //Used to create new user
            public User(string conName)
            {
                id = (uint)RedditForm.myUsers.Count + 1;
                name = conName;
                postScore = 0;
                commonScore = 0;
            }

            public int CompareTo(object alpha)
            {
                if (alpha == null)
                    throw new ArgumentNullException();

                User rightOp = alpha as User;

                if (rightOp != null)
                    return Name.CompareTo(rightOp.Name);
                else
                    throw new ArgumentException("[User]: CompareTo argument is not a Name");
            }
            //need to finish toString
            public override string ToString()
            {//wasn't sure how to format toString
                return "WORDS"; // Console.WriteLine();  THIS NEEDS TO BE FIXED
            }

        }

    }

