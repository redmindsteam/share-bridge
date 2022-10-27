using System;
using static System.Console;

namespace ShareBridge.Console.Helpers
{
    public class Menu
    {
        private int SelectedIndex;
        private string[] Options;
        private string Prompt;

        public Menu(string Prompt, string[] Options)
        {
            this.Prompt = Prompt;
            this.Options = Options;
            SelectedIndex = 0;
        }

        public void DisplayOptions()
        {
            WriteLine(Prompt);
            string startPrefix, endPrefix;
            for (int i = 0; i < Options.Length; i++)
            {
                string currentOption = Options[i];

                if (i == SelectedIndex)
                {
                    startPrefix = "<<";
                    endPrefix = ">>";
                    ForegroundColor = ConsoleColor.Red;
                    BackgroundColor = ConsoleColor.Yellow;
                }

                else
                {
                    startPrefix = "  ";
                    endPrefix = "  ";
                    ForegroundColor = ConsoleColor.White;
                    BackgroundColor = ConsoleColor.Black;
                }
                WriteLine($"{startPrefix} {currentOption} {endPrefix}");
            }
            ResetColor();
        }

        public int Run()
        {
            ConsoleKey keyPressed;
            do
            {
                Clear();
                DisplayOptions();

                ConsoleKeyInfo keyInfo = ReadKey(true);
                keyPressed = keyInfo.Key;

                if (keyPressed == ConsoleKey.UpArrow)
                {
                    SelectedIndex--;
                    if (SelectedIndex == -1)
                    {
                        SelectedIndex = Options.Length - 1;
                    }
                }
                if (keyPressed == ConsoleKey.DownArrow)
                {
                    SelectedIndex++;

                    if (SelectedIndex == Options.Length)
                    {
                        SelectedIndex = 0;
                    }
                }

            } while (keyPressed != ConsoleKey.Enter);

            return SelectedIndex;
        }
    }
}