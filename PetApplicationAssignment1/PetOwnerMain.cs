using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetApplicationAssignment1
{
    class PetOwnerMain
    {
        static void Main(string[] args)
        {
            #region Console window decoration 
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.Clear(); //Paints colour with the one declared above
            Console.ForegroundColor = ConsoleColor.White; //Text colour
            Console.Title = "Pet Application!";
            #endregion

            Pet petObj = new Pet(); //Create object of Pet
            petObj.Start(); //Use object Pet

            Console.WriteLine("Press Enter to exit!"); //Directions to close the program
            Console.ReadLine(); //When Enter is pressed the program closes
        }
    }
}
