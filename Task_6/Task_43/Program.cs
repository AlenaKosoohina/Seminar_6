Console.Write("k1: ");
Double k1 = Convert.ToDouble(Console.ReadLine());
Console.Write("b1: ");
Double b1 = Convert.ToDouble(Console.ReadLine());
Console.Write("k2: ");
Double k2 = Convert.ToDouble(Console.ReadLine());
Console.Write("b2: ");
Double b2 = Convert.ToDouble(Console.ReadLine());
Double x = Math.Round((-(b1 - b2) / (k1 - k2)),3);
Double y = Math.Round((k1 * x + b1),3);
Console.WriteLine($"Пересечеybt: ({x};{y})");