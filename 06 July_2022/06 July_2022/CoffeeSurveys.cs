using System;
namespace WiredBrainCoffeeSurveys.Reports
{
    class Program
    {
        static void Main(string[] args)
        {
            GenerateWinnerEmails();
            GenerateTasksReport();
            GenerateCommetsReport();
        }
        public static void GenerateWinnerEmails()
        {
            var selectedEmails = new List<string>();
            int Counter = 0;

            Console.WriteLine(Environment.NewLine + "Selected Winner Outputs:");
            while(selectedEmails.Count < 2 &&  Counter <Q1Results.Responses.Count)
            {
                var currentItem = Q1Results.Responses[Counter];
                if(currentItem.FavouriteProduct == "Cappucino")
                {
                    selectedEmails.Add(currentItem.EmailAddress);
                    Console.WriteLine(currentItem.EmailAddress);
                }
                Counter++;

            }
            File.WriteAllLines("WinnerReport.csv", selectedEmails);
        }

        private static void GenerateCommetsReport()
        {
            for (var i = 0; i < Q1Results.Responses.Count; i++)
            {
                var currentResponse = Q1Results.Responses[i]; ;
                if (currentResponse.WouldRecommend < 7.0)
                {
                    Console.WriteLine(currentResponse.Comments);

                }
            }
            foreach (var response in Q1Results.Responses)
            {
                if (response.AreaToImprove == Q1Results.AreaToImprove)
                {
                    Console.WriteLine(response.Comments);

                }
            }
        }

        public static void GenerateTasksReport()
        {
            var tasks = new List<string>();

            double responseRate = Q1Results.NumberResponded / Q1Results.NumberSurveyed;
            //double unansweredCount = Q1Results.NumberSurveyed - Q1Results.NumberResponded;
            double OverAllScore = Q1Results.ServiceScore + Q1Results.FoodScore + Q1Results.PriceScore + Q1Results.CoffeeScore / 4;

            /*Console.WriteLine($"Response Percentage: {responseRate}");
            Console.WriteLine($"unanswered Surveys: { unansweredCount}");
            Console.WriteLine($"Overall Score: {OverAllScore}");*/


            bool isCoffeeScoreLower = Q1Results.CoffeeScore < Q1Results.FoodScore;
            //bool CustomersRecommend = Q1Results.WouldRecommend > 7;
            //bool noFrappucinoYesCappucino = Q1Results.LeaseFavouriteProduct == "Frappucino" && Q1Results.FavouriteProduct == "Cappucino";


            /*Console.WriteLine($"Coffe Score higer than food Score: {higherCoffeeScore}");
            Console.WriteLine($"Customer Recommends:{CustomersRecommend}");
            Console.WriteLine($"No Frappucino Yes Cappucino:{noFrappucinoYesCappucino}");*/

            if (isCoffeeScoreLower)
            {
                tasks.Add("Investiage the coffee recipes.");

            }
            else if (OverAllScore > 8.0)
            {
                tasks.Add("Work with leadership to reward staff.");

            }
            else
            {
                tasks.Add("Work with employees for improvement ideas.");
            }

            if (responseRate < .33)
            {
                tasks.Add("Research option to improve response rate.");

            }
            else if (responseRate > .33 && responseRate < .66)
            {
                tasks.Add("Rewards participants with free coffee coupan.");

            }
            else
            {
                tasks.Add("Rewards participants with discount coffee coupan.");
            }

            switch (Q1Results.AreaToImprove)
            {
                case "RewardProgram":
                    tasks.Add("Revisit the rewards deals.");
                    break;
                case "Cleanliness":
                    tasks.Add("Contact the cleaning vendor.");
                    break;
                case "MobileApp":
                    tasks.Add("Conatct consulting firm about app.");
                    break;
                default:
                    tasks.Add("Investigate individual comments for ideas.");
                    break;

            }
            Console.WriteLine(Environment.NewLine + "Tasks Output:");
            foreach(var task in tasks)
            {
                Console.WriteLine(task);

            }
            File.WriteAllLines("TasksReport.csv",tasks)
        }
    }
}