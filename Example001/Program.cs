// Задача № 1 

int Prompt(string message)
{
    System.Console.Write(message);
    string readVelue = Console.ReadLine();
    int result = int.Parse(readVelue);
    return result;
}
var value = Prompt("Введите число >");
var valueNew = Prompt("Введите второе число >");
if (value > valueNew)
{
    System.Console.WriteLine(value);
    System.Console.WriteLine(valueNew);
}
else
{
    System.Console.WriteLine(valueNew);
    System.Console.WriteLine(value);
};