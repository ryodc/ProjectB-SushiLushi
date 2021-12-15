using System;

namespace SushiLushi {
    class MenuList{
        public static string[][] Fish = {
                new string[] {"Sushirijst","Kristalsuiker","Rijstazijn","Zeezout","Zalmfilet","Norivel(zeewier)"}, 
                new string[] {"Sushirijst","Kristalsuiker","Rijstazijn","Zeezout","Tonijnfilet","Norivel(zeewier)"},
                new string[] {"Sushirijst","Kristalsuiker","Rijstazijn","Zeezout","Zalmfilet"},
                new string[] {"Sushirijst","Kristalsuiker","Rijstazijn","Zeezout","Tonijnfilet"},
                new string[] {"Sushirijst","Kristalsuiker","Rijstazijn","Zeezout","Ebi tempura","Norivel(zeewier)", "Avocado", "Komkommer", "Tobiko","Gebakken ui", "Mayonaise", "Wasabi"},
                new string[] {"Sushirijst","Kristalsuiker","Rijstazijn","Zeezout","Zalmfilet","Norivel(zeewier)", "Avocado", "Komkommer", "Tobiko", "Mayonaise", "Wasabi"},
                new string[] {"Sushirijst","Kristalsuiker","Rijstazijn","Zeezout","Tonijnfilet","Norivel(zeewier)", "Avocado", "Bosui", "Sesamzaad", "Mayonaise", "Sriracha"},
                new string[] {"Sushirijst","Kristalsuiker","Rijstazijn","Zeezout","Ebi tempura","Norivel(zeewier)", "Sesamzaad","Gebakken ui", "Mayonaise", "Wasabi"},
                new string[] {"Zalmfilet", "Sesamzaad", "Bosui"},
                new string[] {"Tonijnfilet", "Sesamzaad", "Bosui"}
                };

        public static string[][] Meat = {
                new string[] {"Sushirijst","Kristalsuiker","Rijstazijn","Zeezout","Brookwood varkensbuikspek","Ebi tempura","Norivel(zeewier)", "Aioli", "Wasabi", "Gebakken ui", "Rode ui", "Ketjap"}, 
                new string[] {"Sushirijst","Kristalsuiker","Rijstazijn","Zeezout","Avocado","Carpaccio", "Norivel(zeewier)", "Gebakken ui", "Mayonaise", "Ketjap"},
                new string[] {"Sushirijst","Kristalsuiker","Rijstazijn","Zeezout","Sesamzaad", "Biefstuk", "Lente ui", "Sambal", "Sesamolie", "Mayonaise"},
                new string[] {"Rundvlees", "Shiitake saus", "Bosui", "Zeezout", "Peper", "Cherry tomaat", "Peterselie", "Enoki paddestoelen"},
                new string[] {"Biefrolletjes","Brocolli","Asperge","Gebakken ui", "Mayonaise", "Sambal", "Ketjap"},
                new string[] {"Rundvlees", "Ijsbergsla", "Honingmosterd dressing", "Gebakken ui"},
                new string[] {"Rundvlees", "Zeezout", "Peper", "Koriander", "Sesamzaad", "Ketjap", "Lente ui"},
                new string[] {"Longhaas", "Knoflook", "Zwarte peper korrels", "Bosui", "Tosasaus", "Sojasaus", "Kombu"}
                };

