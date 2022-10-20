Console.WriteLine("Введите координаты: ");

float x1 = float.Parse(Console.ReadLine() ?? "0");




Console.WriteLine("Введите координаты a: ");
float x2 = float.Parse(Console.ReadLine() ?? "0");
Console.WriteLine("Введите координаты b: ");
float y1 = float.Parse(Console.ReadLine() ?? "0");
Console.WriteLine("Введите координаты c: ");
float y2 = float.Parse(Console.ReadLine() ?? "0");
Console.WriteLine("Масштабировать фигуру? : ");
float k = float.Parse(Console.ReadLine() ?? "0");

float[] array = {x1, x2, y1, y2};
Console.WriteLine($"Фигура была увеличенна в {k} раз(а), новые координаты фигуры: ");
for (int i = 0; i < array.Length; i++)
{
    array[i] *= k;
    Console.Write($"({array[i]}), ");
}