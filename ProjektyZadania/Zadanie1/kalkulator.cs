using System;

class Kalkulator {
    static void Main() {
        Console.Write("Podaj pierwszą liczbę: ");
        double a = Convert.ToDouble(Console.ReadLine());
        Console.Write("Podaj drugą liczbę: ");
        double b = Convert.ToDouble(Console.ReadLine());
        Console.Write("Wybierz operację (+, -, *, /): ");
        string op = Console.ReadLine();
        double wynik;
        if (op == "+")
            wynik = a + b;
        else if (op == "-")
            wynik = a - b;
        else if (op == "*")
            wynik = a * b;
        else if (op == "/")
            wynik = b != 0 ? a / b : double.NaN;
        else {
            Console.WriteLine("Nieznana operacja.");
            return;
        }
        Console.WriteLine("Wynik: " + wynik);
    }
}
