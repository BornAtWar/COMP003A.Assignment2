using System.ComponentModel.Design;

namespace COMP003A.Assignment2
{  //Author: Demetrius Richards
   //Course: COMP-003A-L01
   //Purpose: Assignment for class
    internal class Program
    {
        static void Main(string[] args)
        {   Console.ForegroundColor = ConsoleColor.White;
            Console.BackgroundColor = ConsoleColor.DarkBlue;

            Console.WriteLine("***************************************************");
            Console.WriteLine("Console Section");
            Console.WriteLine("***************************************************");


            Console.WriteLine("***************************************************");
            Console.WriteLine("String Section");
            Console.WriteLine("***************************************************");
            Console.WriteLine("Enter First Name");
            string firstName = Console.ReadLine();
            Console.WriteLine("Enter Middle Name");
            string middleName = Console.ReadLine();            
            Console.WriteLine("Enter Last Name");
            string lastName = Console.ReadLine();
            Console.WriteLine("Enter Age in 2023");
            string inputAge = Console.ReadLine();
            int yearBorn = 2023 - Convert.ToInt32(inputAge);
            Console.WriteLine($"Hello, {firstName} {middleName} {lastName}. You were born in {yearBorn}.");


            Console.WriteLine("**************************************************");
            Console.WriteLine("Math Section");
            Console.WriteLine("**************************************************");
            Console.WriteLine("Enter an Integer for Integer1");
            if (int.TryParse(Console.ReadLine(), out int integer1)) ;
            Console.WriteLine("Enter an Integer for Integer2");
            if (int.TryParse(Console.ReadLine(), out int integer2)) ;
            Console.WriteLine($"{integer1} + {integer2} = {integer1 + integer2}");
            Console.WriteLine($"{integer1} - {integer2} = {integer1 - integer2}");
            Console.WriteLine($"{integer1} * {integer2} = {integer1 * integer2}");
            Console.WriteLine($"{integer1} / {integer2} = {integer1 / integer2}");
            Console.WriteLine($"{integer1} % {integer2} = {integer1 % integer2}");

            Console.WriteLine("**************************************************");
            Console.WriteLine("Circle Area & Circumference Calculator Section");
            Console.WriteLine("**************************************************");
            Console.WriteLine("Enter Radius:");
            if (double.TryParse(Console.ReadLine(), out double radius))            
            Console.WriteLine($"The area of the circle with {radius} is:");
            double area = Math.PI * Math.Pow(radius, 2);
            Console.WriteLine("The Circumference is:");
            double circumference = 2 * Math.PI * radius;











        } 
    }
}
