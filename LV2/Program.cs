using System;
using System.Collections.Generic;

namespace LV2
{
    class Program
    {
        static void Main(string[] args)
        {
            const int numberOfDice = 20;
            DiceRoller diceRoller = new DiceRoller();
            for (int i = 0; i < numberOfDice; i++)
            {
                diceRoller.InsertDie(new Die(6));
            }
            diceRoller.RollAllDice();
            IList<int> results = diceRoller.GetRollingResults();
            foreach (int result in results)
            {
                Console.WriteLine(result);
            }

            ConsoleLogger logger = new ConsoleLogger();
            logger.Log(diceRoller);

            

            /*ConsoleLogger logger=new ConsoleLogger();
            logger.Log(diceRoller);
            */

            //Zadatak 2
            /*Console.WriteLine();

            DiceRoller diceRoller2 = new DiceRoller();
            Random randomGenerator = new Random();
            for (int i = 0; i < numberOfDice; i++)
            {
                diceRoller2.InsertDie(new Die(6,randomGenerator));
            }
            diceRoller2.RollAllDice();
            IList<int> results2 = diceRoller2.GetRollingResults();
            foreach (int result in results2)
            {
                Console.WriteLine(result);
            }*/
        }
    }
}