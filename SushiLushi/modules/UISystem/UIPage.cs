using System;

namespace UISystem {
    public class Page {
        public string Title { get; set; }

        public Page(string title) {
            this.Title = title;
        }

        public void Update (Boolean header = true) {
            Console.Clear();
            
            if (header) {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write("========[ ");

                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.Write(this.Title);

                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write(" ]========================[ ");

                Console.ForegroundColor = ConsoleColor.Cyan;
                
                if (Storage.SushiLushiState.isLoggedIn) {
                    Console.Write(Storage.SushiLushiState.loggedUser.username);
                } else {
                    Console.Write("Niet ingelogd!");
                }

                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write(" ]========\n");

                Console.ForegroundColor = ConsoleColor.Gray;
            }
            
        }
    }   
}