using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DinnerParty2._0
{
   class DinnerParty:Party


    {
         public bool HealthyOption { get; set; }
        public override decimal Cost
        {
            get
            {
                decimal totalCost = base.Cost;
                totalCost += CalculateCostOfBeveragesPerPerson() * NumberOfPeople;

                if (HealthyOption)
                    totalCost *= .95m;
                return totalCost;
            }
        }

        public DinnerParty(int numberOfPeople, bool healthyOption, bool fancyDecorations)
        {
            NumberOfPeople = numberOfPeople;
            HealthyOption = healthyOption;
            FancyDecorations = fancyDecorations;
        } 
         
        private decimal CalculateCostOfBeveragesPerPerson()
        {
            if (HealthyOption)
                return 5.00m;
            else
                return 20.00m;
        }
    }

}
