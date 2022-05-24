using songgame;

namespace PRG281_Project_Group_9
{
    class Song : IQuestionAnswer
    {
        public string SongName { get; set; }
        public string Artist { get; set; }

        public Song(string songName, string artist)
        {
            this.SongName = songName;
            this.Artist = artist;
        }

        public string Question()
        {
            return SongName;
        }

        public string Answer()
        {
            return Artist;
        }
    }
}