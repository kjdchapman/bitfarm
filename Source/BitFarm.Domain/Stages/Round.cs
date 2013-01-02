namespace BitFarm.Domain.Stages
{
    public struct Round
    {
        private Stage _stage;

        public Stage Stage
        {
            get { return _stage; }
        }

        public int Number { get; private set; }
    }
}