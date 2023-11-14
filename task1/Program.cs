// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3
int inputM()
{
    bool isNumber = false;
    Console.WriteLine($"Введите количество чисел для ввода: ");
    int finalNumber=0;
    while (isNumber == false)
        {
        string input = Console.ReadLine();
        isNumber = int.TryParse(input, out finalNumber);
        if (isNumber==false)
        Console.WriteLine($"Неверный формат, введите натуральное число");
        }
    return finalNumber;
}
double inputnumber(int index)
{
    bool isNumber = false;
    Console.WriteLine($"Введите число №{index}: ");
    double finalNumber=0;
    while (isNumber == false)
        {
        string input = Console.ReadLine();
        isNumber = double.TryParse(input, out finalNumber);
        if (isNumber==false)
        Console.WriteLine($"Неверный формат, введите число №{index}");
        }
    return finalNumber;
}
void printarray(int M, int count, double[] numbers)
{
    Console.WriteLine($"Вы ввели {M} следующих чисел:");
    Console.WriteLine($"{String.Join("; ", numbers)}");
    Console.WriteLine($"Количество чисел больше нуля: {count}");
}
int M = inputM();
double[] array = new double[M];
int count = 0;
for (int i = 0; i < M; i++)
{
    array[i] = inputnumber(i+1);
    if (array [i]>0) count = count + 1;
}
printarray(M, count, array);