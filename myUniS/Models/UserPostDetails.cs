

using Microsoft.VisualBasic;

namespace myUniS.Models;

    class UserPostDetails
    {
        public string UserImage { get; set; }
        public string UserName { get; set; }
        public string TimeCreated { get; set; }
        public string Handle { get; set; }
        public string Post {  get; set; }
        public int Likes {  get; set; }
        public int Comments { get; set; }
        public int Dislikes { get; set; }
}

