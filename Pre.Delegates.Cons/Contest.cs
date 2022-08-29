using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pre.Delegates.Cons
{
    public class Contest
    {
        private const int MaxScorePerRound = 5;
        private static readonly Random random = new Random();

        public List<Participant> Participants { get; } = new List<Participant>();

        public void AddParticipant(Participant participant)
        {
            Participants.Add(participant);
        }

        public void PlayRound()
        {
            foreach(Participant participant in Participants)
            {
                int randomScore = random.Next(MaxScorePerRound + 1);
                participant.RegisterScore(randomScore);
            }
        }

        public Participant FindWinner()
        {
            Participant winner = Participants[0];
            for(int i = 1; i < Participants.Count; i++)
            {
                Participant participant = Participants[i];
                if(participant.TotalScore > winner.TotalScore)
                {
                    winner = participant;
                }
            }
            return winner;
        }
    }
}
