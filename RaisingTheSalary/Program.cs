namespace RaisingTheSalary
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Person> people = new List<Person>();
            Console.WriteLine("How many employees?");
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                Person person = new Person();
                Console.Write($"Enter name {i + 1}: ");
                person.Name = Console.ReadLine();
                Console.Write($"Enter salary {i + 1}: ");
                person.Salary = double.Parse(Console.ReadLine());
                Console.Write($"Enter occupation {i + 1}: ");
                person.Occupation = Console.ReadLine();
                Console.Write($"Enter department {i + 1}: ");
                person.Department = Console.ReadLine();
                people.Add( person );
            }
            Console.WriteLine($"What % do you want to increace the salary? ");
            double bonus = double.Parse(Console.ReadLine());
            Person.IncreaseSalary(people, bonus);
            for (int i = 0;i < n;i++)
            {
                people[i].Print();
            }
        }
    }
}
