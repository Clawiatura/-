Console.Write("Введите число в ММ:");
int mm = int.Parse(Console.ReadLine());
const int sm = 10;
const int m = 100;
const int km = 1000;
const double milya = 1.609e+6;
const float yardu = 914.4f;
Console.WriteLine($"см:{mm/sm} метры:{mm/m} км:{mm/km} мили:{mm/milya:F2} ярды:{mm/yardu:F2}");

