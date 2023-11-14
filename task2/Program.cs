// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями
// y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)
double inputnumber(string text, string equation)
{
    bool isNumber = false;
    Console.WriteLine($"Введите переменную {text} для уравнения {equation}: ");
    double finalNumber=0;
    while (isNumber == false)
        {
        string input = Console.ReadLine();
        isNumber = double.TryParse(input, out finalNumber);
        if (isNumber==false)
        Console.WriteLine($"Неверный формат, введите переменную {text} для уравнения {equation}: ");
        }
    return finalNumber;
}
double [] coord(double k1, double b1, double k2, double b2)
{
    double[] array = new double[2];
    array[0] = (b2-b1)/(k1-k2);
    array[1] = k1*array[0]+b1;
    return array;
}
void printarray(double[] coord)
{
    Console.WriteLine($"Координата точки пересечения двух прямых:");
    Console.WriteLine($"({String.Join("; ", coord)})");
}
double k1 = inputnumber("k1","y = k1*x + b1");
double b1 = inputnumber("b1","y = k1*x + b1");
double k2 = inputnumber("k2","y = k2*x + b2");
double b2 = inputnumber("b2","y = k2*x + b2");
if (k1-k2==0) Console.WriteLine("Прямые не пересекаются, нет точки пересечения прямых");
else
{
    double[] coord1 = coord(k1, b1, k2, b2);
    printarray(coord1); 
}