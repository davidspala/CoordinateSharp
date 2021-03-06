﻿/*
 * The following program is used to automate certain aspects of the testing of CoordinateSharp.
 */
using System;
using System.Globalization;
using System.Threading;
namespace CoordinateSharp_TestProj
{
    class Program
    {
      
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.White;
          
            while (true)
            {
                Console.WriteLine("Select Test Module to Run (Enter Test Number). Options marked DEPRECATED have been moved to the CoordinateSharp_UnitTests project:");
                Console.WriteLine();
                Console.WriteLine("1. Coordinate Initializations (DEPRECATED)");
                Console.WriteLine("2. Coordinate Conversions (DEPRECATED)");
                Console.WriteLine("3. Coordinate Parsers");
                Console.WriteLine("4. Celestial");
                Console.WriteLine("5. Distance Initialization / Move Tests");
                Console.WriteLine("6. Benchmarks");
                Console.WriteLine("7. GeoFence Tests");
                Console.WriteLine("8. EagerLoading Tests (DEPRECATED)");
                Console.WriteLine("ESC. Exit");
                Console.WriteLine();
                Console.Write("Select a Test Number: ");
                ConsoleKeyInfo t = Console.ReadKey();
                Console.WriteLine();
                Console.WriteLine("*********************");
                Console.WriteLine();

                if (t.Key == ConsoleKey.D1 || t.Key == ConsoleKey.NumPad1) { Coordinate_Initialization.Run_Test(); }
                else if (t.Key == ConsoleKey.D2 || t.Key == ConsoleKey.NumPad2) { Coordinate_Conversion_Tests.Run_Test(); }
                else if (t.Key == ConsoleKey.D3 || t.Key == ConsoleKey.NumPad3) { Coordinate_Parser_Tests.Run_Test(); }
                else if (t.Key == ConsoleKey.D4 || t.Key == ConsoleKey.NumPad4) { CelestialTests.Run_Test(); }
                else if (t.Key == ConsoleKey.D5 || t.Key == ConsoleKey.NumPad5) { Distance_Tests.Run_Test(); }
                else if (t.Key == ConsoleKey.D6 || t.Key == ConsoleKey.NumPad6) { Benchmark_Tests.Run_Test(); }
                else if (t.Key == ConsoleKey.D7 || t.Key == ConsoleKey.NumPad7) { GeoFence_Tests.Run_Test(); }
                else if (t.Key == ConsoleKey.D8 || t.Key == ConsoleKey.NumPad8) { EagerLoading_Tests.Run_Tests(); }
                else if (t.Key == ConsoleKey.Escape) { return; }
                else
                {
                    Console.WriteLine();
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Test choice invalid.");
                    Console.ForegroundColor = ConsoleColor.White;
                }
               
                Console.WriteLine();
                Console.WriteLine();
            }
            
        }                  
    }
}
