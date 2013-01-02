namespace BitFarm.Domain.Stages
{
    public class Round
    {
        public int Number { get; set; }

        public Stage Stage { get; set; }

        public Move AvailableMove { get; set; }
    }
}