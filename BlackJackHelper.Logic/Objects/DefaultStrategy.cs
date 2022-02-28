using BlackJackHelper.Logic.Engines.PlayerActions.Hards;
using BlackJackHelper.Logic.Engines.PlayerActions.Softs;
using BlackJackHelper.Logic.Engines.PlayerActions.Splits;
using BlackJackHelper.Logic.Enums;
using BlackJackHelper.Logic.Interfaces;

namespace BlackJackHelper.Logic.Objects
{
    public class DefaultStrategy : IStrategy
    {
        private int _playerHandValue = 0;

        private Face _dealerFace;

        public ResultAction WhatShouldPlayerDo(Hand playerHand, Face dealerUpcard)
        {
            _playerHandValue = playerHand.Value;
            _dealerFace = dealerUpcard;

            if (playerHand.IsPair)
            {
                var firstCard = playerHand.Cards[0];
                return WhatDoIfPair(firstCard);
            }

            if (playerHand.IsSoft)
            {
                return WhatDoIfSoftValue();
            }

            return WhatDoIfHardValue();
        }
        private ResultAction WhatDoIfPair(Card firstCard)
        {
            switch (firstCard.Face)
            {
                case Face.Two:
                    return TwoAndThreeSplits.WhatDo(_dealerFace);
                case Face.Three:
                    return TwoAndThreeSplits.WhatDo(_dealerFace);
                case Face.Four:
                    return ResultAction.Hit;
                case Face.Six:
                    return SixSplits.WhatDo(_dealerFace);
                case Face.Seven:
                    return SevenSplits.WhatDo(_dealerFace);
                case Face.Eight:
                    return ResultAction.Split;
                case Face.Nine:
                    return NineSplits.WhatDo(_dealerFace);
                case Face.Ace:
                    return ResultAction.Split;
                default:
                    return WhatDoIfHardValue();
            }
        }
        private ResultAction WhatDoIfHardValue()
        {
            switch (_playerHandValue)
            {
                case >= 21:
                    return ResultAction.Bust;
                case >= 17:
                    return ResultAction.Stand;
                case >= 13:
                    return PlayerHighHard.WhatDo(_dealerFace);
                case 12:
                    return TwelveHard.WhatDo(_dealerFace);
                case 11:
                    return ResultAction.DoubleOrHit;
                case 10:
                    return TenHard.WhatDo(_dealerFace);
                case 9:
                    return NineHard.WhatDo(_dealerFace);
                default:
                    return ResultAction.Hit;
            }
        }
        private ResultAction WhatDoIfSoftValue()
        {
            switch (_playerHandValue)
            {
                case >= 20:
                    return ResultAction.Stand;
                case 19:
                    return NineteenSoft.WhatDo(_dealerFace);
                case 18:
                    return EighteenSoft.WhatDo(_dealerFace);
                case 17:
                    return SeventeenSoft.WhatDo(_dealerFace);
                case >= 15:
                    return FifteenAndSixteenSoft.WhatDo(_dealerFace);
                case >= 13:
                    return ThirteenAndFourteenSoft.WhatDo(_dealerFace);
                default: return ResultAction.Incalculable;
            }
        }
    }
}
