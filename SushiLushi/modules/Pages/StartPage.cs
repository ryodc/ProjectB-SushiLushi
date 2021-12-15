using System;
using System.Linq;
namespace SushiLushi {
    public static class StartPage {
        
        public static UISystem.Page page = new UISystem.Page("Start Page");

        public static void Display () {
            page.Update(false);

            //Returns random int from 0 - menu.length
            static int Random(int length){
                Random rd = new Random();
                return rd.Next(0, length);
            }
            
            //Start Visualization
            static void Print(){
                string[] menu = {"sushi1", "sushi2", "sushi3", "sushi4", "sushi5", "sushi6"};
                
                int[] MofD = new int[4];
                for (int i = 0; i < MofD.Length; i++){
                    bool run = true;
                    while (run){
                        int temp = Random(menu.Length);
                        if (!MofD.Contains(temp)){
                            MofD[i] = temp;
                            run = false;
                            break;
                        }
                    }
                }
                
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("");
                Console.WriteLine(@"`----------------------------------------------------------------------------------------``--------------------------------------------------------------------------------`");  
                Console.WriteLine(@".s:------------------------------------------------------------------------------------:s..s:----------------------------------------------------------------------------:s.");
                Console.WriteLine(@".s.                                                                                    .s..s.                                                                            .s.");
                Console.WriteLine(@".s.       ========        ========        ========        ========        ========     .s..s.                               Meals of the day:                            .s.");
                Console.WriteLine(@".s.     //-#&%&%!-\\    //-#$!$!&-\\    //-#&%&%!-\\    //-#&%&%!-\\    //-#&%&%!-\\   .s..s.                                                                            .s.");
                Console.WriteLine($".s.    ||-@#@#@#@#-||  ||-^%($)%)@-||  ||-@#@#@#@#-||  ||-@#@#@#@#-||  ||-@#@#@#@#-||  .s..s.                 {menu[MofD[0]]}:   //price          {menu[MofD[2]]}:   //price               .s.");
                Console.WriteLine(@$".s.     \\-$%$#@%-//    \\-@%$#@&-//    \\-$%$#@%-//    \\-$%$#@%-//    \\-$%$#@%-//   .s..s." + $"                 {menu[MofD[1]]}:   //price          {menu[MofD[3]]}:   //price               .s.");
                Console.WriteLine(@".s.       ========        ========        ========        ========        ========     .s..s.                                                                            .s.");
                Console.WriteLine(@"`/::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::/``/::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::/`");
                Console.WriteLine(@".s:------------------------------------------------------------------------------------:s..s:----------------------------------------------------------------------------:s.");
                Console.WriteLine(@".s.                                                                                    .s..s.                                                                            .s.");
                Console.WriteLine(@".s.    `-/+oo+/:`      ++/     :++       .:+ooo+/-`     .++-    `++:     .++++++++++`  .s..s.                               Quick and Easy!                              .s.");
                Console.WriteLine(@".s.   `oso:---/o-      os+     +ss      -ss/---:++`     -ss-    `ss/     `---+ss/---   .s..s.     ___________________    ___________________    ___________________      .s.");
                Console.WriteLine(@".s.   -ss/`            os+     +ss      +ss-`           -ss-    `ss/         :ss-      .s..s.     |   Sushi Lushi   |    |   Sushi Lushi   |    |   Sushi Lushi   |      .s.");
                Console.WriteLine(@".s.    :oso+/-.`       os+     +ss      `+sso+:-`       -sso////+ss/         :ss-      .s..s.     |-----------------|    |-----------------|    |-----------------|      .s.");
                Console.WriteLine(@".s.     `.:+osso:      os+     +ss        `-/+oss+-     -ss+/////ss/         :ss-      .s..s.     |                 |    |      Menu       |    |                 |      .s.");
                Console.WriteLine(@".s.          ./ss-     oso     +so            `.oss`    -ss-    `ss/         :ss-      .s..s.     |                 |    |                 |    | Datum:          |      .s.");
                Console.WriteLine(@$".s.   -+/-.``.+ss.     :ss:.`.:ss:     `/+:.```-oso     -ss-    `ss/      .../ss:...   .s..s.     |   Login         |    | {menu[MofD[0]]} [1] + -  |    |   21-05-2021    |      .s.");
                Console.WriteLine(@".s.   ./+oooooo/.       -+ooooo+-       -+oooooo+:`     .oo-    `oo/     .oooooooooo`  .s..s.     |   Registreren   |    |                 |    |                 |      .s.");
                Console.WriteLine(@$".s.      ``````           `````           ``````         ``      ```      ``````````   .s..s.     |   Reserveren    |    | {menu[MofD[1]]} [0] + -  |    | Tijd:           |      .s.");
                Console.WriteLine(@".s.   _               _      _             ______             _   _              _     .s..s.     |   Menu          |    |                 |    |   14:00 - 16:00 |      .s.");
                Console.WriteLine(@$".s.  |+|             |.|    |+|           /======/           |s| |d|            |#|    .s..s.     |                 |    | {menu[MofD[2]]} [2] + -  |    |                 |      .s.");
                Console.WriteLine(@".s.  |d|             |-|    |d|           \----/             |o|_|g|            |@|    .s..s.     |                 |    |                 |    | Personen:       |      .s.");
                Console.WriteLine(@".s.  |d|             |@|    |!|             \%-^\            |hf_hg|            |*|    .s..s.     |                 |    |                 |    |   3             |      .s.");
                Console.WriteLine(@".s.  |=|___           \-\___/-/             /*#-/            |h| |s|            |#|    .s..s.     |_________________|    |_________________|    |_________________|      .s.");
                Console.WriteLine(@".s.  |=====|           \=====/            \=====/            |=| |=|            |=|    .s..s.           Stap 1                 Stap 2                 Stap 3             .s.");
                Console.WriteLine(@"                                                                                                        Login             Kies van het menu         Reserveer            .s.");
                Console.WriteLine(@".s-````````````````````````````````````````````````````````````````````````````````````-s..s.                                                                            .s.");
                Console.WriteLine(@"`/::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::/``::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::/` ");
                Console.WriteLine(@".s.                                                                                    .s..s.                                                                            .s.");
                Console.WriteLine(@".s.       ========        ========        ========        ========        ========     .s..s.                                                                            .s.");
                Console.WriteLine(@".s.     //-#&%&%!-\\    //-#$!$!&-\\    //-#&%&%!-\\    //-#&%&%!-\\    //-#&%&%!-\\   .s..s.                                                                            .s.");
                Console.WriteLine(@".s.    ||-@#@#@#@#-||  ||-^%($)%)@-||  ||-@#@#@#@#-||  ||-@#@#@#@#-||  ||-@#@#@#@#-||  .s..s.                             Eetsmakelijk!                                  .s.");
                Console.WriteLine(@".s.     \\-$%$#@%-//    \\-@%$#@&-//    \\-$%$#@%-//    \\-$%$#@%-//    \\-$%$#@%-//   .s..s.                                                                            .s.");
                Console.WriteLine(@".s.       ========        ========        ========        ========        ========     .s..s.                                                                            .s.");
                Console.WriteLine(@".s.                                                                                    .s..s.                                                                            .s.");
                Console.WriteLine(@"`----------------------------------------------------------------------------------------``--------------------------------------------------------------------------------`");
                Console.WriteLine(@".s:------------------------------------------------------------------------------------:s..s.----------------------------------------------------------------------------.s.");
            }

            Print();

            UISystem.Output.WriteLine(System.ConsoleColor.White, "");
            UISystem.Output.WriteLine(System.ConsoleColor.White, "Welkom bij Sushi Lushi, het beste Sushi restaurant in de wereld!");
            UISystem.Output.WriteLine(System.ConsoleColor.White, "Maak uw keuze!");

            var menu = new UISystem.Menu();

            // Niet ingelogd
            if (!Storage.SushiLushiState.isLoggedIn) {
                menu.Add("Login", LoginPage.Display);
                menu.Add("Registreren", RegisterPage.Display);
                
                menu.Add("Reserveren", ReserveerPage.Display);
                menu.Add("Menu bekijken", MenuList.Display);
            }

            // Ingelogd als gebruiker
            if (Storage.SushiLushiState.isLoggedIn && !Storage.SushiLushiState.isAdmin) {
                menu.Add("Reserveren", ReserveerPage.Display);
                menu.Add("Mijn reserveringen", listReservations);
                menu.Add("Menu bekijken", MenuList.Display);
            }

            // Ingelogd als admin
            if (Storage.SushiLushiState.isLoggedIn && Storage.SushiLushiState.isAdmin) {
                menu.Add("Gebruikers beheren", AdminPage.Display);
                menu.Add("Reserveringen beheren", null);
            }

            if (Storage.SushiLushiState.isLoggedIn) {
                menu.Add("Uitloggen", logout);
            }


            menu.Display();
        }

        public static void logout() {
            Storage.SushiLushiState.isLoggedIn = false;
            Storage.SushiLushiState.isAdmin = false;
            Storage.SushiLushiState.loggedUser = null;
            
            UISystem.Input.ReadString("U bent uitgelogd! (Druk op enter om verder te gaan)");
            StartPage.Display();
        }

        public static void listReservations() {
            UISystem.Output.WriteLine(ConsoleColor.Cyan, "Dit zijn uw reserveringen:");

            foreach (Storage.Reservation reservation in Storage.System.data.reservations) {
                if (reservation.username == Storage.SushiLushiState.loggedUser.username) {
                    UISystem.Output.WriteLine(ConsoleColor.Green, "");
                    UISystem.Output.WriteLine(ConsoleColor.Green, "| Datum: " + reservation.datetime.ToString());
                    UISystem.Output.WriteLine(ConsoleColor.Green, "| Aantal personen: " + reservation.amountPeople);
                    UISystem.Output.WriteLine(ConsoleColor.Green, "");
                }
            }
            
            UISystem.Input.ReadString("(Druk op enter om verder te gaan)");
            StartPage.Display();
        }
    }
}