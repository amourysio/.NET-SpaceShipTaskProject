using System;

namespace SpaceShipExam
{
    public class Family: BigSister
    {
        private int boughtSpaceShipYear;
    

        public Family()
        {
            this.LightMiles = LightMiles;
            this.boughtSpaceShipYear = boughtSpaceShipYear;
            this.InitialTax = 5000;
            this.DeclinesTax = 355;
            this.IncreasesTax = 100;
        }
        public int BoughtSpaceShipYear
        { 
            get => boughtSpaceShipYear;
            set => boughtSpaceShipYear = value;
        }
        

        public int Result()
        {
            if(TheYear > boughtSpaceShipYear)
            {
             boughtSpaceShipYear = TheYear - boughtSpaceShipYear;
            }
            else
            {
                Console.WriteLine("The Year Now is 2345, Please Enter The year you bought Spaceship");
                throw new Exception("Test2");
            }
             LightMiles = LightMiles / 1000;
             return InitialTax + LightMiles * IncreasesTax - boughtSpaceShipYear * DeclinesTax;
        }



    }
}
