using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dungeon
{
    public interface IConsoleUtilities
    {
        void PrintChar(string text, int ms);
    }

    public class ConsoleUtilities : IConsoleUtilities
    {
        public void PrintChar(string text, int ms = 40)
        {
            foreach (char c in text)
            {
                Console.Write(c);
                System.Threading.Thread.Sleep(ms);
            }
            Console.WriteLine();
        }
    }
}
