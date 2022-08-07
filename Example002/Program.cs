// Задача № 2. Принимает на вход 3 числа и выдает максимальное из этих чисел

int Prompt(string message)
{
    System.Console.Write(message);
    string readVelue = Console.ReadLine();
    int result = int.Parse(readVelue);
    return result;
}
int value_1 = Prompt("Введите первое число ->");
int value_2 = Prompt("Введите второе число ->");
int value_3 = Prompt("Введите третье число ->");

int max = value_1;

if (value_2 > max)
{
    max = value_2;
}
if (value_3 > max)
{
    max = value_3;
}
Console.WriteLine("Наибольшее из введённых чисел -> " + max);