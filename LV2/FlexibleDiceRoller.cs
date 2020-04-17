using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LV2
{
    class FlexibleDiceRoller : IDiceRollerRoll, IDiceRollerControler
    {
        private List<Die> dice;
        private List<int> resultForEachRoll;
        public FlexibleDiceRoller()
        {
            this.dice = new List<Die>();
            this.resultForEachRoll = new List<int>();
        }
        public void InsertDie(Die die)
        {
            dice.Add(die);
        }

        public void RemoveAllDice()
        {
            this.dice.Clear();
            this.resultForEachRoll.Clear();
        }
        public void RollAllDice()
        {
            this.resultForEachRoll.Clear();
            foreach (Die die in dice)
            {
                this.resultForEachRoll.Add(die.Roll());
            }
        }

        public void RemoveSide(int side)
        {
            for(int i = 0; i < dice.Count; i++)
            {
                if (dice[i].numberOfSides == side)
                {
                    dice.RemoveAt(i);
                    resultForEachRoll.RemoveAt(i);
                    i--;
                }
            }
        }
    }
}
