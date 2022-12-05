//Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
//2, 3, 7 -> 7
//44 5 78 -> 78
//22 3 9 -> 22

Console.Clear();
int [] number = new int [3];
string [] title = {"первое", "второе", "третье"};
int count = 0;
while (count < number.Length)
{
    Console.Write( $"Введите {title[count]} число: " );
    number[count] = int.Parse(Console.ReadLine());
    count++;
}
int max = number[0];
count = 0;
while (count < number.Length)
{
if(max < number[count]){ max = number[count]; }
count++;
}
Console.WriteLine($"Максимальное число равно {max}");