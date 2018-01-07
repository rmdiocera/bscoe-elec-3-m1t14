using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Hacker : MonoBehaviour {

    string ans;
    int num, num2;
    string word;
    string[] Level1Library = {"cuffs","guns","knife","bail","crime"};
    string[] Level2Library = { "tuxedo", "leather", "glasses", "silent", "access" };
    string[] Level3Library = { "treasure", "classified", "experiment", "contract", "confidential" };
    enum Screen {MainMenu, Password, Win};
    Screen currentScreen = Screen.MainMenu;



    // Use this for initialization
    void Start() {
        string greeting = "Welcome to the Hacking Game,";
        ShowMainMenu(greeting);
    }
    void ShowMainMenu(string greeting)
    {
        currentScreen = Screen.MainMenu;
        Terminal.WriteLine(greeting + " M1T14!");
        Terminal.WriteLine("");
        Terminal.WriteLine("What would you like to hack today?");
        Terminal.WriteLine("Press 1 for the Police Directory");
        Terminal.WriteLine("Press 2 for the Secret Service");
        Terminal.WriteLine("Press 3 for the Restricted Files");
        Terminal.WriteLine("");
        Terminal.WriteLine("Enter your selection:");
    }

    void OnUserInput(string input)
    {
        if (currentScreen == Screen.MainMenu)
        {
            if (input.Equals("Menu", StringComparison.InvariantCultureIgnoreCase))
            {
                Terminal.ClearScreen();
                ShowMainMenu("You returned to the main screen,");
            }

            else if (input == "1")
            {
                Terminal.ClearScreen();
                Terminal.WriteLine("Loading Local Library.....");
                StartGame(1);
                num2 = 1;
                
            }

            else if (input == "2")
            {
                Terminal.ClearScreen();
                Terminal.WriteLine("Loading System Security.....");
                StartGame(2);
                num2 = 2;
            }

            else if (input == "3")
            {
                Terminal.ClearScreen();
                Terminal.WriteLine("Loading Global Access.....");
                StartGame(3);
                num2 = 3;
            }

            else if (input == "EXB")
            {
                Terminal.ClearScreen();
                Terminal.WriteLine("    Kalimutan mo na yan");
                Terminal.WriteLine("    Sige-sige maglibang");
                Terminal.WriteLine("    Wag kang magpakahibang");
                Terminal.WriteLine("    Dapat ay itawa lang");
                Terminal.WriteLine("    Ang problema sa babae");
                Terminal.WriteLine("    Dapat 'di iniinda");
                Terminal.WriteLine("    Hayaan mo sila ang maghabol sa'yo");
                Terminal.WriteLine("    'Di ba?");
            }

            else
            {
                Terminal.WriteLine("Error. Please select another option.");
            }
        }

        else if (currentScreen == Screen.Password)
        {

            if (input.Equals(word))
            {
                Terminal.ClearScreen();
                WinScreen();
            }
            else
            {
                Terminal.WriteLine("Wrong password! Please try again.");
                Terminal.WriteLine("");
                StartGame(num2);
            }

        }

        else if (currentScreen == Screen.Win)
        {
            
            if (input.Equals("Menu", StringComparison.InvariantCultureIgnoreCase))
            {
                Terminal.ClearScreen();
                ShowMainMenu("You returned to the main screen,");
            }
            else
            {
                Terminal.WriteLine("Please type a valid keyword.");
            }
        }

    }

    void StartGame(int level)
    {

        
        if (level == 1)
        {
            currentScreen = Screen.Password;
            num = UnityEngine.Random.Range(0, 5);
            word = Level1Library[num];
            Terminal.WriteLine("Solve the password: " + StringExtension.Anagram(Level1Library[num]));
        }

        if (level == 2)
        {
            currentScreen = Screen.Password;
            num = UnityEngine.Random.Range(0, 5);
            word = Level2Library[num];
            Terminal.WriteLine("Solve the password: " + StringExtension.Anagram(Level2Library[num]));
        }

        if (level == 3)
        {
            currentScreen = Screen.Password;
            num = UnityEngine.Random.Range(0, 5);
            word = Level3Library[num];
            Terminal.WriteLine("Solve the password: " + StringExtension.Anagram(Level3Library[num]));
        }
    }

    void WinScreen()
    {
        currentScreen = Screen.Win;
        Terminal.WriteLine("        ▒▒▒▒▒▄██████████▄▒▒▒▒▒ ");
        Terminal.WriteLine("        ▒▒▒▄██████████████▄▒▒▒");
        Terminal.WriteLine("        ▒▒██████████████████▒▒");
        Terminal.WriteLine("        ▒▐███▀▀▀▀▀██▀▀▀▀▀███▌▒");
        Terminal.WriteLine("        ▒███▒▒▌■▐▒▒▒▒▌■▐▒▒███▒");
        Terminal.WriteLine("        ▒▐██▄▒▀▀▀▒▒▒▒▀▀▀▒▄██▌▒");
        Terminal.WriteLine("        ▒▒▀████▒▄▄▒▒▄▄▒████▀▒▒");
        Terminal.WriteLine("        ▒▒▐███▒▒▒▀▒▒▀▒▒▒███▌▒▒");
        Terminal.WriteLine("        ▒▒███▒▒▒▒▒▒▒▒▒▒▒▒███▒▒");
        Terminal.WriteLine("        ▒▒▒██▒▒▀▀▀▀▀▀▀▀▒▒██▒▒▒");
        Terminal.WriteLine("        ▒▒▒▐██▄▒▒▒▒▒▒▒▒▄██▌▒▒▒");
        Terminal.WriteLine("        ▒▒▒▒▀████████████▀▒▒▒▒");
        Terminal.WriteLine(" Congratulations! Type menu to go back.");
    }

}
