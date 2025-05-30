// See https://aka.ms/new-console-template for more information

using System.Numerics;

Console.WriteLine("Enter two numbers: ");
string userInput = Console.ReadLine();
double num1 = Convert.ToDouble(userInput);
string userInput2 = Console.ReadLine();
double num2 = Convert.ToDouble(userInput2);
Console.WriteLine("Choose the Arithmetic operation that you want to do: ");
string operation = Console.ReadLine();
double result;

// Check if the operation is addition
if (operation == "+")
{
    result = num1 + num2; // Perform addition
                          // Display the result
    Console.WriteLine($"Result: {result}");
}
// Check if the operation is subtraction
else if (operation == "-")
{
    result = num1 - num2; // Perform subtraction
                          // Display the result
    Console.WriteLine($"Result: {result}");
}
// Check if the operation is multiplication
else if (operation == "*")
{
    result = num1 * num2; // Perform multiplication
                          // Display the result
    Console.WriteLine($"Result: {result}");
}
// Check if the operation is division
else if (operation == "/")
{
    // Check if the second number is not zero to avoid division by zero
    if (num2 != 0)
    {
        result = num1 / num2; // Perform division
                              // Display the result
        Console.WriteLine($"Result: {result}");
    }
    else
    {
        // Display an error message for division by zero
        Console.WriteLine("Error: Division by zero is not allowed.");
    }
}
else
{
    // Display an error message for an invalid operation
    Console.WriteLine("Invalid operation. Please choose +, -, *, or /.");
}
Console.ReadKey();