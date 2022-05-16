using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ex04.Menus.Interfaces;

namespace Ex04.Menus.Test
{
    public class ShowVersion : MenuItem, IRunFunc
    {
        public ShowVersion() : base("ShowVersion", null)
        {
        }

        void IRunFunc.Run()
        {
            MenuFunction.ShowVersion();
        }
    }
}
