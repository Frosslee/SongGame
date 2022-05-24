using PRG281_Project_Group_9;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace songgame
{
    public partial class frmDuoStage : Form
    {
        // DECLARED STUFF
        DataHandler handler = new DataHandler();
        

        string type;

        string previousAwnserg;
        string previousAwnsers;
       
        int score;
        int score2;
        int Round;

        int currentPlayer;

        Player playerone = new Player();
        Player playertwo = new Player();



        public frmDuoStage()
        {
            InitializeComponent();
        }


        private void frmDuoStage_Load_1(object sender, EventArgs e)
        {
           
            Round = 1;
            currentPlayer = 1;
            if (currentPlayer == 1)
            {
                lblRound.Text = (Round).ToString();
                type = evenorodd(Round);
                Round += 1;
            }
            else if (currentPlayer == 2)
            {
                lblRound.Text = (Round+1).ToString();
                type = evenorodd(Round);
                Round += 1;
            }

            lblPlayer.Text = "Player One";
              
            
            
            // FIRST QUESTION 
            QuestionGenres q1 = handler.GenerateQuestionGenres(Artists);

            lblVraag.Text = q1.Vraag;
            previousAwnserg = q1.CorrectAnswer;
            previousAwnsers = "";

            btnAnswerOne.Text = q1.PossibleAnswers[0];
            btnAnswerTwo.Text = q1.PossibleAnswers[1];
            btnAnswerThree.Text = q1.PossibleAnswers[2];
            btnAnswerFour.Text = q1.PossibleAnswers[3];

        }



        //////////////////////////////////////////////////////////////////////////// BUTTON 1
        private void btnAnswerOne_Click(object sender, EventArgs e)
        {
            if (currentPlayer==1)
            {
                lblPlayer.Text = "Player One";
            }
            else if(currentPlayer == 2)
            {
                lblPlayer.Text = "Player Two";
                
            }

            if (btnAnswerOne.Text == previousAwnserg)//previousbtn text
            {
                score++;
            }

            if (btnAnswerOne.Text == previousAwnsers)
            {
                score++;
            }


            //round counter
            if (currentPlayer == 1)
            {
                lblRound.Text = (Round).ToString();
                type = evenorodd(Round);
                Round += 1;
            }
            else if(currentPlayer == 2)
            {
                lblRound.Text = (Round+1).ToString();
                type = evenorodd(Round);
                Round += 1;
            }
           
           

            if (type == "genre")//new btntext
            {
                QuestionGenres q1 = handler.GenerateQuestionGenres(Artists);

                lblVraag.Text = q1.Vraag;
                previousAwnserg = q1.CorrectAnswer;

                btnAnswerOne.Text = q1.PossibleAnswers[0];
                btnAnswerTwo.Text = q1.PossibleAnswers[1];
                btnAnswerThree.Text = q1.PossibleAnswers[2];
                btnAnswerFour.Text = q1.PossibleAnswers[3];



            }
            else if (type == "song")
            {
                QuestionSongs s1 = handler.GenerateQuestionSongs(Songs);

                lblVraag.Text = s1.Vraag;
                previousAwnsers = s1.CorrectAnswer;
                btnAnswerOne.Text = s1.PossibleAnswers[0];
                btnAnswerTwo.Text = s1.PossibleAnswers[1];
                btnAnswerThree.Text = s1.PossibleAnswers[2];
                btnAnswerFour.Text = s1.PossibleAnswers[3];


                ////

            }

            if (RoundLimter(Round))
            {
                if (currentPlayer == 1)
                {
                    if (btnAnswerOne.Text == previousAwnserg)
                    {
                        score++;
                    }
                    if (btnAnswerOne.Text == previousAwnsers)
                    {
                        score++;
                    }
                   
                    Round = 0;
                    //switch page
                    //gives player score
                    playerone.PlayerScore = score;
                    score = 0;
                    //gives the party form score
                    currentPlayer += 1;
                    
                }
                else if(currentPlayer==2)
                {
                    if (btnAnswerOne.Text == previousAwnserg)
                    {
                        score++;
                    }
                    if (btnAnswerOne.Text == previousAwnsers)
                    {
                        score++;
                    }
                    //switch page
                    //gives player score
                    playertwo.PlayerScore = score;
                    //gives the party form score
                    frmPartySolo party = new frmPartySolo(playerone.PlayerScore, playertwo.PlayerScore);
                    party.Show();
                    this.Hide();
                }
                
            }

        }


        ////////////////////////////////////////////////////////////////////////////// BUTTON 2
        private void btnAnswerTwo_Click(object sender, EventArgs e)
        {
            if (currentPlayer == 1)
            {
                lblPlayer.Text = "Player One";
            }
            else if (currentPlayer == 2)
            {
                lblPlayer.Text = "Player Two";
            }
            if (btnAnswerTwo.Text == previousAwnserg)
            {
                score++;
            }
            if (btnAnswerTwo.Text == previousAwnsers)
            {
                score++;
            }


            if (currentPlayer == 1)
            {
                lblRound.Text = (Round).ToString();
                type = evenorodd(Round);
                Round += 1;
            }
            else if (currentPlayer == 2)
            {
                lblRound.Text = (Round+1).ToString();
                type = evenorodd(Round);
                Round += 1;
            }

            if (type == "genre")
            {
                QuestionGenres q1 = handler.GenerateQuestionGenres(Artists);

                lblVraag.Text = q1.Vraag;
                previousAwnserg = q1.CorrectAnswer;
                btnAnswerOne.Text = q1.PossibleAnswers[0];
                btnAnswerTwo.Text = q1.PossibleAnswers[1];
                btnAnswerThree.Text = q1.PossibleAnswers[2];
                btnAnswerFour.Text = q1.PossibleAnswers[3];

            }
            else if (type == "song")
            {
                QuestionSongs s1 = handler.GenerateQuestionSongs(Songs);

                lblVraag.Text = s1.Vraag;
                previousAwnsers = s1.CorrectAnswer;
                btnAnswerOne.Text = s1.PossibleAnswers[0];
                btnAnswerTwo.Text = s1.PossibleAnswers[1];
                btnAnswerThree.Text = s1.PossibleAnswers[2];
                btnAnswerFour.Text = s1.PossibleAnswers[3];



            }
            if (RoundLimter(Round))
            {
                if (currentPlayer == 1)
                {
                    if (btnAnswerTwo.Text == previousAwnserg)
                    {
                        score++;
                    }
                    if (btnAnswerTwo.Text == previousAwnsers)
                    {
                        score++;
                    }
                    Round = 0;
                    
                    //switch page
                    //gives player score
                    playerone.PlayerScore = score;
                    score = 0;
                    //gives the party form score
                    currentPlayer += 1;

                }
                else if (currentPlayer == 2)
                {
                    if (btnAnswerTwo.Text == previousAwnserg)
                    {
                        score++;
                    }
                    if (btnAnswerTwo.Text == previousAwnsers)
                    {
                        score++;
                    }
                    //switch page
                    //gives player score
                    playertwo.PlayerScore = score;
                    //gives the party form score
                    frmPartySolo party = new frmPartySolo(playerone.PlayerScore,playertwo.PlayerScore);
                    party.Show();
                    this.Hide();
                }

            }

        }


        //////////////////////////////////////////////////////////////////////////// BUTTON 3
        private void btnAnswerThree_Click(object sender, EventArgs e)
        {
            if (currentPlayer == 1)
            {
                lblPlayer.Text = "Player One";
            }
            else if (currentPlayer == 2)
            {
                lblPlayer.Text = "Player Two";
            }
            if (btnAnswerThree.Text == previousAwnserg)
            {
                score++;
            }
            if (btnAnswerThree.Text == previousAwnsers)
            {
                score++;
            }

            if (currentPlayer == 1)
            {
                lblRound.Text = (Round).ToString();
                type = evenorodd(Round);
                Round += 1;
            }
            else if (currentPlayer == 2)
            {
                lblRound.Text = (Round+1).ToString();
                type = evenorodd(Round);
                Round += 1;
            }

            if (type == "genre")
            {
                QuestionGenres q1 = handler.GenerateQuestionGenres(Artists);

                lblVraag.Text = q1.Vraag;
                previousAwnserg = q1.CorrectAnswer;
                btnAnswerOne.Text = q1.PossibleAnswers[0];
                btnAnswerTwo.Text = q1.PossibleAnswers[1];
                btnAnswerThree.Text = q1.PossibleAnswers[2];
                btnAnswerFour.Text = q1.PossibleAnswers[3];



            }
            else if (type == "song")
            {
                QuestionSongs s1 = handler.GenerateQuestionSongs(Songs);

                lblVraag.Text = s1.Vraag;
                previousAwnsers = s1.CorrectAnswer;
                btnAnswerOne.Text = s1.PossibleAnswers[0];
                btnAnswerTwo.Text = s1.PossibleAnswers[1];
                btnAnswerThree.Text = s1.PossibleAnswers[2];
                btnAnswerFour.Text = s1.PossibleAnswers[3];



            }
            if (RoundLimter(Round))
            {
                if (currentPlayer == 1)
                {
                    if (btnAnswerThree.Text == previousAwnserg)
                    {
                        score++;
                    }
                    if (btnAnswerThree.Text == previousAwnsers)
                    {
                        score++;
                    }
                    Round = 0;
                  

                    //switch page
                    //gives player score
                    playerone.PlayerScore = score;
                    score = 0;
                    //gives the party form score
                    currentPlayer += 1;

                }
                else if (currentPlayer == 2)
                {
                    if (btnAnswerThree.Text == previousAwnserg)
                    {
                        score++;
                    }
                    if (btnAnswerThree.Text == previousAwnsers)
                    {
                        score++;
                    }
                    
                    //switch page
                    //gives player score
                    playertwo.PlayerScore = score;
                    //gives the party form score
                    frmPartySolo party = new frmPartySolo(playerone.PlayerScore, playertwo.PlayerScore);
                    party.Show();
                    this.Hide();
                }

            }

        }


        ///////////////////////////////////////////////////////////////////////////////// BUTTON 4
        private void btnAnswerFour_Click(object sender, EventArgs e)
        {
            if (currentPlayer == 1)
            {
                lblPlayer.Text = "Player One";
            }
            else if (currentPlayer == 2)
            {
                lblPlayer.Text = "Player Two";
            }
            if (btnAnswerFour.Text == previousAwnserg)
            {
                score++;
            }
            if (btnAnswerFour.Text == previousAwnsers)
            {
                score++;
            }

            if (currentPlayer == 1)
            {
                lblRound.Text = (Round ).ToString();
                type = evenorodd(Round);
                Round += 1;
            }
            else if (currentPlayer == 2)
            {
                lblRound.Text = (Round+1).ToString();
                type = evenorodd(Round);
                Round += 1;
            }

            if (type == "genre")
            {
                QuestionGenres q1 = handler.GenerateQuestionGenres(Artists);

                lblVraag.Text = q1.Vraag;
                previousAwnserg = q1.CorrectAnswer;
                btnAnswerOne.Text = q1.PossibleAnswers[0];
                btnAnswerTwo.Text = q1.PossibleAnswers[1];
                btnAnswerThree.Text = q1.PossibleAnswers[2];
                btnAnswerFour.Text = q1.PossibleAnswers[3];

            }
            else if (type == "song")
            {
                QuestionSongs s1 = handler.GenerateQuestionSongs(Songs);
                lblVraag.Text = s1.Vraag;
                previousAwnsers = s1.CorrectAnswer;
                btnAnswerOne.Text = s1.PossibleAnswers[0];
                btnAnswerTwo.Text = s1.PossibleAnswers[1];
                btnAnswerThree.Text = s1.PossibleAnswers[2];
                btnAnswerFour.Text = s1.PossibleAnswers[3];

            }

            if (RoundLimter(Round))
            {
                if (currentPlayer == 1)
                {
                    if (btnAnswerFour.Text == previousAwnserg)
                    {
                        score++;
                    }
                    if (btnAnswerFour.Text == previousAwnsers)
                    {
                        score++;
                    }
                    Round = 0;
                    //switch page
                    //gives player score
                    playerone.PlayerScore = score;
                    score = 0;
                    //gives the party form score
                    currentPlayer += 1;

                }
                else if (currentPlayer == 2)
                {
                    if (btnAnswerFour.Text == previousAwnserg)
                    {
                        score++;
                    }
                    if (btnAnswerFour.Text == previousAwnsers)
                    {
                        score++;
                    }
                    Round = 0;
                    //switch page
                    //gives player score
                    playertwo.PlayerScore = score;
                    //gives the party form score
                    frmPartySolo party = new frmPartySolo(playerone.PlayerScore, playertwo.PlayerScore);
                    party.Show();
                    this.Hide();
                }
            }



            //////////////////////////////////////////////////////////////////////////////// METHODS
        }
        public string evenorodd(int round)
        {
            string type;

            if (round % 2 == 0)
            {
                type = "song";
                return type;
            }
            else
            {
                type = "genre";
                return type;
            }
        }

        public bool RoundLimter(int round)
        {
            if (round <= 10)
            {
                return false;
            }
            else
            { 
                return true;
            }
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

        private void btnReturn_Click(object sender, EventArgs e)
        {
            frmMenu menu = new frmMenu();
            menu.Show();
            this.Hide();
        }
    }
}
