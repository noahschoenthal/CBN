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
                Console.Write("~~~ WELCOME TO THE CREATE BRANCHNAME GENERATOR ~~~\n\n PLEASE WRITE YOUR TEXT:\n\n");
                var inputReadLine = Console.ReadLine();
                Console.WriteLine();
                Console.Write("Which symbol should replace the spaces? \n");

                if (inputReadLine != null)
                {
                    ReplaceText(inputReadLine);
                }
                else
                {
                    Console.WriteLine("Creation of new text was unsuccessful, please write text with space.\n");
                }

                Console.Write("Write 'e' to close, any other key to continue: ");
                if (Console.ReadLine() == "e") endProgram = true;

                Console.WriteLine("\n");
            }
            return;
        }

        private static void ReplaceText(string inputReadLine)
        {
            var trimCharacter = Console.ReadLine();
            Console.WriteLine();
            inputReadLine = inputReadLine.TrimEnd(',').Replace(" ",trimCharacter).
                ToLower().Replace(",", "").Replace(":",trimCharacter)
                .Replace("_",trimCharacter);
            Clipboard.SetText("feature/{YOURNUMBER}_" + inputReadLine);
            Console.WriteLine("Created Branchname moved into your clipboard:\n" + inputReadLine + "\n");
            Console.Write("Branch name got successfully copied.\n");
        }
    }
}
