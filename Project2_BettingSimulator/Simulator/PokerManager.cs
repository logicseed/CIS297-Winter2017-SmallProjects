﻿// Marc King - mjking @umich.edu
// CIS297 - Winter 2017 - Professor Eric Charnesky
// University of Michigan - Dearborn

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simulator
{
    class PokerManager
    {
        private PokerHand playerHand;
        private PokerHand computerHand;
        private bool playerWins;

        internal PokerHand PlayerHand
        {
            get
            {
                return playerHand;
            }
        }

        internal PokerHand ComputerHand
        {
            get
            {
                return computerHand;
            }
        }

        public bool PlayerWins
        {
            get
            {
                return playerWins;
            }
        }

        public PokerManager()
        {
            playerHand = new PokerHand();
            computerHand = new PokerHand();
            var deck = new PokerDeck();

            for (int i = 0; i < PokerHand.HAND_SIZE; i++)
            {
                playerHand.Add(deck.NextCard());
                computerHand.Add(deck.NextCard());
            }

            if (playerHand.CompareTo(computerHand) == 1) playerWins = true;
            else playerWins = false;
        }
    }
}
