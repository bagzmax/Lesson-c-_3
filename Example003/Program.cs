//Расстояние между двумя точками А и В

void printGipotenuza(double ax, double ay, double bx, double by)
{
    double deltaX = ax - bx;
    double deltaY = ay - by;
    double c = Math.Sqrt(deltaX * deltaX + deltaY * deltaY); // Math - модуль вычисления функции sqrt
    System.Console.WriteLine(c);
}
printGipotenuza(7,-5,1,-1);

