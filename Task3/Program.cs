﻿//Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
//4 -> да
//-3 -> нет
//7 -> нет

Console.Clear();
Console.Write("ВВедите число: ");
int var = int.Parse(Console.ReadLine());
if(var % 2 == 0) {Console.WriteLine($"Да число {var} является четным");}
else {Console.WriteLine($"Число {var} не является четным");}