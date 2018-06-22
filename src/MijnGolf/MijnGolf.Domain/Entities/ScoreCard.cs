using System.Collections.Generic;
using System;

namespace MijnGolf.Domain.Entities
{
    public class ScoreCard
    {
        public int UserId { get; }

        public IList<Hole> Holes { get; }

        public DateTime Played { get; }

        public ScoreCard(int userId, IList<Hole> holes, DateTime played)
        {
            UserId = userId;
            Holes = holes;
            Played = played;
        }
    }
}