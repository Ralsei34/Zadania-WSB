using System;

class Board
{
    private string[] fields;

    public Board()
    {
        fields = new string[9];
        for (int i = 0; i < 9; i++)
        {
            fields[i] = " ";
        }
    }

    public void Show()
    {
        Console.WriteLine();
        for (int i = 0; i < 3; i++)
        {
            Console.WriteLine($"{fields[i * 3]}|{fields[i * 3 + 1]}|{fields[i * 3 + 2]}");
            if (i < 2) Console.WriteLine("-----");
        }
    }

    public bool MakeMove(int position, string symbol)
    {
        if (position >= 0 && position < 9 && fields[position] == " ")
        {
            fields[position] = symbol;
            return true;
        }
        return false;
    }

    public bool CheckWinner(string symbol)
    {
        int[][] wins = new int[][]
        {
            new[] {0, 1, 2}, new[] {3, 4, 5}, new[] {6, 7, 8},
            new[] {0, 3, 6}, new[] {1, 4, 7}, new[] {2, 5, 8},
            new[] {0, 4, 8}, new[] {2, 4, 6}
        };

        foreach (var combo in wins)
        {
            if (fields[combo[0]] == symbol &&
                fields[combo[1]] == symbol &&
                fields[combo[2]] == symbol)
            {
                return true;
            }
        }

        return false;
    }

    public bool IsFull()
    {
        foreach (var field in fields)
        {
            if (field == " ") return false;
        }
        return true;
    }
}

class Player
{
    public string Name { get; set; }
    public string Symbol { get; set; }

    public Player(string name, string symbol)
    {
        Name = name;
        Symbol = symbol;
    }
}

class Game
{
    private Board board;
    private Player player1;
    private Player player2;
    private Player current;

    public Game()
    {
        Console.Write("Podaj imię gracza 1 (X): ");
        string name1 = Console.ReadLine();
        Console.Write("Podaj imię gracza 2 (O): ");
        string name2 = Console.ReadLine();

        player1 = new Player(name1, "X");
        player2 = new Player(name2, "O");
        board = new Board();
        current = player1;
    }

    public void Play()
    {
        while (true)
        {
            board.Show();
            Console.Write($"{current.Name} ({current.Symbol}), wybierz pole (0-8): ");
            string input = Console.ReadLine();

            if (!int.TryParse(input, out int position))
            {
                Console.WriteLine("To nie jest liczba. Spróbuj ponownie.");
                continue;
            }

            if (!board.MakeMove(position, current.Symbol))
            {
                Console.WriteLine("Niepoprawny ruch. Pole zajęte lub poza zakresem.");
                continue;
            }

            if (board.CheckWinner(current.Symbol))
            {
                board.Show();
                Console.WriteLine($"Gratulacje {current.Name}, wygrałeś!");
                break;
            }

            if (board.IsFull())
            {
                board.Show();
                Console.WriteLine("Remis!");
                break;
            }

            SwitchPlayer();
        }
    }

    private void SwitchPlayer()
    {
        current = current == player1 ? player2 : player1;
    }
}

class Program
{
    static void Main(string[] args)
    {
        Game game = new Game();
        game.Play();
    }
}
