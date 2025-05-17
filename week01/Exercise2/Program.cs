using System;

class Program
{
    static void Main()
    {
        // Ask the user for their grade percentage
        Console.Write("Enter your grade percentage: ");
        string input = Console.ReadLine();
        int grade = int.Parse(input);

        string letter = "";
        string sign = "";

        // Determine the letter grade
        if (grade >= 90)
        {
            letter = "A";
        }
        else if (grade >= 80)
        {
            letter = "B";
        }
        else if (grade >= 70)
        {
            letter = "C";
        }
        else if (grade >= 60)
        {
            letter = "D";
        }
        else
        {
            letter = "F";
        }

        // Determine the sign (stretch challenge)
        int lastDigit = grade % 10;

 if (letter != "A" && letter != "F")
 {
 if (lastDigit >= 7)
 {
 sign = "+";
 }
 else if (lastDigit < 3)
 {
 sign = "-";
}
 }
 else if (letter == "A" && grade < 93)
 {
sign = "-";
 }

        // Display the final grade
Console.WriteLine($"\nYour grade is: {letter}{sign}");

        // Pass/fail message
 if (grade >= 70)
{
 Console.WriteLine("Congratulations! You passed the course.");
 }
 else
 {
 Console.WriteLine("Don't give up! Keep working and you'll improve next time.");
 }
 }
}