using songgame;
using System;
using System.Collections.Generic;
using System.Linq;

namespace PRG281_Project_Group_9
{
    internal class QuestionSongs : QuestionPartOne, IAllAnswers
    {
        public QuestionSongs(string song, string correct)
        {
            Vraag = $"Which artist performed {song}?";
            CorrectAnswer = correct;
            // Console.WriteLine(CorrectAnswer);
            //Keep AllAnswers in sync with all used
            AllAnswers = new List<string>()
                {
                "Air Supply",
                "Arctic Monkey",
                "Arizona Zervas",
                "Benny Benass",
                "Bon Jovi",
                "Def Leppard",
                "Depeche Mode",
                "Foo Fighters",
                "Gorillaz",
                "Gun N Roses",
                "King Of Leon",
                "Nirvana",
                "Phil Collins",
                "Pink Floyd",
                "R.E.M",
                "The Beatles",
                "The Jimi Hendrix Experience",
                "The Rolling Stones",
                "The Smith",
                "The White Stripes"
              
            };
            AllAnswers.Remove(CorrectAnswer);

            AllAnswers = AllAnswers.OrderBy(x => Guid.NewGuid()).ToList();
            PossibleAnswers = new List<string>();

            for (int i = 0; i < AllAnswers.Count; i++)
            {
                if (i != PossibleAnswers.IndexOf(CorrectAnswer) && PossibleAnswers.Count < 4 &&
                    !PossibleAnswers.Contains(AllAnswers[i]))
                {
                    PossibleAnswers.Add(AllAnswers[i]);
                }
            }

            Random rand = new Random();
            int rando = rand.Next(0, 4);
            PossibleAnswers[rando] = CorrectAnswer;
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