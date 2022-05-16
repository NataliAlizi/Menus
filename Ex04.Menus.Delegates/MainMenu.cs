using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex04.Menus.Delegates
{
    public class MainMenu : MenuItem
    {
        private MenuItem m_CurrMenu;

        public MainMenu(string i_Title) : base(i_Title, null)
        {
        }

        public void Show()
        {
            m_CurrMenu = this;
            int userChoice = 0;
            string userInput = string.Empty;
            bool validAnswer = true, validParse = false;
            while (m_CurrMenu != null)
            {
                Console.Clear();
                m_CurrMenu.ShowItem();
                userInput = Console.ReadLine();
                validParse = int.TryParse(userInput, out userChoice);
                if (validParse)
                {
                    validAnswer = m_CurrMenu.ValidChoice(userChoice);
                }

                if (!validAnswer || !validParse)
                {
                    Console.WriteLine("invalid choice!!!!");
                    System.Threading.Thread.Sleep(1000);
                    continue;
                }

                handleUserChoice(userChoice, ref m_CurrMenu);
            }
        }

        private void handleUserChoice(int i_UserChoice, ref MenuItem io_CurrMenu)
        {
            Console.Clear();
            MenuItem prevMenu = io_CurrMenu;
            if (i_UserChoice == 0)
            {
                io_CurrMenu = (MenuItem)io_CurrMenu.ParentMenu;
            }
            else
            {
                if (io_CurrMenu.MenuList[i_UserChoice - 1].CheckIfLeaf())
                {
                    io_CurrMenu.MenuList[i_UserChoice - 1].RunAction();
                    Console.WriteLine("Press any key to continue and then enter");
                    Console.ReadLine();
                    io_CurrMenu = (MenuItem)io_CurrMenu.MenuList[i_UserChoice - 1].ParentMenu;
                }
                else
                {
                    io_CurrMenu = io_CurrMenu.MenuList[i_UserChoice - 1];
                }
            }
        }
    }
}
