// Задача № 4 На вход принимает число (N), а на выходе показывает все чётные числа от 1 до N
int Prompt(string message)
{
    System.Console.Write(message);
    string readVelue = Console.ReadLine();
    int result = int.Parse(readVelue);
    return result;
}

int N;

N = Prompt("Введите число > ");
for (int i = 1; i <= N; i++)
{
    if (i % 2 == 0)
    {
        Console.WriteLine(i);
    }
}