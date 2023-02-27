using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetApplicationAssignment1
{
    /// <summary>
    ///1. Input from the user
    /// 1.1 Get name of the pet
    /// 1.2 Get the age of the pet
    /// 1.3 Get the gender of the pet
    /// 
    /// 2. Display the data entered by the user
    ///  2.1 Display name
    ///  2.2 Display age
    ///  2.3 Display gender
    /// </summary>
    class Pet
    {
        private string name; //name of the pet
        private int age; //age of the pet
        private bool isFemale; //gender of the pet, true if female

        public void Start()
        {
            ReadAndSavePetData(); //Inputs saved here
            DisplayPetInfo(); //Outputs displayed here
        }
        #region ReadAndSavePetData
        public void ReadAndSavePetData()
        {
            ReadName();
            ReadAge();
            ReadGender();
        }
        #endregion
        #region ReadName
        public void ReadName()
        {
            Console.Write("What's the name of your pet?: "); //Lets the user input name of pet
            name = Console.ReadLine(); //Saves name from the input inside the string "name"
        }
        #endregion
        #region ReadAge
        public void ReadAge()
        {
            Console.WriteLine(); //Blankspace
            Console.Write("What's the age of " + name + "?: "); //Lets the user input the age of the pet 
            age = int.Parse(Console.ReadLine());
        }
        #endregion
        #region ReadGender
        public void ReadGender()
        {
            Console.WriteLine(); //Blankspace
            Console.Write("Is " + name + " female? (y/n): "); //Lets user input y or n to the question
            char response = char.Parse(Console.ReadLine());

            if ((response == 'y') || (response == 'Y')) //If the user answers with a "y" or "Y" the pet is declared as a female
                isFemale = true;
            else
                isFemale = false;
        }
        #endregion
        #region DisplayPetInfo
        public void DisplayPetInfo()
        {
            Console.WriteLine(); //Blankspace
            Console.WriteLine("___________________________"); //Line to seperate input and output
            Console.WriteLine(); //Blankspace
            string textOut = "" + name + " is " + age + " years old.";
            Console.WriteLine(textOut); //Writes out what's saved in the string "textOut"
            Console.WriteLine(); //Blankspace
            if //If "isFemale" is true, writes out "good girl", if false writes out "good boy"
                (isFemale)
            Console.WriteLine("" + name + " is a good girl!");
            else
                Console.WriteLine("" + name + " is a good boy!");
            Console.WriteLine("___________________________");//Line to end the output
            Console.WriteLine(); //Blankspace

        }
        #endregion

    }
}
