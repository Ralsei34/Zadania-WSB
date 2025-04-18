n = int(input("Ile ocen chcesz podać? "))
suma = 0

for i in range(n):
    ocena = float(input(f"Podaj ocenę {i+1}: "))
    suma += ocena

srednia = suma / n
print(f"Średnia: {srednia:.2f}")

if srednia >= 3.0:
    print("Uczeń zdał.")
else:
    print("Uczeń nie zdał.")
