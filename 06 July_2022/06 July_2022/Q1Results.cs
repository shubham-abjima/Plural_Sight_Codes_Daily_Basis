using System;

using System.Collections.Generic;
using System.IO;
namespace WiredBrainCoffeeSurveys.Reports
{
    public static class Q1Results
    {
        public static double ServiceScore { get; set; } = 8.0;

        public static double CoffeeScore { get; set; } = 8.5;

        public static double PriceScore { get; set; } = 6.0;

        public static double FoodScore { get; set; } = 7.5;

        public static double WouldRecommend { get; set; } = 6.5;

        public static string FavouriteProduct { get; set; } = "Cappucino";

        public static string LeaseFavouriteProduct { get; set; } = "Frappucino";

        public static string AreaToImprove { get; set; } = "MobileApp";

        public static int NumberSurveyed { set; get; } = 500;

        public static int NumberResponded { set; get; } = 400;

        public static double NumberRewardsMember { get; set; } = 130;

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