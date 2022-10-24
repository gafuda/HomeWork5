
// Console.WriteLine("Введите число: ");
// double b1 = double.Parse(Console.ReadLine() ?? "0");
// Console.WriteLine("Введите число: ");
// double k1 = double.Parse(Console.ReadLine() ?? "0");
// Console.WriteLine("Введите число: ");
// double b2 = double.Parse(Console.ReadLine() ?? "0");
// Console.WriteLine("Введите число: ");
// double k2 = double.Parse(Console.ReadLine() ?? "0");

// double x = (b1 - b2) / (k2 - k1);
// double y = k2 * x + b2;


// if (k1 == k2 && b1 == b2)   
// {
//      Console.WriteLine ("Прямые совпадают");
// }
// else if (k1 == k2)
// {
//     Console.WriteLine("Прямые параллельны");
// }
// else
// {
//     Console.Write($" Координаты точки пересечения прямых ({x}; {y})");
// }



// Console.WriteLine("Введите координаты: ");

// float x1 = float.Parse(Console.ReadLine() ?? "0");

// Console.WriteLine("Введите координаты a: ");
// float x2 = float.Parse(Console.ReadLine() ?? "0");
// Console.WriteLine("Введите координаты b: ");
// float y1 = float.Parse(Console.ReadLine() ?? "0");
// Console.WriteLine("Введите координаты c: ");
// float y2 = float.Parse(Console.ReadLine() ?? "0");
// Console.WriteLine("Масштабировать фигуру? : ");
// float k = float.Parse(Console.ReadLine() ?? "0");

// float[] array = {x1, x2, y1, y2};
// Console.WriteLine($"Фигура была увеличенна в {k} раз(а), новые координаты фигуры: ");
// for (int i = 0; i < array.Length; i++)
// {
//     array[i] *= k;
//     Console.Write($"({array[i]}), ");
// }



// void FillArray (int[] array, int min, int max)
// {
//     Random random = new Random();
//     {
//         for (int i = 0; i < array.Length; i++)
//         {
//             array[i] = random.Next(min, max);
//         }
//     }
// }
// void PrintArray(int[] array)
// {
//     for (int i = 0; i < array.Length; i++)
//     {
//         Console.Write($"{array[i]} ");
//     }
// }
// void CopyArray(int[] array)
// {
//     for (int i = 0; i < array.Length; i++)
//     {
//         array[i] = array[i];
//     }
// }
// Console.WriteLine("ВВедите минимальное значение массива: ");
// int min = int.Parse(Console.ReadLine() ?? "0");

// Console.WriteLine("ВВедите максимальное значение массива: ");
// int max = int.Parse(Console.ReadLine() ?? "0");

// Console.WriteLine("ВВедите длинну массива: ");
// int longg = int.Parse(Console.ReadLine() ?? "0");

// int[] array = new int [longg];
// Console.WriteLine();
// FillArray(array, min,max);
// Console.Write("Ваш массив: ");
// PrintArray(array);
// Console.WriteLine();
// CopyArray(array);
// Console.Write("Копия вашего массива: ");
// PrintArray(array);