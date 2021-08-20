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
                Console.WriteLine("Type the story name in:\n");
                string inputReadLine = Console.ReadLine();
                Console.WriteLine(
                    "Which symbol should replace the spaces? Write one of them (to replace with blank leave it empty by pressing enter):\n '+' '-' ':' '_' '/'\n");
                string trimCharacter = Console.ReadLine();

                if (inputReadLine != null)
                {
                    inputReadLine = inputReadLine.Replace(" ", trimCharacter);
                    inputReadLine.ToLower();
                    Clipboard.SetText(inputReadLine);
                }
                else
                {
                    Console.WriteLine("Please type text with space.\n");
                }

                Console.Write("Branch name got successfully copied.\n");

                Console.Write("Press 'e' to close the app, press any other key and Enter to continue: ");
                if (Console.ReadLine() == "e") endProgram = true;

                Console.WriteLine("\n");
            }
            return;
        }
    }
}
