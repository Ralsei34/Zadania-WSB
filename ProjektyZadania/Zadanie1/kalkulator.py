a = float(input("Podaj pierwszą liczbę: "))
b = float(input("Podaj drugą liczbę: "))
operator = input("Wybierz operację (+, -, *, /): ")

if operator == "+":
    wynik = a + b
elif operator == "-":
    wynik = a - b
elif operator == "*":
    wynik = a * b
elif operator == "/":
    if b != 0:
        wynik = a / b
    else:
        wynik = "Błąd,dzielenie przez zero"
else:
    wynik = "Nieznana operacja"

print("Wynik:", wynik)
