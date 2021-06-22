using System;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            //Be sure to follow best practice when creating your classes

            //DONE -----
            // Create a class Animal
            // give this class 4 members that all Animals have in common

            //DONE -----
            // Create a class Bird
            // give this class 4 members that are specific to Bird
            // Set this class to inherit from your Animal Class

            //DONE -----
            // Create a class Reptile
            // give this class 4 members that are specific to Reptile
            // Set this class to inherit from your Animal Class



            //DONE -----
            /*Create an object of your Bird class
             *  give values to your members using the object of your Bird class
             *  
             * Creatively display the class member values 
             */

            var Flamingo = new Bird (true, "pink", true, "long + curved");
            #region
            Flamingo.CanFly = true;
            Flamingo.Wings = "pink";
            Flamingo.Feathered = true;
            Flamingo.Beak = "long + curved";
            #endregion

            //DONE -----
            /*Create an object of your Reptile class
             *  give values to your members using the object of your Reptile class
             *  
             * Creatively display the class member values 
             */

            var Snake = new Reptile (true, "yellow", true, "desert");
            #region
            Snake.ColdBlooded = true;
            Snake.ScaleColor = "yellow";
            Snake.Tail = true;
            Snake.Habitat = "desert";
            #endregion

            var myAnimals = new Animal[] { Flamingo, Snake };
            foreach (var animal in myAnimals)
            {
                Console.WriteLine($"{animal} is alive: {animal.IsAlive}.");
                Console.WriteLine($"{animal} {animal.Adapts} to adapt.");
                Console.WriteLine($"{animal} can reproduce: {animal.Reproduces}.");
                Console.WriteLine($"{animal} eats {animal.Eats}.");
            }

        }
    }
}
