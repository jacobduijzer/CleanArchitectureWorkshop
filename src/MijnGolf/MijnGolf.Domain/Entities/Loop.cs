namespace MijnGolf.Domain.Entities
{
    public class Loop
    {
        public int Id { get; }

        public int NumberOfHoles { get; }

        public Loop(int id, int numberOfHoles)
        {
            Id = id;
            NumberOfHoles = numberOfHoles;
        }
    }
}
