class ValidTriangle
{
    static void Main()
    {
        int side1, side2, side3;

        
        side1 = int.Parse(Console.ReadLine());
        side2 = int.Parse(Console.ReadLine());
        side3 = int.Parse(Console.ReadLine());

        if (IsTriangleValid(side1, side2, side3))
        {
            Console.WriteLine("Valid Triangle");
        }
        else
        {
            Console.WriteLine("Invalid Triangle");
        }
    }

    static bool IsTriangleValid(int side1, int side2, int side3)
    {
        return (side1 + side2 > side3) && (side1 + side3 > side2) && (side2 + side3 > side1);
    }
}
    