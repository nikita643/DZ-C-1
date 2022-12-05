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