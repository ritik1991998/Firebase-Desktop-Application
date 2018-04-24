using System.Collections;

namespace Firebase_Desktop_Application
{
    internal class ChatMessage
    {
        public string text { get; set; }
        public string timeCurrent { get; set; }
        public string photoUrl { get; set; }
        public string posterId { get; set; }
        public ArrayList likedUsers { get; set; }
        public ArrayList unlikedUsers { get; set; }
        public ArrayList saveIt { get; set; }

    }
}