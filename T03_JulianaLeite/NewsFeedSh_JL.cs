using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T03_JulianaLeite
{
    internal class NewsFeedSh_JL
    {
        List<MessagePostSh_JL> messages;
        List<PhotoPostSh_JL> photos;

        public NewsFeedSh_JL()
        {
            messages = new List<MessagePostSh_JL>();
            photos = new List<PhotoPostSh_JL>();
        }

        public void AddMessagePostSh_JL(MessagePostSh_JL message)
        {
            messages.Add(message);
        }

        public void AddPhotoPostSh_JL(PhotoPostSh_JL photo)
        {
            photos.Add(photo);
        }

        public List<MessagePostSh_JL> GetMessagesSh_JL()
        {
            return messages;
        }

        public List<PhotoPostSh_JL> GetPhotosSh_JL()
        {
            return photos;
        }

        override public String ToString()
        {
            String tmp = "";
            foreach (MessagePostSh_JL message in messages)
            {
                // display all text posts
                tmp += message.ToString() + "\n";
            }
            foreach (PhotoPostSh_JL photo in photos)
            {
                // display all photos
                tmp += photo.ToString() + "\n";
            }
            return tmp;
        }
    }
}
