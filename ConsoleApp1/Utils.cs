using System;
using System.Text.RegularExpressions;
using static System.Console;

namespace ConsoleApp1 {
    public static class Utils {

        public static string AskQuestion(string question) {
            WriteLine(question);
            return ReadLine();
        }

        public static int AskIntQuestion(string question) {
            WriteLine(question);
            return int.Parse(ReadLine());
        }

        public static bool AskYesNoQuestion(string question) {
            WriteLine("\n" + question + " [y/n]");
            var input = ReadLine();
            while (!input.StartsWith("y") && !input.StartsWith("n")) {
                WriteLine("\n" + question + " [y/n]");
                input = ReadLine();
            }
            return (input.StartsWith("y"));

        }

        public static void PrintHeader(string header) {
            WriteLine("\n");
            WriteLine("==============================\n");
            WriteLine(header + "\n");
            WriteLine("==============================\n");
            WriteLine("\n");
        }

    }
}