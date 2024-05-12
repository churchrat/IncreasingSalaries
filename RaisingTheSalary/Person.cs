using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace RaisingTheSalary
{
    internal class Person
    {
        public Person()
        {
            
        }
        public Person(string name, double salary, string ocupation, string department)
        {
            Name = name;
            Salary = salary;
            Occupation = ocupation;
            Department = department;
        }
        public Person(string name, double salary)
        {
            Name = name;
            Salary = salary;
        }
        private string name;
        private double salary;
        private string ocupation;
        private string department;

        public string Name { get; set; }
        public double Salary { get; set; }
        public string Occupation { get; set; }
        public string Department { get; set; }

        public void Print()
        {
            Console.WriteLine($"Name: {this.Name}; Salary: {Math.Round(this.Salary,2)}; Occupation: {this.Occupation}; Department: {this.Department}");
        }
        public static void IncreaseSalary(List<Person> people, double bonus)
        {
            for (int i = 0; i < people.Count; i++)
            {
                double bonusReal = (bonus / 100) * people[i].Salary;
                people[i].Salary += bonusReal;
            }
        }
    }
}
