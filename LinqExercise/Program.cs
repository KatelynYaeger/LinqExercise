using System;
using System.Collections.Generic;
using System.Linq;

namespace LinqExercise
{
    class Program
    {
        //Static array of integers
        private static int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 0 };

        static void Main(string[] args)
        {
            /*
             * 
             * Complete every task using Method OR Query syntax. 
             * You may find that Method syntax is easier to use since it is most like C#
             * Every one of these can be completed using Linq and then printing with a foreach loop.
             * Push to your github when completed!
             * 
             */

            //TODO: Print the Sum of numbers - DONE 

            Console.WriteLine($"{numbers.Sum()}");

            Console.WriteLine("");

            //TODO: Print the Average of numbers - DONE 

            Console.WriteLine($"{numbers.Average()}");

            Console.WriteLine("");

            //TODO: Order numbers in ascending order and print to the console - DONE

            var number = numbers.OrderBy(digit => digit).ToList();
            foreach (var digit in number)
            {
                Console.WriteLine($"{digit}");
            }

            Console.WriteLine("");


            //TODO: Order numbers in decsending order and print to the console -DONE

            var numberList = numbers.OrderByDescending(digit => digit).ToList();
            foreach (var digit in numberList)
            {
                Console.WriteLine($"{digit}");
            }

            Console.WriteLine("");

            //TODO: Print to the console only the numbers greater than 6 - DONE

            var num = numbers.Where(digit => digit < 6);
            foreach (var digit in num)
            {
                Console.WriteLine($"{digit}");
            }

            Console.WriteLine("");

            //TODO: Order numbers in any order (acsending or desc) but only print 4 of them **foreach loop only! - DONE

            var nums = numbers.OrderBy(digit => digit).Take(4).ToList();
            foreach (var digit in nums)
            {
                Console.WriteLine($"{digit}");
            }

            Console.WriteLine("");

            //TODO: Change the value at index 4 to your age, then print the numbers in decsending order - DONE

            numbers[4] = 28;

            var orderedList = numbers.OrderByDescending(digit => digit).ToList();
            foreach (var digit in orderedList)
            {
                Console.WriteLine($"{digit}");
            }


            Console.WriteLine("");



            // List of employees ****Do not remove this****
            var employees = CreateEmployees();

            //TODO: Print all the employees' FullName properties to the console only
            //if their FirstName starts with a C OR an S and order this in ascending order by FirstName.

            var filtered =
                employees.Where(person => person.FirstName.StartsWith("C") || person.FirstName.StartsWith("S"))
                .OrderBy(person => person.FirstName);

            foreach (var employee in filtered)
            {
                Console.WriteLine($"{employee.FullName}");
            }

            //TODO: Print all the employees' FullName and Age who are over the age 26
            //to the console and order this by Age first and then by FirstName in the same result.

            var over26 = employees.Where(person => person.Age > 26).OrderBy(person => person.Age)
                .ThenBy(person => person.FirstName);

            foreach (var person in over26)
            {
                Console.WriteLine($"{person.FullName} is {person.Age} years old");
            }

            //TODO: Print the Sum and then the Average of the employees' YearsOfExperience - DONE
            //if their YOE is less than or equal to 10 AND Age is greater than 35.

            var years = employees.Where(person => person.YearsOfExperience <= 10 && person.Age > 35);

            var sumYOE = years.Sum(employee => employee.YearsOfExperience);
            var avgYOE = years.Average(employee => employee.YearsOfExperience);

            Console.WriteLine($"Sum: {sumYOE}");
            Console.WriteLine($"Average: {avgYOE}");


            //TODO: Add an employee to the end of the list without using employees.Add() - DONE

            employees = employees.Append(new Employee("Bald", "Balthazar", 18, 2)).ToList();

            foreach (var person in employees)
            {
                Console.WriteLine($"First name: {person.FirstName}, Last name: {person.LastName}, Age: {person.Age}, Years of Experience:{person.YearsOfExperience}");
            }

            Console.WriteLine();

            Console.ReadLine();
        }

        #region CreateEmployeesMethod
        private static List<Employee> CreateEmployees()
        {
            List<Employee> employees = new List<Employee>();
            employees.Add(new Employee("Cruz", "Sanchez", 25, 10));
            employees.Add(new Employee("Steven", "Bustamento", 56, 5));
            employees.Add(new Employee("Micheal", "Doyle", 36, 8));
            employees.Add(new Employee("Daniel", "Walsh", 72, 22));
            employees.Add(new Employee("Jill", "Valentine", 32, 43));
            employees.Add(new Employee("Yusuke", "Urameshi", 14, 1));
            employees.Add(new Employee("Big", "Boss", 23, 14));
            employees.Add(new Employee("Solid", "Snake", 18, 3));
            employees.Add(new Employee("Chris", "Redfield", 44, 7));
            employees.Add(new Employee("Faye", "Valentine", 32, 10));

            return employees;
        }
        #endregion
    }
}
