using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoopyPlanet_Max_Zaozernyy
{
    class Project
    {
        static void Main(string[] args)
        {


            {


                //Initialisation of variables

                double weight = 0;
                int menuChoice = 0;
                double ratio = 0;
                string Destination = "";


                while (menuChoice !=9) // The loop is going to run unless user choice equal to 9
                

                {
                    Console.WriteLine("     Welcome Human"); // This is the console menu from which user chooses the Destination
                    Console.WriteLine("  Choose your Destination");
                    Console.WriteLine("------------------------------------");
                    Console.WriteLine("1. Jupiter   2. Mars.   3. Mercury |");
                    Console.WriteLine("4. Neptune   5. Pluto   6. Saturn  |");
                    Console.WriteLine("7. Uranus    8. Venus   9. <Quit>  |");
                    Console.WriteLine("------------------------------------");
                    Console.WriteLine("\n\n");

                    {

                        Console.Write("Enter Your Destination: "); // Asks the user for Destination
                        menuChoice = int.Parse(Console.ReadLine()); //Converts user input into integer


                    }


                    switch (menuChoice) // The switch will determine the what happens with each choice, and calculate accordingly.
                    {
                        case 1:
                            ratio = 2.64;
                            Destination = "Jupiter";
                            break;

                        case 2:
                            ratio = 0.38;
                            Destination = "Mars";
                            break;

                        case 3:
                            ratio = 0.37;
                            Destination = "Mercury";
                            break;

                        case 4:
                            ratio = 1.12;
                            Destination = "Neptune";
                            break;

                        case 5:
                            ratio = 0.04;
                            Destination = "Pluto";
                            break;

                        case 6:
                            ratio = 1.15;
                            Destination = "Saturn";
                            break;

                        case 7:
                            ratio = 1.15;
                            Destination = "Uranus";
                            break;

                        case 8:
                            ratio = 0.88;
                            Destination = "Venus";
                            break;
                        case 9: //Exits the Console
                            Console.WriteLine("\nDestination does not exist");
                            Console.WriteLine("\nCosnsole will now be terminated\n");
                            continue;
                        default:

                            continue; //Skips the remaining the code.

                    }

                    Console.WriteLine("\nYour Destination is: " + Destination); //Let the user know of the chosen Destination

                    Console.Write("\nYou May Enter Your Weight in Pounds Now: "); //Asks to input users weight
                    weight = double.Parse(Console.ReadLine()); //Conversion of user input to double value

                    double FinalW = 0;
                    FinalW = (ratio * weight); //How the weight is calculated for planets other than Earth
                    Console.WriteLine("\nYour weight on Earth is " + weight + " pounds, which is " + FinalW + " Pounds on " + Destination + "\n"); //Outputs the calculation, stating the result as per the chosen option


                   


                }
            }
        }
    }
}