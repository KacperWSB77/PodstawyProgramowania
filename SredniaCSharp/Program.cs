Console.Write("Ile masz ocen? ");
int liczba = int.Parse(Console.ReadLine());

double suma = 0;

for (int i = 0; i < liczba; i++)
{
    Console.Write("Podaj ocene: ");
    suma += double.Parse(Console.ReadLine());
}

double srednia = suma / liczba;

Console.WriteLine("Srednia: " + srednia);

if (srednia >= 3)
    Console.WriteLine("Uczen zdal");
else
    Console.WriteLine("Uczen nie zdal");