using System;
using System.Windows.Forms;

namespace createBranchName
{
    static class Program
    {
        [STAThread]
        private static void Main()
        {
            bool endProgram = false;
            while (!endProgram)
            {
                Console.WriteLine("Your text:\n");
                var inputReadLine = Console.ReadLine();
                Console.WriteLine(
                    "Which symbol should replace the spaces? Write one of them (to replace with blank leave it empty by pressing enter):\n '+' '-' ':' '_' '/'\n");
                var trimCharacter = Console.ReadLine();

                if (inputReadLine != null)
                {
                    inputReadLine = inputReadLine.Replace(" ", trimCharacter).ToLower();
                    Clipboard.SetText("feature/{YOURNUMBER}_" + inputReadLine);
                    Console.Write("Branch name got successfully copied.\n");
                }
                else
                {
                    Console.WriteLine("Creation of new text was unsuccessful, please write text with space.\n");
                }

                Console.Write("'e' to close, any other key to continue: ");
                if (Console.ReadLine() == "e") endProgram = true;

                Console.WriteLine("\n");
            }
            return;
        }
    }
}
