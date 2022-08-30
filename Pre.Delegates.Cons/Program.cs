using Pre.Delegates.Cons;

// create some participants
Participant alice = new Participant("Alice");
Participant bob = new Participant("Bob");
Participant carol = new Participant("Carol");

// register participants to contest
Contest contest = new Contest(PickPlayerWithHighestTotalThenMaxScore);
contest.AddParticipant(alice);
contest.AddParticipant(bob);
contest.AddParticipant(carol);

// play some rounds
int numRounds = 3;
for(int i = 0; i < numRounds; i++)
{
    contest.PlayRound();
}

// find the winner!
Participant winner = contest.FindWinner();

// print outcome
Console.WriteLine("Participants:");
Console.WriteLine("-------------");
Console.WriteLine(string.Join("\n", contest.Participants));
Console.WriteLine();

Console.WriteLine("Winner:");
Console.WriteLine("-------");
Console.WriteLine(winner);


// methods

Participant PickPlayerWithHighestTotalScore(Participant p1, Participant p2)
{
    if(p1.TotalScore > p2.TotalScore)
    {
        return p1;
    }
    else
    {
        return p2;
    }
}

Participant PickPlayerWithLowestTotalScore(Participant p1, Participant p2)
{
    if (p1.TotalScore < p2.TotalScore)
    {
        return p1;
    }
    else
    {
        return p2;
    }
}

Participant PickPlayerWithHighestTotalThenMaxScore(Participant p1, Participant p2)
{
    if (p1.TotalScore > p2.TotalScore)
    {
        return p1;
    }
    else if(p2.TotalScore > p1.TotalScore)
    {
        return p2;
    }
    else
    {
        if(p1.MaximumScore > p2.MaximumScore)
        {
            return p1;
        }
        else
        {
            return p2;
        }
    }
}
