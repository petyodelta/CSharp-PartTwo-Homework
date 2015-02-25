/*Write methods that calculate the surface of a triangle by given:
Side and an altitude to it;
Three sides;
Two sides and an angle between them;
Use System.Math.*/

using System;

class TriangleSurface
{
    static void Main()
    {
        Console.WriteLine("Calcualate surface of a triagle by:");
        Console.WriteLine("1->Side and an altitude to it");
        Console.WriteLine("2->Three sides");
        Console.WriteLine("3->Two sides and an angle between them");
        
        Console.Write("Enter 1,2 or 3: ");
        int choice = int.Parse(Console.ReadLine());
        
        double surface = 0;

        switch (choice)
        {
            case 1: surface = CalculateBySideAndAltitude(); break;
            case 2: surface = CalculateByThreeSides(); break;
            case 3: surface = CalculateByTwoSidesAndAngle(); break;
            
        }
        Console.WriteLine("Surface is {0:F2}", surface);
    }

    static double CalculateBySideAndAltitude()
    {
        Console.Write("Enter side lenght: ");
        double a = double.Parse(Console.ReadLine());

        Console.Write("Enter altitude lenght: ");
        double h = double.Parse(Console.ReadLine());

        double surface = (a * h) / 2;
        return surface;
    }

    static double CalculateByThreeSides()
    {
        Console.Write("Enter first side lenght: ");
        double a = double.Parse(Console.ReadLine());

        Console.Write("Enter second side lenght: ");
        double b = double.Parse(Console.ReadLine());

        Console.Write("Enter third side lenght: ");
        double c = double.Parse(Console.ReadLine());

        double s = (a + b + c) / 2;
        double surface = Math.Sqrt(s*(s - a)*(s - b)*(s - c));
        return surface;
    }

    static double CalculateByTwoSidesAndAngle()
    {
        Console.Write("Enter first side lenght: ");
        double a = double.Parse(Console.ReadLine());

        Console.Write("Enter second side lenght: ");
        double b = double.Parse(Console.ReadLine());

        Console.Write("Enter angle: ");
        double angle = double.Parse(Console.ReadLine());

        double surface = (a * b * Math.Sin(angle * 0.0174532925)) / 2;// angle should be in radians.
        return surface;
    }
}

