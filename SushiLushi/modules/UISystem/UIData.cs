using System;

namespace UISystem {

    public static class Input {

        public static int ReadInt(string prompt, int min, int max) {
            Output.DisplayPrompt(prompt);
            return ReadInt(min, max);
        }

        public static int ReadInt(int min, int max) {
            int value = ReadInt();

            while (value < min || value > max)
            {
                Output.DisplayPrompt("Selecteer een keuze ({0} t/m {1}):", min, max);
                value = ReadInt();
            }

            return value;
        }

        public static int ReadInt() {
            string input = Console.ReadLine();
            int value;

            while (!int.TryParse(input, out value))
            {
                Output.DisplayPrompt("Selecteer een keuze (getal):");
                input = Console.ReadLine();
            }

            return value;
        }

        public static string ReadString(string prompt) {
            Output.DisplayPrompt(prompt);
            return Console.ReadLine();
        }

        public static TEnum ReadEnum<TEnum>(string prompt) where TEnum : struct, IConvertible, IComparable, IFormattable {
            Type type = typeof(TEnum);

            if (!type.IsEnum)
                throw new ArgumentException("TEnum must be an enumerated type");

            Output.WriteLine(prompt);
            Menu menu = new Menu();

            TEnum choice = default(TEnum);

            foreach (var value in Enum.GetValues(type)) {
                menu.Add(Enum.GetName(type, value), () => { choice = (TEnum)value; });
            }
                
            menu.Display();

            return choice;
        }

    }

    public static class Output
    {
        public static void WriteLine(ConsoleColor color, string format, params object[] args)
        {
            Console.ForegroundColor = color;
            Console.WriteLine(format, args);
            Console.ResetColor();
        }

        public static void WriteLine(ConsoleColor color, string value)
        {
            Console.ForegroundColor = color;
            Console.WriteLine(value);
            Console.ResetColor();
        }

        public static void WriteLine(string format, params object[] args)
        {
            Console.WriteLine(format, args);
        }

        public static void DisplayPrompt(string format, params object[] args)
        {
            format = format.Trim() + " ";
            Console.Write(format, args);
        }
    }
}