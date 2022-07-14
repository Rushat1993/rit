Console.Write("Введите трёхзначное число: ");

int Number = Convert.ToInt32(Console.ReadLine());
int digit1 = Number / 10;
int digit2 = digit1 % 10;
Console.WriteLine($"Цифра {digit2}");