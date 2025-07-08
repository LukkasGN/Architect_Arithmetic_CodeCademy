using System;

class ArchitectArithmetic
{
    static void Main(string[] args)
    {
        Console.WriteLine("The total cost for the Pantheon: ₤" + CalculateTotalCost());
    }

    // Method to calculate area of a circle: π * r²
    static double Circle(double radius)
    {
        return Math.PI * radius * radius;
    }

    // Method to calculate area of a rectangle: length * width
    static double Rect(double length, double width)
    {
        return length * width;
    }

    // Method to calculate area of a triangle: (base * height) / 2
    static double Triangle(double bottom, double height)
    {
        return (bottom * height) / 2;
    }

    // Method to calculate total area and cost
    static double CalculateTotalCost()
    {
        // Pantheon: circle radius = 21.5, rectangle = 15 x 18
        double circleArea = Circle(21.5);
        double rectArea = Rect(15, 18);
        double totalArea = circleArea + rectArea;

        double tileCost = 100; // cost per square meter
        return Math.Round(totalArea * tileCost, 2); // round to 2 decimal places
    }
}
