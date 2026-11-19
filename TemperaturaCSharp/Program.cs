Console.WriteLine("c - Celsjusz na Fahrenheit");
Console.WriteLine("f - Fahrenheit na Celsjusz");
string wybor = Console.ReadLine();

Console.Write("Podaj temperature: ");
double temp = double.Parse(Console.ReadLine());

if (wybor == "c")
    Console.WriteLine("Wynik: " + (temp * 1.8 + 32) + " F");
else if (wybor == "f")
    Console.WriteLine("Wynik: " + ((temp - 32) / 1.8) + " C");
else
    Console.WriteLine("Bledny wybor");