using System;

namespace SpaceShipExam
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                
                Family family = new Family();
                 family.BoughtSpaceShipYear = 2338;
                 family.LightMiles = 2_344;
                 Console.WriteLine("Family SpaceShip Tax Result is:"+ family.Result());
 
            }

             catch (Exception s)
            {
                Console.WriteLine(s.Message);
                Console.WriteLine(s.StackTrace);
            }

            try
            {

            Cargo cargo = new Cargo();
            cargo.BoughtSpaceShipYear = 2308;
            cargo.LightMiles = 344_789;
            Console.WriteLine("Cargo SpaceShip Tax Result is:" + cargo.Result());
            }
            catch (Exception s)
            {
                Console.WriteLine(s.Message);
                Console.WriteLine(s.StackTrace);
            }

          
           

        }
    }
}
