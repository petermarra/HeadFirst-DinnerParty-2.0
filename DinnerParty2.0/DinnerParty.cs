using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dinner_Party
{
    public class DinnerParty
    {
        public const int CostOfFoodPerPerson = 25;

        public int NumberOfPeople { get; set; }
        public bool FancyDecorations { get; set; }
        public bool HealthyOption { get; set; }
        public decimal Cost
        {
            get
            {
                decimal totalCost = 0;
                totalCost += CalculateCostOfDecorations();
                totalCost += (CostOfFoodPerPerson + CalculateCostOfBeveragesPerPerson()) * NumberOfPeople;

                if (HealthyOption)
                {
                    totalCost *= .95m;
                }
                return totalCost;
            }
        }

        public DinnerParty(int numberOfPeople, bool healthyOption, bool fancyDecorations)
        {
            NumberOfPeople = numberOfPeople;
            HealthyOption = healthyOption;
            FancyDecorations = fancyDecorations;
        } 

        private decimal CalculateCostOfDecorations()
        {
            if (FancyDecorations)
            {
                return (15.00m * NumberOfPeople) + 50m;
            }
            else
            {
                return (7.50m * NumberOfPeople) + 30m;
            }
        }
        private decimal CalculateCostOfBeveragesPerPerson()
        {
            if (HealthyOption)
            {
                return 5.00m;
            }
            else
            {
                return 20.00m;
            }
        }
    }

}
