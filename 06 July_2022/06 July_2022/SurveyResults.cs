using System;

using System.Collections.Generic;
using System.IO;
namespace WiredBrainCoffeeSurveys.Reports
{
    public static class SurveyResults
    {
        public static double ServiceScore { get; set; }

        public static double CoffeeScore { get; set; }

        public static double PriceScore { get; set; } 

        public static double FoodScore { get; set; } 

        public static double WouldRecommend { get; set; }

        public static string FavouriteProduct { get; set; } 

        public static string LeaseFavouriteProduct { get; set; } 

        public static string AreaToImprove { get; set; } 

        public static int NumberSurveyed { set; get; } 

        public static int NumberResponded { set; get; }

        public static double NumberRewardsMember { get; set; } 

        public static List<SurveyResponse> Responses = new List<SurveyResponse>()
        {
            new SurveyResponse()
            {
                EmailAddress = "test1@sample.com",
                CoffeeScore = 8.0,
                FoodScore = 9.0,
                PriceScore = 7.0,
                ServiceScore = 8.5,
                AreaToImprove = "MobileApp",
                FavouriteProduct = "Latte",
                LeaseFavouriteProduct = "Fruit",
                WouldRecommend = "8.0",
                Comments = "Coffee and service are great!"
            
            },
            new SurveyResponse()
            {
                EmailAddress = "test2@sample.com",
                CoffeeScore = 4.0,
                FoodScore = 9.0,
                PriceScore = 7.0,
                ServiceScore = 8.5,
                AreaToImprove = "MobileApp",
                FavouriteProduct = "Frappucino",
                LeaseFavouriteProduct = "Fruit",
                WouldRecommend = 8.0,
                Comments = "The mobile app looks good in Both Android and IOS"

            },
            new SurveyResponse()
            {
                EmailAddress = "test3@sample.com",
                CoffeeScore = 9.0,
                FoodScore = 8.0,
                PriceScore = 6.0,
                ServiceScore = 5.5,
                AreaToImprove = "Cleanliness",
                FavouriteProduct = "Cappucino",
                LeaseFavouriteProduct = "Fruit",
                WouldRecommend = 8.0,
                Comments = "Overall Good experience"

            },
            new SurveyResponse()
            {
                EmailAddress = "test4@sample.com",
                CoffeeScore = 8.0,
                FoodScore = 9.0,
                PriceScore = 7.0,
                ServiceScore = 8.5,
                AreaToImprove = "MobileApp",
                FavouriteProduct = "Latte",
                LeaseFavouriteProduct = "Fruit",
                WouldRecommend =8.0,
                Comments = "Coffee and service are great!"

            },
            new SurveyResponse()
            {
                EmailAddress = "test5@sample.com",
                CoffeeScore = 8.0,
                FoodScore = 9.0,
                PriceScore = 7.0,
                ServiceScore = 8.5,
                AreaToImprove = "others",
                FavouriteProduct = "Latte",
                LeaseFavouriteProduct = "Fruit",
                WouldRecommend = 8.0,
                Comments = "Coffee and service are great!"

            },
            new SurveyResponse()
            {
                EmailAddress = "test6@sample.com",
                CoffeeScore = 8.0,
                FoodScore = 9.0,
                PriceScore = 7.0,
                ServiceScore = 8.5,
                AreaToImprove = "Pricing",
                FavouriteProduct = "Latte",
                LeaseFavouriteProduct = "Fruit",
                WouldRecommend = 8.0,
                Comments = "Coffee and service are great!"

            },
            new SurveyResponse()
            {
                EmailAddress = "test7@sample.com",
                CoffeeScore = 8.0,
                FoodScore = 9.0,
                PriceScore = 7.0,
                ServiceScore = 8.5,
                AreaToImprove = "MobileApp",
                FavouriteProduct = "Latte",
                LeaseFavouriteProduct = "Fruit",
                WouldRecommend = 8.0,
                Comments = "Coffee and service are great!"

            },
            new SurveyResponse()
            {
                EmailAddress = "test8@sample.com",
                CoffeeScore = 8.0,
                FoodScore = 9.0,
                PriceScore = 7.0,
                ServiceScore = 8.5,
                AreaToImprove = "MobileApp",
                FavouriteProduct = "Latte",
                LeaseFavouriteProduct = "Fruit",
                WouldRecommend = 8.0,
                Comments = "Coffee and service are great!"

            },

        }
    }
        

}