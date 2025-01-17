﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppLoopAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            ////***************CONSOLE APP ASSIGNMENT : PART 1 *******************************
            ////create a one-dimensional array of strings
            //string[] adjectives = { "fast ", "goofy ", "hyper ", "big ", "hungry " };
            ////ask user input for some text
            //Console.WriteLine("Insert a type of animal");
            //string userAnimal = Console.ReadLine();
            ////Create a loop that iterates through each string in the array and adds the user's text input to the end of each string.
            ////This step will not output anything to the console, but will update each array element by appending the user's text.
            //for (int i = 0; i < adjectives.Length; i++)
            //{
            //    adjectives[i] = adjectives[i] +userAnimal;
            //}
            ////Create a loop that prints off each string in the array on a separate line.
            //for (int i = 0; i < adjectives.Length; i++)
            //{
            //    Console.WriteLine(adjectives[i]);
            //}

            //Console.ReadLine();

            //***************CONSOLE APP ASSIGNMENT : PART 2 *******************************
            //Create an infinite loop
            //This loop continues until i<50
            //The value of i will never be above 50
            //The condition i<50 will always be true 
            //for (int i = 0; i < 50; i--)
            //{
            //    Console.WriteLine("value : {0}", i);
            //}
            //Console.ReadLine();
            //fixed loop
            //for (int i = 0; i < 50; i++)
            //{
            //    Console.WriteLine("value : {0}", i);
            //}
            //Console.ReadLine();

            //for (int i = 0; i >= 0; i++)
            //{
            //    Console.WriteLine("value : {0}", i);
            //}
            //Console.ReadLine();

            //***************CONSOLE APP ASSIGNMENT : PART 3 *******************************
           // Create a loop where the comparison that’s used to determine whether to continue iterating the loop is a “<” operator.
           // int array
            int[] ages = { 40, 12, 33, 27, 85, 91, 50, 16 };
            //iterates through each item
            for (int a = 0; a < ages.Length; a++)
            {
                //if statement [i] is item that you are targeting
                if (ages[a] < 50)
                {
                    //goes through each item and logs it if less than 50
                    Console.WriteLine("Ages less than 50: " + ages[a]);

                }
            }
            Console.ReadLine();

            for (int i = 0; i <= 10; i++)
            {
                Console.WriteLine(i);
            }
            Console.ReadLine();

            //***************CONSOLE APP ASSIGNMENT : PART 4 * ******************************
            Console.WriteLine("Guess a letter that is in my name");
            //list of strings
            List<string> lettersName = new List<string>() { "b", "r", "e", "a", "n" };
            //iteration of list
            bool status = false;
            string userGuess;
            while (status != true)
            {
                userGuess = Console.ReadLine();

                if (lettersName.Contains(userGuess))
                {
                    Console.WriteLine("Correct. That letter is in my name. The index for this letter is: " + lettersName.IndexOf(userGuess));
                    status = true;
                }
                else
                {
                    Console.WriteLine("You guessed incorrectly. Please try again.");
                }
            }
            Console.ReadLine();



            //***************CONSOLE APP ASSIGNMENT : PART 5 *******************************
            Console.WriteLine("Guess a letter that is in my name");
            //list of strings
            List<string> lettersName = new List<string>() { "b", "r", "e", "a", "n", "n", "a" };
            //iteration of list
            bool status = false;
            string userGuess;
            int count = -1;
                userGuess = Console.ReadLine();

            foreach (string letter in lettersName)
            {
                count++;
                if (userGuess == letter)
                {

                    Console.WriteLine("Correct. That letter is in my name. The index of that letter is " + count + ".");

                }
            }

            if (!lettersName.Contains(userGuess))
            {
                Console.WriteLine("That letter is not in my name.");
            }
               
            
            Console.ReadLine();

            //***************CONSOLE APP ASSIGNMENT : PART 6 *******************************
            List<string> animalName = new List<string>() { "cat", "dog", "bird", "snake", "dog", "bunny", "dog" };
            List<string> nonDupe = new List<string>();

            foreach (string animal in animalName)
            {

                if (nonDupe.Contains(animal))
                {
                    Console.WriteLine(animal + " has already appeared in the list.");

                }
                //adds animal to nonDupe list
                else
                {
                    nonDupe.Add(animal);
                    Console.WriteLine(animal);
                }
            }

            Console.ReadLine();
        }
    }
}





