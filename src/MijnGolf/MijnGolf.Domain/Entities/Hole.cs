namespace MijnGolf.Domain.Entities
{
    public class Hole
    {
        public int HoleNumber { get; }

        public int NumberOfStrokes { get; }

        public Hole(int holeNumber, int numberOfStrokes)
        {
            HoleNumber = holeNumber;
            NumberOfStrokes = numberOfStrokes;
        }
    }
}
