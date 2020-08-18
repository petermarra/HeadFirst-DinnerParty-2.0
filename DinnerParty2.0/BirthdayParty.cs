using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DinnerParty2._0
{
    class BirthdayParty:Party
    {
         
        private string cakeWriting;
        public string CakeWriting
        { 
            get 
            { 
                return cakeWriting; 
            }
        set
            {
                cakeWriting = value;
            }
        }
        public bool CakeWritingTooLong
        {
            get
            {
                if (CakeWriting.Length > MaxWritingLength())
                    return true;
                else
                    return false;
            }
        }
        private int ActualLength
        {
            get
            {
                if (CakeWriting.Length > MaxWritingLength())
                    return MaxWritingLength();
                else
                    return cakeWriting.Length;
            }
        }

       public override decimal Cost
        {
            get
            {
                decimal totalCost = base.Cost;
                decimal cakeCost;
                if (CakeSize() == 8)
                    cakeCost = 40M + ActualLength * .25M;
                else
                    cakeCost = 75M + ActualLength * .25M;
                return totalCost + cakeCost;

            }
        }

        public BirthdayParty(int numberOfPeople,
                             bool fancyDecorations,
                             string cakeWriting)
        {
            NumberOfPeople = numberOfPeople;
            FancyDecorations = fancyDecorations;
            CakeWriting = cakeWriting;
        }
    
        private int CakeSize()
        {
            if (NumberOfPeople <= 4)
                return 8;
            else
                return 16;
        }

        private int MaxWritingLength()
        {
            if (CakeSize() == 8)
                return 16;
            else
                return 40;
        }

       

    }
}
