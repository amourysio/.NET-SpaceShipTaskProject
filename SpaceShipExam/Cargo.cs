using System;
using System.Collections.Generic;
using System.Text;

namespace SpaceShipExam
{
   public  class Cargo : BigSister
    {
        private int boughtSpaceShipYear;


        public Cargo()
        {
            this.LightMiles = LightMiles;
            this.boughtSpaceShipYear = BoughtSpaceShipYear;
            this.InitialTax = 10000;
            this.DeclinesTax = 736;
            this.IncreasesTax = 1000;
        }
        public int BoughtSpaceShipYear
        {
            get => boughtSpaceShipYear;
            set => boughtSpaceShipYear = value;
        }

        public int Result()
        {
            int intInitialTax = (int)InitialTax;
            if (TheYear > boughtSpaceShipYear)
            {
                boughtSpaceShipYear = TheYear - boughtSpaceShipYear;
            }
            else
            {
                Console.WriteLine("The Year Now is 2345, Please Enter The year you bought Spaceship");
                throw new Exception("Test1");
            }
            LightMiles = LightMiles / 1000;
            return intInitialTax + LightMiles * IncreasesTax - boughtSpaceShipYear * DeclinesTax;
        }

    }
}
