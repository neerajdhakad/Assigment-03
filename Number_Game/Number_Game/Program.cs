using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Number_Game
{
    class Program
    {
        static void Main(string[] args)
        {
            MathGame game = new MathGame();
            game.StartGame();
            Console.ReadLine();
        }
    }
}
