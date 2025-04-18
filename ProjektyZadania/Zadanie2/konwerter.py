kierunek = input("Wybierz kierunek konwersji C lub F ").upper()
temp = float(input("Podaj temperaturę: "))
if kierunek == "C":
    wynik = temp * 1.8 + 32
    print(f"{temp}°C = {wynik}°F")
elif kierunek == "F":
    wynik = (temp - 32) / 1.8
    print(f"{temp}°F = {wynik:.2f}°C")
else:
    print("Nieznany kierunek konwersji")
