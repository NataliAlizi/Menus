using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ex04.Menus.Interfaces;

namespace Ex04.Menus.Test
{
    public class ShowDate : MenuItem, IRunFunc
    {
        public ShowDate() : base("ShowDate", null)
        {
        }

        void IRunFunc.Run()
        {
            MenuFunction.ShowDate();
        }
    }
}
