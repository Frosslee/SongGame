using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace songgame
{
    class Player : IComparable
    {
        public int PlayerScore { get; set; }
        
        

        public Player()
        {
            this.PlayerScore = 0;

        }
        

        public void IncreaseScore()
        {
            this.PlayerScore += 1;
        }

        public int CompareTo(object obj)
        {
            throw new NotImplementedException();
        }
    }
}
