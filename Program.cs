﻿using System;

namespace AlgorithmAkademy_v2._0
{
    class Program
    {
        static void Main(string[] args)
        {
            MainMenu mainMenu = new MainMenu();
            Console.WriteLine(mainMenu.menuText);
            mainMenu.ProjectMenu();
        }
    }
}
