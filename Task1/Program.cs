// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
//a = 5; b = 7 -> max = 7
//a = 2 b = 10 -> max = 10
//a = -9 b = -3 -> max = -3


Console.Clear();
int [] number = new int [2];
string [] title = {"первое", "второе"};
int count = 0;
while (count < number.Length){
    Console.Write($"Введите {title[count]} число: ");
    number[count] = int.Parse(Console.ReadLine());
    count++;
}
int max = number[0];
count = 0;
while(count < number.Length)
{
    if(max < number[count]){ max = number[count]; }
    count++;
}
Console.WriteLine($"Максимальное число равно: {max}");