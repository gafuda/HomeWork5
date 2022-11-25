
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


// double[] massiv_coordinat_s_mashtabom(string[] num, double k)
// {
//     double[] mas = new double[num.Length];
//     for (int ind = 0; ind < num.Length; ind++)
//     {
//         mas[ind] = (double.Parse(num[ind])) * k;
//     }
//     return mas;
// }

// void Pechat_Massiva(double[] massiv)
// {
//     for (int i = 0; i < massiv.Length; i+=2)
//     {
//         Console.Write($"({massiv[i]}, {massiv[i+1]})  ");
//     }
// }

// Console.Write("Введите координаты точек фигуры через запятую ',': ");
// string[] num = (Console.ReadLine() ?? "0").Split(',');
// Console.Write("Введите коэфициент масштабирования: ");
// double k = double.Parse(Console.ReadLine() ?? "0");
// double[] mash_koor = massiv_coordinat_s_mashtabom(num, k);
// Pechat_Massiva(mash_koor);


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
