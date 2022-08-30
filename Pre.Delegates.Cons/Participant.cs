using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pre.Delegates.Cons
{
    public class Participant
    {
        public string Name { get; }
        public List<int> Scores { get; }

        public int TotalScore
        {
            get
            {
                int total = 0;
                foreach(int score in Scores)
                {
                    total += score;
                }
                return total;
            }
        }

        public int MaximumScore
        {
            get
            {
                int max = Scores[0];
                foreach(int score in Scores)
                {
                    if(score > max)
                    {
                        max = score;
                    }
                }
                return max;
            }
        }

        public Participant(string name)
        {
            Name = name;
            Scores = new List<int>();
        }

        public void RegisterScore(int score)
        {
            Scores.Add(score);
        }

        public override string ToString()
        {
            return $"{Name} - Scores: ({string.Join(",", Scores)})"
                + $"(Tot: {TotalScore} - Max: {MaximumScore})";
        }
    }
}
