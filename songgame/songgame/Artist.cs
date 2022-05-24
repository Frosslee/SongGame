using songgame;
using System.Collections.Generic;

namespace PRG281_Project_Group_9
{
    class Artist : IQuestionAnswer
    {
        public string ArtistName { get; set; }
        public List<string> Genre { get; set; }

        
        public Artist(string name, List<string> genres)
        {
            this.ArtistName = name;
            this.Genre = genres;
        }


        //Implement
        public string Question()
        {
            return ArtistName;
        }

        public string Answer()
        {
            return Genre[0];
        }
    }
}