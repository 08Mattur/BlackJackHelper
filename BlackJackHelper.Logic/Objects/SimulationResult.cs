namespace BlackJackHelper.Logic.Objects
{
    public class SimulationResult
    {        
        public double StartBankRoll { get; set; }
        public double EndBankRoll { get; set; }
        public double AmountPerBet { get; set; }
        public int HandsPlayed { get; set; }
        public int HandsWon { get; set; }
        public int HandsLost { get; set; }
        public int HandsDrawn { get; set; }
        public int PlayerBlackJack { get; set; }
        public int DealerBlackJack { get; set; }
        public int DealerBust { get; set; }
    }
}
