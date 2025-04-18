using System;

class Oceny {
    static void Main() {
        Console.Write("Ile ocen chcesz podać? ");
        int n = int.Parse(Console.ReadLine());
        double suma = 0;
        for (int i = 0; i < n; i++) {
            Console.Write($"Podaj ocenę {i + 1}: ");
            double ocena = Convert.ToDouble(Console.ReadLine());
            suma += ocena;
        }
        double srednia = suma / n;
        Console.WriteLine($"Średnia: {srednia:F2}");
        if (srednia >= 3.0)
            Console.WriteLine("Uczeń zdał");
        else
            Console.WriteLine("Uczeń nie zdał");
    }
}
