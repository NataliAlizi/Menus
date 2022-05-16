using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex04.Menus.Interfaces
{
    public class Menu
    {
        private Menu m_ParentMenu;

        public Menu ParentMenu
        {
            get { return m_ParentMenu; }
            set
            {
                m_ParentMenu = value;
            }
        }

        internal string Title { get; set; }

        public Menu(string i_Title, Menu i_ParentMenu = null)
        {
            Title = i_Title;
            m_ParentMenu = i_ParentMenu;
        }
    }
}
