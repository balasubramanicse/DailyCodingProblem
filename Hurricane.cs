/*
 An imminent hurricane threatens the coastal town of Codeville. If at most two people can fit in a rescue boat, and the maximum weight limit for a given boat is k, determine how many boats will be needed to save everyone.

For example, given a population with weights [100, 200, 150, 80] and a boat limit of 200, the smallest number of boats required will be three.
 */

namespace DailyCodingProblem
{
    public class Hurricane
    {
        private readonly int[] PeopleData;
        private readonly int BoatSize;
        public Hurricane(int[] peopleData, int boatSize)
        {
            PeopleData = peopleData;
            BoatSize = boatSize;
        }

        private int GetPeopleCount()
        {
            int totalPeople = 0;
            for (int i = 0; i < PeopleData.Length; i++)
            {
                totalPeople = totalPeople + PeopleData[i];
            }
            return totalPeople;

        }
        public int GetBoatsNeeded()
        {
            int neededBoats = 0;
            int totalPeople = GetPeopleCount();
            neededBoats = totalPeople / BoatSize;
            return totalPeople % BoatSize == 0 ? neededBoats : neededBoats + 1;
        }
    }
}
