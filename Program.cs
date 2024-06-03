using System;

Console.WriteLine("Welcome to the Universal Calculator app!!!");
Console.WriteLine("===================================");
Console.WriteLine("1 -> is a program for calculating the surface of a Circle:");
Console.WriteLine("2 -> is a program for calculating the volume of a Cylinder:");
Console.WriteLine("3 -> is a Simple Calculator program:");
Console.WriteLine("===================================");
Console.Write("Choose one of the numbers: ");

try
{

    int select = Convert.ToInt16(Console.ReadLine());

    while (select == 1 || select == 2 || select == 3)
    {
        if (select == 1)
        {
            Console.WriteLine("Welcome to the Circle Area Calculator.");
            Console.Write("Enter the radius of the circle: ");
            int radius = Convert.ToInt32(Console.ReadLine());
            const double PI = 3.14;

            Console.WriteLine($"Circle surface: {PI * Math.Pow(radius, 2)}");
        }
        else if (select == 2)
        {
            Console.WriteLine("Welcome to the Cylinder volume calculator.");
            Console.Write("Enter the radius of the cylinder: ");
            int radius = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the height of the cylinder: ");
            int height = Convert.ToInt32(Console.ReadLine());
            const double PI = 3.14;

            Console.WriteLine($"Cylinder volume: {PI * Math.Pow(radius, 2) * height}");
        }
        else if (select == 3)
        {
            Console.WriteLine("Welcome to Simple Calculator");
            Console.WriteLine("Enter the number and operation in the form (2 + 2 or 2+2)");
            string inputNumAndOperation = Console.ReadLine();
            string[] separators = { " ", "+", "-", "*", "/" };
            string[] parts = inputNumAndOperation.Split(separators, StringSplitOptions.RemoveEmptyEntries);


            int firstNumber = Convert.ToInt32(parts[0]);
            int secondNumber = Convert.ToInt32(parts[1]);

            foreach (var operationChar in inputNumAndOperation)
            {
                if (operationChar == '-')
                {
                    Console.WriteLine($"Result:{firstNumber} - {secondNumber} = {firstNumber - secondNumber}");
                }
                else if (operationChar == '+')
                {
                    Console.WriteLine($"Result:{firstNumber} + {secondNumber} = {firstNumber + secondNumber}");
                }
                else if (operationChar == '*')
                {
                    Console.WriteLine($"Result:{firstNumber} * {secondNumber} = {firstNumber * secondNumber}");
                }
                else if (operationChar == '/')
                {
                    if (secondNumber != 0)
                    {
                        Console.WriteLine($"Result:{firstNumber} / {secondNumber} = {firstNumber / secondNumber}");
                    }
                    else
                    {
                        Console.WriteLine("Cannot be divided by ZERO!!!!");
                    }
                }
            }

        }

        Console.WriteLine("===================================");
        Console.WriteLine("1 -> is a program for calculating the surface of a Circle:");
        Console.WriteLine("2 -> is a program for calculating the volume of a Cylinder:");
        Console.WriteLine("3 -> is a Simple Calculator program:");
        Console.WriteLine("===================================");
        Console.WriteLine("To reuse the program, select one of the above\nPress the optional key to exit the program.");
        select = Convert.ToInt32(Console.ReadLine());
    }

}
catch (Exception)
{

    Console.WriteLine("Please enter only number and action!!!");
}

Console.WriteLine("Thank you for using the program");

