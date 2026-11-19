print("c - Celsjusz na Fahrenheit")
print("f - Fahrenheit na Celsjusz")

wybor = input("Wybierz opcje: ")
temp = float(input("Podaj temperature: "))

if wybor == "c":
    print("Wynik:", temp * 1.8 + 32, "F")
elif wybor == "f":
    print("Wynik:", (temp - 32) / 1.8, "C")
else:
    print("Bledny wybor")