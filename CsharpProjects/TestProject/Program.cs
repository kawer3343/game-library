using System;
using System.IO;
using System.Numerics;


string filePath = "GameLibrary.txt";

if (File.Exists(filePath))
{   
    Console.WriteLine("Сколько игр хотите добавить?: ");
    int countGame = int.Parse(Console.ReadLine());
    for (int quantity = 1; quantity <= countGame; quantity++){
        Console.Write("Введите жанр игры: ");
        string genre = Console.ReadLine();
        Console.Write("Введите название игры: ");
        string name = Console.ReadLine();
        Console.Write("Введите разработчика игры: ");
        string dev = Console.ReadLine();
        string game = $"Жанр: {genre}, название игры: {name}, разработчик: {dev}";
        File.AppendAllText(filePath, game + "\n");
        string content = File.ReadAllText(filePath);
        Console.WriteLine(content);
    }
}
else
{
    Console.WriteLine("Файл не найден.");
}