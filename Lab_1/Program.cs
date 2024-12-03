using System;

class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter case no :");
        int n = int.Parse(Console.ReadLine());

        switch (n)
        {
            case 1:
                Console.WriteLine("Enter Name:");
                String name = Console.ReadLine();

                Console.WriteLine("Enter Address:");
                String address = Console.ReadLine();

                Console.WriteLine("Enter Contact no:");
                int contact = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Enter City:");
                String city = Console.ReadLine();

                Console.WriteLine($"Name:{name}\n Address:{address} \n Contact:{contact} \n City:{city}");
                break;

            case 2:

                Console.WriteLine("Enter no1:");
                int no1 = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Enter no2:");
                int no2 = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine($"First no is : {no1} \n Second no is : {no2}");
                break ;

             
            case 3:
                Console.WriteLine("Enter your Name:");
                String name1 = Console.ReadLine();

                Console.WriteLine("Enter your city:");
                String city1 = Console.ReadLine();

                Console.WriteLine($"Hello {name1} from country {city1}");
                break;

            case 4:
                Console.WriteLine("Enter Length:");
                int length = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Enter Width:");
                int width = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine($"Area:{length * width}");
                break;

           
            case 5:
                Console.WriteLine("Enter Length:");
                int length5 = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Enter Width:");
                int width5 = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Enter Radius:");
                int radius = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine($"Area of Suare:{length5 * length5} \n Area of Rectangle:{length5 * width5}\n");
                break;


            case 6:
                Console.WriteLine("Temperature Converter");
                Console.WriteLine("1. Fahrenheit to Celsius");
                Console.WriteLine("2. Celsius to Fahrenheit");
                Console.Write("Choose an option (1 or 2): ");
                int choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        Console.Write("Enter temperature in Fahrenheit: ");
                        double fahrenheit = double.Parse(Console.ReadLine());
                        double celsiusResult = (fahrenheit - 32) * 5 / 9;
                        Console.WriteLine($"Temperature in Celsius: {celsiusResult:F2}");
                        break;

                    case 2:
                        Console.Write("Enter temperature in Celsius: ");
                        double celsius = double.Parse(Console.ReadLine());
                        double fahrenheitResult = (celsius * 9 / 5) + 32;
                        Console.WriteLine($"Temperature in Fahrenheit: {fahrenheitResult:F2}");
                        break;

                    default:
                        Console.WriteLine("Invalid choice! Please select 1 or 2.");
                        break;
                }
                break;

            case 7:
                Console.WriteLine("Enter p:");
                int p = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter r:");
                int r = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter n:");
                int n7 = Convert.ToInt32(Console.ReadLine());
                float si = (p + r + n7) / 100;
                Console.WriteLine("Simple interest is:{si}");
                break;

            case 8:
                double num1, num2, result;
                string operation;

               
                Console.Write("Enter the first number: ");
                num1 = Convert.ToDouble(Console.ReadLine());

                Console.Write("Enter the second number: ");
                num2 = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Choose an operation (+ for Addition, - for Subtraction, * for Multiplication, / for Division): ");
                operation = Console.ReadLine();

                
                switch (operation)
                {
                    case "+":
                        result = num1 + num2;
                        Console.WriteLine($"Result: {num1} + {num2} = {result}");
                        break;
                    case "-":
                        result = num1 - num2;
                        Console.WriteLine($"Result: {num1} - {num2} = {result}");
                        break;
                    case "*":
                        result = num1 * num2;
                        Console.WriteLine($"Result: {num1} * {num2} = {result}");
                        break;
                    case "/":
                        if (num2 != 0)
                        {
                            result = num1 / num2;
                            Console.WriteLine($"Result: {num1} / {num2} = {result}");
                        }
                        else
                        {
                            Console.WriteLine("Error: Division by zero is not allowed.");
                        }
                        break;
                    default:
                        Console.WriteLine("Error: Invalid operation. Please choose +, -, *, or /.");
                        break;
                
                }
                break;

            case 9:
                Console.Write("Enter the first number: ");
                int num8 = int.Parse(Console.ReadLine());

                Console.Write("Enter the second number: ");
                int num9 = int.Parse(Console.ReadLine());

                Console.WriteLine($"\nBefore swapping: num1 = {num8}, num2 = {num9}");

                num1 = num8 + num9;
                num2 = num8 - num9;
                num1 = num8 - num9;

                Console.WriteLine($"After swapping: num1 = {num1}, num2 = {num2}");
               
                break;

            case 10:
                Console.WriteLine("Enter A First Number :");
                int no11 = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Enter A Second Number :");
                int no22 = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Enter A Third Number :");
                int no3 = Convert.ToInt32(Console.ReadLine());

                int max = (no11 > no22) ? (no11 > no3 ? no1 : no3) : (no2 > no3 ? no2 : no3);

                Console.WriteLine($"Maximum Number Is : {max}");
                break;

        }

    }
}