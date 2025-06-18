namespace Week_11_Assignment_11._2._1
{
    internal class Program
    {
        public static int MaxProfit(int[] prices)
        {
            int buying = int.MaxValue;
            int profit = 0;
            

            foreach (int price in prices)
            {
                if (price < buying )
                {
                    buying = price;
               
                }
                else if (price - buying > profit )
                {
                   profit = price - buying;
                }
                
            }         
            return profit;
            
        }
        static void Main(string[] args)
        {
            //int buying = int.MinValue;
            //int selling = int.MinValue;
      
            int[] prices = { 7, 1, 5, 3, 6, 4 };
            int profit = MaxProfit(prices);
            Console.WriteLine("Maximum profit is: " + profit);


        }
    }
}
