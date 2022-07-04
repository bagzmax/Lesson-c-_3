
void printRangeXY(float x)
{
    if (x == 1) 
    {
        System.Console.WriteLine("Плоскость 1 :X > 0 Y > 0");
    }
    else if (x == 2)
    {
        System.Console.WriteLine("плоскость 2: X < 0 Y > 0");
    }
    else if (x == 3)
    {
        System.Console.WriteLine("Плоскость 3: X < 0 Y < 0");
    }
    else if (x == 4)
    {
        System.Console.WriteLine("Плоскость 4: X > 0 Y < 0");
    }
}
printRangeXY(2);




