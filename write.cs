using System;
using System.IO;

class Program
{
    static void Main()
    {
        string filePath = "output.txt";
        string textToWrite = "Hello from Jenkins!\n";

        try
        {
            // Append the text to the file (creates file if it doesn't exist)
            File.AppendAllText(filePath, textToWrite);
            Console.WriteLine("Text written successfully.");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error writing to file: {ex.Message}");
        }
    }
}
