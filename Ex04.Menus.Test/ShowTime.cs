using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ex04.Menus.Interfaces;

namespace Ex04.Menus.Test
{
    public class ShowTime : MenuItem, IRunFunc
    {
        public ShowTime() : base("ShowTime", null)
        {
        }

        void IRunFunc.Run()
        {
            MenuFunction.ShowTime();
        }
    }
}
