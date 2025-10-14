using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T03_JulianaLeite
{
    internal class NewsFeed_JL
    {
        private List<Post_JL> posts_JL;
        public NewsFeed_JL()
        {
            posts_JL = new List<Post_JL>();
        }
        public void AddPost_JL(Post_JL post_JL)
        {
            posts_JL.Add(post_JL);
        }

        public List<Post_JL> GetPosts_JL()
        {
            return posts_JL;
        }

        override public String ToString()
        {
            String tmp = "";
            foreach (Post_JL p in posts_JL)
            {//display all text posts
                tmp += p.ToString() + "\n";
            }
            return tmp;
        }
    }
}
