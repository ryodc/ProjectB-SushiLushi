using System;

namespace SushiLushi
{
    class Program
    {
        static void Main(string[] args)
        {
            // Initialiseer storage systeem
            Storage.System.InitStorage();

            // Open startpage
            StartPage.Display();
        }
    }
}
