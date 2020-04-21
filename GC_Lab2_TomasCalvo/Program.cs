using System;

namespace GC_Lab2_TomasCalvo
{
    class Program
    {
        static void Main(string[] args)
        {
			Console.WriteLine("Welcome to Room Calculator.");
            //Loop begins
            int roomNumber = 1;
            bool loop = true;
            while (loop == true)
            {
                //Input
                Console.WriteLine($"Enter Room {roomNumber} length:");
                string lengthInput = Console.ReadLine();

                Console.WriteLine($"Enter Room {roomNumber} width:");
                string widthInput = Console.ReadLine();

                Console.WriteLine($"Enter Room {roomNumber} ceiling height:");
                string heightInput = Console.ReadLine();

                //Processing
                double length = double.Parse(lengthInput);
                double width = double.Parse(widthInput);
                double height = double.Parse(heightInput);

                double area = width * length;
                double perimeter = 2*(width + length);
                double volume = width * length * height;

                //Output
                Console.WriteLine($"The area of Room {roomNumber} is {area} square units.");
                Console.WriteLine($"The perimeter of Room {roomNumber} is {perimeter} units.");
                Console.WriteLine($"The volume of Room {roomNumber} is {volume} cubic units.");

                //Loop ends
                Console.WriteLine("Would you like to calculate another room?");
                var response = Console.ReadLine();
                if (response == "y" || response == "yes")
                {
                    loop = true;
                    roomNumber++;
                }
                else
                {
                    loop = false;
                    Console.WriteLine("Thank you for using Room Calculator.");
                }
            }
        }
    }
}
