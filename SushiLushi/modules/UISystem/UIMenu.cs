
using System;
using System.Collections.Generic;
using System.Linq;

namespace UISystem
{
    public class Menu {

        private IList<Option> Options { get; set; }
        private int selectedIndex { get; set; }

        public Menu()
        {
            Options = new List<Option>();
        }

        public void Display() {
            Console.WriteLine("");

            for (int i = 0; i < Options.Count; i++)
            {
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.Write("[{0}] ", i + 1);
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write(Options[i].Name + "\n");
            }
            
            Console.WriteLine("");
            
            int choice = Input.ReadInt("Selecteer een keuze:", min: 1, max: Options.Count);
            selectedIndex = choice;

            if (Options[choice - 1].Callback != null) {
                Options[choice - 1].Callback();
            }
        }

        public int GetSelectedIndex() {
            return selectedIndex;
        }

        public Menu Add(string option, Action callback = null) {
            return Add(new Option(option, callback));
        }

        public Menu Add(Option option) {
            Options.Add(option);
            return this;
        }

        public bool Contains(string option) {
            return Options.FirstOrDefault((op) => op.Name.Equals(option)) != null;
        }

    }
}