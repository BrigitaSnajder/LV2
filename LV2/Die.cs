using System;
using System.Collections.Generic;
using System.Text;

namespace LV2
{
    class Die
    {
        public int numberOfSides;
        //Zadatak 1
        //private Random randomGenerator;
        private RandomGenerator randomGenerator;

        public Die(int numberOfSides)
        {
            this.numberOfSides = numberOfSides;
            //Zadatak 1
            //this.randomGenerator = new Random();
            this.randomGenerator = RandomGenerator.GetInstance();
        }

        //Zadatak 2
        /*public Die(int numberOfSides, Random randomGenerator)
        {
            this.numberOfSides = numberOfSides;
            //this.randomGenerator = randomGenerator;
        }*/


        public int Roll()
        {
            //Zadatak 1 & 2
            //int rolledNumber = randomGenerator.Next(1, numberOfSides + 1);
            int rolledNumber = randomGenerator.NextInt(1, numberOfSides + 1);
            return rolledNumber;
        }
    }
}