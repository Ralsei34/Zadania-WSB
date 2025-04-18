using System;

class Konwerter {
    static void Main() {
        Console.Write("Wybierz kierunek konwersji C lub F ");
        string kierunek = Console.ReadLine().ToUpper();
        Console.Write("Podaj temperaturę: ");
        double temp = Convert.ToDouble(Console.ReadLine());
        if (kierunek == "C") {
            double wynik = temp * 1.8 + 32;
            Console.WriteLine($"{temp}°C = {wynik}°F");
        } else if (kierunek == "F") {
            double wynik = (temp - 32) / 1.8;
            Console.WriteLine($"{temp}°F = {wynik:F2}°C");
        } else {
            Console.WriteLine("Nieznany kierunek konwersji");
        }
    }
}
