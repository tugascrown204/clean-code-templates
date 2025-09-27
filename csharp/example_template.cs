using System;

namespace CleanCodeTemplates {
    public class Program {
        /// <summary>
        /// Greet a person with a friendly message.
        /// </summary>
        /// <param name="name">The name of the person to greet.</param>
        /// <returns>Greeting message.</returns>
        public static string Greet(string name) {
            return $"Hello, {name}!";
        }

        public static void Main(string[] args) {
            Console.WriteLine(Greet("World"));
        }
    }
}