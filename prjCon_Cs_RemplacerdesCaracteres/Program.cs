using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace prjCon_Cs_RemplacerdesCaracteres
{
    class Program
    {
        /*
        * This project uses the following licenses:
        *  MIT License
        *  Copyright (c) 2019 Ricardo Mendoza 
        *  Montréal Québec Canada
        *  Institut Teccart
        *  www.teccart.qc.ca
        *  Hiver 2019
        */
        static void Main(string[] args)
        {
            // variable
            string xchaine = "ABCBEAG";
            Console.WriteLine("\n\nREMPLACER DES CARATERES", Console.ForegroundColor=ConsoleColor.Green);
            Console.WriteLine("\nRemplacer A->X et B->Y", Console.ForegroundColor=ConsoleColor.Gray);
            Console.WriteLine("\n\nChaine : {0}", xchaine,Console.ForegroundColor=ConsoleColor.Yellow);
            Console.WriteLine("\nRemplace : {0}", fncRemplacerChar(xchaine),Console.ForegroundColor=ConsoleColor.Cyan);
            Console.ReadKey();
        }

        // ---------- Remplacer A->X et B->Y
        // staic -> methods are methods that are called on the class itself, not on specific object instance
        // private -> the method can be acceced only by code in the same class or struct
        private static string fncRemplacerChar(string source)
        {
            // Regex -> In a specified input string, replaces all strings that match a specified regular 
            // expression with a specified replacement string. Specified options modify the matching operation.
            // RegexOptions.IgnoreCase. Sometimes text data has inconsistent casing. 
            // Some data is uppercase, and some lowercase, but both are valid. The Regex type in the
            // C# language by default is case-sensitive. RegexOptions.IgnoreCase relaxes this.
            source = Regex.Replace(source, "A", "X", RegexOptions.IgnoreCase);
            source = Regex.Replace(source, "B", "Y", RegexOptions.IgnoreCase);
            return source;
        }
    }
}