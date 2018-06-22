using System;
using System.Collections.Generic;

namespace MijnGolf.Domain.Entities
{
    public class Course
    {
        public int Id { get; }

        public string Name { get; }

        public IList<Loop> Loops { get; }

        public Course(int id, string name, IList<Loop> loops)
        {
            Id = id;
            Name = name;
            Loops = loops;
        }
    }
}
