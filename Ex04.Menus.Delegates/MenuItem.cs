using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex04.Menus.Delegates
{
    public class MenuItem : Menu
    {
        public event Action ItemChosed;

        private List<MenuItem> m_MenuList = new List<MenuItem>();

        public MenuItem(string i_Title, Menu i_Parent) : base(i_Title, i_Parent)
        {
        }

        public List<MenuItem> MenuList
        {
            get { return m_MenuList; }
        }

        public void AddMenuItem(string i_Title, Action i_ItemChosed)
        {
            MenuItem newMenuItem = new MenuItem(i_Title, this);
            newMenuItem.ItemChosed += i_ItemChosed;
            if (newMenuItem == null)
            {
                throw new Exception("Can't add Null to menu!!!");
            }

            m_MenuList.Add(newMenuItem);
        }

        public void AddMenuItem(string i_Title)
        {
            MenuItem newMenuItem = new MenuItem(i_Title, this);
            if (newMenuItem == null)
            {
                throw new Exception("Can't add Null to menu!!!");
            }

            m_MenuList.Add(newMenuItem);
        }

        public bool ValidChoice(int i_UserChoice)
        {
            return i_UserChoice >= 0 && i_UserChoice <= m_MenuList.Count;
        }

        public void ShowItem()
        {
            Console.WriteLine(MenuOption().ToString());
        }

        public bool CheckIfLeaf()
        {
            bool isLeaf = false;
            if (this.m_MenuList.Count == 0)
            {
                isLeaf = true;
            }

            return isLeaf;
        }

        public StringBuilder MenuOption()
        {
            int i = 1;
            StringBuilder optionsToPrint = new StringBuilder();
            optionsToPrint.AppendFormat("{1}{0}" + "----------------------{0}", Environment.NewLine, this.Title);
            foreach (MenuItem item in m_MenuList)
            {
                optionsToPrint.AppendLine(string.Format("({0}) {1}", i, item.Title));
                i++;
            }

            if (this.ParentMenu == null)
            {
                optionsToPrint.AppendLine("(0) Exit");
            }
            else
            {
                optionsToPrint.AppendLine("(0) Back");
            }

            optionsToPrint.AppendLine(string.Format("choose option between 0 and {0}", m_MenuList.Count));

            return optionsToPrint;
        }

        public void RunAction()
        {
            OnItemChosed();
        }

        protected virtual void OnItemChosed()
        {
            if (ItemChosed != null)
            {
                ItemChosed.Invoke();
            }
        }
    }
}
