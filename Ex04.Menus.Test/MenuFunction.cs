using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex04.Menus.Test
{
    public class MenuFunction
    {
        public static void ShowTime()
        {
            DateTime time = DateTime.Now;
            Console.WriteLine(time.ToString("HH:mm:ss "));
        }

        public static void ShowDate()
        {
            DateTime date = DateTime.Today;
            Console.WriteLine(date.ToString("d/M/yy"));
        }

        public static void CountSpaces()
        {
            int spacesCounter = 0;
            Console.WriteLine(string.Format("Hey!!! Please enter a Sentence"));
            string userInput = Console.ReadLine();
            foreach (char sign in userInput)
            {
                if (sign == ' ')
                {
                    spacesCounter++;
                }
            }

            Console.WriteLine(string.Format("There are {0} spaces in the sentence you typed", spacesCounter));
        }

        public static void ShowVersion()
        {
            Console.WriteLine(string.Format("Version: 22.2.4.8950"));
        }
    }
}
