using System;

namespace numberPicker
{
    class Program
    {
        static void Main(string[] args)
        {
            Random randomNum = new Random();
            int computerChoice = randomNum.Next(1, 101);
            
            Console.WriteLine(@"
            Welcome to number picker.
    Try and guess the number the computer picked.
            Pick a number between 1-100
            ");
            bool running = true;
        while(running){

            string choice = Console.ReadLine();
           try{
               int result = Int32.Parse(choice);
            Console.WriteLine($"You picked the number {choice}");
            if(result == computerChoice){
                Console.Clear();
                Console.WriteLine("You got it right! Congradulations!!");
                running = false;
            }else if(result < computerChoice){
                Console.Clear();
                Console.WriteLine("You guessed too low, try again");
            }else {
                Console.Clear();
                Console.WriteLine("You guessed too high, try again");
            }
           }
           catch (FormatException){
               Console.Clear();
               Console.WriteLine("That is not a number, please pick a number.");
           }

        }
    }
}}