        public static string[][] Vegan = {
                new string[] {"Sushirijst","Kristalsuiker","Rijstazijn","Zeezout","Ei","Norivel(zeewier)", "Melk"}, 
                new string[] {"Sushirijst","Kristalsuiker","Rijstazijn","Zeezout","Komkommer","Norivel(zeewier)"},
                new string[] {"Sushirijst","Kristalsuiker","Rijstazijn","Zeezout","Avocado","Norivel(zeewier)"},
                new string[] {"Sushirijst","Kristalsuiker","Rijstazijn","Zeezout","Avocado", "Komkommer", "Tempura kruimels", "Mayonaise"},
                new string[] {"Norivel(zeewier)", "Zeewier", "Zeezout", "Azijn"},
                new string[] {"Sojabonen", "Zeezout"}
                };
        public static string[][] All = {
                new string[] {"Sushirijst","Kristalsuiker","Rijstazijn","Zeezout","Zalmfilet","Norivel(zeewier)"}, 
                new string[] {"Sushirijst","Kristalsuiker","Rijstazijn","Zeezout","Tonijnfilet","Norivel(zeewier)"},
                new string[] {"Sushirijst","Kristalsuiker","Rijstazijn","Zeezout","Zalmfilet"},
                new string[] {"Sushirijst","Kristalsuiker","Rijstazijn","Zeezout","Tonijnfilet"},
                new string[] {"Sushirijst","Kristalsuiker","Rijstazijn","Zeezout","Ebi tempura","Norivel(zeewier)", "Avocado", "Komkommer", "Tobiko","Gebakken ui", "Mayonaise", "Wasabi"},
                new string[] {"Sushirijst","Kristalsuiker","Rijstazijn","Zeezout","Zalmfilet","Norivel(zeewier)", "Avocado", "Komkommer", "Tobiko", "Mayonaise", "Wasabi"},
                new string[] {"Sushirijst","Kristalsuiker","Rijstazijn","Zeezout","Tonijnfilet","Norivel(zeewier)", "Avocado", "Bosui", "Sesamzaad", "Mayonaise", "Sriracha"},
                new string[] {"Sushirijst","Kristalsuiker","Rijstazijn","Zeezout","Ebi tempura","Norivel(zeewier)", "Sesamzaad","Gebakken ui", "Mayonaise", "Wasabi"},
                new string[] {"Zalmfilet", "Sesamzaad", "Bosui"},
                new string[] {"Tonijnfilet", "Sesamzaad", "Bosui"},
                new string[] {"Sushirijst","Kristalsuiker","Rijstazijn","Zeezout","Brookwood varkensbuikspek","Ebi tempura","Norivel(zeewier)", "Aioli", "Wasabi", "Gebakken ui", "Rode ui", "Ketjap"}, 
                new string[] {"Sushirijst","Kristalsuiker","Rijstazijn","Zeezout","Avocado","Carpaccio", "Norivel(zeewier)", "Gebakken ui", "Mayonaise", "Ketjap"},
                new string[] {"Sushirijst","Kristalsuiker","Rijstazijn","Zeezout","Sesamzaad", "Biefstuk", "Lente ui", "Sambal", "Sesamolie", "Mayonaise"},
                new string[] {"Rundvlees", "Shiitake saus", "Bosui", "Zeezout", "Peper", "Cherry tomaat", "Peterselie", "Enoki paddestoelen"},
                new string[] {"Biefrolletjes","Brocolli","Asperge","Gebakken ui", "Mayonaise", "Sambal", "Ketjap"},
                new string[] {"Rundvlees", "Ijsbergsla", "Honingmosterd dressing", "Gebakken ui"},
                new string[] {"Rundvlees", "Zeezout", "Peper", "Koriander", "Sesamzaad", "Ketjap", "Lente ui"},
                new string[] {"Longhaas", "Knoflook", "Zwarte peper korrels", "Bosui", "Tosasaus", "Sojasaus", "Kombu"},
                new string[] {"Sushirijst","Kristalsuiker","Rijstazijn","Zeezout","Ei","Norivel(zeewier)", "Melk"}, 
                new string[] {"Sushirijst","Kristalsuiker","Rijstazijn","Zeezout","Komkommer","Norivel(zeewier)"},
                new string[] {"Sushirijst","Kristalsuiker","Rijstazijn","Zeezout","Avocado","Norivel(zeewier)"},
                new string[] {"Sushirijst","Kristalsuiker","Rijstazijn","Zeezout","Avocado", "Komkommer", "Tempura kruimels", "Mayonaise"},
                new string[] {"Norivel(zeewier)", "Zeewier", "Zeezout", "Azijn"},
                new string[] {"Sojabonen", "Zeezout"}
            };

        public static UISystem.Page page = new UISystem.Page("Menu pagina");

