
// Квадрат чисел от 1 до N

Console.WriteLine ("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());
int i = 1;

while (Math.Abs(num) - i >=0)  //проверка на отрицательное вводимое число
 {
     Console.Write ($"{i*i},");
     i ++;
 }
 Console.Write("\b \b"); // удаляет последний символ

//for (int i = 1; i <= Math.Sqrt(num); i++) Console.Write($"{i*i} ");

