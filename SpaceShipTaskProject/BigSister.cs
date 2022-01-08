using System;
using System.Collections.Generic;
using System.Text;

namespace SpaceShipExam
{
    public class BigSister
    {
        private int theYear = 2345;
        private int initialTax;
        private int declinesTax;
        private int increasesTax;
        private int lightMiles;
        
      
        public int TheYear
        {
            get => theYear;
            set
            {
                if (value == 0)
                {
                    throw new Exception();
                }
                theYear = value;
            }
        }
        public int InitialTax
        {
            get => initialTax;
            set=>initialTax = value;
        }
        public int DeclinesTax
        {
            get => declinesTax;
            set => declinesTax = value;
        }
        public int IncreasesTax
        {
            get => increasesTax;
            set => increasesTax = value;
        }
        public int LightMiles
        {
            get => lightMiles;
            set => lightMiles = value;
        }
    }
}
