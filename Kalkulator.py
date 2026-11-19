x = float(input("Pierwsza liczba: "))
y = float(input("Druga liczba: "))
znak = input("Dzialanie (+, -, *, /): ")

if znak == "+":
    print("Wynik:", x + y)
elif znak == "-":
    print("Wynik:", x - y)
elif znak == "*":
    print("Wynik:", x * y)
elif znak == "/" and y != 0:
    print("Wynik:", x / y)
else:
    print("Blad")
