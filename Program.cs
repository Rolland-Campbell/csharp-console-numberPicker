using System;

namespace numberPicker
{
    class Program
    {
        static void Main(string[] args)
        {
            Random randomNum = new Random();
            int computerChoice = randomNum.Next(0, 100);
            
            Console.WriteLine(@"
            Welcome to number picker.
    Try and guess the number the computer picked.
            Pick a number between 1-100
            ");
            bool running = true;
        while(running){

            int choice = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"You picked the number {choice}");
            if(choice == computerChoice){
                Console.WriteLine("You got it right! Congradulations!!");
                running = false;
            }else if(choice < computerChoice){
                Console.WriteLine("You guessed too low, try again");
            }else {
                Console.WriteLine("You guessed too high, try again");
        }
        }
    }
}}
