using System.Collections.Generic;

namespace FuegoOrderingSystem
{
    public static class QueueData
    {
        public static List<string> PreparingQueue = new List<string> { "102", "114", "103", "105", "117" };
        public static List<string> ServingQueue = new List<string> { "098", "099", "100", "101" };
        private static int nextOrderNum = 104;

        public static string AddNewOrder()
        {
            string newNum = nextOrderNum.ToString();
            PreparingQueue.Add(newNum);
            nextOrderNum++;
            return newNum;
        }
    }
}
