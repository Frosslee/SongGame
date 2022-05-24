using System.Collections.Generic;

namespace PRG281_Project_Group_9
{
    class QuestionPartOne
    {
        public string Vraag { get; set; }
        public string CorrectAnswer { get; set; }
        public List<string> AllAnswers { get; set; }
        public List<string> PossibleAnswers { get; set; }
        public int CorrectAnswerIndex { get; set; }
    }
}