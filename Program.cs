using System;
using System.Windows.Forms;

namespace createBranchName
{
    static class Program
    {
        [STAThread]
        private static void Main()
        {
            Console.WriteLine("Type the story name in:\n");
            string inputReadLine = Console.ReadLine();

            if (inputReadLine != null)
            {
                inputReadLine = inputReadLine.Replace(" ", "-");
                inputReadLine.ToLower();
                Clipboard.SetText(inputReadLine);
            }
            else
            {
                Console.WriteLine("Please type text with space.");
            }
            Console.Write("Name got successfully copied.");
            Console.Read();
        }
    }
}
