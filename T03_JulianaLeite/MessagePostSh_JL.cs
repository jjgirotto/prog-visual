using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T03_JulianaLeite
{
    internal class MessagePostSh_JL
    {
        String username;
        String message;
        long timestamp;
        int likes;
        List<String> comments;
        
        public MessagePostSh_JL(String username, String message)
        {
            this.username = username;
            this.message = message;
            timestamp = System.DateTime.Now.Millisecond;
            likes = 0;
            comments = new List<String>();
        }
        public MessagePostSh_JL() : this("Anónimo", "Vazio")
        {
        }

        public void Like()
        {
            likes++;
        }

        public void Unlike()
        {
            if (likes > 0)
            {
                likes--;
            }
        }
        public void AddComment(String text)
        {
            comments.Add(text);
        }
        public String getText()
        {
            return message;
        }

        // sem private => PRIVATE! em C#
        private String TimeString(long time)
        {
            long current = System.DateTime.Now.Millisecond;
            long pastMillis = current - time;
            long seconds = pastMillis / 1000;
            long minutes = seconds / 60;
            if (minutes > 0)
            {
                return minutes + " minutes ago";
            }
            else
            {
                return seconds + " seconds ago";
            }
        }
        override public String ToString()
        {
            String tmp = username
            + "\n " + message
            + "\n";
            tmp += " " + TimeString(timestamp)
            + "\n";
            if (likes > 0)
            {
                tmp += " - " + likes
                + " people like this.";
            }
            else
            {
                tmp += "";
            }
            if (comments.Count == 0)
            {
                tmp += " No comments.";
            }
            else
            {
                tmp += " " + comments.Count +
                " comment(s). Click here to view.";
            }
            return tmp + "\n";
        }
    }
}

