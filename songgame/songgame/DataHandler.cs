using PRG281_Project_Group_9;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace songgame
{
    class DataHandler
    {
        // PROPERTIES
        public List<Artist> artists { get; set; }
        public List<Song> songs { get; set; }
        public List<QuestionGenres> genreQuestions { get; set; }
        public List<QuestionSongs> songQuestions { get; set; }
        public List<object> allQuestions { get; set; }

        
        

        //CONSTRUCTORS  
        public DataHandler() { }



        //METHODS

        public QuestionGenres GenerateQuestionGenres(List<Artist> artists)
        {
            Random random = new Random();
            int rand = random.Next(0, artists.Count);
            int rand2 = random.Next(0, artists[rand].Genre.Count);

            QuestionGenres q1 = new QuestionGenres(artists[rand].ArtistName, artists[rand].Genre[rand2]);
            Console.WriteLine($"{q1.Vraag} : {q1.CorrectAnswer} || {q1.PrintOut()} || {q1.PossibleAnswers.Count}");
            return q1;
        }

        public QuestionSongs GenerateQuestionSongs(List<Song> songs)
        {
            Random random = new Random();
            int rand = random.Next(0, songs.Count);

            QuestionSongs questionSongs = new QuestionSongs(songs[rand].SongName, songs[rand].Artist);

            Console.WriteLine($"{questionSongs.Vraag} : {questionSongs.CorrectAnswer} || {questionSongs.PrintOut()} || {questionSongs.PossibleAnswers.Count}");

            return questionSongs;
        }
        //create list of 5 random question in genre
        public List<QuestionGenres> GetGenres()
        {
            genreQuestions = new List<QuestionGenres>() { };//creates empty list
            

            for (int i = 0; i < 5; i++)//loops thorug 0 to 5
            {
                QuestionGenres ques = GenerateQuestionGenres(Artists);
                genreQuestions.Add(ques);//populates the list with artists

            }

            return genreQuestions;
        }
        //create list of 5 random question in songs
        public List<QuestionSongs> GetSongs()
        {
            songQuestions = new List<QuestionSongs>() { };

            for (int i = 0; i < 5; i++)
            {
                songQuestions.Add(GenerateQuestionSongs(Songs));
            }

            return songQuestions;
        }

        // Vraag
        // string
        // 
        // 
        // 


        public List<object> GetAllQuestions()
        {
            allQuestions.Add(this.GetGenres());
            allQuestions.Add(this.GetSongs());

            return allQuestions;
        }








        //////////////////// DATA DEPOSIT

        List<Artist> Artists = new List<Artist>
            {
                //acid rock
                new Artist("Benny Benassi", new List<string> {"Acid Rock"}),
                new Artist("Pink Floyd", new List<string> {"Acid Rock"}),
                new Artist("The Rolling Stones", new List<string> {"Acid Rock"}),
                // alt rock
                new Artist("Depeche Mode", new List<string> {"Alt Rock"}),
                new Artist("Gorillaz", new List<string> {"Alt Rock"}),
                new Artist("R.E.M", new List<string> {"Alt Rock"}),
                //arena rock
                new Artist("Bon Jovi", new List<string> {"Arena Rock"}),
                new Artist("The Beatles", new List<string> {"Arena Rock"}),
                //garage rock
                new Artist("The White Stripes", new List<string> {"Garage Rock"}),
                new Artist("King Of Leon", new List<string> {"Garage Rock"}),
                //grunge rock
                new Artist("Arizona Zervas", new List<string> {"Grunge"}),
                new Artist("Nirvana", new List<string> {"Grunge"}),
                new Artist("Foo Fighters", new List<string> {"Grunge"}),
                //hard rock
                new Artist("Def Leppard", new List<string> {"Hard Rock"}),
                new Artist("Gun N Roses", new List<string> {"Hard Rock"}),
                //indie rock
                new Artist("Arctic Monkey", new List<string> {"Indie Rock"}),
                new Artist("The Smith", new List<string> {"Indie Rock"}),
                //psych rock
                new Artist("The Jimi Hendrix Experience", new List<string> {"Psych Rock"}),
                // soft rock
                new Artist("Air Supply", new List<string> {"Soft Rock"}),
                new Artist("Phil Collins", new List<string> {"Soft Rock"})
            };

        List<Song> Songs = new List<Song>()
            {
                new Song("Satisfaction", "Benny Benassi"),
                new Song("Wish You Were Here", "Pink Floyd"),
                new Song("Paint It Black", "The Rolling Stones"),

                new Song("Enjoy The Silence", "Depeche Mode"),
                new Song("Clint Eastwood 320k", "Gorillaz "),
                new Song("Feel Good Inc", "Gorillaz "),
                new Song("Man On The Moon", "R.E.M"),
                new Song("Losing Your Religion", "R.E.M"),

                new Song("Bed Of Roses", "Bon Jovi"),
                new Song("Livin On A Prayer", "Bon Jovi"),
                new Song("Here Comes The Sun", "The Beatles"),
                new Song("Dont Let Me Down", "The Beatles"),
                new Song("Hey Jude", "The Beatles"),

                new Song("Sex On Fire", "King Of Leon"),
                new Song("Seven Nation Army", "The White Stripes"),
                new Song("We re Going To Be Friends", "The White Stripes"),

                new Song("Roxanne", "Arizona Zervas"),
                new Song("Been A Son", "Nirvana"),
                new Song("Come As You Are", "Nirvana"),
                new Song("All My Life", "Foo Fighters"),
                new Song("Everlong", "Foo Fighters"),

                new Song("Pour Some Sugar On Me", "Def Leppard"),
                new Song("Love Bites", "Def Leppard"),
                new Song("November Rain", "Gun N Roses"),
                new Song("Sweet Child O Mine", "Gun N Roses"),

                new Song("Do I Wanna Know", "Arctic Monkeys"),
                new Song("505", "Arctic Monkeys"),
                new Song("Girlfriend In A Coma", "The Smiths"),

                new Song("Foxey Lady", "The Jimi Hendrix Experience"),
                new Song("Purple Haze", "The Jimi Hendrix Experience"),
                new Song("All Along The Watchtower", "The Jimi Hendrix Experience"),

                new Song("Making Love Out Of Nothing At All", "Air Supply"),
                new Song("All Out Of Love", "Air Supply"),
                new Song("Against All Odds", "Phil Collins"),
                new Song("In The Air Tonight", "Phil Collins"),
                new Song("Another Day In Paradise", "Phil Collins")
            };








    }
}
