

using System;
using System.Collections.Generic;
using System.Text;

namespace Mastermind
{
    class MainMenu
    {

        Game _game;

        private enum MainMenuChoice
        {
            eNotChosen,
            ePlayGame,
            eQuit
        }

        MainMenuChoice choice = MainMenuChoice.eNotChosen;

        public MainMenu()
        {

        }

        public void Run()
        {
            do
            {
                choice = IntToEnum(GetChoice());
                switch (choice)
                {
                    case MainMenuChoice.ePlayGame:
                        _game = new Game();
                        _game.Run();
                        choice = MainMenuChoice.eNotChosen;
                        break;
                    case MainMenuChoice.eQuit:
                        Environment.Exit(0);
                        break;
                }
            } while (choice == MainMenuChoice.eNotChosen);
        }

        private void DisplayMenu()
        {
            Console.WriteLine("\n        Welcome to MASTERMIND!\n");
            Console.WriteLine("Main Menu:");
            Console.WriteLine("    1. Play Game");
            Console.WriteLine("    2. Quit\n");
        }

        private int GetChoice()
        {
            bool valid;
            int choice;
            do
            {
                valid = true;
                DisplayMenu();
                if (!Int32.TryParse(Console.ReadLine(), out choice))
                {
                    valid = false;
                    Console.Clear();
                    Console.WriteLine("Invalid Input\n");
                }
                
            } while (!valid);
            return choice;
        }

        private MainMenuChoice IntToEnum(int n)
        {
            switch (n)
            {
                case 1:
                    return MainMenuChoice.ePlayGame;
                case 2:
                    return MainMenuChoice.eQuit;
                default:
                    Console.Clear();
                    Console.WriteLine("Invalid Input\n");
                    return MainMenuChoice.eNotChosen;
            }
        }


    }
}
