using songgame;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;

namespace PRG281_Project_Group_9
{
    internal class QuestionGenres : QuestionPartOne, IAllAnswers
    {

        
        

        public QuestionGenres(string artist, string correct)
        {
            Vraag = $"What genre does {artist} play in?";
            CorrectAnswer = correct;
            // Console.WriteLine(CorrectAnswer);

            AllAnswers = new List<string>()
            {
                "Acid Rock",
                "Alt Rock",
                "Arena Rock",
                "Folk Rock",
                "Garage Rock",
                "Grunge  Rock" ,
                "Hard Rock",
                "Indie Rock",
                "Death Rock",
                "Indie Rock",
                "Psych Rock",
                "Soft Rock"
            };
            AllAnswers.Remove(CorrectAnswer);

            AllAnswers = AllAnswers.OrderBy(x => Guid.NewGuid()).ToList();
            PossibleAnswers = new List<string>();

            for (int i = 0; i < AllAnswers.Count; i++)
            {
                if (i != PossibleAnswers.IndexOf(CorrectAnswer) && PossibleAnswers.Count < 4 && !PossibleAnswers.Contains(AllAnswers[i]))
                {
                    PossibleAnswers.Add(AllAnswers[i]);
                }
            }

            Random rand = new Random();
            int rando = rand.Next(0, 4);

            try
            {
                PossibleAnswers[rando] = CorrectAnswer;
            }
            catch (NullReferenceException)
            {
                Console.WriteLine("This shouldn't be null, revise the algorithm");
            }
        }

        public List<string> allAnswers()
        {
            return PossibleAnswers;
        }

        public string PrintOut()
        {
            string braa = "";
            foreach (string ans in PossibleAnswers)
            {
                braa += $"{ans}     ";
            }
            return braa;
        }

        
    }
}