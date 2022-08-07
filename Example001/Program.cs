// Задача № 1 Принимает 2 числа и выводит сначала большее, а потом меньшее

int Prompt(string message)
{
    System.Console.Write(message);
    string readVelue = Console.ReadLine();
    int result = int.Parse(readVelue);
    return result;
}
int value = Prompt("Введите первое число ->");
int valueNew = Prompt("Введите второе число ->");
if (value > valueNew)
{
    Console.WriteLine("max = " + value + " min = " + valueNew);
}
else
{
    Console.WriteLine("max = " + valueNew + " min = " + value);
};