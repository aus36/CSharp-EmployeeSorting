using System;
namespace Assignment1
{
    public class Worker
    {
        public string? workerType { get; set; } //class fields and properties
        public int? employeeID { get; set; }
        public string? firstName { get; set; }
        public string? lastName { get; set; }
        public string? employmentDate { get; set; }

        public override string ToString() //function for returning human readable string format of class with properties
        {
            throw new Exception("Cannot convert object worker to string.");
        }
        public virtual string toXML() //function returning XML format in a string for writing to files (virutal to be overriden by child classes) 
        {
            string XML =
                "\n\t<Worker>" +
                "\n\t\t<EmployeeID>" + this.employeeID + "</EmployeeID>" +
                "\n\t\t<FirstName>" + this.firstName + "</FirstName>" +
                "\n\t\t<LastName>" + this.lastName + "</LastName>" +
                "\n\t\t<EmploymentDate>" + this.employmentDate + "</EmploymentDate>" +
                "\n\t</Worker>";
            return XML;
        }
    }

    public class PreHire : Worker
    {
        public string? offerDate { get; set; }
        public string? acceptDate { get; set; }

        public override string ToString()
        {
            string output = "Worker Type : PreHire" +
                "\nEmployee ID : " + this.employeeID +
                "\nFirst Name : " + this.firstName +
                "\nLast Name : " + this.lastName +
                "\nEmployment Date : " + this.employmentDate +
                "\nOffer sent Date : " + this.offerDate +
                "\nOffer Acceptance Date : " + this.acceptDate;
            return output;
        }

        public override string toXML()
        {
            string XML =
                "\n\t<PreHire>" +
                "\n\t\t<EmployeeID>"+this.employeeID+"</EmployeeID>" +
                "\n\t\t<FirstName>"+this.firstName+"</FirstName>" +
                "\n\t\t<LastName>"+this.lastName+"</LastName>" +
                "\n\t\t<EmploymentDate>"+this.employmentDate+"</EmploymentDate>" +
                "\n\t\t<OfferDate>" + this.offerDate + "</OfferDate>" +
                "\n\t\t<AcceptDate>" + this.acceptDate + "</AcceptDate>" +
                "\n\t</PreHire>";
            return XML;
        }
    }

    public class Employee : Worker
    {
        public string? jobTitle { get; set; }
        public double? monthlySalary { get; set; }

        public override string ToString()
        {
            string output = "Worker Type : Employee" +
                "\nEmployee ID : " + this.employeeID +
                "\nFirst Name : " + this.firstName +
                "\nLast Name : " + this.lastName +
                "\nEmployment Date : " + this.employmentDate +
                "\nJob Title : " + this.jobTitle +
                "\nMonthly Salary : $" + this.monthlySalary;
            return output;
        }

        public override string toXML()
        {
            string XML =
                "\n\t<Employee>" +
                "\n\t\t<EmployeeID>" + this.employeeID + "</EmployeeID>" +
                "\n\t\t<FirstName>" + this.firstName + "</FirstName>" +
                "\n\t\t<LastName>" + this.lastName + "</LastName>" +
                "\n\t\t<EmploymentDate>" + this.employmentDate + "</EmploymentDate>" +
                "\n\t\t<JobTitle>" + this.jobTitle + "</JobTitle>" +
                "\n\t\t<MonthlySalary>" + this.monthlySalary + "</MonthlySalary>" +
                "\n\t</Employee>";
            return XML;
        }
    }

    public class Retiree : Worker
    {
        public string? retirementProgram { get; set; }
        public string? retirementDate { get; set; }

        public override string ToString()
        {
            string output = "Worker Type : Retiree" +
                "\nEmployee ID : " + this.employeeID +
                "\nFirst Name : " + this.firstName +
                "\nLast Name : " + this.lastName +
                "\nEmployment Date : " + this.employmentDate +
                "\nReirement Program : " + this.retirementProgram +
                "\nRetirement Date" + this.retirementDate;
            return output;
        }

        public override string toXML()
        {
            string XML =
                "\n\t<Retiree>" +
                "\n\t\t<EmployeeID>" + this.employeeID + "</EmployeeID>" +
                "\n\t\t<FirstName>" + this.firstName + "</FirstName>" +
                "\n\t\t<LastName>" + this.lastName + "</LastName>" +
                "\n\t\t<EmploymentDate>" + this.employmentDate + "</EmploymentDate>" +
                "\n\t\t<RetirementProgram>" + this.retirementProgram + "</RetirementProgram>" +
                "\n\t\t<RetirementDate>"+ this.retirementDate + "</RetirementDate>" +
                "\n\t</Retiree>";
            return XML;
        }
    }
}

