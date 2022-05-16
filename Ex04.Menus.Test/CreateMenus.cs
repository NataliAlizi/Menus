using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ex04.Menus.Delegates;
using Ex04.Menus.Interfaces;

namespace Ex04.Menus.Test
{
    public class CreateMenus
    {
        private Delegates.MainMenu m_DelegateMainMenu = new Delegates.MainMenu("Delegates main menu");
        private Interfaces.MainMenu m_InterfaceMainMenu = new Interfaces.MainMenu("Interfaces main menu");

        public static void RunMenus()
        {
            CreateMenus menus = new CreateMenus();
            menus.setInterfaceMainMenu();
            menus.InterfacesMainMenu.Show();
            menus.setDelegateMainMenu();
            menus.DelegateMainMenu.Show();
        }

        public Delegates.MainMenu DelegateMainMenu
        {
            get { return m_DelegateMainMenu; }
        }

        public Interfaces.MainMenu InterfacesMainMenu
        {
            get { return m_InterfaceMainMenu; }
        }

        private void setDelegateMainMenu()
        {
            m_DelegateMainMenu.AddMenuItem("Show Date/Time");
            m_DelegateMainMenu.MenuList[m_DelegateMainMenu.MenuList.Count - 1].AddMenuItem("Show Date", MenuFunction.ShowDate);
            m_DelegateMainMenu.MenuList[m_DelegateMainMenu.MenuList.Count - 1].AddMenuItem("Show Time", MenuFunction.ShowTime);
            m_DelegateMainMenu.AddMenuItem("Version and Spaces");
            m_DelegateMainMenu.MenuList[m_DelegateMainMenu.MenuList.Count - 1].AddMenuItem("Show Version", MenuFunction.ShowVersion);
            m_DelegateMainMenu.MenuList[m_DelegateMainMenu.MenuList.Count - 1].AddMenuItem("Count Spaces", MenuFunction.CountSpaces);
        }

        private void setInterfaceMainMenu()
        {
            m_InterfaceMainMenu.AddMenuItem("Show Date/Time");
            m_InterfaceMainMenu.MenuList[m_InterfaceMainMenu.MenuList.Count - 1].AddMenuItem("Show Date", new ShowDate());
            m_InterfaceMainMenu.MenuList[m_InterfaceMainMenu.MenuList.Count - 1].AddMenuItem("Show Time", new ShowTime());
            m_InterfaceMainMenu.AddMenuItem("Version and Spaces");
            m_InterfaceMainMenu.MenuList[m_InterfaceMainMenu.MenuList.Count - 1].AddMenuItem("Show Version", new ShowVersion());
            m_InterfaceMainMenu.MenuList[m_InterfaceMainMenu.MenuList.Count - 1].AddMenuItem("Count Spaces", new CountSpaces());
        }
    }
}
