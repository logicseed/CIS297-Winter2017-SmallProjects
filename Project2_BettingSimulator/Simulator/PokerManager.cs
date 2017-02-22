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
    class PokerManager
    {
        private PokerHand playerHand;
        private PokerHand computerHand;

        public PokerManager()
        {
            playerHand = new PokerHand();
            computerHand = new PokerHand();


        }
    }
}
