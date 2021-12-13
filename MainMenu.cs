using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmAkademy_v2._0
{
    class MainMenu
    {
        /// <summary>
        /// Главное Меню для программы
        /// </summary>
        /// <returns></returns>
        public void MyMenu()
        {
            string text = Console.ReadLine();
            do
            {
                if (int.TryParse(text, out int numberInter))
                {
                    
                    if (numberInter == 1)
                       // SimpleNumbers();

                    if (numberInter == 2)
                       // FibonachiNumbers();

                    if (numberInter == 3)
                      //  DualLinkedList();

                    if (numberInter == 9)
                        Environment.Exit(0);
                    Console.WriteLine("Для выхода в главное меню нажмите ESC");
                }
                else
                {
                    Console.WriteLine("Команда не распознана");
                }
            }
            while (Console.ReadKey(true).Key != ConsoleKey.Escape);
            Console.Clear();
            Console.WriteLine(menuText);
            MyMenu();
        }
    }
}
