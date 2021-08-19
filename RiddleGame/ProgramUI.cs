using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace RiddleGame
{
    public class ProgramUI
    {
        public enum Letters { E, C, H, O }
        public List<string> _letterList = new List<string>();

        public void Run()
        {   
            GameTitle gameTitle = new GameTitle();
            gameTitle.RunName(); 
            Console.BackgroundColor=ConsoleColor.Gray;
            Console.ForegroundColor = ConsoleColor.Red; 
            Console.ReadKey();

            Menu();
        }

        public void Menu()
        {

            bool continueToRun = true;
            while (continueToRun)
            {
                Console.Clear();

                Console.WriteLine($"\t\t\t\n\nWelcome to the Riddle Game! I will give you a riddle to solve. Solve the riddle by going down each path and collecting" +
                    " letters to help you find the answer!\n\n\t\t\t\t\t\tHere is your riddle:\n\n~~~I speak without a mouth and hear without ears. I have no body, but " +
                    "I come alive with wind. What am I??~~~\n\nChoose from the following options by typing the number path you'd like to go down.\n\tMenu:\n\tPath " +
                    "1\n\tPath 2\n\tPath 3\n\tPath 4\n\t5. See aquired letters\n\t6. Guess Riddle\n\t7. Exit");

                string userInput = Console.ReadLine();
                if (_letterList.Contains("C") && _letterList.Contains("E") && _letterList.Contains("H") && _letterList.Contains("O"))
                {
                    Console.Clear();
                    Console.WriteLine("\t\n\nYou have all the letters needed for the answer! Press any key to go to main menu and make your guess!");
                    Console.WriteLine("\n\t\nYou acquired the followings:\n\n");
                    _letterList.ForEach(Console.WriteLine);
                    Console.ReadKey();
                }


                switch (userInput)
                {
                    case "1":
                        PathOne();
                        break;
                    case "2":
                        PathTwo();
                        break;
                    case "3":
                        PathThree();
                        break;
                    case "4":
                        PathFour();
                        break;
                    case "5":
                        SeeAquiredLetters();
                        break;
                    case "6":
                        GuessRiddle();
                        break;
                    case "7":
                        Console.Clear();
                        Console.WriteLine("\n\tGoodbye!");
                        Thread.Sleep(2000);
                        break;
                    default:
                        Console.WriteLine("\n\tEnter a valid number");
                        break;
                }
            }
        }

        public void PathOne()
        {
            Console.Clear();
            Console.WriteLine("\n\tYou found another riddle!\nWhat time is it when en elephant sits on your fence?\n\n1. Time to get a new fence\n2. Time to get a new elephant\nChoose your answer with a 1 or 2\n");
            string userInput = Console.ReadLine();
            if (userInput == "1")
            {
                Console.Clear();
                Console.WriteLine("\n\tYou better get a new fence, yours is broken!!\n\nYou get a 'C'!!\n\nPress any key to go to main menu");
                if(!_letterList.Contains("C"))_letterList.Add("C");
                Console.ReadKey();
            }
            else if (userInput == "2")
            {
                Console.Clear();
                Console.WriteLine("\n\tYou certainly need a new, not so rude elephant, but no letter for you! Go back and try again!\n\nPress any key to go try again");
                Console.ReadKey();
                PathOne();
            }
            else
            {
                Console.Clear();
                Console.WriteLine("\n\tChoose either a 1 or a 2!!\n\nPress any key to go try again");
                Console.ReadKey();
                PathOne();

            }


        }
        public void PathTwo()
        {
            Console.Clear();
            Console.WriteLine("\n\tWhat gets wet while drying\n\n1. Water\n2. A Towel\nChoose your answer with a 1 or 2\n");

            string command = Console.ReadLine().ToLower();

            if (command == "2")
            {
                Console.Clear();
                Console.WriteLine("\n\tSure! I hope you know why. Just kidding. Of course you know! As an award, I will give you a letter, which is 'O'. Not zero!\n\nPress any key to go to main menu");
                if(!_letterList.Contains("O"))_letterList.Add("O");
                Console.ReadKey();
            }
            else if (command == null)
            {
                Console.Clear();
                Console.WriteLine("\n\tChoose one of the options: 1 or 2?\n\nPress any key to try again");
                Console.ReadKey();
                PathTwo();
            }
            else
            {
                Console.Clear();
                Console.WriteLine("\n\tOoops! No! I think you know what to choose now\n\nPress any key to try again");
                Console.ReadKey();
                PathTwo();

            }

        }
        public void PathThree()
        {
            Console.Clear();
            Console.WriteLine("\n\tWhat can you hold in your right hand, but never in your left hand?\n\n1. A right handed pencil\n2. Your left hand\nChoose your answer with a 1 or 2\n");

            string userInput = Console.ReadLine().ToLower();

            if (userInput == "1")
            {
                Console.Clear();
                Console.WriteLine("\n\tAre there really right and left handed pencils O_o?? Try again!!\n\nPress any key to try again...");
                Console.ReadKey();
                PathThree();
            }
            else if (userInput == "2")
            {
                Console.Clear();
                Console.WriteLine("\n\tThat's right! You CAN hold someone else's left hand, but not your own! you get a 'E'!!!\n\nPress any key to go to main menu");
                if(!_letterList.Contains("E"))_letterList.Add("E");
                Console.ReadKey();
            }
            else
            {
                Console.Clear();
                Console.WriteLine("\n\tPlease choose either a 1 or a 2!\n\nPress any key to try again...");
                Console.ReadKey();
                PathOne();

            }


        }
        public void PathFour()
        {
            Console.Clear();
            Console.WriteLine("\n\tWhat can you catch, but not throw?\n\n1. A cold\n2. a REEEEEEEALLY heavy ball\nChoose your answer with a 1 or 2\n");
            {
                string command = Console.ReadLine().ToLower();

                if (command == "1")
                {
                    Console.Clear();
                    Console.WriteLine("\n\tSmart! I doubted that you would guess it...kidding...I have a surprise for you. Letteeeeeeer: 'H'!\n\nPress any key to go to main menu");
                    if(!_letterList.Contains("H"))_letterList.Add("H");
                    Console.ReadKey();
                }
                else if (command == null)
                {
                    Console.Clear();
                    Console.WriteLine("\n\tChoose one of the options: 1 or 2?\n\nPress any key to try again...");
                    Console.ReadKey();
                    PathFour();
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("\n\tOoops! Not correct! I think you know what to choose now\n\nPress any key to try again...");
                    Console.ReadKey();
                    PathFour();
                }

            }
        }
        public void SeeAquiredLetters()
        {
            Console.Clear();
            //Console.WriteLine("Here are all the letters you've aquired!");
            //string userInput = Console.ReadLine();
            if (_letterList.Count == 0)
            {
                    Console.Clear();
                    Console.WriteLine($"\t\n You thought you solved the riddles? Not yeeet! Go back and solve some, and earn letters." +
                        $"\n\n\n\nPress any key to go to the main menu...");
                    Console.ReadKey();
            }
            else
            {
                Console.Clear();
                Console.WriteLine("\n\t\nYou acquired the followings:\n\n");
                _letterList.ForEach(Console.WriteLine);
                Console.WriteLine("\n\n\n\nPress any key to go to the main menu...");
                Console.ReadKey();
            }
            //foreach (string letter in _letterList)
            //{
            //    //if (_letterList.Count == 4)
            //    //{
            //    //    Console.Clear();
            //    //    Console.WriteLine("\n\t\nYou acquired the followings:\n\n");
            //    //    _letterList.ForEach(Console.WriteLine);
            //    //    GuessRiddle();
            //    //    Console.ReadKey();
            //    //}
            //    if (letter == null)
            //    {

            //    }
            //}

        }
        public void GuessRiddle()
        {
            Console.Clear();
            Console.WriteLine("\n\tWhat is your guess to the riddle?\n\nI speak without a mouth and hear without ears. I have no body, but i come alive with wind. What am I??");
            string command = Console.ReadLine().ToLower();

            if (command == "echo")
            {
                Console.Clear();
                Console.WriteLine("\n\tWow! You are AMAZING!\n\nPress any key to go to main menu");
                Console.ReadKey();
            }
            else if (command != "echo")
            {
                Console.Clear();
                Console.WriteLine("\n\tOoops! Try again!\n\nPress any key to go to the menu");
                Console.ReadKey();
                    
            }
            else
            {
                Console.Clear();
                Console.WriteLine("\n\tI thought you said you wanted to guess!\n\nPress any key to go to main menu");
                Console.ReadKey();
            }

        }















    }
}
