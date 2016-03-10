using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Struct6
{
    enum colors : int { green, yellow, blue };
    static class ColorPrinter
    {
        static public void Print(string stroka, int color)
        {
            switch (color)
            {
                case 0:                    
                    Console.ForegroundColor = ConsoleColor.Green; 
                    
                    break;
                case 1:
                    Console.ForegroundColor = ConsoleColor.Yellow;                    
                    break;
                case 2:
                    Console.ForegroundColor = ConsoleColor.Blue;                                        
                    break;
                default:
                    Console.ForegroundColor = ConsoleColor.White; 
                    break;                    
            }
            Console.WriteLine(stroka);
            Console.ResetColor();
        }
    }
}
