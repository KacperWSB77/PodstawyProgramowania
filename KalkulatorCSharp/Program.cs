Console.Write("Pierwsza liczba: ");
double x = double.Parse(Console.ReadLine());

Console.Write("Druga liczba: ");
double y = double.Parse(Console.ReadLine());

Console.Write("Dzialanie (+, -, *, /): ");
string dzialanie = Console.ReadLine();

if (dzialanie == "+")
    Console.WriteLine("Wynik: " + (x + y));
else if (dzialanie == "-")
    Console.WriteLine("Wynik: " + (x - y));
else if (dzialanie == "*")
    Console.WriteLine("Wynik: " + (x * y));
else if (dzialanie == "/" && y != 0)
    Console.WriteLine("Wynik: " + (x / y));
else
    Console.WriteLine("Blad");
