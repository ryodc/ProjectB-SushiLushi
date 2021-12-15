using System;
using System.IO;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Collections.Generic;

namespace Storage {

    public static class SushiLushiState {
        public static Boolean isLoggedIn = false;
        public static Boolean isAdmin = false;
        public static User loggedUser = null;

    }

    public class SushiLushiData {

        // List van alle geregistreerde accounts
        public List<User> users;
        public List<Reservation> reservations;

        // Constructor
        public SushiLushiData() {
            users = new List<User>();
            reservations = new List<Reservation>();
        }
    }

    public static class System {
        // Maak een nieuw SushiLushiData object aan
        public static SushiLushiData data;

        // Globale json bestandsnaam
        private static string mainStorageFile = @"./sushi-lushi-data.json";

        // Constructor
        static System() {
            data = new SushiLushiData();
        }

        public static void InitStorage() {
            // Check of het mainstorage bestand bestaat. zo niet maak hem dan aan.
            if(!File.Exists(mainStorageFile)) {
                
                // Initialiseer nieuwe admin user
                User adminUser = new User() {
                    username = "admin",
                    email = "admin",
                    password = "12345",
                    role = "admin"
                };
                
                // Voeg admin user toe aan data user list
                System.data.users.Add(adminUser);

                // Call save storage om huidige data op te slaan
                SaveStorage();
            } else {
                // Bestand bestaal al wel, laad data in.
                LoadStorage();
            }

        }   

        public static void SaveStorage () {

            // Check of het bestand al bestaat
            if(!File.Exists(mainStorageFile)) {
                // Maak het bestand leeg
                File.WriteAllText(mainStorageFile, String.Empty);
            }

            // Json opties en zet identaties & fields aan
            JsonSerializerOptions options = new JsonSerializerOptions {
                IncludeFields = true,
                WriteIndented = true,
            };

            // Zet de SushiLushiData object om naar json (serialize)
            string jsonTextData = JsonSerializer.Serialize<SushiLushiData>(data, options);
            
            // Maak bestand aan en zet de serialized data er in
            File.WriteAllText(mainStorageFile, jsonTextData);
        }

        private static void LoadStorage () {

            // Laad alle json data in van het bestand
            string jsonTextData = File.ReadAllText(mainStorageFile);

            Console.WriteLine(jsonTextData);

            // Json opties zodat fields ook worden deserialized
            var options = new JsonSerializerOptions
            {
                IncludeFields = true,
            };

            // Zet de jsondata om naar een SushiLushiData object (deserialize)
            System.data = JsonSerializer.Deserialize<SushiLushiData>(jsonTextData, options);
        }

    }
}