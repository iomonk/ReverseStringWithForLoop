using ReverseStringWithForLoop.Handler;

Console.Write("Enter any string: ");
var userInput = Console.ReadLine();
var reversedString = userInput.ReverseString();
Console.WriteLine($"{reversedString}");