//Austin Hale
//C# Assignment 1

//All output/input files are located in the folder: Assignment1/bin/Debug/net7.0

using System;
namespace Assignment1;

public class Program
{
    static void Main()
    {
        //Take user input for variables
        Console.WriteLine("Enter the full filepath of the input file (eg: Desktop/Users/SampleUser/inputfile.txt): ");
        string inputFilePath = Console.ReadLine()!;
        Console.WriteLine("Enter the name of the pre-hires output file (just the filename, not full path, (ex: output.txt): ");
        string preHiresFname = Console.ReadLine()!;
        Console.WriteLine("Enter the name of the employees output file: ");
        string employeesFname = Console.ReadLine()!;
        Console.WriteLine("Enter the name of the retirees output file: ");
        string retireesFname = Console.ReadLine()!;

        //Read file contents and place into string array
        string[] fileLines = FileReader.read(inputFilePath);

        //Objectify strings from file input
        Worker[] workers = new Worker[fileLines.Length - 1];
        workers = FileReader.objectify(fileLines);

        //Sort object arrays
        Sorter.Sort(workers);

        //Write XML of workers to filepaths entered
        FileWriter.write(workers, preHiresFname, employeesFname, retireesFname);
    }
}