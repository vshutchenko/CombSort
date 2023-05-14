using CombSort.Lib;

Console.WriteLine("Укажите путь к файлу:");
var filePath = Console.ReadLine();

if (!File.Exists(filePath))
{
    Console.WriteLine("Файл не найден!");
    return;
}

try
{
    var numbers = File.ReadAllLines(filePath).Select(int.Parse);

    var sortedNumbers = numbers.CombSort();

    Console.WriteLine("Введите путь для сохранения отсортированного файла:");
    var savePath = Console.ReadLine();

    File.WriteAllLines(savePath, sortedNumbers.Select(n => n.ToString()));

    Console.WriteLine("Файл отсортирован и сохранен!");
}
catch (Exception ex)
{
    Console.WriteLine($"Возникла ошибка при работе с файлом: {ex.Message}");
}

Console.ReadLine();