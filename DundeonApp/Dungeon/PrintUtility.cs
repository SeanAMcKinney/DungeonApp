using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dungeon
{
    public class PrintUtility
    {
        public static void Print(string text, int ms = 40)
        {
            foreach (char c in text)
            {
                Console.Write(c);
                System.Threading.Thread.Sleep(ms);
            }//end foreach
            Console.WriteLine();
        }//end Print()

    }//end class
}//end namespace
