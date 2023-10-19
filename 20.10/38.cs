////38.1
//int summa = 0;
//while (true)
//{
//    Console.WriteLine("Введите очередное число последовательности a=");
//    int a = int.Parse(Console.ReadLine());
//    if (a >= 0)
//        summa += a;
//    Console.WriteLine("Продолжить ввод? Y/N");
//    if (Console.ReadLine() == "N")
//        break;
//}
//Console.WriteLine($"Сумма чисел summa= {summa}");

////38.4
//Console.WriteLine("Введите число");
//int N = int.Parse(Console.ReadLine());
//Console.WriteLine("Введите число послдедовательности, каждое нове числло с enter,а");
//int P = int.Parse(Console.ReadLine());
//int k = 0;
//for (int i = 0; i < P; i++)
//{
//    int a = int.Parse(Console.ReadLine());  
//    if (a == N)
//    {
//        k++;
//    }
//}
//Console.WriteLine($"Колличество числа {N} повторяется {k} раз(а)");

////38.6
//Console.WriteLine("Введите значение больше 0");
//int summa = int.Parse(Console.ReadLine());
//while (true)
//{
//    Console.WriteLine("Введите очередное число последовательности a=");
//    int x = int.Parse(Console.ReadLine());
//    if (x >= 0)
//        summa = x;
//    Console.WriteLine("Продолжить ввод? Y/N");
//    if (Console.ReadLine() == "N")
//        break;
//}
//Console.WriteLine($"Произведение чисел summa= {summa}");

////38.7

//Console.WriteLine("колво чисел в последовательности");
//int P = int.Parse(Console.ReadLine());
//int summa = 0;
//Console.WriteLine("Введиет последовательность");
//for (int i = 0; i < P; i++)
//{
//Console.Write($"Введите число {i}: ");
//   int a = int.Parse(Console.ReadLine());
//    summa += Math.Abs(a);
//}
//Console.WriteLine($"summa = {summa}");

////38.9
//double summa = 0;
//while (true)
//{
//    Console.WriteLine("Введите очередное число последовательности a=");
//    double c = int.Parse(Console.ReadLine());
//    if (c >= 0)
//        summa += Math.Pow(c, 2);
//    Console.WriteLine("Продолжить ввод? Y/N");
//    if (Console.ReadLine() == "N")
//        break;
//}
//Console.WriteLine($"Сумма квадратов последовательности равна = {summa}");

////38.10
//Console.Write("Введите количество чисел в последовательности: ");
//int n = int.Parse(Console.ReadLine());
//double sum = 0; 
//double SR; 
//for (int i = 1; i <= n; i++)
//{
//    Console.Write($"Введите число {i}: ");
//    double number = double.Parse(Console.ReadLine());

//    sum += number;
//}
//    SR = sum / n;
//    Console.WriteLine($"Среднее арифметическое: {SR}");
////38.12
//Console.Write("Введите количество чисел в последовательности: ");
//int n = int.Parse(Console.ReadLine());
//double qwe = 1; 
//for (int i = 1; i <= n; i++)
//{
//    Console.Write($"Введите число {i}: ");
//    double number = double.Parse(Console.ReadLine());
//    double zxc = Math.Abs(number);
//    qwe *= zxc;
//}
//Console.WriteLine($"Произведение модулей элементов последовательности: {qwe}");
