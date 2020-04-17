using System;
using System.Collections.Generic;
using System.Text;

namespace LV2
{
    class DiceRoller : ILogable
    {
        private List<Die> dice;
        private List<int> resultForEachRoll;
        //Zadatak 4
        //private ILogger logger;

        public DiceRoller()
        {
            this.dice = new List<Die>();
            this.resultForEachRoll = new List<int>();
        }

        public void InsertDie(Die die)
        {
            dice.Add(die);
        }

        public void RollAllDice()
        {
            this.resultForEachRoll.Clear();
            foreach (Die die in dice)
            {
                this.resultForEachRoll.Add(die.Roll());
            }
        }

        public IList<int> GetRollingResults()
        {
            return new System.Collections.ObjectModel.ReadOnlyCollection<int>(
           this.resultForEachRoll
           );
        }

        public int DiceCount
        {
            get { return dice.Count; }
        }

        //Zadatak 4
        /*public void LogRollingResults()
        {
            foreach (int result in this.resultForEachRoll)
            {
                logger.Log(result.ToString());
            }
        }

        public void SetLogger(ILogger logger)
        {
            this.logger = logger;
        }*/

        public string GetStringRepresentation()
        {
            string result = "";
            foreach (int r in this.resultForEachRoll)
            {
                result += r.ToString();
                result += " ";
            }            
            return result;
        }
    }
}