        public static void Display() {
            MenuList.page.Update();

            var menu = new UISystem.Menu()
                .Add("Visgerechten", fish)
                .Add("Vleesgerechten", meat)
                .Add("Vegetarische gerechten", vegan)
                .Add("Alle gerechten", all)
                .Add("Terug naar startpagina", () => StartPage.Display());
            menu.Display();

        }
        public static void fish() {
            page.Update();
            var menu = new UISystem.Menu()
                .Add("Maki zalm")
                .Add("Maki tonijn")
                .Add("Nigiri zalm")
                .Add("Nigiri tonijn")
                .Add("California roll")
                .Add("Crunchy california roll")
                .Add("Spicy tonijn roll")
                .Add("Ebi tempura roll")
                .Add("Zalm sashimi")
                .Add("Tonijn sashimi")
                .Add("Terug naar gerechten", Display);

            menu.Display();

            page.Update();
            Console.WriteLine("");
            for (int j = 0; j < Fish[menu.GetSelectedIndex()].Length; j++){
                Console.WriteLine($"- {Fish[menu.GetSelectedIndex()][j]}");
            }
            Console.WriteLine("");
            UISystem.Input.ReadString("(Klik op enter om door te gaan)");
            Display();
        }
        public static void meat() {
            page.Update();

            var menu = new UISystem.Menu()
                .Add("Surf n' turf roll")
                .Add("Carpaccio roll")
                .Add("Beef roll")
                .Add("Tournedos")
                .Add("Usuyaki")
                .Add("Beef lettuce wrap")
                .Add("Japanese burger")
                .Add("Beef tataki")
                .Add("Terug naar gerechten", Display);

            menu.Display();

            page.Update();
            Console.WriteLine("");
            for (int j = 0; j < Meat[menu.GetSelectedIndex()].Length; j++){
                Console.WriteLine($"- {Meat[menu.GetSelectedIndex()][j]}");
            }
            Console.WriteLine("");
            UISystem.Input.ReadString("(Klik op enter om door te gaan)");
            Display();
        }
        public static void vegan() {
            page.Update();

            var menu = new UISystem.Menu()
                .Add("Nigiri tamago")
                .Add("Maki Komkommer")
                .Add("Maki avocado")
                .Add("Crispy mayo roll")
                .Add("Wakame tamaki")
                .Add("Edamame")
                .Add("Terug naar gerechten", Display);

            menu.Display();

            page.Update();
            Console.WriteLine("");
            for (int j = 0; j < Vegan[menu.GetSelectedIndex()].Length; j++){
                Console.WriteLine($"- {Vegan[menu.GetSelectedIndex()][j]}");
            }
            Console.WriteLine("");
            UISystem.Input.ReadString("(Klik op enter om door te gaan)");
            Display();
        }
        public static void all() {
            page.Update();

            var menu = new UISystem.Menu()
                .Add("Maki zalm")
                .Add("Maki tonijn")
                .Add("Nigiri zalm")
                .Add("Nigiri tonijn")
                .Add("California roll")
                .Add("Crunchy california roll")
                .Add("Spicy tonijn roll")
                .Add("Ebi tempura roll")
                .Add("Zalm sashimi")
                .Add("Tonijn sashimi")
                .Add("Surf n' turf roll")
                .Add("Carpaccio roll")
                .Add("Beef roll")
                .Add("Tournedos")
                .Add("Usuyaki")
                .Add("Beef lettuce wrap")
                .Add("Japanese burger")
                .Add("Beef tataki")
                .Add("Nigiri tamago")
                .Add("Maki Komkommer")
                .Add("Maki avocado")
                .Add("Crispy mayo roll")
                .Add("Wakame tamaki")
                .Add("Edamame")
                .Add("Terug naar gerechten", Display);

            menu.Display();

            page.Update();
            Console.WriteLine("");
            for (int j = 0; j < All[menu.GetSelectedIndex()].Length; j++){
                Console.WriteLine($"- {All[menu.GetSelectedIndex()][j]}");
            }
            Console.WriteLine("");
            UISystem.Input.ReadString("(Klik op enter om door te gaan)");
            Display();
        }              
    }
}