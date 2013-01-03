namespace BitFarm.Domain.Moves
{
    public class Move
    {
        private MoveType _id;

        public Move(MoveType id)
        {
            _id = id;
        }

        public MoveType ID
        {
            get { return _id; }
        }
    }
}