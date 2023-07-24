using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuessNumbergame
{
    internal class Program
    {
        //static void Main(string[] args)
        //{
        //    Console.WriteLine("Guess a number : ");
        //    int guessnum = int.Parse(Console.ReadLine());
        //    int corectnum = 58;

        //    while (true)
        //    {
        //        if (guessnum > corectnum)
        //        {
        //            Console.WriteLine("Answer is too high please guess another number  ");
        //          //  int newnum = int.Parse(Console.ReadLine());

        //        }

        //        else if (guessnum < corectnum)
        //        {
        //            Console.WriteLine("Answer is too high please guess another number  ");
        //            //int newnum = int.Parse(Console.ReadLine());

        //        }
        //        else if (guessnum == corectnum)
        //        {
        //            Console.WriteLine(" Answer is corect ");
        //            break;
        //        }
        //        guessnum = int.Parse(Console.ReadLine());
        //    }
              
        //}

       


    
       
        
            static void Main(string[] args)
            {
                Console.WriteLine("Guess a number: ");
                int guessnum = int.Parse(Console.ReadLine());
                int correctnum = 58;

                while (true)
                {
                    if (guessnum > correctnum)
                    {
                        Console.WriteLine("Answer is too high. Please guess another number: ");
                    }
                    else if (guessnum < correctnum)
                    {
                        Console.WriteLine("Answer is too low. Please guess another number: ");
                    }
                    else if (guessnum == correctnum)
                    {
                        Console.WriteLine("Answer is correct.");
                        break; // Break out of the loop if the guess is correct
                    }

                    // Read the new guessed number outside of the if statements
                    guessnum = int.Parse(Console.ReadLine());
                }

                Console.ReadLine();
            }
        }
    }



