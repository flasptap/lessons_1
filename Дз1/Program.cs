//  Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3

Console.WriteLine("Введите 2 числа,");
Console.Write("Первое: ");
int numbers1 = int.Parse(Console.ReadLine());
Console.Write("Второе: ");
int numbers2 = int.Parse(Console.ReadLine());
if (numbers1 > numbers2)
{
    Console.WriteLine("Число " + numbers1 + " большее");
    Console.Write("Число " + numbers2 + " меньшее");
}
else if (numbers1 == numbers2)
{
    Console.WriteLine("Число " + numbers1 + " равно числу " + numbers2);
}
else
{
    Console.WriteLine("Число " + numbers2 + " большее");
    Console.Write("Число " + numbers1 + " меньшее");
}