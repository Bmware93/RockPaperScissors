using System;
namespace RockPaperScissors
{
    class RockPlayer : Player
    {
        public override Roshambo GenerateRoshambo()
        {
            return Roshambo.Rock;
        }
    }
}

