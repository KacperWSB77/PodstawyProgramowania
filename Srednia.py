liczba = int(input("Ile masz ocen? "))
suma = 0

for i in range(liczba):
    ocena = float(input("Podaj ocene: "))
    suma = suma + ocena

srednia = suma / liczba
print("Srednia:", srednia)

if srednia >= 3:
    print("Uczen zdal")
else:
    print("Uczen nie zdal")
