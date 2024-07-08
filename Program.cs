using System.Security.Cryptography.X509Certificates;

namespace Zachary_Renyhart_Assignment_10._2._2
{
   
    public class Employee
    {
        public double Salary { get; set; }
        public int Age { get; set; }

        public string Name { get; set; }

    }


    internal class Program
    {
        static void Main(string[] args)
        {

            List<Employee> employees = new List<Employee>()
            {
                new Employee() { Name = "Zack", Age = 23, Salary = 75000 },
                new Employee() { Name = "Michelle", Age = 22, Salary = 95000 },
                new Employee() { Name = "Valorie", Age = 35, Salary = 2000 },
                new Employee() { Name = "Michael", Age = 31, Salary = 32000 },
                new Employee() { Name = "Sean", Age = 34, Salary = 4500 },
                new Employee() { Name = "Keith", Age = 23, Salary = 60000 },
                new Employee() { Name = "Giana", Age = 18, Salary = 1200 },
                new Employee() { Name = "Mark", Age = 45, Salary = 90000 }

            };
                var NumQuery = from num in employees where num.Salary > 5000 && num.Age < 30 select num;
            Console.WriteLine("These are the employees that are making more than $5,000 a year and are younger than 30 years old!!");
            Console.WriteLine();
                foreach (var num in NumQuery)
                {
                    Console.WriteLine("Name: " + num.Name);
                    Console.WriteLine("Age: " + num.Age);
                    Console.WriteLine("Salary $"+num.Salary);
                Console.WriteLine();
                }

            }
            
        }
            










        
    
}
