// Marc King - mjking@umich.edu
// CIS297 - Winter 2017 - Professor Eric Charnesky
// University of Michigan - Dearborn

using System;
using System.Collections.Generic;
using System.Linq;

namespace Project1_Yahtzee
{
    /// <summary>
    /// Handles all the dice mechanics for a player's turn.
    /// </summary>
    /// <remarks>The object lifetime should be a single turn.</remarks>
    public class DiceRoller
    {
        #region Constants

        /// <summary>
        /// The number of dice initially rolled.
        /// </summary>
        private const int NUM_DICE = 5;

        /// <summary>
        /// The smallest number shown on a die face.
        /// </summary>
        private const int MIN_DIE_FACE = 1;

        /// <summary>
        /// The largest number shown on a die face.
        /// </summary>
        private const int MAX_DIE_FACE = 6;

        /// <summary>
        /// The maximum number of times the dice can be rolled per turn.
        /// </summary>
        private const int MAX_ROLL_COUNT = 3;

        #endregion Constants

        #region Private Fields

        /// <summary>
        /// Random number generator used for rolling the dice.
        /// </summary>
        private Random random;

        /// <summary>
        /// The current list of rolled dice.
        /// </summary>
        private List<int> dice;

        /// <summary>
        /// The current list of sorted, rolled dice.
        /// </summary>
        private List<int> sortedDice;

        /// <summary>
        /// The dice to keep from rerolling.
        /// </summary>
        /// <remarks>False indicates that the die can be rerolled.</remarks>
        private List<bool> willKeepDice;

        /// <summary>
        /// How many times the dice have been rolled.
        /// </summary>
        private int rollCount = 0;

        /// <summary>
        /// Indicates whether or not the die rolls have been sorted.
        /// </summary>
        private bool hasSorted = false;

        #endregion Private Fields

        #region Constructors

        /// <summary>
        /// Constructor without dependency injection.
        /// </summary>
        /// <remarks>
        /// The constructor with dependency injection is preferred to reduce the need to initialize
        /// the Random classm repeatedly.
        /// </remarks>
        public DiceRoller()
        {
            random = new Random();
            InitializeCollectionFields();
        }
        
        /// <summary>
        /// Constructor with dependency injection.
        /// </summary>
        /// <param name="random">Dependency injected Random object.</param>
        public DiceRoller(Random random)
        {
            this.random = random;
            InitializeCollectionFields();
        }

        #endregion Constructors

        #region Private Methods

        /// <summary>
        /// Initializes the collection fields of this object with default values.
        /// </summary>
        private void InitializeCollectionFields()
        {
            dice = Enumerable.Repeat(0, NUM_DICE).ToList<int>();
            sortedDice = Enumerable.Repeat(0, NUM_DICE).ToList<int>();
            willKeepDice = Enumerable.Repeat(false, NUM_DICE).ToList<bool>();
        }

        #endregion Private Methods

        #region Public Properties

        /// <summary>
        /// Returns the current unsorted die rolls.
        /// </summary>
        public List<int> Dice
        {
            get
            {
                return dice;
            }
        }

        public bool WillKeep(int die)
        {
            return willKeepDice[die];
        }


        /// <summary>
        /// Gets the current list of dice in ascending order.
        /// </summary>
        /// <remarks>
        /// Has internal side-effects: <c>sortedDice</c> and <c>hasSorted</c> are modified.
        /// </remarks>
        public List<int> SortedDice
        {
            get
            {
                if (hasSorted == false)
                {
                    sortedDice = new List<int>(dice);
                    sortedDice.Sort();
                    hasSorted = true;
                }
                return sortedDice;
            }
        }

        /// <summary>
        /// Returns how many rolls are left in the turn.
        /// </summary>
        public int RollsRemaining
        {
            get
            {
                return MAX_ROLL_COUNT - rollCount;
            }
        }

        #endregion Public Properties

        #region Public Methods

        /// <summary>
        /// Rolls all of the dice that aren't marked to be kept from a previous roll.
        /// </summary>
        public void RollDice()
        {
            if (RollsRemaining <= 0) return;

            for (int index = 0; index < this.dice.Count; index++)
            {
                if (willKeepDice[index] == false)
                {
                    dice[index] = random.Next(MIN_DIE_FACE, MAX_DIE_FACE + 1);
                    hasSorted = false;
                }
            }

            rollCount++;
        }

        public void KeepDie(int die, bool keep)
        {
            willKeepDice[die] = keep;
        }



        #endregion Public Methods
    }
}