using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OO_Programming_Challenge
{
    class die
    {

        static void Main(string[] args)
        {
            
                



            Console.WriteLine("Welcome to Caves and Lizards");
            Console.WriteLine("________________________________");

           
        // Task 1: Simulate a Dice Rolling
       
        
    

        Random rnd = new Random();
        int Dice = rnd.Next(1, 7); // picks a number between 1 and 6
        Console.ReadKey();
        int[] numbers =  new int[7];
        

     
        Console.WriteLine("\n You rolled a: " + Dice); 
        string vals = Console.ReadLine();
        new Random();



        // Task 2: Do you want to roll again and loops

        bool Continue = true;
        while(Continue){
        Console.WriteLine("Do you wish to roll once more? [Yes/No]\n Do you wish to display the average? [Avg]\n Do you wish to display the Total? [Total]\n Do you wish to display the Rolls? [Rolls]");
        string choice = Console.ReadLine();
        switch (choice)
                 {
                case "Yes" or "yes":
                Random rnd2 = new Random();
                int dice1 = rnd2.Next(1, 7);
                Console.WriteLine("\nYou rolled a: " + dice1);
                break;

                case "Total" or "total":
                Continue = false;
                Console.WriteLine();
                break;

                case "Avg" or "avg":
                Continue = false;
                double average = numbers.Average();

            Console.WriteLine("The average is: {0}", average);
            Console.ReadLine();
    
                
                break;

                case "No" or "no":
                Continue = false;
                Console.WriteLine("Thanks for playing!!");
                break;

                case "Rolls" or "rolls":
                Continue = false;
                Console.WriteLine(vals);
                break;
                 
                
                }
            }
        
        }
    }
}
