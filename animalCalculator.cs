// Week 2: Animal Information Calculator
// Collect animal data and calculate food requirements

using System;
// using Internal;

// Title
Console.WriteLine("=== Animal Information Entry ===");

// Ask for animal name
Console.Write("Enter an animal name: ");
string nameInput = Console.ReadLine();

// Ask for animal count
Console.Write($"Enter number of {nameInput}s: ");
int countInput = Convert.ToInt32(Console.ReadLine());

// Ask for pounds of food required per day
Console.Write($"Enter pounds of food per {nameInput} per day: ");
double foodInput = Convert.ToDouble(Console.ReadLine());

// Output Animal and food data
Console.WriteLine($"\nAnimal: {nameInput}");
Console.WriteLine($"Count: {countInput}");
Console.WriteLine($"Daily food: {foodInput} lbs/day");

// Calculate and output additional data
Console.WriteLine($"Total Daily Food: {countInput * foodInput} lbs");
Console.WriteLine($"Total Weekly Food: {7 * (countInput * foodInput)} lbs");
