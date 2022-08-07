// Задача № 3 На вход принимает число и вадает, является ли это число чётным

int Prompt(string message)
{
    System.Console.Write(message);
    string readVelue = Console.ReadLine();
    int result = int.Parse(readVelue);
    return result;
}

int i;
i = Prompt("Введите число > ");
if (i % 2 == 0) 
{
    System.Console.WriteLine("Yes");
}
else 
{
    System.Console.WriteLine("No");
}
