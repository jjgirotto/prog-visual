using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T03_JulianaLeite
{
    internal class PhotoPostSh_JL
    {
        String username;
        String caption;
        String filename;
        long timestamp;
        int likes;
        List<String> comments;
        public PhotoPostSh_JL(String username, String caption, String filename)
        {
            this.username = username;
            this.filename = filename;
            this.caption = caption;
            timestamp =
            System.DateTime.Now.Millisecond;
            likes = 0;
            comments = new List<String>();
        }
        public PhotoPostSh_JL() : this("Anónimo", "noCaption", "noFile")
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
        public String GetImageFile()
        {
            return filename;
        }
        public String GetCaption()
        {
            return caption;
        }
        // sem private => PRIVATE! em C#
        String TimeString(long time)
        {
            long current =
            System.DateTime.Now.Millisecond;
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
            + "\n [" + caption
            + "]\n";
            tmp += " " + filename
            + "\n "
            + TimeString(timestamp)
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
            if (comments.Count() == 0)
            {
                tmp += " No comments.";
            }
            else
            {
                tmp += "\t" + comments.Count +
                " comment(s). Click here to view.";
            }
            return tmp + "\n";
        }
    }
}

