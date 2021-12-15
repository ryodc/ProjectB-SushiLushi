using System;

namespace SushiLushi {
    class RegisterPage {
        public static UISystem.Page page = new UISystem.Page("Registratie pagina");

        public static void Display() {
            page.Update();
            Console.WriteLine("");
            // Wordt gevraagd om invoeren van email
            Console.WriteLine("Voer uw mail in:");
            var email = Console.ReadLine().ToLower();
            while(!RegisterPage.Check(email)){
                page.Update();
                Console.WriteLine("Dit mailadres is al in gebruik. Probeer nogmaals: ");
                email = Console.ReadLine().ToLower();
            }
            
            // Als er geen geldige mail wordt ingevoerd komt er een foutmelding
            while(!(email.Contains('@') && email.Contains('.')) || email.Contains(' ')){
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("");
                Console.WriteLine("Mailadres niet geldig. Probeer nogmaals:");
                Console.ResetColor();
                email = Console.ReadLine().ToLower();
            }

            Console.WriteLine("");
            // Wordt gevraagd om nogmaals invoeren van email
            Console.WriteLine("Voer uw mail nogmaals in");
            string repeatEmail = Console.ReadLine().ToLower();

            // Als de 2e mail niet overeen komt geeft deze foutmelding
            while(email != repeatEmail){
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("");
                Console.WriteLine("De mailadressen komen niet overeen. Probeer nogmaals:");
                Console.ResetColor();
                repeatEmail = Console.ReadLine().ToLower();
            }

            page.Update();
            Console.WriteLine("");
            // Wordt gevraagd om invoeren van gebruikersnaam
            Console.WriteLine("Voer uw gebruikersnaam in:");
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.WriteLine("LET OP: hoofdletter gevoelig");
            Console.ResetColor();
            var username = Console.ReadLine();
            while(!RegisterPage.Check(username)){
                page.Update();
                Console.WriteLine("Deze gebruikersnaam is al in gebruik. Probeer nogmaals: ");
                Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.WriteLine("LET OP: hoofdletter gevoelig");
                Console.ResetColor();
                username = Console.ReadLine(); 
            }

            while(username.Contains(' ')){
                Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("");
                    Console.WriteLine("Gebruikersnaam mag geen spaties bevatten. Probeer nogmaals:");
                    Console.ResetColor();
                    username = Console.ReadLine();
            }

            page.Update();
            Console.WriteLine("");
            // Wordt gevraagd om invoeren van wachtwoord
            Console.WriteLine("Voer uw wachtwoord in:");
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.WriteLine("Wachtwoord moet bestaan uit 8 karakters met een cijfer, een hoofdletter en een speciaal karakter");
            Console.ResetColor();
            var password = Console.ReadLine();
            

            bool isNumber = false;
            while(isNumber == false){
                while(password.Length < 8){
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("");
                    Console.WriteLine("Wachtwoord bevat GEEN 8 karakters. Probeer nogmaals:");
                    Console.ResetColor();
                    password = Console.ReadLine();
                }

                for (int i = 0; i < password.Length && isNumber == false; i++){
                    if (!char.IsDigit(password[i])){
                        isNumber = false;
                        }
                    else{
                        isNumber = true;
                    }
                }
                if(isNumber == false){
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("");
                    Console.WriteLine("Wachtwoord bevat GEEN digit. Probeer nogmaals:");
                    Console.ResetColor();
                    password = Console.ReadLine();
                }
            }
            
            Console.WriteLine("");
            // Wordt gevraagd om nogmaals invoeren van wachtwoord
            Console.WriteLine("Voer uw wachtwoord nogmaals in:");
            string repeatPassword = Console.ReadLine();

            // Als de 2e wachtwoord niet overeen komt geeft deze foutmelding
            while(password != repeatPassword){
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("De wachtwoorden komen niet overeen. Probeer nogmaals:");
                Console.ResetColor();
                repeatPassword = Console.ReadLine();

            }
            
            // Maak nieuw user object aan
            // Stel de gegevens in (properties)
            Storage.User newUser = new Storage.User() {
                username = username,
                email = email,
                password = password,
                role = "user"
            };

            // Voeg toe aan storge user list
            Storage.System.data.users.Add(newUser);

            // Sla de huidige gegevens op
            Storage.System.SaveStorage();
            
            UISystem.Input.ReadString("U heeft geregisteerd! (klik op enter om door te gaan)");
            StartPage.Display();
        }
        public static bool Check(string user){
            foreach(Storage.User gebruiker in Storage.System.data.users) {
                if(gebruiker.email == user || gebruiker.username == user)
                    return false;
            }
            return true;
        }

    }
}