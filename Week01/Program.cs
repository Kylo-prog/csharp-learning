using System;
using System.Text;

// Настройка кодировки для корректного ввода и вывода кириллицы
Console.InputEncoding = Encoding.UTF8;
Console.OutputEncoding = Encoding.UTF8;

Console.Write("Как тебя зовут? ");
var name = Console.ReadLine();

Console.WriteLine($"Привет, {name}!");
Console.WriteLine("\nИнформация о тебе:");

Console.Write("Имя: ");
var nameTrue = Console.ReadLine();
Console.Write("Город: ");
var city = Console.ReadLine();
Console.Write("Возраст: ");
var age = Console.ReadLine();
Console.Write("Страна: ");
var country = Console.ReadLine();
Console.Write("Рост: ");
var height = Console.ReadLine();
Console.Write("Телефон: ");
var phoneNumber = Console.ReadLine();

Console.WriteLine("\n----ВИЗИТКА----");
Console.WriteLine($"Имя: {nameTrue}");
Console.WriteLine($"Город: {city}");
Console.WriteLine($"Возраст: {age}");
Console.WriteLine($"Страна: {country}");
Console.WriteLine($"Рост: {height}");
Console.WriteLine($"Телефон: {phoneNumber}");