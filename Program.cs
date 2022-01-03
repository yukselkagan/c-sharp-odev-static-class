using System;

namespace c_sharp_odev_static_class
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Number of employees: "+ Employee.EmployeeCount);

            Employee employee = new Employee("John", "Doe", "Finance");
            Console.WriteLine("Number of employees: " + Employee.EmployeeCount);
            Employee employee2 = new Employee("Gimli", "Erobor", "Finance");
            Employee employee3 = new Employee("Legolas", "Mirkwood", "Finance");
            Console.WriteLine("Number of employees: " + Employee.EmployeeCount);

            Console.WriteLine("SumNumber : "+ Operations.SumNumber(100,30));
            Console.WriteLine("SubtractionNumber : " + Operations.SubtractionNumber(100,30));


        }
    }




    class Employee
    {

        private static int employeeCount;

        public static int EmployeeCount { get => employeeCount; }


        private string firstName;
        private string lastName;
        private string department;

        static Employee()
        {
            employeeCount = 0;
        }


        public Employee(string firstName, string lastName, string department)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.department = department;
            employeeCount++;
        }

    }



    static class Operations
    {
        public static int SumNumber(int number1, int number2)
        {
            return number1 + number2;
        }

        public static int SubtractionNumber(int number1, int number2)
        {
            return number1 - number2;
        }




    }







}
