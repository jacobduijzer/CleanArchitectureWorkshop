using System.Collections.Generic;
using System;

namespace MijnGolf.Domain.Entities
{
    public class ScoreCard
    {
        public int UserId { get; }

        public int CourseId { get; }

        public int LoopId { get; }

        public IList<Hole> Holes { get; }

        public DateTime Played { get; }

        public ScoreCard(int userId, int courseId, int loopId, IList<Hole> holes, DateTime played)
        {
            UserId = userId;
            CourseId = courseId;
            LoopId = loopId;
            Holes = holes;
            Played = played;
        }
    }
}