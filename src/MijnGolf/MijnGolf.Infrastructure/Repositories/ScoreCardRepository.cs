using System.Collections.Generic;
using MijnGolf.Domain.Entities;
using System;

namespace MijnGolf.Infrastructure.Repositories
{
    public class ScoreCardRepository
    {
        private readonly IList<ScoreCard> _courses;

        public ScoreCardRepository()
        {
        }

        public IReadOnlyList<ScoreCard> GetAll()
        {
            throw new NotImplementedException();
        }

        public void AddScoreCard(ScoreCard scoreCard)
        {
            throw new NotImplementedException();
        }

        public ScoreCard GetById(int id)
        {
            throw new NotImplementedException();
        }
    }
}
