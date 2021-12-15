using System;

namespace SushiLushi {
    class ReserveerPage {
        public static UISystem.Page page = new UISystem.Page("Reserveer pagina");

        public static void Display() { 
            page.Update(); 
            //
            // Aantal Personen
            //

            int aantal_mensen = UISystem.Input.ReadInt("Voer het aantal personen in waarmee u komt:", 1, 5);
            
            //
            // Datum
            //

            
            Console.Write("Vandaag is het ");
            Console.ForegroundColor = ConsoleColor.Yellow;
            DateTime today = DateTime.Now;  
            Console.WriteLine(today.ToString("dddd") + " " + today.Date.ToString("dd-MM-yyyy"));
            Console.ResetColor();

            Console.WriteLine("Kies een dag:");

            DateTime[] available_dates = new DateTime[] { today.AddDays(1), today.AddDays(2), today.AddDays(3), today.AddDays(4), today.AddDays(5) };

            var menu2 = new UISystem.Menu();

            foreach (DateTime value in available_dates) {
                menu2.Add(value.ToString("dddd") + " " + value.Date.ToString("dd-MM"));
            }

            menu2.Display();

            int index_menu2 = menu2.GetSelectedIndex(); 
            Console.Write("Je hebt gekozen voor: ");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(available_dates[index_menu2 -1].ToString("dddd") + " " + available_dates[index_menu2 -1].Date.ToString("dd-MM"));
            Console.ResetColor();

            //
            // Tijd
            //

            Console.WriteLine("Kies een tijd: ");
            
            TimeSpan[] available_times = new TimeSpan[] { new TimeSpan(13, 00, 00), new TimeSpan(16, 00, 00), new TimeSpan(18, 00, 00), new TimeSpan(20, 00, 00)};
            var menu3 = new UISystem.Menu();

            foreach (TimeSpan value in available_times) {
                menu3.Add("Vanaf: " + value.ToString(@"hh\:mm"));
            }

            menu3.Display();
            
            int index_menu3 = menu3.GetSelectedIndex();
            page.Update();
            Console.Write("Je hebt gekozen voor: ");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(available_dates[index_menu2].ToString("dddd") + " " + available_dates[index_menu2].Date.ToString("dd-MM") + " " + available_times[index_menu3 - 1].ToString(@"hh\:mm"));
            Console.ResetColor();  

            //
            // Dieet opmerkingen
            //
            
            int[] Arr_Opties = new int[aantal_mensen];  
            string[] Arr2 = new string[] { "Geen", "Vegetarisch", "Veganistisch", "Glutenvrij", "Notenallergie" };
            
            int counter_mensen = 1; 
            for (int i = 0; i < aantal_mensen; i++) { 
                Console.Write("Heeft u dieet wensen/ alergieën?");
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine(" Persoon " + counter_mensen);
                Console.ResetColor();  

                var menu4 = new UISystem.Menu();

                foreach (string value in Arr2) {
                    menu4.Add(value);
                }

                menu4.Display();

                int index_menu4 = menu4.GetSelectedIndex();
                Arr_Opties[i] = index_menu4; 
                counter_mensen++; 
            }

            Console.WriteLine("Eetwensen personen: ");
            string[] people_notes = new string[aantal_mensen];
            for (int i = 0; i < aantal_mensen; i++) {
                int optie_menu = Arr_Opties[i];
                int index_onnodig = i+1;
                
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write("Persoon " + index_onnodig + ": "); 
                Console.ResetColor();  
                Console.WriteLine(Arr2[optie_menu - 1]); 

                people_notes[i] = Arr2[optie_menu - 1];
            }

            string reservationUsername = "";
            bool reservationGuest = true;
            
            if (Storage.SushiLushiState.isLoggedIn) {
                reservationUsername = Storage.SushiLushiState.loggedUser.username;
                reservationGuest = false;
            }

            // voeg tijd en datum bij elkaar tot een datetime object
            DateTime reservationDatetime = new DateTime(
                available_dates[index_menu2].Year,
                available_dates[index_menu2].Month,
                available_dates[index_menu2].Day,
                available_times[index_menu3 - 1].Hours,
                available_times[index_menu3 - 1].Minutes,
                0
            );

            Storage.Reservation newReservation = new Storage.Reservation() {
                guestAccount = reservationGuest,
                username = reservationUsername,
                amountPeople = aantal_mensen,
                peopleNotes = people_notes,
                datetime = reservationDatetime
            };

            Storage.System.data.reservations.Add(newReservation);
            Storage.System.SaveStorage();

            UISystem.Input.ReadString("U heeft gereserveerd! (Klik op enter om door te gaan)");
            StartPage.Display();
        }
        private static void GoToStart() {
            StartPage.Display();        }

    }
}