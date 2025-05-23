class Board:
    def __init__(self):
        self.pola = [" "] * 9

    def wyswietl(self):
        print()
        for i in range(3):
            print(f"{self.pola[i * 3]}|{self.pola[i * 3 + 1]}|{self.pola[i * 3 + 2]}")
            if i < 2:
                print("-----")

    def wykonaj_ruch(self, pozycja, znak):
        if 0 <= pozycja <= 8 and self.pola[pozycja] == " ":
            self.pola[pozycja] = znak
            return True
        return False

    def sprawdz_zwyciezce(self, znak):
        wygrane = [
            [0, 1, 2], [3, 4, 5], [6, 7, 8],
            [0, 3, 6], [1, 4, 7], [2, 5, 8],
            [0, 4, 8], [2, 4, 6]
        ]
        for kombinacja in wygrane:
            if all(self.pola[i] == znak for i in kombinacja):
                return True
        return False

    def czy_pelna(self):
        return " " not in self.pola


class Player:
    def __init__(self, imie, znak):
        self.imie = imie
        self.znak = znak


class Game:
    def __init__(self):
        print("Witaj w grze Kółko i Krzyżyk!")
        imie1 = input("Podaj imię gracza 1 (X): ")
        imie2 = input("Podaj imię gracza 2 (O): ")
        self.player1 = Player(imie1, "X")
        self.player2 = Player(imie2, "O")
        self.board = Board()
        self.aktualny = self.player1

    def zmien_gracza(self):
        self.aktualny = self.player2 if self.aktualny == self.player1 else self.player1

    def graj(self):
        while True:
            self.board.wyswietl()
            try:
                pole = int(input(f"{self.aktualny.imie} ({self.aktualny.znak}), wybierz pole (0-8): "))
            except ValueError:
                print("To nie jest liczba. Spróbuj ponownie.")
                continue

            if not self.board.wykonaj_ruch(pole, self.aktualny.znak):
                print("Niepoprawny ruch. Pole zajęte lub poza zakresem.")
                continue

            if self.board.sprawdz_zwyciezce(self.aktualny.znak):
                self.board.wyswietl()
                print(f"Gratulacje {self.aktualny.imie}, wygrałeś!")
                break

            if self.board.czy_pelna():
                self.board.wyswietl()
                print("Remis!")
                break

            self.zmien_gracza()


if __name__ == "__main__":
    gra = Game()
    gra.graj()
