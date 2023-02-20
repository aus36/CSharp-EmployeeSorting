using System;
using System.IO;
namespace Assignment1
{
    public class Sorter
    {
        public static Worker[] Sort(Worker[] input)
        {
            for (int i = 0; i < (input.Length) - 1; i++)
            {
                for (int j = 0; j < (input.Length) - 1; j++)
                {
                    if (String.Compare(input[i].lastName, input[i+1].lastName) > 0)
                    {
                        Worker temp = input[i + 1];
                        input[i + 1] = input[i];
                        input[i] = temp;
                    }
                }
            }
            return input;
        }
    }

    public class FileReader
    {
        public static string[] read(string filePath) //Class for reading file input into string array
        {
            return File.ReadAllLines(filePath);
        }

        public static Worker[] objectify(string[] input) //Class for turning string array into object array
        {
            Worker[] workers = new Worker[input.Length-1];
            for(int i=1; i<input.Length; i++)
            {
                string[] line = input[i].Split('\t',StringSplitOptions.RemoveEmptyEntries);
                switch (line[0]) //store different data based on type of employee
                {
                    case ("PreHire"):
                        PreHire p = new PreHire();
                        p.workerType = line[0]; //fill all data in new object
                        p.employeeID = int.Parse(line[1]);
                        p.firstName = line[2];
                        p.lastName = line[3];
                        p.offerDate = line[4];
                        p.acceptDate = line[5];
                        p.employmentDate = line[6];
                        workers[i-1] = p; //add to workers array for return
                        break;

                    case ("Employee"):
                        Employee e = new Employee();
                        e.workerType = line[0];
                        e.employeeID = int.Parse(line[1]);
                        e.firstName = line[2];
                        e.lastName = line[3];
                        e.employmentDate = line[4];
                        e.jobTitle = line[5];
                        e.monthlySalary = double.Parse(line[6]);
                        workers[i-1] = e;
                        break;

                    case ("Retiree"):
                        Retiree r = new Retiree();
                        r.workerType = line[0];
                        r.employeeID = int.Parse(line[1]);
                        r.firstName = line[2];
                        r.lastName = line[3];
                        r.employmentDate = line[4];
                        r.retirementProgram = line[5];
                        r.retirementDate = line[6];
                        workers[i-1] = r;
                        break;
                }
            }
            return workers; //output array of workers read from file
        }
    }

    public class FileWriter
    {
        public static void write(Worker[] workers, string pFile, string eFile, string rFile)
        {
            File.WriteAllText(pFile, "<PreHires>"); //write opening XML tags
            File.WriteAllText(eFile, "<Employees>");
            File.WriteAllText(rFile, "<Retirees>");
            
            foreach (Worker w in workers) //iterate through workers, writing each into respective files in XML format
            {
                switch (w.workerType)
                {
                    case ("PreHire"):
                        File.AppendAllText(pFile, w.toXML());
                        break;
                    case ("Employee"):
                        File.AppendAllText(eFile, w.toXML());
                        break;
                    case ("Retiree"):
                        File.AppendAllText(rFile, w.toXML());
                        break;
                }
            }

            File.AppendAllText(pFile, "\n</PreHires>"); //write closing XML tags
            File.AppendAllText(eFile, "\n</Employees>");
            File.AppendAllText(rFile, "\n</Retirees>");
        }
    }
}

