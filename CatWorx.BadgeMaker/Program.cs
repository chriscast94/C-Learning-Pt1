//New system
// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

//test
// string greeting = "Hello";
// greeting = greeting + "World";
// Console.WriteLine("greeting" + greeting);

//Older system
// Using == import; allows us to use one of the namespace System's members without always calling it
//using System;

using System.Collections.Generic;
//Namespace similar to modules in Node.js
//Like containers with members — everything within the curly braces are members within that container

//Example Dictionary
Dictionary<string, int> myScoreBoard = new Dictionary<string, int>();

myScoreBoard.Add("firstInning", 10);
myScoreBoard.Add("secondInning", 20);
myScoreBoard.Add("thirdInning", 30);
myScoreBoard.Add("fourthInning", 40);
myScoreBoard.Add("fifthInning", 50);

Console.WriteLine("----------------");
Console.WriteLine("  Scoreboard");
Console.WriteLine("----------------");
Console.WriteLine("Inning |  Score");
Console.WriteLine("   1   |    {0}", myScoreBoard["firstInning"]);
Console.WriteLine("   2   |    {0}", myScoreBoard["secondInning"]);
Console.WriteLine("   3   |    {0}", myScoreBoard["thirdInning"]);
Console.WriteLine("   4   |    {0}", myScoreBoard["fourthInning"]);
Console.WriteLine("   5   |    {0}", myScoreBoard["fifthInning"]);



// namespace CatWorx.BadgeMaker
// {
//     class Program
//     {
//         static void Main(string[] args)
//         {
//             // Integers
//             // Console.WriteLine(2 * 3);         // Basic Arithmetic: +, -, /, * 6
//             // Console.WriteLine(10 % 3);        // Modulus Op => remainder of 10/3 1
//             // Console.WriteLine(1 + 2 * 3);     // order of operations 7
//             // Console.WriteLine(10 / 3.0);      // int's and doubles 3.3
//             // Console.WriteLine(10 / 3);        // int's  3
//             // Console.WriteLine("12" + "3");    // What happens here? strings concat

//             // int num = 10;
//             // num += 100; // adds 100 to int 10
//             // Console.WriteLine(num);
//             // num++; //adds 1 to int num
//             // Console.WriteLine(num);

//             //Boolean
//             // bool isCold = true;
//             // Console.WriteLine(isCold ? "drink" : "add ice");  // output: drink
//             // Console.WriteLine(!isCold ? "drink" : "add ice");  // output: add ice

//             //Conversion
//             string stringNum = "2";
//             int intNum = Convert.ToInt16(stringNum); //Convert begins conversion, .ToInt16 converts to specific type
//             Console.WriteLine(intNum);
//             Console.WriteLine(intNum.GetType());

//         }
//     }
// }