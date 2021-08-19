using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RiddleGame
{
    public class GameTitle
    {
        public void RunName()
        {

        string[] lines = File.ReadAllLines(@"C:\Users\dabak\Source\Repos\RiddleGame\RiddleGame\GameName.txt");
            foreach (string line in lines)
            {
                Console.WriteLine("\t\t\t\t" + line);
            }
           Console.WriteLine("\n\n\n\n\npress any key to continue...");
        }
    }
}
