// Marc King - mjking @umich.edu
// CIS297 - Winter 2017 - Professor Eric Charnesky
// University of Michigan - Dearborn

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simulator
{
    public class BettingManager
    {
        private double money = 1000.0;
        private int wins = 0;
        private int losses = 0;

        private PokerManager pokerManager;

        public double Money
        {
            get
            {
                return money;
            }
        }

        public int Wins
        {
            get
            {
                return wins;
            }
        }

        public int Losses
        {
            get
            {
                return losses;
            }
        }

        internal PokerManager PokerManager
        {
            get
            {
                return pokerManager;
            }
        }

        public BettingManager()
        {
            pokerManager = new PokerManager();
        }

        public bool RacesHorses(int pick, double bet)
        {
            var horseRace = new HorseRace();
            if (horseRace.Winner == pick)
            {
                money += bet;
                wins++;
                return true;
            }
            else
            {
                money -= bet;
                losses++;
                return false;
            }
        }

        public bool PlayPokerHand(double bet)
        {
            var playerWon = false;
            if (pokerManager.PlayerWins)
            {
                money += bet;
                wins++;
                playerWon = true;
            }
            else
            {
                money -= bet;
                losses++;
            }

            pokerManager = new PokerManager();
            return playerWon;
        }

        public bool PlayPowerBall(double bet, PowerBall playerPowerBall)
        {
            var powerBall = new PowerBall();
            if (powerBall.CompareTo(playerPowerBall) == 0)
            {
                money += bet;
                wins++;
                return true;
            }
            else
            {
                money -= bet;
                losses++;
                return false;
            }
        }
    }
}
