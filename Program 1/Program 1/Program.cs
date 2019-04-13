/*Grading ID: A7272
 * Class: CIS 199-01
 * Program 1
 * Due: 9/26/17
 * Description:  This program gathers information about a room the user intends to paint and calculates the numbre of gallons the user will need to purchase to paint the room. */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Program_1
{
    class Program
    {
        static void Main(string[] args)
        {
            double LengthOfWalls;  //Holds the total length of the walls 
            double HeightOfWalls;  //Holds the height if the walls 
            int NumberOfDoors;  //Holds the number of doors in the room
            const int DoorSize = 20;  // Holds the square footage taken up by a single door
            int SqFtOfDoors;  //Holds the total Square footage taken up by the doors in the room
            int NumberOfWindows;  //Holds the number of windows in the room
            const int WindowSize = 15;  //Holds the square footage taken up by a single window
            int SqFtWindows;  //Holds the total square feet taken up by the windows in the room
            int NumberOfCoats;  //Holds the number of coats that the user wishes to apply 
            const int GallonCoverage = 350;  //Holds the max square feet one gallon of paint will cover
            double MinGallons;  //Holds the exact amount of gallons needed to paint the room
            int GallonsToBuy;  //Holds the number of gallons the user will have to buy

            WriteLine("Welcome to the Hand-Dandy Paint Estimator");


            WriteLine("\n\nEnter the total length of all walls (in feet): ");
            LengthOfWalls = double.Parse(ReadLine());  //Converts the user input into a double and saves it to the Variable
            WriteLine("Enter the height of the walls (in feet): ");
            HeightOfWalls =  double.Parse(ReadLine());  //Converts the user input into a double and saves it to the Variable
            WriteLine("Enter the Number of Doors in the room (Non-Neg Int): ");
            NumberOfDoors = int.Parse(ReadLine());  //Converts the user input into a Integer and saves it to the Variable
            WriteLine("Enter the number of windows in the room (Non-Neg Int): ");
            NumberOfWindows = int.Parse(ReadLine()); //Converts the user input into a Integer and saves it to the Variable
            WriteLine("Enter the number of coats of paint (Non-Neg Int): ");
            NumberOfCoats = int.Parse(ReadLine());  //Converts the user input into a Integer and saves it to the Variable

            SqFtOfDoors = NumberOfDoors * DoorSize;  //Calculates the total Square footage taken by doors in the room
            SqFtWindows = NumberOfWindows * WindowSize; //Calculates the total square footage taken by windows in the rooom

            MinGallons = (((LengthOfWalls * HeightOfWalls) - (SqFtOfDoors + SqFtWindows)) * NumberOfCoats) / GallonCoverage;  //Calcluates the exact/minimum ammount of paint needed to paint the room
            WriteLine($"You'll need a minimum of {MinGallons:F1} Gallons of paint");
            GallonsToBuy = (int)Math.Ceiling(MinGallons);  //Rounds up the Minimum amount of paint needed up to the nearest gallon
            WriteLine($"You'll need to buy {GallonsToBuy} Gallons, though");
        }
    }
}
