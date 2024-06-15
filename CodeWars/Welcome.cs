using System.Collections.Generic;

namespace CodeWars
{
    public class Welcome
    {
        private static Dictionary<string, string> WelcomeDB = new Dictionary<string, string>
        { 
            { "english", "Welcome" },
            { "czech", "Vitejte" },
            { "danish", "Velkomst" },
            { "dutch", "Welkom" },
            { "estonian", "Tere tulemast" },
            { "finnish", "Tervetuloa" },
            { "flemish", "Welgekomen" },
            { "french", "Bienvenue" },
            { "german", "Willkommen" },
            { "irish", "Failte" },
            { "italian", "Benvenuto" },
            { "latvian", "Gaidits" },
            { "lithuanian", "Laukiamas" },
            { "polish", "Witamy" },
            { "spanish", "Bienvenido" },
            { "swedish", "Valkommen" },
            { "welsh", "Croeso" },
        };

        public static string Greet(string language)
            => WelcomeDB.TryGetValue(language, out var welcome) ? welcome : "Welcome";
    }
}
